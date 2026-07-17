namespace StrategyPreparatorioPrac
{
    internal class FullEmployer: IEmpleado
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