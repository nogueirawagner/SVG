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
      // ORDEM INVERSA DA MASTERSEED — EVITA CONFLITO DE FK

      // 1. ViaturaOperacao (depende de Viatura + Operacao)
      var killViaturaOperacao = new MockViaturaOperacao(_viaturaOperacaoAppService);
      killViaturaOperacao.Kill();

      // 2. OperadorOperacao (depende de Operador + Operacao)
      var killOperadorOperacao = new MockOperadorOperacao(_operadorOperacaoAppService);
      killOperadorOperacao.Kill();

      // 3. Operacao (independente)
      var killOperacao = new MockOperacao(_operacaoAppService);
      killOperacao.Kill();

      // 4. Viatura (depende de Sessao)
      var killViatura = new MockViatura(_viaturaAppService);
      killViatura.Kill();

      // 5. Operador (depende de Sessao)
      var killOperador = new MockOperador(_operadorAppService);
      killOperador.Kill();

      // 6. Sessao (não depende de nada)
      var killSessao = new MockSessao(_sessaoAppService);
      killSessao.Kill();
    }
  }
}
