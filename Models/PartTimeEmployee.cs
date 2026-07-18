namespace StrategyPreparatorioPrac
{
    internal class PartTimeEmployee : IEmpleado
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