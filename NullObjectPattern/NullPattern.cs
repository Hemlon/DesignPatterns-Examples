using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
   public abstract class NullPattern
    {

   
        internal class NullObject: NullPattern //the null object is a singleton
        {
            private NullObject() { } //default private constructor
            public static NullObject Null //create a single instance
            { get { return Nested.instance; } }
            class Nested
            {
                static Nested()
                {

                }
                internal static readonly NullObject instance = new NullObject(); //instance of
            }
        }


    }
}
