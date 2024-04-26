using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Transport transport = new Lamborghini();
            Lamborghini lamborghini = new Lamborghini();
            R_Flot r_flot = new R_Flot();
            YAK yak = new YAK();

            lamborghini.informathion();
            Console.Read();
        }
    }
}
