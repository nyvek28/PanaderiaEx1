using Panaderia.AccesoDatos.Dao;
using Panaderia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.AccesoDatos.Mapper.Base
{
    public interface ISqlStatements
    {
        SqlOperation GetCreateStatement(EntidadBase entidad);
        SqlOperation GetRetriveByIdStatement(string id);
        SqlOperation GetRCreateStatement(EntidadBase entidad);
        SqlOperation GetRetriveStatement(EntidadBase entidad);
        SqlOperation GetRetriveAllStatement();
        SqlOperation GetUpdateStatement(EntidadBase entidad);
        SqlOperation GetDeleteStatement(EntidadBase entidad);
    }
}
