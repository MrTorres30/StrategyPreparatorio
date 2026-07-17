
namespace StrategyPreparatorioPrac
{
    internal class Contexto
    {
        public string nombre {get; set;}
        public decimal impuesto {get; set;}
        public decimal sueldo {get; set;}   
    
        public Contexto(string nombre, decimal impuesto, decimal sueldo)
        {
            this.nombre = nombre;
            this.impuesto = impuesto;
            this.sueldo = sueldo;
        }
    }
}