using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class CommandNotFound : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get;

        } = "CommandNotFound";

        public string Description
        {
            get;

        } = "Command Not Found";

        public void Execute()
        {
            Console.WriteLine("Command Not Found");
        }

        public ICommand MakeCommand(string[] args, int index)
        {
             return new CommandNotFound {};
        }
    }
}
