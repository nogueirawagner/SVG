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
      // IMPORTANTE: Ordem correta respeitando FKs
      // 1. Sessões (pai de todos)
      var sessaoSeed = new MockSessao(_sessaoAppService);

      // 2. Operadores (FK: SessaoID)
      var operadorSeed = new MockOperador(_operadorAppService);

      // 3. Viaturas (FK: SessaoID)
      var viaturaSeed = new MockViatura(_viaturaAppService);

      // 4. Operações (independente)
      var operacaoSeed = new MockOperacao(_operacaoAppService);

      // 5. Operador x Operação (FKs: OperadorID + OperacaoID)
      var operadorOperacaoSeed = new MockOperadorOperacao(_operadorOperacaoAppService);

      // 6. Viatura x Operação (FKs: ViaturaID + OperacaoID)
      var viaturaOperacaoSeed = new MockViaturaOperacao(_viaturaOperacaoAppService);
    }
  }
}
