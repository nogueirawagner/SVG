using SimpleInjector;
using SimpleInjector.Lifestyles;
using SVG.App.Interface;
using SVG.Console;
using SVG.IoC;

public class Program
{
  private readonly IOperadorAppService _operadorAppService;

  private Program(
    IOperadorAppService operadorAppService
    )
  {
    _operadorAppService = operadorAppService;
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
        container.GetInstance<IOperadorAppService>()
        );
    
      program.RunOperadores();
    }
  }

  public void RunOperadores()
  {
    var mockOperador = new MockOperador(_operadorAppService);
    mockOperador.AdicionarOperador();
  }
}


