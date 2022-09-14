using DockerCarvedRockApi.ApiModels;
using DockerCarvedRockApi.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace DockerCarvedRockApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductLogic _productLogic;

        public ProductsController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts(string category = "all")
        {
            Log.Information("Starting Controller Action GetProducts for {category}", category);
            return _productLogic.GetProductsForCategory(category);
        }
    }
}
