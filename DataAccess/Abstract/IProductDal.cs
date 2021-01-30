using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        List<Product> GetAllByCategory(int categoryID);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        
    }
}
