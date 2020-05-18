using System;
namespace Catalog.Api.Core.Domain
{
    public class ProductCategory: BaseEntity
    {
        public ProductCategory()
        {
        }

        /// <summary>
        /// Gets or sets the product identifier
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// Gets or sets the category identifier
        /// </summary>
        public int CategoryId { get; set; }
    }
}
