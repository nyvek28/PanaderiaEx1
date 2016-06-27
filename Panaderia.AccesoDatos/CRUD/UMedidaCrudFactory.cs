using Panaderia.AccesoDatos.CRUD.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Panaderia.Entidades;
using Panaderia.AccesoDatos.Mapper;
using Panaderia.AccesoDatos.Dao;

namespace Panaderia.AccesoDatos.CRUD
{
    class UMedidaCrudFactory : CrudFactory
    {

        private UMedidaMapper _mapper { get; set; }

        public UMedidaCrudFactory()
        {
            _mapper = new UMedidaMapper();
        }

        public override bool Create(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public override bool Delete(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public override EntidadBase RCreate(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(string id)
        {

            var um = new UMedida
            {
                Simbolo = id
            };

            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveStatement(um));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    return (T)Convert.ChangeType(_mapper.BuildObject(dic), typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override T RetrieveByIngrediente<T>(EntidadBase entidad)
        {

            try
            {
                var lstResult = SqlDao.ExecuteQueryProcedure(_mapper.GetRetriveByIngredienteStatement(entidad));
                var dic = new Dictionary<string, object>();
                if (lstResult.Count > 0)
                {
                    dic = lstResult[0];

                    return (T)Convert.ChangeType(_mapper.BuildObject(dic), typeof(T));
                }

                return default(T);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override T RetrieveByIdInt<T>(int id)
        {
            throw new NotImplementedException();
        }

        public override bool Update(EntidadBase entidad)
        {
            throw new NotImplementedException();
        }
    }
}
