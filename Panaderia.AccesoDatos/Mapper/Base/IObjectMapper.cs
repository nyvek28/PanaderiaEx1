using Panaderia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.AccesoDatos.Mapper.Base
{
    public interface IObjectMapper
    {
        List<EntidadBase> BuildObjects(List<Dictionary<string, object>> values);
        EntidadBase BuildObject(Dictionary<string, object> values);
    }
}
