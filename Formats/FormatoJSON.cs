using System.Text.Json;

namespace StrategyPreparatorioPrac
{
    internal class FormatoJSON : IExportador
    {
        public void Exportar(List<Contexto> lista, string nombreArchivo)
        {
            try
            {
                var formato = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(lista, formato);
                File.WriteAllText(nombreArchivo, jsonString);
                Console.WriteLine($"Archivo JSON exportado con éxito en: {nombreArchivo}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al exportar JSON: {ex.Message}");
            }
        }
    }
}