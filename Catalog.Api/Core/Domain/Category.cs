using System;
namespace Catalog.Api.Core.Domain
{
    public class Category: BaseEntity
    {
        public Category()
        {
        }

        /// <summary>
        /// Get or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }
    }
}

