using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    abstract class IOPin : Component
    {
        protected String name;
        protected Component input;

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public override bool getState()
        {
            return input.getState();
        }
    }
}
