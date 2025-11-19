namespace SVG.Console.Mocks
{
  public abstract class Mock
  {
    public Mock(bool seed = false, bool kill = false, bool run = true)
    {
      // kill tem prioridade: se kill for true, sempre limpa
      if (kill)
      {
        Kill();

        // Se além de kill, seed também for true → limpa, insere e (se run for true) roda
        if (seed)
        {
          Seed();

          if (run)
            Run();
        }

        // kill true e seed false → só limpa e sai
        return;
      }

      // Se só seed for true (sem kill explícito): limpa, insere e (se run for true) roda
      if (seed)
      {
        Kill();
        Seed();

        if (run)
          Run();

        return;
      }

      // Caso nenhum dos flags seed/kill esteja ligado:
      // se run for true (default) → apenas roda
      if (run)
      {
        Run();
      }
    }
    
    public abstract void Kill();
    
    public abstract void Seed();

    public virtual void Run() { }
  }
}
