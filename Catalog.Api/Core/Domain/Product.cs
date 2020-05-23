using System;
namespace Catalog.Api.Core.Domain
{
    public class Product
    {
        public Product()
        {
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; private set; }
    }
}
