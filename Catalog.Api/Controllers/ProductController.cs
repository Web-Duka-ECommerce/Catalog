using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Catalog.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Milk", "Diet Coke", "Water", "Beef", "Chicken", "Tissue", "Suasages", "Pepper", "Pizza", "Butter"
        };

        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Get a list of product catalog items
        /// </summary>
        /// <returns>Products</returns>
        [HttpGet]
        [Produces("application/json")]
        [ProducesResponseType(typeof(IEnumerable<ProductView>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public IEnumerable<ProductView> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new ProductView
            {
                Id = index,
                Date = DateTime.Now.AddDays(index),
                Name = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
        /// <summary>
        /// Get a product by ID
        /// </summary>
        /// <param name="productId">The id of the product you want to get</param>
        /// <returns>A product with id, name and description fields</returns>
        [HttpGet("{productId}")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ProductView), (int)HttpStatusCode.OK)]
        public ProductView GetById(int productId)
        {
            var rng = new Random();
            var weather = new ProductView
            {
                Id = productId,
                Date = DateTime.Now.AddDays(1),
                Name = Summaries[rng.Next(Summaries.Length)]
            };

            return weather;
        }
    }
}
