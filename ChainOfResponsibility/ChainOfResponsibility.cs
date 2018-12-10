using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    enum ChainResponse
    {
       Denied = 0, Approved = 1      
    }

    interface IReport
    {
     
    }

    interface IChainHandler
    {
        ChainResponse ToNext(IReport itemToBePassed);
        void RegisterNext(IChainHandler next);
    }

    interface IChainApprover
    {
        ChainResponse Approve(IReport itemToBePassed);
    }

    class ChainOfResponsibility: IChainHandler
    {
        private IChainHandler next;
        private readonly IChainApprover approver;

        public ChainOfResponsibility(IChainApprover nextInChain)
        {
           this.approver = nextInChain;
        }

        public void RegisterNext(IChainHandler next)
        {
            this.next = next;
        }
       
        public ChainResponse ToNext(IReport itemToBePassed)
        {
            ChainResponse response = approver.Approve(itemToBePassed);

            if (response == ChainResponse.Denied ) {
                return next.ToNext(itemToBePassed);
            }
            return response;
        }
    }
}
