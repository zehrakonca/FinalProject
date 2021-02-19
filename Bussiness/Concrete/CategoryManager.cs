using Bussiness.Abstract;
using Bussiness.Constants;
using Core.Utilities.Abstract;
using Core.Utilities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Concrete
{
	public class CategoryManager : ICategoryService
	{
		ICategoryDal _categoryDal;
		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public IDataResult<List<Category>> GetAll()
		{
			return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.ProductsListed);
		}

		public IDataResult<Category> GetByID(int categoryID)
		{
			return new SuccessDataResult<Category>(_categoryDal.Get(p => p.CategoryID == categoryID));
		}
		public IResult Add(Category product)
		{
			//business codes

			if (product.CategoryName.Length < 2)
			{
				//magic strings
				return new ErrorResult(Messages.ProductNameInvalid);
			}
			_categoryDal.Add(product);

			return new SuccessResult(Messages.ProductAdded);
		}
	}
}
