﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleException
{
    internal class Radio
    {
       
        public void TurnOn(bool on)
        {
            Console.WriteLine(on ? "Jamming.." : "Quiet time..");
        }
    }
}
