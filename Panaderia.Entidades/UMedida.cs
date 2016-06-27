using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public class UMedida : EntidadBase
    {

        public string Nombre { get; set; }
        public string Simbolo { get; set; }

        public override string toString()
        {
            string msj;

            msj = "Id: " + Id + "\n"
                + "Nombre: " + Nombre + "\n"
                + "Simbolo: " + Simbolo + "\n"
                + "";

            return msj;
        }
    }
}
