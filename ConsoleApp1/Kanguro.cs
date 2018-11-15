using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Kanguro : AnimalTerrestre
    {
        public Kanguro()
        {
            Nombre = "Kanguro Jack";
        }
        public void Saltar()
        {
            Console.WriteLine("Hola soy " + Nombre + " y estoy saltando asi bien alto we cachai ");
        }
    }
}
