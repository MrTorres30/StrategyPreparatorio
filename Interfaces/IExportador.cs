namespace StrategyPreparatorioPrac
{
    internal interface IExportador
    {
    void Exportar(List<Contexto> lista, string nombreArchivo);
    }
}