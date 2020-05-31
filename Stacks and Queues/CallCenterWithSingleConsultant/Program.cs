using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallCenterWithSingleConsultant
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            CallCenter center = new CallCenter();
            center.Call(1234);
            center.Call(5678);
            center.Call(1468);
            center.Call(9641);

            while(center.AreWaitingCalls())
            {
                IncomingCall call = center.Answer("Marcin");
                Log($" Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}.");
                Thread.Sleep(1000);
                Log($" Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}.");
                Console.Read();
            }         
        }
        private static void Log(string Text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] { Text}");
        }
    }
}
