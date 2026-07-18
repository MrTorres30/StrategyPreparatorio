using System.Linq.Expressions;
using System.Text.Json;

namespace StrategyPreparatorioPrac
{
    internal class FormatoJSON
    {
        public void Guardar(List<Contexto> lista)
        {
            var formato = new JsonSerializerOptions { WriteIndented = true };
            string JsonString = JsonSerializer.Serialize(lista, formato);
            File.WriteAllText("empleados.json", JsonString);
        }
         public List<Contexto> Cargar()
        {
            try
            {
                if (!File.Exists("empleados.json"))
                    return new List<Contexto>();

                string jsonString = File.ReadAllText("empleados.json");
                return JsonSerializer.Deserialize<List<Contexto>>(jsonString) ?? new List<Contexto>();
            }
           catch (Exception ex)
            {
            System.Console.WriteLine("Error al crear el formato" + ex.Message);
            return new List<Contexto>();
            }
        }
    }
}