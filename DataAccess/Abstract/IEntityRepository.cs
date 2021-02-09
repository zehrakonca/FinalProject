using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //class referans tip
    //class, IEntity olabilir, yada onu implemet eden bir nesne olabilir.
    //new'lenebilir olmalıdır. 
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		// linq dersindeki gibi filtreler yazmayı sağlar.
		//GetAll(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T,bool>> filter); 
        // tek bir maddenin detaylarına girmek için kullanılır. 

        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
