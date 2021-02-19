using Core.Utilities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
	public interface ICategoryService
	{
		IDataResult<List<Category>> GetAll();
		IDataResult<Category>GetByID(int categoryID);
	}
}
