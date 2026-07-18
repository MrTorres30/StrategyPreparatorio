namespace StrategyPreparatorioPrac
{
    internal class FactoryEmpleado
    {
        public static IEmpleado CrearEmpleado(TipoEmpleado tipo)
        {
            return tipo switch
            {
                TipoEmpleado.FullEmployer => new FullEmployer(),
                TipoEmpleado.PartTimeEmployee => new PartTimeEmployee(),
                TipoEmpleado.ContractEmployer => new ContractEmployer(),
                _ => throw new ArgumentException("Este tipo de empelado no existe")
            };
        }
    }
}