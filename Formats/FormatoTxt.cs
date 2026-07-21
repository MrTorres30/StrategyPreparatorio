namespace StrategyPreparatorioPrac
{
    internal class FormatoTxt : IExportador
    {
        public void Exportar(List<Contexto> lista, string nombreArchivo)
        {
            try
            {
            List<string> lineas = new List<string>();
            lineas.Add("Nombre | Tipo Empleado | Salario | Impuesto");
            lineas.Add("--------------------------------------------------");

             foreach (var emp in lista)
            {
                lineas.Add($"{emp.Nombre} | {emp.EmployerType} | ${emp.Sueldo} | ${emp.Impuesto}");
            }
            File.WriteAllLines(nombreArchivo, lineas);    
            }
            catch  (Exception ex)
            {
                 Console.WriteLine($"Error al exportar TXT: {ex.Message}");
            }
        }


    }
}
