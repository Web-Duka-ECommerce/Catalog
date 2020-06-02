using System;

namespace Catalog.Api
{
    public class ProductView
    {
        ///
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description => $"{Name} description";

        public DateTime Date { get; set; }
    }
}
