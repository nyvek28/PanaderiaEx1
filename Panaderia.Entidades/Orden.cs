using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public class Orden : EntidadBase
    {
        public Receta Receta { get; set; }
        public int Porciones { get; set; }
        public int Sobrantes { get; set; }
        public bool Completa { get; set; }

        public Orden(Receta receta, int porciones)
        {
            Receta = receta;
            Porciones = porciones;
            Sobrantes = CalcularSobrantes();
            Completa = false;
        }

        public double getTiempoCoccion()
        {
            return Receta.TiempoCoccion;
        }

        private int CalcularSobrantes()
        {
            int sobrantes;
            int numRecetas = 1;

            while(Porciones > (Receta.Porciones * numRecetas))
            {
                numRecetas++;
            }

            sobrantes = (Receta.Porciones * numRecetas) - Porciones;

            return sobrantes;
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }
    }
}
