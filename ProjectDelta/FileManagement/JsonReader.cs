using System.Collections.Generic;
using Newtonsoft.Json;
using ProjectDelta.Types;
using System.IO;
using System.Reflection;

namespace ProjectDelta.Logic
{
    public class JsonReader
    {
        public List<Application> GetApplicationList()
        {
            return JsonConvert.DeserializeObject<ApplicationList>(ReadJsonFile("Placeholders")).Applications;
        }

        public List<Command> GetCommandList()
        {
            return JsonConvert.DeserializeObject<CommandList>(ReadJsonFile("Commands")).ListOfCommands;
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