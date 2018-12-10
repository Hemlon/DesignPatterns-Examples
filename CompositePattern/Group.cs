using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Group : IComposite
    {
       
        public Group(string name, List<IComposite> list)
        {
            this.Name = name;
            Members = list;
        }

        List<IComposite> Members;
       

        public int Coins
        {
            get
            {
                return Coins;
            }

            set
            {
                var share =  value / Members.Count;
                foreach (var member in Members)
                {
                    member.Coins = share;
                }
            }
        }

        string Name
        {
            get;
        }

        public void ShowCoins()
        {
            foreach (var member in Members)
            {
                member.ShowCoins();
            }
        }
    }
}
