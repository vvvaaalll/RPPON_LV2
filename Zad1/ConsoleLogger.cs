using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class ConsoleLogger : ILogger
    {

            public void Log(ILoggable message) {

                Console.WriteLine(message.GetStringRepresentation());

            }

           
        
    }
}
