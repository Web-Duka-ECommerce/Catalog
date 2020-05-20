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

        [HttpGet]
        [Route("/api/v1/product")]
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

        [HttpGet]
        [Route("/api/v1/product/{id:int}")]
        [Produces("application/json")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        [ProducesResponseType(typeof(ProductView), (int)HttpStatusCode.OK)]
        public ProductView GetById(int id)
        {
            var rng = new Random();
            var weather = new ProductView
            {
                Id = id,
                Date = DateTime.Now.AddDays(1),
                Name = Summaries[rng.Next(Summaries.Length)]
            };

            return weather;
        }
    }
}
