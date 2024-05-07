using System;
using CrystalSharp.Application;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.ReadModels;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Queries
{
    public class ProductDetailQuery : IQuery<QueryExecutionResult<ProductReadModel>>
    {
        public Guid GlobalUId { get; set; }
    }
}
