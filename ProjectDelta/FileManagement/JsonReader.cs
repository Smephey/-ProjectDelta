using Newtonsoft.Json;
using ProjectDelta.Types;
using ProjectDelta.Types.JsonObjects;
using System.IO;
using System.Reflection;

namespace ProjectDelta.Logic
{
    public class JsonReader
    {
        public ApplicationList GetApplicationList()
        {
            return JsonConvert.DeserializeObject<ApplicationList>(ReadJsonFile("Placeholders"));
        }

        public CommandList GetCommandList()
        {
            return JsonConvert.DeserializeObject<CommandList>(ReadJsonFile("Commands"));
        }

        private string ReadJsonFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $"Data//{fileName}.Json")))
            {
                return reader.ReadToEnd();
            }
        }
    }
}