using System;
namespace Catalog.Api.Core.Domain
{
    /// <summary>
    /// Represents a product type
    /// </summary>
    public enum ProductType
    {
        /// <summary>
        /// Simple
        /// </summary>
        SimpleProduct = 5,

        /// <summary>
        /// Grouped (Product with variants)
        /// </summary>
        GroupedProduct = 10
    }
}
