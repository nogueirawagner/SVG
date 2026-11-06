public static class PlanejamentoMigrationDraft
{
    // A migration inicial já foi aplicada, conforme informado pelo usuário.
    // Não regenerar arquivos ou snapshots de uma migration aplicada.
    public static void Generate() => throw new InvalidOperationException(
        "A migration inicial de Planejamento já foi aplicada e não pode ser regenerada. " +
        "Prepare uma nova migration incremental com nome yyyyMMddHHmm, sem executar no banco.");
}
