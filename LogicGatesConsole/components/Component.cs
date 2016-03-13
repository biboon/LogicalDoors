using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    abstract class Component
    {
        public String getId()
        {
            return base.ToString();
        }

        public virtual String description()
        {
            return getId();
        }

        public abstract bool getState();
    }
}
