﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Zad1
{
    class ConsoleLogger : ILogger
    {
       
            public void Log(string message) {

                Console.WriteLine(message);

            }

           
        
    }
}
