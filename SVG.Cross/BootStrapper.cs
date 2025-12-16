using SimpleInjector;
using SVG.App.Interface;
using SVG.App.Services;
using SVG.Domain.Interfaces.Repositories;
using SVG.Domain.Interfaces.Services;
using SVG.Domain.Services;
using SVG.Infra.Context.SQLServer;
using SVG.Infra.Repositories;

namespace SVG.IoC
{
  public class BootStrapper
  {
    public static void RegisterServices(Container container, string cs)
    {
      container.Register<SQLServerContext>(() =>
      {
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

      // Sessao
      container.Register<ISessaoRepository, SessaoRepository>(Lifestyle.Scoped);
      container.Register<ISessaoAppService, SessaoAppService>(Lifestyle.Scoped);
      container.Register<ISessaoService, SessaoService>(Lifestyle.Scoped);

      // Viatura
      container.Register<IViaturaRepository, ViaturaRepository>(Lifestyle.Scoped);
      container.Register<IViaturaAppService, ViaturaAppService>(Lifestyle.Scoped);
      container.Register<IViaturaService, ViaturaService>(Lifestyle.Scoped);

      // ViaturaOperacao
      container.Register<IViaturaOperacaoRepository, ViaturaOperacaoRepository>(Lifestyle.Scoped);
      container.Register<IViaturaOperacaoAppService, ViaturaOperacaoAppService>(Lifestyle.Scoped);
      container.Register<IViaturaOperacaoService, ViaturaOperacaoService>(Lifestyle.Scoped);

      container.Register<ITipoOperacaoRepository, TipoOperacaoRepository>(Lifestyle.Scoped);
      container.Register<ITipoOperacaoService, TipoOperacaoService>(Lifestyle.Scoped);
      container.Register<ITipoOperacaoAppService, TipoOperacaoAppService>(Lifestyle.Scoped);

    }
  }
}
