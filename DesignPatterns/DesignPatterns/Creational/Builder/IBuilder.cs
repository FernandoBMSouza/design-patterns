﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Builder
{
    internal interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
    }
}
