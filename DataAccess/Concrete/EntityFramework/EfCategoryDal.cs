﻿using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using System.Linq.Expressions;


namespace DataAccess.Concrete.EntityFramework
{
	public class EfCategoryDal : ICategoryDal
	{
		public void Add(Category entity)
		{
			throw new NotImplementedException();
		}

		public void Delete(Category entity)
		{
			throw new NotImplementedException();
		}

		public Category Get(Expression<Func<Category, bool>> filter)
		{
			throw new NotImplementedException();
		}

		public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
		{
			throw new NotImplementedException();
		}

		public void Update(Category entity)
		{
			throw new NotImplementedException();
		}
	}
}
