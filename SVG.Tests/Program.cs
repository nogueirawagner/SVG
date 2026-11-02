using System.ComponentModel.DataAnnotations;
using System.Reflection;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Services;
using SVG.Domain.TiposEstruturados.Enums;
using SVG.WebApp.Models;

var checks = 0;
void Check(bool ok, string description)
{
    if (!ok) throw new Exception(description);
    checks++;
}
var vehicle = new Viatura { ID = 1, Situacao = XSituacaoViatura.Disponivel };
ViaturaMovimentacao? last = null;
var writes = 0;
var vr = DispatchProxy.Create<IViaturaRepository, RepositoryProxy>();
((RepositoryProxy)(object)vr).Handler = (method, args) => {
    if (method == "GetById") return vehicle;
    writes++;
    return null;
};
var mr = DispatchProxy.Create<IViaturaMovimentacaoRepository, RepositoryProxy>();
((RepositoryProxy)(object)mr).Handler = (method, args) => {
    if (method == "PegarUltimaMovimentacao") return last;
    if (method == "Add") last = (ViaturaMovimentacao)args![0]!;
    writes++;
    return null;
};
var service = new ViaturaMovimentacaoService(mr, vr);
ViaturaMovimentacao Movement(DateTime date, int? fuel) => new() {
    ViaturaID = 1, DataHoraRetirada = date, NivelCombustivelRetirada = fuel
};
void Reject(Action action, string message)
{
    var before = writes;
    try { action(); }
    catch (Exception ex) {
        Check(ex.Message.Contains(message), "Mensagem inesperada: " + ex.Message);
        Check(writes == before, "Operação inválida gravou dados.");
        return;
    }
    throw new Exception("Operação inválida foi aceita.");
}
Reject(() => service.RetirarViatura(Movement(DateTime.Now.AddHours(1), 50), 1, 7), "futura");
Reject(() => service.RetirarViatura(Movement(default, 50), 1, 7), "válida");
foreach (int? fuel in new int?[] { null, -1, 101 })
    Reject(() => service.RetirarViatura(Movement(DateTime.Now.AddMinutes(-1), fuel), 1, 7), "combustível");
Reject(() => service.RetirarViatura(Movement(DateTime.Now.AddMinutes(-1), 50), 1, 0), "operador logado");
var departure = DateTime.Now.AddHours(-2);
service.RetirarViatura(Movement(departure, 0), 1, 7);
Check(last!.OperadorID == 1 && last.OperadorResponsavelID == 7, "Autor da retirada confundido com operador selecionado.");
Check(last!.DataHoraRetirada == departure && last.NivelCombustivelRetirada == 0, "Retirada não preservada.");
Reject(() => service.DevolverViatura(1, 1, 100, false, null, DateTime.Now.AddHours(1), 50, 8), "futura");
Reject(() => service.DevolverViatura(1, 1, 100, false, null, departure.AddMinutes(-1), 50, 8), "anterior");
foreach (var fuel in new[] { -1, 101 })
    Reject(() => service.DevolverViatura(1, 1, 100, false, null, departure.AddMinutes(1), fuel, 8), "combustível");
Reject(() => service.DevolverViatura(1, 1, 100, false, null, departure.AddMinutes(1), 50, 0), "operador logado");
var returned = departure.AddHours(1);
service.DevolverViatura(1, 1, 100, false, null, returned, 100, 8);
Check(last!.OperadorID == 1 && last.OperadorResponsavelID == 8, "Autor da devolução confundido com operador selecionado.");
Check(last.DataHoraDevolucao == returned && last.NivelCombustivelDevolucao == 100, "Devolução não preservada.");
Reject(() => service.RetirarViatura(Movement(departure, 50), 1, 7), "anterior");
service.RetirarViatura(Movement(returned.AddMinutes(1), 100), 1, 7);
var previous = last;
var next = returned.AddMinutes(2);
service.RetirarViatura(Movement(next, 50), 0, 9);
Check(last!.OperadorID == 9 && last.OperadorResponsavelID == 9, "Operador vazio não assume o logado.");
Check(previous!.OperadorResponsavelID == 9 && previous.OperadorID == 1, "Fechamento automático não auditado ou alterou o operador.");
Check(previous!.DataHoraDevolucao == next, "Fechamento automático posterior à nova retirada.");
Check(previous.Situacao == XSituacaoViatura.Disponivel && previous.NivelCombustivelDevolucao == null, "Fechamento automático inválido.");
service.DevolverViatura(1, 0, 101, false, null, next, 0, 8);
Check(last!.OperadorID == 8 && last.OperadorResponsavelID == 8, "Devolução sem operador não assume o logado.");
Check(last!.NivelCombustivelDevolucao == 0, "Tanque vazio não aceito.");
foreach (var model in new[] {
    new ViaturaRegistroViewModel(),
    new ViaturaRegistroViewModel { DataHora = DateTime.Now.AddDays(1), NivelCombustivel = 50 },
    new ViaturaRegistroViewModel { DataHora = departure, NivelCombustivel = 101 }
}) {
    Check(!Validator.TryValidateObject(model, new ValidationContext(model), new List<ValidationResult>(), true), "Formulário inválido aceito.");
}
Console.WriteLine($"{checks} verificações passaram.");

public class RepositoryProxy : DispatchProxy
{
    public Func<string, object?[]?, object?> Handler { get; set; } = null!;
    protected override object? Invoke(MethodInfo? method, object?[]? args) => Handler(method!.Name, args);
}
