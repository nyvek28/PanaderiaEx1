using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.AccesoDatos.Dao
{
    public class SqlOperation
    {
        public string ProcedureName { get; set; }
        public List<SqlParameter> Parameters { get; set; }

        public SqlOperation()
        {
            Parameters = new List<SqlParameter>();
        }

        public void AddVarcharParam(string paramName, string paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, System.Data.SqlDbType.VarChar)
            {
                Value = paramValue
            };

            Parameters.Add(param);

        }

        public void AddDecimalParam(string paramName, double paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, System.Data.SqlDbType.Decimal)
            {
                Value = (decimal)paramValue
            };

            Parameters.Add(param);

        }

        public void AddIntParam(string paramName, int paramValue)
        {
            var param = new SqlParameter("@P_" + paramName, System.Data.SqlDbType.Int)
            {
                Value = paramValue
            };

            Parameters.Add(param);

        }
    }
}
