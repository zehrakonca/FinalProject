using Bussiness.Abstract;
using Bussiness.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductsController : ControllerBase
	{
		//loosely coupled gevşek bağlılık.
		//naming convention
		//IoC Container /  inversion of control - değişim kontrolü 
		//aop = bir methodun önünde yada sonunda hata verdiğinde çalışan kod parçacıkları. bussines içinde bussines yazılır. 
		IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}
		[HttpGet("getall")]
		public IActionResult GetAll()
		{
			var result = _productService.GetAll();
			if (result.Success)
			{
				return Ok(result.Data) ;
			}
			else
			{
				return BadRequest(result.Message);
			}
		}
		[HttpGet("getbyid")]
		public IActionResult GetByID(int productID)
		{
			var result = _productService.GetByID(productID);
			if (result.Success)
			{
				return Ok(result.Data);
			}
			return BadRequest(result);	
		}
		[HttpPost("add")]
		public IActionResult Add(Product product)
		{
			var result = _productService.Add(product);
			if (result.Success)
			{
				return Ok(result);
			}
			return BadRequest(result);
		}
	}
}
