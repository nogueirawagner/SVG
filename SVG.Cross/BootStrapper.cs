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
      container.Register<ISQLServerContext, SQLServerContext>(Lifestyle.Scoped);

      container.Register<IOperadorRepository, OperadorRepository>(Lifestyle.Scoped);
      container.Register<IOperadorAppService, OperadorAppService>(Lifestyle.Scoped);
      container.Register<IOperadorService, OperadorService>(Lifestyle.Scoped);
    }
  }
}
