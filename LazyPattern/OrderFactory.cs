using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPattern
{
    //identity problems between proxy and actual object
    //override the gethash to get around it
    //end up using up too much proxy
    //can use dynamic proxy

        //use a factory
        public class OrderFactory
        {
            public ILazyProxy Create(Guid id)
            {
                return new OrderProxy() { Id = id };
            }
        }



    
}
