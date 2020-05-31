using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Priority_Queue;

namespace CallCenterWithPrioritySupport
{
    public class CallCenter
    {
        private int _counter = 0;
        public SimplePriorityQueue<IncomingCall> Calls { get; private set; }

        public CallCenter()
        {
            Calls = new SimplePriorityQueue<IncomingCall>();
        }
        public void Call(int clientId, bool IsPriority = false)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = clientId,
                CallTime = DateTime.Now,
                IsPriority = IsPriority
            };
            Calls.Enqueue(call, IsPriority ? 0 :1);
        }
        public IncomingCall Answer(string Consultant)
        {
            if(Calls.Count > 0)
            {
                IncomingCall call = Calls.Dequeue();
                call.Consultant = Consultant;
                call.StartTime = DateTime.Now;
                return call;
            }
            return null;
        }
        public void End(IncomingCall call)
        {
            call.EndTime = DateTime.Now;
        }

        public bool AreWaitingCalls()
        {
            return Calls.Count > 0;
        }
    }
}
