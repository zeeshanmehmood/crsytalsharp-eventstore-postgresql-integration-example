using System;
using CrystalSharp.Application;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.ReadModels;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Queries
{
    public class ProductDetailByVersionQuery : IQuery<QueryExecutionResult<ProductReadModel>>
    {
        public Guid GlobalUId { get; set; }
        public long Version { get; set; }
    }
}
