using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    //There are collegue that could inherit from abstract class or interface
    //Mediator to decoupling collegues
    //centralized control
    //could get too big
    class Mediator : IMediator
    {
        private readonly IList<BaseClass> members = new List<BaseClass>();

        public void Recieve(BaseClass obj)
        {
            foreach (var member in members.Where(x=> x != obj))
            {
                //do whatever
                //if (condition met)
                //member.Warn(obj);
            }
        }

        public void Register(BaseClass obj)
        {
            if(!members.Contains(obj))
            { members.Add(obj); }
        }
    }
}
