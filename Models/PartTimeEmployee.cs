namespace StrategyPreparatorioPrac
{
    internal class PartTimeEmployee : IEmpleado
    {
    public decimal CalcularImpuesto (Contexto contexto)
        {
            return contexto.Sueldo * 0.10m;      
        }
    }
}