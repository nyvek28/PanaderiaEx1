using Panaderia.AccesoDatos.Mapper.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaderia.AccesoDatos.Dao;
using Panaderia.Entidades;

namespace Panaderia.AccesoDatos.Mapper
{
    class UMedidaMapper : EntityMapper, IObjectMapper, ISqlStatements
    {

        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_SIMBOLO = "SIMBOLO";

        public EntidadBase BuildObject(Dictionary<string, object> values)
        {
            var um = new UMedida
            {
                Id = GetIntValue(values, DB_COL_ID),
                Nombre = GetStringValue(values, DB_COL_NOMBRE),
                Simbolo = GetStringValue(values, DB_COL_SIMBOLO)
            };

            return um;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> values)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRCreateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "GET_ALL_UMEDIDA_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveByIdStatement(int id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "GET_UMEDIDA_PR" };

            var um = (UMedida)entidad;
            operation.AddVarcharParam(DB_COL_SIMBOLO, um.Simbolo);

            return operation;
        }

        public SqlOperation GetRetriveByIngredienteStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "GET_UMEDIDA_INGREDIENTE_PR" };

            var i = (Ingrediente)entidad;
            operation.AddIntParam("INGREDIENTE", i.Id);

            return operation;
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
