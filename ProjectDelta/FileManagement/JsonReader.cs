using System.Collections.Generic;
using System.IO;
using System.Reflection;
using Newtonsoft.Json;
using ProjectDelta.Types;

namespace ProjectDelta.FileManagement
{
    public class JsonReader
    {
        public ApplicationList GetApplicationList()
        {
            var applications = new ApplicationList()
            {
                Applications = new List<Application>()
                {
                    new Application()
                    {
                        Description = "Descccc", 
                        Name = "Name",
                    }
                }
            };
            //using (StreamReader reader = new StreamReader(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Data/Placeholders.Json")))
            //{
            //    var json = reader.ReadToEnd();
            //    applications = JsonConvert.DeserializeObject<ApplicationList>(json);
            //}
            return applications;
        }
    }
}
