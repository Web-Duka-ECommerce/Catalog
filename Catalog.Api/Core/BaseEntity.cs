﻿using System;
namespace Catalog.Api.Core
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public abstract partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Get key for caching the entity
        /// </summary>
        public string EntityCacheKey => GetEntityCacheKey(GetType(), Id);

        /// <summary>
        /// Get key for caching the entity
        /// </summary>
        /// <param name="entityType">Entity type</param>
        /// <param name="id">Entity id</param>
        /// <returns>Key for caching the entity</returns>
        private string GetEntityCacheKey(Type entityType, object id)
        {
            throw new NotImplementedException();
        }
    }
}
