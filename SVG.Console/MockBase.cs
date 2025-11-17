using SVG.App.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVG.Console
{
  public class MockBase
  {
    private readonly IOperadorAppService _operadorAppService;

    private MockOperador _mockOperadores;

    public MockBase(
      IOperadorAppService operadorAppService,
      bool limparBase = false,
      bool iniciarBase = false
      )
    {
      _operadorAppService = operadorAppService;
      _mockOperadores = new MockOperador(_operadorAppService);

      if (limparBase)
        LimparBase();

      if (iniciarBase)
      {
        LimparBase();
        IniciarBase();
      }
    }

    public void LimparBase()
    {
      _mockOperadores.LimparOperadores();
    }

    public void IniciarBase()
    {
      _mockOperadores.AdicionarOperador();
    }
  }
}
