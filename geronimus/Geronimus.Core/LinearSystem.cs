﻿using System;
using System.Collections.Generic;

namespace Geronimus.Core
{
    public class LinearSystem
    {
        public List<LinearEquation> Equations { get; private set; }

        public LinearSystem()
        {
            this.Equations = new List<LinearEquation>(3);
        }

        public LinearSystem Add(LinearEquation equation)
        {
            this.Equations.Add(equation);
            return this;
        }
    }
}