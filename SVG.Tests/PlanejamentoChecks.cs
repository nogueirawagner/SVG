using System.ComponentModel.DataAnnotations;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SVG.Domain.Entities;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Services;
using SVG.Domain.TiposEstruturados.Planejamento;
using SVG.App.Services;
using SVG.WebApp.Controllers;

public static class PlanejamentoChecks
{
    public static int Run()
    {
        int checks=0, writes=0;
        void Check(bool value,string message){if(!value)throw new Exception(message);checks++;}
        var repo=DispatchProxy.Create<IPlanejamentoRepository,RepositoryProxy>();
        var plan=new Planejamento{ID=4,Titulo="Exemplo",SecaoID=2,Versao=new byte[]{1,2,3},Endereco="Endereço histórico",Alvos=new List<PlanejamentoAlvo>{new(){AlvoID=10,Alvo=new Alvo{ID=10,Nome="Pessoa existente"},Observacoes="Contexto"}}};
        ((RepositoryProxy)(object)repo).Handler=(name,args)=>name switch {
            "Salvar"=>++writes,
            "Obter"=>plan,
            "BuscarAlvos"=>new List<XAlvoResumo>{new(10,"Pessoa existente",null,null,2)},
            _=>null
        };
        var service=new PlanejamentoService(repo);
        var autor=new XAutorPlanejamento(1,false);
        XPlanejamentoEntrada Valid()=>new(){Titulo="Planejamento de teste",Endereco="Endereço X",DataPrevista=DateTime.Today,Alvos=new(){new(){Nome="Pessoa de teste"}}};
        void Reject(Action action)
        {
            int before=writes;
            try{action();}catch(ValidationException){Check(before==writes,"Dados inválidos chegaram à persistência.");return;}
            throw new Exception("Entrada inválida foi aceita.");
        }
        void Save(XPlanejamentoEntrada e,bool finalizar=false)=>service.Salvar(e,autor,Array.Empty<XAnexoAlvoEntrada>(),finalizar);
        Check(service.BuscarAlvos(" ").Count==0,"Busca vazia deve ser limitada.");
        Check(service.BuscarAlvos("Pessoa").Single().QuantidadePlanejamentos==2,"Consulta deve reunir os planejamentos pelo alvo.");
        Reject(()=>service.Salvar(Valid(),new(0,false),Array.Empty<XAnexoAlvoEntrada>(),false));
        var e=Valid();e.Latitude=-15;Reject(()=>Save(e));
        e=Valid();e.Latitude=91;e.Longitude=0;Reject(()=>Save(e));
        e=Valid();e.Alvos.Clear();Reject(()=>Save(e,true));
        e=Valid();e.Endereco=" ";Reject(()=>Save(e,true));
        e=Valid();e.Alvos[0].Nome=" ";Reject(()=>Save(e));
        e=Valid();e.Alvos[0].CPF="111.111.111-11";Reject(()=>Save(e));
        e=Valid();e.Alvos[0].CPF="12345678909";Save(e);
        Check(PlanejamentoService.NormalizarCpf("123.456.789-09")=="12345678909","CPF não normalizado.");
        e=Valid();e.Alvos=new(){new(){AlvoID=5},new(){AlvoID=5}};Reject(()=>Save(e));
        e=Valid();e.Alvos.Add(new(){Nome="Outra pessoa",Codigo="A"});e.Alvos[0].Codigo="a";Reject(()=>Save(e));
        e=Valid();e.Integrantes=new(){new(){OperadorID=1,Funcao="Motorista"},new(){OperadorID=1,Funcao="Navegação"}};Reject(()=>Save(e));
        e=Valid();e.Itens.Add(new(){Tipo="Rota",Descricao="Referência",Url="javascript:alert(1)"});Reject(()=>Save(e));
        e=Valid();e.Itens.Add(new(){Tipo="Inexistente",Descricao="Texto"});Reject(()=>Save(e));
        e=Valid();e.ID=1;Reject(()=>Save(e));
        e=Valid();e.Alvos[0].DataNascimento=DateTime.Today.AddDays(1);Reject(()=>Save(e));
        Reject(()=>service.Salvar(Valid(),autor,new[]{new XAnexoAlvoEntrada(0,"falso.png",new byte[]{1,2,3})},false));
        e=Valid();e.Alvos[0].AlvoID=4;
        Reject(()=>service.Salvar(e,autor,new[]{new XAnexoAlvoEntrada(9,"foto.png",new byte[]{137,80,78,71,13,10,26,10})},false));
        e=Valid();e.Latitude=0;e.Longitude=0;Save(e,true);
        Save(new XPlanejamentoEntrada{Titulo="Rascunho sem alvos"});
        Check(writes==3,"Gravações válidas não chegaram ao repositório.");
        e=Valid();e.HorarioBriefingDOE=TimeSpan.FromDays(1);Reject(()=>Save(e));
        e=Valid();e.Link_Rota_DP_Desemb="javascript:alert(1)";Reject(()=>Save(e));
        e=Valid();e.DistanciaRotaDPDesembKm=-1;Reject(()=>Save(e));
        plan.LocalBriefing="Teste";plan.HorarioBriefingDOE=TimeSpan.FromHours(4);plan.Link_Endereco_Alvo="https://www.google.com/maps?q=-10,-20";
        plan.Link_Rota_DP_Desemb="https://www.google.com/maps/dir/A/B";plan.SocorristaAPH1="Pessoa";
        var png=new byte[]{137,80,78,71,13,10,26,10};
        Reject(()=>service.Salvar(Valid(),autor,Array.Empty<XAnexoAlvoEntrada>(),false,new[]{new XArquivoPlanejamentoEntrada("sem-grupo.png",png)}));
        Reject(()=>service.Salvar(Valid(),autor,Array.Empty<XAnexoAlvoEntrada>(),false,new[]{new XArquivoPlanejamentoEntrada("invalido.png",png,(SVG.Domain.TiposEstruturados.Enums.XSubgrupoImagemPlanejamento)99)}));
        var app=new PlanejamentoAppService(service);
        var edit=app.PrepararEdicao(4)!;
        Check(edit.Alvos.Single().AlvoID==10 && edit.Endereco=="Endereço histórico","Edição perdeu vínculo ou endereço.");
        Check(edit.LocalBriefing=="Teste" && edit.HorarioBriefingDOE==TimeSpan.FromHours(4) && edit.Link_Endereco_Alvo==plan.Link_Endereco_Alvo && edit.Link_Rota_DP_Desemb==plan.Link_Rota_DP_Desemb && edit.SocorristaAPH1=="Pessoa","Edição perdeu campos do modelo padrão.");
        Check(edit.Versao==Convert.ToBase64String(plan.Versao),"Edição deve transportar versão de concorrência.");
        var controller=typeof(PlanejamentoController);
        Check(controller.GetCustomAttribute<AuthorizeAttribute>()!=null,"Leitura deve exigir autenticação.");
        var post=controller.GetMethod("Salvar")!;
        Check(post.GetCustomAttribute<ValidateAntiForgeryTokenAttribute>()!=null,"Gravação sem antiforgery.");
        Check(post.GetCustomAttribute<AuthorizeAttribute>()?.Roles=="Admin,Operador","Gravação sem papéis definidos.");
        Check(typeof(XPlanejamentoEntrada).GetProperty("SecaoID")==null,"Cliente pode escolher seção arbitrariamente.");
        Check(typeof(Alvo).GetProperty("PlanejamentoID")==null,"Alvo não pode carregar FK 1:N do modelo anterior.");
        Console.WriteLine($"Planejamento: {checks} verificações passaram (sem banco).");
        return checks;
    }
}
