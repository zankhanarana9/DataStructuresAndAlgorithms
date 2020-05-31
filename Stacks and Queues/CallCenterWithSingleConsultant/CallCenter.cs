using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallCenterWithSingleConsultant
{
    public class CallCenter
    {
        private int _counter = 0;
        public Queue<IncomingCall> Calls { get; private set; }
        public CallCenter()
        {
            Calls = new Queue<IncomingCall>();
        }

        public void Call(int ClientId)
        {
            IncomingCall call = new IncomingCall()
            {
                Id = ++_counter,
                ClientId = ClientId,
                CallTime = DateTime.Now
            };
            Calls.Enqueue(call);
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
