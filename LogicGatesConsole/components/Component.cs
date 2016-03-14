using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    abstract class Component
    {
        protected static int instances = 0;
        protected int id;

        public Component() { instances++; id = instances; }

        public int Serial
        {
            get { return id; }
        }

        public String getId()
        {
            return GetType().Name.ToString() + id;
        }

        public virtual String description()
        {
            return getId();
        }

        public abstract bool getState();
    }
}
