using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal abstract class Airplane : Transport
    {
        public override int speed { get; set; } = 400;
        public override int tonnage { get; set; } = 100;
        public override int range { get; set; } = 2000000;

        public override int getSpeed()
        {
            Console.WriteLine($"Скорость самолета: {speed}");
            return speed;
        }
        public override int getTonnage()
        {
            Console.WriteLine($"Грузоподъёмность самолета: {tonnage}");
            return tonnage;
        }
        public override int getRange()
        {
            Console.WriteLine($"Скорость самолета: {range}");
            return range;
        }
    }
}
