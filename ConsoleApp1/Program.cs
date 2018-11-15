using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AnimalAcuatico delfin = new AnimalAcuatico();
            AnimalTerrestre Elefante = new AnimalTerrestre();
            Kanguro kanguro = new Kanguro();
            Animal tiburon = new AnimalAcuatico();
            List<Animal> animales = new List<Animal>();
            tiburon.Nombre = "Baby Shark turu turu turu";
            ((AnimalAcuatico)tiburon).Nadar();
            delfin.Nombre = "Flippy el delfin";
            Elefante.Nombre = "Dumbo la pelicula innecesaria";

            delfin.comer();
            delfin.Nadar();

            Elefante.Caminar();

            kanguro.Caminar();
            kanguro.Saltar();
            kanguro.comer();
            animales.Add(delfin);
            animales.Add(tiburon);
            animales.Add(Elefante);
            animales.Add(kanguro);

            foreach(var animal in animales)
            {
                Console.WriteLine(animal.Nombre);
               if (animal.GetType() == typeof(AnimalAcuatico))
                {
                    ((AnimalAcuatico)animal).Nadar();
                }
            }

            Console.ReadLine();
        }
    }
}
