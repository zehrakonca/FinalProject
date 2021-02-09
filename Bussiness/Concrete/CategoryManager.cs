using Bussiness.Abstract;
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
		public List<Category> GetAll()
		{
			return _categoryDal.GetAll();
		}
		public Category GetByID(int categoryID)
		{
			return _categoryDal.Get(c => c.CategoryID == categoryID);
		}
	}
}
