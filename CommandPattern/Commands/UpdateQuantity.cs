using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class UpdateQuantity : ICommand, ICommandFactory
    {
        public string CommandName
        {
            get;  
        } = "UpdateQuantity";

        public string Description
        {
            get;

        } = "Update the Quantity";

        public int Quantity { get; set; }

        public void Execute()
        {
            Console.WriteLine(Quantity);
        }

        public ICommand MakeCommand(string[] args, int index)
        {
            return new UpdateQuantity { Quantity = int.Parse(args[index+1]) };
        }
    }
}
