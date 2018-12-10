using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public abstract class BaseClass
    {
        private readonly IMediator mediator;

        protected BaseClass(Guid id, IMediator Mediator)
        {
            Id = id;
            this.mediator = Mediator;
            mediator.Register(this);
        }

        private string name;

        public string Name { get { return name; } set { name = value; mediator.RecieveName(this); } }

        public abstract Guid Id { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
