using Newtonsoft.Json;
using ProjectDelta.Types;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ProjectDelta.Logic
{
    public class JsonReader
    {
        public ApplicationList GetApplicationList()
        {
            var applications = new ApplicationList();
            using (StreamReader reader = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data/Placeholders.Json")))
            {
                var json = reader.ReadToEnd();
                applications = JsonConvert.DeserializeObject<ApplicationList>(json);
            }
            return applications;
        }
    }
}
