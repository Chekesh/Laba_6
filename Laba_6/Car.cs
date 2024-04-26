using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal abstract class Car:Transport
    {
        public override int speed { get; set; } = 200;
        public override int tonnage { get; set; } = 8;
        public override int range { get; set; } = 150;

        public override int getSpeed()
        {
            Console.WriteLine($"Скорость машины: {speed}");
            return speed;
        }
        public override int getTonnage()
        {
            Console.WriteLine($"Грузоподъёмность машины: {tonnage}");
            return tonnage;
        }
        public override int getRange()
        {
            Console.WriteLine($"Скорость машины: {range}");
            return range;
        }
    }
}
