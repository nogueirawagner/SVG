using GestaoDDD.Infra.Data.Repositories;
using SimpleInjector;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.Services;
using SVG.Infra.Context.SQLServer;

namespace SVG.IoC
{
  public class BootStrapper
  {
    public static void RegisterServices(Container container)
    {
      container.Register<SQLServerContext>(() =>
      {
        var cs = "Data Source=DESKTOP-3MKU8HI;Initial Catalog=SVG;Persist Security Info=True;User ID=sa;Password=_senhas_2012;MultipleActiveResultSets=True";

        return new SQLServerContext(cs);
      }, Lifestyle.Scoped);

      container.Register<ISQLServerContext>(() =>
        container.GetInstance<SQLServerContext>(),
        Lifestyle.Scoped);

      // Operador
      container.Register<IOperadorRepository, OperadorRepository>(Lifestyle.Scoped);
      container.Register<IOperadorAppService, OperadorAppService>(Lifestyle.Scoped);
      container.Register<IOperadorService, OperadorService>(Lifestyle.Scoped);

      // Operacao
      container.Register<IOperacaoRepository, OperacaoRepository>(Lifestyle.Scoped);
      container.Register<IOperacaoAppService, OperacaoAppService>(Lifestyle.Scoped);
      container.Register<IOperacaoService, OperacaoService>(Lifestyle.Scoped);

      // OperadorOperacao
      container.Register<IOperadorOperacaoRepository, OperadorOperacaoRepository>(Lifestyle.Scoped);
      container.Register<IOperadorOperacaoAppService, OperadorOperacaoAppService>(Lifestyle.Scoped);
      container.Register<IOperadorOperacaoService, OperadorOperacaoService>(Lifestyle.Scoped);

      // Equipe
      container.Register<IEquipeRepository, EquipeRepository>(Lifestyle.Scoped);
      container.Register<IEquipeAppService, EquipeAppService>(Lifestyle.Scoped);
      container.Register<IEquipeService, EquipeService>(Lifestyle.Scoped);

      // Viatura
      container.Register<IViaturaRepository, ViaturaRepository>(Lifestyle.Scoped);
      container.Register<IViaturaAppService, ViaturaAppService>(Lifestyle.Scoped);
      container.Register<IViaturaService, ViaturaService>(Lifestyle.Scoped);

      // ViaturaOperacao
      container.Register<IViaturaOperacaoRepository, ViaturaOperacaoRepository>(Lifestyle.Scoped);
      container.Register<IViaturaOperacaoAppService, ViaturaOperacaoAppService>(Lifestyle.Scoped);
      container.Register<IViaturaOperacaoService, ViaturaOperacaoService>(Lifestyle.Scoped);
    }
  }
}
