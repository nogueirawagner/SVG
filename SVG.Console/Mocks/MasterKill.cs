using SVG.App.Interface;

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

    public MasterKill(
        ISessaoAppService sessaoAppService,
        IOperadorAppService operadorAppService,
        IViaturaAppService viaturaAppService,
        IOperacaoAppService operacaoAppService,
        IOperadorOperacaoAppService operadorOperacaoAppService,
        IViaturaOperacaoAppService viaturaOperacaoAppService
    )
    {
      _sessaoAppService = sessaoAppService;
      _operadorAppService = operadorAppService;
      _viaturaAppService = viaturaAppService;
      _operacaoAppService = operacaoAppService;
      _operadorOperacaoAppService = operadorOperacaoAppService;
      _viaturaOperacaoAppService = viaturaOperacaoAppService;
    }

    public void Kill()
    {
      // 1. ViaturaOperacao
      var killViaturaOperacao = new MockViaturaOperacao(_viaturaOperacaoAppService, kill: true, seed: false, run: false);

      // 2. OperadorOperacao
      var killOperadorOperacao = new MockOperadorOperacao(_operadorOperacaoAppService, _operacaoAppService, _operadorAppService, kill: true, seed: false, run: false);

      // 3. Operacao
      var killOperacao = new MockOperacao(_operacaoAppService, kill: true, seed: false, run: false);

      // 4. Viatura
      var killViatura = new MockViatura(_viaturaAppService, kill: true, seed: false, run: false);

      // 5. Operador
      var killOperador = new MockOperador(_operadorAppService, kill: true, seed: false, run: false);

      // 6. Sessao
      var killSessao = new MockSessao(_sessaoAppService, kill: true, seed: false, run: false);
    }

  }
}
