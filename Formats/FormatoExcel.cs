using ClosedXML.Excel;
namespace StrategyPreparatorioPrac
{
    internal class FormatoExcel : IExportador
    {
        
        public void Exportar(List<Contexto> lista, string nombreArchivo)
        {
            try
            {
                string encabezado = "Nombre,Tipo Empleado,Salario,Impuesto";
                List<string> lineas = new List<string> { encabezado };
                foreach (var emp in lista)
                {
                    lineas.Add($"{emp.Nombre},{emp.EmployerType},{emp.Sueldo},{emp.Impuesto}");
                }
                string contenido = string.Join(Environment.NewLine, lineas);
                System.Console.WriteLine("Guardando datos en Excel (CSV)...");
                File.WriteAllText(nombreArchivo, contenido);
                System.Console.WriteLine($"Archivo generado correctamente: {nombreArchivo}");
            }
            catch (Exception ex)
            {
                System.Console.WriteLine($"Error al exportar Excel: {ex.Message}");
            }
        }
    }
}
