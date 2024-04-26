using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal abstract class Transport
    {
        public abstract int speed { get; set; }
        public abstract int tonnage { get; set; }
        public abstract int range { get; set; }

        public abstract int getSpeed();
        public abstract int getTonnage();
        public abstract int getRange();
    }
}
