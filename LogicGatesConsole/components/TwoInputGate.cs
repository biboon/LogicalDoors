using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    abstract class TwoInputGate : Gate
    {
        public abstract bool eval();

        protected Component input1;
        protected Component input2;

        public Component Input1
        {
            get { return input1; }
            set { input1 = value; }
        }

        public Component Input2
        {
            get { return input2; }
            set { input2 = value; }
        }

        public override String description()
        {
            return base.description() + "input1: " + ((input1 != null) ? input1.getId() : "not connected") + "input2: " + ((input2 != null) ? input2.getId() : "not connected");
        }

        public override bool getState()
        {
            if (input1 == null)
                throw new NotConnectedException("Input 1 not connected");
            else if (input2 == null)
                throw new NotConnectedException("Input 2 not connected");
            else
                return eval();
        }
    }
}
