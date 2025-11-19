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

    public MasterSeed(
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

    public void Run()
    {
      // 1. Sessões
      var sessaoSeed = new MockSessao(_sessaoAppService, seed: true);

      // 2. Operadores
      var operadorSeed = new MockOperador(_operadorAppService, seed: true);

      // 3. Viaturas
      var viaturaSeed = new MockViatura(_viaturaAppService, seed: true);

      // 4. Operações
      var operacaoSeed = new MockOperacao(_operacaoAppService, seed: true);

      // 5. Operador x Operação
      var operadorOperacaoSeed = new MockOperadorOperacao(_operadorOperacaoAppService, _operacaoAppService, _operadorAppService, seed: true);

      // 6. Viatura x Operação
      var viaturaOperacaoSeed = new MockViaturaOperacao(_viaturaOperacaoAppService, seed: true);
    }

  }
}
