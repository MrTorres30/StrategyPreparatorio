namespace StrategyPreparatorioPrac
{
    internal class Contexto
    {
        public string Nombre {get; set;}
        public decimal Impuesto {get; set;}
        public decimal Sueldo {get; set;}   

        public TipoEmpleado EmployerType {get; set;} 
    
        public Contexto(string nombre, decimal sueldo, TipoEmpleado employerType)
        {
        this.Nombre = nombre;
        this.Sueldo = sueldo;
        this.EmployerType = employerType;

        }
    }
}