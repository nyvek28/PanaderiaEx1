using Panaderia.AccesoDatos.Dao;
using Panaderia.AccesoDatos.Mapper.Base;
using Panaderia.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panaderia.AccesoDatos.CRUD.Base
{
    public abstract class CrudFactory
    {
        protected SqlDao SqlSqlDao;
        protected EntityMapper EntityMapper { get; set; }

        public abstract bool Create(EntidadBase entidad);
        public abstract EntidadBase RCreate(EntidadBase entidad);
        public abstract T Retrieve<T>(string id);
        public abstract T RetrieveByIdInt<T>(int id);
        public abstract List<T> RetrieveAll<T>();
        public abstract bool Update(EntidadBase entidad);
        public abstract bool Delete(EntidadBase entidad);
    }
}
