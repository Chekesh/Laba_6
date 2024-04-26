using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal class R_Flot : Ship
    {
        public override int speed { get; set; } = 100;
        public override int tonnage { get; set; } = 175;
        public override int range { get; set; } = 350000;

        public void informathion()
        {
            Console.WriteLine($"Ламборгини имеет скорость: {speed} км/ч, грузоподъёмность {tonnage} т, дальность расстояния {range}");
            //Console.WriteLine($"Ламборгини имеет скорость: \n{getSpeed()}, \n{getTonnage()}, \n{getRange()}");
        }
    }
}
