using System;
namespace Catalog.Api.Core.Domain
{
    public class ProductAttribute: BaseEntity
    {
        public ProductAttribute()
        {
        }

        /// <summary>
        /// Get or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Get or sets the description
        /// </summary>
        public string Description { get; set; }
    }
}
