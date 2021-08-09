using System.IO;
using System.Text.Json;

namespace ClinicWebApplication.Modules
{
    public class JsonModule
    {
        public void WriteJson<T>(T obj, string path)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            string json = JsonSerializer.Serialize(obj, options);

            using (StreamWriter streamWriter = new StreamWriter(path))
            {
                streamWriter.WriteLine(json);
            }
        }

        public T ReadJson<T>(string path)
        {
            string json;

            using (StreamReader streamReader = new StreamReader(path))
            {
                json = streamReader.ReadToEnd();
            }

            return JsonSerializer.Deserialize<T>(json);
        }
    }
}
