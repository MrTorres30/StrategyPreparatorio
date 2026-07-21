using ClosedXML;

namespace StrategyPreparatorioPrac
{
    internal class ContractEmployer : IEmpleado
    {
        public decimal CalcularImpuesto (Contexto contexto)
        {
            return contexto.Sueldo * 0.15m;
        }
    }
}