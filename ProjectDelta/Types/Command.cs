using System.Collections.Generic;

namespace ProjectDelta.Types
{
    public class Command
    {
        public string InputCommand { get; set; }
        public string Description { get; set; }
    }

    public class CommandList
    {
        public List<Command> ListOfCommands;
    }
}