using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public class Ingrediente : EntidadBase
    {

        public string Nombre { get; set; }
        public UMedida UnidadDeMedida { get; set; }
        public string UnidadDeEmpaque { get; set; }
        public double CantPorEmpaque { get; set; }
        public double Unidades { get; set; }

        public override string toString()
        {
            string msj;

            msj = "Id: " + Id + "\n"
                + "Nombre: " + Nombre + "\n"
                + "Unidad de Medida: " + UnidadDeMedida.Nombre + "\n"
                + "Unidad de Empaque: " + UnidadDeEmpaque + "\n"
                + "Cantidad por Empaque: " + CantPorEmpaque + UnidadDeMedida.Simbolo + "\n"
                + "";

            return msj;
        }
    }
}
