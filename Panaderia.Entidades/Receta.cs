using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public class Receta : EntidadBase
    {

        public List<Ingrediente> Ingredientes { get; set; }
        public string Nombre { get; set; }
        public double TiempoCoccion { get; set; }
        public int Porciones { get; set; }

        public Receta()
        {
            Porciones = 5;
            TiempoCoccion = 15;
        }

        public override string toString()
        {
            throw new NotImplementedException();
        }

    }
}
