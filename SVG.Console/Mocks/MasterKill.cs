using SVG.App.Interface;
using SVG.App.Services;

namespace SVG.Console.Mocks
{
  public class MasterKill
  {
    private readonly ISessaoAppService _sessaoAppService;
    private readonly IOperadorAppService _operadorAppService;
    private readonly IViaturaAppService _viaturaAppService;
    private readonly IOperacaoAppService _operacaoAppService;
    private readonly IOperadorOperacaoAppService _operadorOperacaoAppService;
    private readonly IViaturaOperacaoAppService _viaturaOperacaoAppService;
    private readonly ITipoOperacaoAppService _tipoOperacaoAppService;

    public MasterKill(
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

    public void Kill()
    {
      new MockViaturaOperacao(_viaturaOperacaoAppService, kill: true, seed: false, run: false);

      new MockOperadorOperacao(_operadorOperacaoAppService, _operacaoAppService, _operadorAppService, kill: true, seed: false, run: false);

      new MockOperacao(_operacaoAppService, kill: true, seed: false, run: false);

      new MockViatura(_viaturaAppService, kill: true, seed: false, run: false);

      new MockOperador(_operadorAppService, kill: true, seed: false, run: false);

      new MockTipoOperacao(_tipoOperacaoAppService, kill: true, seed: false, run: false);

      new MockSessao(_sessaoAppService, kill: true, seed: false, run: false);
    }

  }
}
