using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    class Not : Gate
    {
        protected Component input;

        public Component Input
        {
            get { return input; }
            set { input = value; }
        }

        public override String description()
        {
            return base.description() + " input: " + ((input != null) ? input.getId() : "not connected");
        }

        public override bool getState()
        {
            if (input == null)
                throw new NotConnectedException();
            else
                return !input.getState();
        }
    }
}
