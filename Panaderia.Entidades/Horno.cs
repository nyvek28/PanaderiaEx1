using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public class Horno : EntidadBase
    {

        private Thread _thread;

        public Horno()
        {
            _thread = new Thread(new ParameterizedThreadStart(ComenzarHorno));
        }

        public void Hornear(Orden o)
        {
            Console.WriteLine("Empezando...");
            _thread.Start(o);
        }

        private void ComenzarHorno(Object o)
        {
            Orden orden = (Orden)o;
            Thread.Sleep((int)orden.getTiempoCoccion() * 1000);
            Console.WriteLine("Horneada lista");
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
