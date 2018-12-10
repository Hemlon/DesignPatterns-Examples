using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Individual : IComposite
    {
        public string Name { get; }

        public int Coins
        {
            get;set;          
        }

        public void ShowCoins()
        {
            Console.WriteLine(Name + " has " + Coins);
        }

        public Individual (string name)
        {
            this.Name = name;
        }
    }
}
