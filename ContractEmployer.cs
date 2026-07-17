namespace StrategyPreparatorioPrac
{
    internal class ContractEmployer : IEmpleado
    {
        public decimal CalcularImpuesto (Contexto contexto)
        {
            decimal salarioBruto = contexto.impuesto;
            {
                return contexto.sueldo;
            }
        }
    }
}