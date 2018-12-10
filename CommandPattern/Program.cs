using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            string ext = "fe80::b91c:91b7:87b2:17d8%16";
            string extSch = "fe80::11f6:8c3:800b:ea90%4";
            args = new string[] {"Send",ext,"2045", "Download -f Naplan.gz" };
            var commands = getCommands();
            if (args.Length == 0)
            {
                return;
            }

            var parser = new CommandParser(commands);

         //   for (int i = 0; i < args.Count(); i +=)
            {
                var command = parser.ParseCommand(args, 0);
                if (command != null) command.Execute();
            }
            
            Console.ReadLine();
        }
        static IEnumerable<ICommandFactory> getCommands()
        {
            return new ICommandFactory[]
            {
                new UpdateQuantity(),
                new CommandNotFound(),
                new Send()
            };
        }
    }
}
