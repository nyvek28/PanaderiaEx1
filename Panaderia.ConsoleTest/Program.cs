using Panaderia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Antes del thread");
            Horno h = new Horno();
            Console.WriteLine("Horno instanciado");
            h.Hornear(new Orden(new Receta(), 10));
            Console.WriteLine("Despues del thread");
        }
    }
}
