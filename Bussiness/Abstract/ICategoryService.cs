using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.Abstract
{
	public interface ICategoryService
	{
		List<Category> GetAll();
		Category GetByID(int categoryID);
	}
}
