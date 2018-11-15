using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Nombre { get; set; }

        public void comer()
        {
            Console.WriteLine("Hola soy " + Nombre + " y estoy comiendo");
        }
    }
}
