﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpEvolution.Tests01
{
    public class SubstractCalculate : ICalculate
    {
        public double Calculate(Options options)
        {
            return options.FirstNumber - options.SecondNumber;
        }
    }
}
