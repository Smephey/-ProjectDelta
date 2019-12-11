using System.Collections.Generic;

namespace ProjectDelta.Types
{
    public class Application
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ApplicationList
    {
        public List<Application> Applications { get; set; }
    }
}