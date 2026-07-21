using System.Runtime.CompilerServices;

namespace StrategyPreparatorioPrac
{
    internal class Nomina
    {
        private readonly List<Contexto> listaempleados = new List<Contexto>();

        public void Iniciar()
        {
        System.Console.WriteLine("============================");  
        System.Console.WriteLine("CALCULADORA DE IMPUESTOS");
        System.Console.WriteLine("============================");

         CapturarEmpleados();
         ExportarDatos();
        }

        private void CapturarEmpleados()
        {
            bool continuar = true;
            while (continuar)
            {
                System.Console.WriteLine("Ingrese el nombre del empleado: ");
                string nombre = Console.ReadLine() ?? "";

                System.Console.WriteLine("Ingrese su sueldo bruto: ");
                decimal.TryParse(Console.ReadLine(), out decimal sueldo);
            
                System.Console.WriteLine("\n Seleccione el Tipo de Emleado");
                System.Console.WriteLine("Full Employer - 25% impuesto");
                System.Console.WriteLine("PartTimeEmployee - 10% impuesto");
                System.Console.WriteLine("ContractEmployer - 15% impuesto");
                System.Console.WriteLine("Selccione su opcion (1-3)");
                string opcionTipo = Console.ReadLine() ?? "1";

                 TipoEmpleado tipo = opcionTipo switch
                 {
                     "1" => TipoEmpleado.FullEmployer,
                     "2" => TipoEmpleado.PartTimeEmployee,
                     "3" => TipoEmpleado.ContractEmployer,
                     _ => TipoEmpleado.FullEmployer
                 };

                IEmpleado strategy = FactoryEmpleado.CrearEmpleado(tipo);
                Contexto empleado = new Contexto(nombre, sueldo, tipo);
                empleado.Impuesto = strategy.CalcularImpuesto(empleado);

                listaempleados.Add(empleado);

                System.Console.WriteLine($"\n Empleado añadido. Impuesto: ${empleado.Impuesto}\n");
                Console.Write("Desea agregar otro empleado? (s/n): ");
                string resp = (Console.ReadLine() ?? "").ToLower();
                if (resp != "s")
                    continuar = false;
            }
        }
                private void ExportarDatos()
        {
            if (listaempleados.Count == 0) return;

            System.Console.WriteLine("============================");
            System.Console.WriteLine("   OPCIONES DE EXPORTACION  ");
            System.Console.WriteLine("============================");
            System.Console.WriteLine("1. Exportar a JSON ");
            System.Console.WriteLine("2. Exportar a Txt ");
            System.Console.WriteLine("3. Exportar a Excel ");
            System.Console.WriteLine("Elija el formato de exportación (1-3): ");
            string opcionFormato = Console.ReadLine() ?? "1";

            (IExportador exportador, string extension) = opcionFormato switch
            {
                "1" => ((IExportador)new FormatoJSON(), "empleados.json"),
                "2" => ((IExportador)new FormatoTxt(), "empleados.txt"),
                "3" => ((IExportador)new FormatoExcel(), "empleados.csv"),
                _   => ((IExportador)new FormatoJSON(), "empleados.json")
            };
            exportador.Exportar(listaempleados, extension);
        }
    }
}
