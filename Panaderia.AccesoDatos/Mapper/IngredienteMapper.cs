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
    public class IngredienteMapper : EntityMapper, IObjectMapper, ISqlStatements
    {

        private const string DB_COL_ID = "ID";
        private const string DB_COL_NOMBRE = "NOMBRE";
        private const string DB_COL_UNIDAD_MEDIDA = "UNIDAD_MEDIDA";
        private const string DB_COL_UNIDAD_EMPAQUE = "UNIDAD_EMPAQUE";
        private const string DB_COL_CANT_POR_EMPAQUE = "CANT_POR_EMPAQUE";
        private const string DB_COL_UNIDADES = "UNIDADES";

        public EntidadBase BuildObject(Dictionary<string, object> values)
        {
            var ingrediente = new Ingrediente
            {
                Id = GetIntValue(values, DB_COL_ID),
                UnidadDeMedida = GetIntValue(values, DB_COL_ID),
                UnidadDeEmpaque = GetStringValue(values, DB_COL_UNIDAD_EMPAQUE),
                CantPorEmpaque = GetIntValue(values, DB_COL_ID),
                Unidades = GetDoubleValue(values, DB_COL_UNIDADES)

            };

            return ingrediente;
        }

        public List<EntidadBase> BuildObjects(List<Dictionary<string, object>> values)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetCreateStatement(EntidadBase entidad)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_INGREDIENTE_PR" };

            var i = (Ingrediente)entidad;
            operation.AddVarcharParam(DB_COL_NOMBRE, i.Nombre);
            operation.AddIntParam(DB_COL_UNIDAD_MEDIDA, i.UnidadDeMedida.Id);
            operation.AddVarcharParam(DB_COL_UNIDAD_EMPAQUE, i.UnidadDeEmpaque);
            operation.AddDecimalParam(DB_COL_CANT_POR_EMPAQUE, i.CantPorEmpaque);
            operation.AddDecimalParam(DB_COL_UNIDADES, i.Unidades);

            return operation;
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
            var operation = new SqlOperation { ProcedureName = "GET_ALL_INGREDIENTE_PR" };

            return operation;
        }

        public SqlOperation GetRetriveByIdStatement(string id)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
