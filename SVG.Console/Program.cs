using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.App.Interface;
using SVG.Console;
using SVG.Console.Mocks;
using SVG.IoC;

public class Program
{
  private readonly IOperadorAppService _operadorAppService;
  private readonly IOperacaoAppService _operacaoAppService;
  private readonly ISessaoAppService _sessaoAppService;
  private readonly IViaturaAppService _viaturaAppService;
  private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;
  private readonly IViaturaOperacaoAppService _viaturaOperacaoAppService;

  private Program(
      IOperadorAppService operadorAppService,
      IOperacaoAppService operacaoAppService,
      ISessaoAppService sessaoAppService,
      IViaturaAppService viaturaAppService,
      IOperadorOperacaoAppService operadorOperacaoAppService,
      IViaturaOperacaoAppService viaturaOperacaoAppService
  )
  {
    _operadorAppService = operadorAppService;
    _operacaoAppService = operacaoAppService;
    _sessaoAppService = sessaoAppService;
    _viaturaAppService = viaturaAppService;
    _operadorOperacaoAppService = operadorOperacaoAppService;
    _viaturaOperacaoAppService = viaturaOperacaoAppService;
  }
  public static void Main()
  {
    var container = new Container();
    container.Options.DefaultScopedLifestyle = new AsyncScopedLifestyle();
    BootStrapper.RegisterServices(container);
    container.Verify();

    using (AsyncScopedLifestyle.BeginScope(container))
    {
      var program = new Program(
          container.GetInstance<IOperadorAppService>(),
          container.GetInstance<IOperacaoAppService>(),
          container.GetInstance<ISessaoAppService>(),
          container.GetInstance<IViaturaAppService>(),
          container.GetInstance<IOperadorOperacaoAppService>(),
          container.GetInstance<IViaturaOperacaoAppService>()
      );

      //program.Run();
    }
  }
  public void Run()
  {
    var master = new MasterSeed(
         _sessaoAppService,
         _operadorAppService,
         _viaturaAppService,
         _operacaoAppService,
         _operadorOperacaoAppService,
         _viaturaOperacaoAppService
     );
    master.Run();
  }

  public void Kill()
  {
    var master = new MasterKill(
         _sessaoAppService,
         _operadorAppService,
         _viaturaAppService,
         _operacaoAppService,
         _operadorOperacaoAppService,
         _viaturaOperacaoAppService
     );
    master.Kill();
  }
}


