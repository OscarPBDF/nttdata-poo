using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.InterfaceExample
{
    public class Camion : Vehiculo
    {
        public override void Arrancar()
        {
            Console.WriteLine("Camion arrancado");
        }

        public override void Parar()
        {
            Console.WriteLine("Camion parado");
        }
    }
}
