namespace StrategyPreparatorioPrac
{
    internal class FullEmployer: IEmpleado
    {
        public decimal CalcularImpuesto (Contexto contexto)
        {
            return contexto.Sueldo * 0.25m;
        }
    }
}