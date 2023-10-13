using CoreLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccess
{
    public interface IEntityRepository<T> where T : class,IEntity, new()
    {
        T Get(int id); 

        List<T> GetAll(); 

        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);


    }
}
