using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPattern
{
   public class Order: ILazyProxy
    {

        public Guid Id { get; set; }
        public virtual string Name { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }


    }
}
