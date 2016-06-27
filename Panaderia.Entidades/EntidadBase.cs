using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.Entidades
{
    public abstract class EntidadBase
    {
        public int Id { get; set; }

        public abstract string toString();
    }
}
