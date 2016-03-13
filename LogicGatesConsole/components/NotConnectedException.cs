using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicGatesConsole.components
{
    class NotConnectedException : Exception
    {
        public NotConnectedException() { }

        public NotConnectedException(string message)
            : base(message)
        { }

        public NotConnectedException(string message, Exception inner)
            : base(message, inner)
        { }
    }
}
