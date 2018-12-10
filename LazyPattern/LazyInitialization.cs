using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyPattern
{
    class LazyInitialization
    {
        Lazy<string> name;
        Lazy<string> initializer;

        public LazyInitialization()
        {
            initializer = new Lazy<string>(()=> "");
        }

        string Name
        {
            get
            {
                return initializer.Value;
            }
        }


    }
}
