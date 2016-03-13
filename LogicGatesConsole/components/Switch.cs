using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    class Switch : Component
    {
        protected bool state;
        
        public void on() { state = true; }

        public void off() { state = false; }

        public override bool getState()
        {
            return state;
        }

        public override String description()
        {
            return base.description() + " switched " + ((state) ? "on" : "off");
        }
    }
}
