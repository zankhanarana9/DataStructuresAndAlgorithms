﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace CallCenterWithPrioritySupport
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            CallCenter center = new CallCenter();
            center.Call(1234);
            center.Call(5678, true);
            center.Call(1468);
            center.Call(9641, true);

            while(center.AreWaitingCalls())
            {
                IncomingCall call = center.Answer("Marcin");
                Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant} / Mode: {(call.IsPriority ? "priority" : "normal")}");
                Thread.Sleep(random.Next(1000, 10000));
                center.End(call);
                Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant} / Mode: {(call.IsPriority ? "priority" : "normal")}");
            }
        }
        private static void Log(string Text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {Text}");
        }
    }
}
