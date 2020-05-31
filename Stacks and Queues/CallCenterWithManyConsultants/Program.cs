﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CallCenterWithManyConsultants
{
    class Program
    {
        static void Main(string[] args)
        {
            CallCenter center = new CallCenter();
            Parallel.Invoke(
                () => CallersAction(center),
                () => ConsultantAction(center, "Marcin", ConsoleColor.Red),
                () => ConsultantAction(center, "James", ConsoleColor.Yellow),
                () => ConsultantAction(center, "Olivia", ConsoleColor.Green)
                );
        }
        private static void CallersAction(CallCenter center)
        {
            Random random = new Random();
            while(true)
            {
                int clientId = random.Next(1, 10000);
                int waitingCount = center.Call(clientId);
                Log($"Incoming call from {clientId}, waiting in the queue: {waitingCount}");
                Thread.Sleep(random.Next(1000, 2000));
            }
        }

        private static void ConsultantAction(CallCenter center, string Consultant, ConsoleColor color)
        {
            Random random = new Random();
            while(true)
            {
                IncomingCall call = center.Answer(Consultant);
                if(call!= null)
                {
                    Console.ForegroundColor = color;
                    Log($"Call #{call.Id} from {call.ClientId} is answered by {call.Consultant}");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(1000, 5000));
                    center.End(call);

                    Log($"Call #{call.Id} from {call.ClientId} is ended by {call.Consultant}");
                    Console.ForegroundColor = ConsoleColor.Gray;

                    Thread.Sleep(random.Next(500,1000));
                }
                else
                {
                    Thread.Sleep(100);
                }
            }
        }
        private static void Log(string text)
        {
            Console.WriteLine($"[{DateTime.Now.ToString("HH:mm:ss")}] {text}");
        }
    }
}
