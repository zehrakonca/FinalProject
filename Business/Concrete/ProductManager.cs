using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }

		public List<Product> GetAllByCategoryId(int id)
		{
			return _productDal.GetAll(p => p.CategoryID == id);
		}

		public List<Product> GetByUnitPrice(decimal min, decimal max)
		{
			return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
		}
	}
}
