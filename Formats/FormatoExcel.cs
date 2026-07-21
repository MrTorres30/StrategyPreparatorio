using ClosedXML.Excel;
namespace StrategyPreparatorioPrac
{
    internal class FormatoExcel : IExportador
    {
        public void Exportar (List<Contexto> lista , string nombreArchivo)
        {
            try
            {
                List<string> lineas = new List<string>();
                
                lineas.Add("Nombre;Tipo Empleado;Salario;Impuesto");
                foreach (var emp in lista)
                {
                    lineas.Add($"{emp.Nombre};{emp.EmployerType};{emp.Sueldo};{emp.Impuesto}");
                }
                File.WriteAllLines(nombreArchivo, lineas);
                Console.WriteLine($"Archivo Excel (CSV) creado con éxito: {nombreArchivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar xcel: {ex.Message}");
            }
        }
    }
}
