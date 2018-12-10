using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
   
    class CommandParser
    {
        readonly IEnumerable<ICommandFactory> availableCommands;

        public CommandParser(IEnumerable<ICommandFactory> availableCommand)
        {
            this.availableCommands = availableCommand;
        }

        internal ICommand ParseCommand (string[] args, int index)
        {
        
                var requestedCommandName = args[index];
                var command = FindRequestedCommand(requestedCommandName);

                return command.MakeCommand(args, index);
            
        } 

        ICommandFactory FindRequestedCommand(string commandName)
        {     
             var res = availableCommands.FirstOrDefault((cmd) => cmd.CommandName == commandName);
            if (res == null) res = new CommandNotFound();
            return res;
        }

    }
}
