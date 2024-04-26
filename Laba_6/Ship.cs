using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal class Ship: Transport
    {
        public override int speed { get; set; } = 80;
        public override int tonnage { get; set; } = 150;
        public override int range { get; set; } = 300000;

        public override int getSpeed()
        {
            Console.WriteLine($"Скорость корабля: {speed}");
            return speed;
        }
        public override int getTonnage()
        {
            Console.WriteLine($"Грузоподъёмность корабля: {tonnage}");
            return tonnage;
        }
        public override int getRange()
        {
            Console.WriteLine($"Скорость корабля: {range}");
            return range;
        }
    }
}
