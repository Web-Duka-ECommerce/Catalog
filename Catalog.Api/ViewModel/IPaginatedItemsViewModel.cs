using System;
using System.Collections.Generic;

namespace Catalog.Api.ViewModel
{
    public interface IPaginatedItemsViewModel<TEntity> where TEntity : class
    {
        int PageIndex { get; }

        int PageSize { get; }

        long Count { get; }

        IEnumerable<TEntity> Data { get; }
    }
}
