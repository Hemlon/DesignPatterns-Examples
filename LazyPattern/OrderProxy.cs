using System;

namespace LazyPattern
{
    public class OrderProxy:ILazyProxy
    {
        public OrderProxy()
        {
        }

        public Guid Id { get; set; }
    }
}