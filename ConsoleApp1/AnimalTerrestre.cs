using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AnimalTerrestre : Animal
    {
        public void Caminar()
        {
            Console.WriteLine("Hola soy " + Nombre + " y ando caminando como la ves carnal ");
        }
    }
}
