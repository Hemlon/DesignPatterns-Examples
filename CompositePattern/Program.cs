using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {

            var Lony = new Individual("Lony");
            var Julie = new Individual("Julie");
            var Alicia = new Individual("Alicia");
            var Sentu = new Individual("Sentu");

            var Hem = new Group("Hem", new List<IComposite> { Lony, Julie, Alicia } );
            var root = new Group("root", new List<IComposite> { Hem, Sentu });
            root.Coins = 100;
            root.ShowCoins();
            Console.ReadLine();

        }
    }
}
