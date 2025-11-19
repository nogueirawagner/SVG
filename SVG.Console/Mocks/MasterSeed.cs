using SVG.App.Interface;

namespace SVG.Console.Mocks
{
  public class MasterSeed
  {
    private readonly ISessaoAppService _sessaoAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly IViaturaAppService _viaturaAppService;
    private readonly IOperacaoAppService _operacaoAppService;
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;
    private readonly IViaturaOperacaoAppService _viaturaOperacaoAppService;
    private readonly ITipoOperacaoAppService _tipoOperacaoAppService;

    public MasterSeed(
        ISessaoAppService sessaoAppService,
        IOperadorAppService operadorAppService,
        IViaturaAppService viaturaAppService,
        IOperacaoAppService operacaoAppService,
        IOperadorOperacaoAppService operadorOperacaoAppService,
        IViaturaOperacaoAppService viaturaOperacaoAppService,
        ITipoOperacaoAppService tipoOperacaoAppService
    )
    {
      _sessaoAppService = sessaoAppService;
      _operadorAppService = operadorAppService;
      _viaturaAppService = viaturaAppService;
      _operacaoAppService = operacaoAppService;
      _operadorOperacaoAppService = operadorOperacaoAppService;
      _viaturaOperacaoAppService = viaturaOperacaoAppService;
      _tipoOperacaoAppService = tipoOperacaoAppService;
    }

    public void Run()
    {
      new MockSessao(_sessaoAppService, seed: true);

      new MockTipoOperacao(_tipoOperacaoAppService, seed: true);

      new MockOperador(_operadorAppService, seed: true);

      new MockViatura(_viaturaAppService, seed: true);

      new MockOperacao(_operacaoAppService, seed: true);

      new MockOperadorOperacao(_operadorOperacaoAppService, _operacaoAppService, _operadorAppService, seed: true);

      new MockViaturaOperacao(_viaturaOperacaoAppService, seed: true);
    }
  }
}
