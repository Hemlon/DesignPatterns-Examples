using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{   //there must be one and only one
    //must have public Instance() method, private Singleton constructor


    class Singleton
    {
        private Singleton() { } //default private constructor
        public static Singleton Instance //create a single instance
        { get { return Nested.instance; } }

        private class Nested
        {
            static Nested()
            {

            }
            internal static readonly Singleton instance = new Singleton(); //instance of
        }
    }
}
