﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    class Or : TwoInputGate
    {
        public override bool eval()
        {
            return (input1.getState() || input2.getState());
        }
    }
}
