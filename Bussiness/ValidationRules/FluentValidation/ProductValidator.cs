using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bussiness.ValidationRules.FluentValidation
{
	public class ProductValidator : AbstractValidator<Product>
	{
		public ProductValidator()
		{
			RuleFor(p => p.ProductName).MinimumLength(2);
			RuleFor(p => p.ProductName).NotEmpty();
			RuleFor(p => p.UnitPrice).NotEmpty();
			RuleFor(p => p.UnitPrice).GreaterThan(0);//sıfırdan büyük olmalı.
			RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryID == 1);
			RuleFor(p => p.ProductName).Must(startWithA).WithMessage("Ürünler A harfi ile başlamalı.");
		}

		private bool startWithA(string arg)
		{
			return arg.StartsWith("A");
		}
	}
}

// cross cutting concerns log cache transaction authorization 