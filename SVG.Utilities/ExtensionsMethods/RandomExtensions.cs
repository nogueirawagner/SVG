public static class RandomExtensions
{
  /// <summary>
  /// Retorna um booleano baseado em uma probabilidade percentual (0–100).
  /// Ex: 60 → 60% chance de true.
  /// </summary>
  public static bool NextBool(this Random random, int percentTrue)
  {
    if (percentTrue < 0 || percentTrue > 100)
      percentTrue = random.Next(0, 100);

    // Gera número entre 0 e 99
    int value = random.Next(0, 100);

    return value < percentTrue;
  }
}
