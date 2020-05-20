using System;
namespace Catalog.Api.Core.Domain
{
    public class Product
    {
        public Product()
        {
        }

        public string Name { get; private set; }

        public string Description { get; private set; }
    }
}
