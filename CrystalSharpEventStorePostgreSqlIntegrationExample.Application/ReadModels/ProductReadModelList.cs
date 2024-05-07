using System.Collections.Generic;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.ReadModels
{
    public class ProductReadModelList
    {
        public IEnumerable<ProductReadModel> Products { get; set; }
    }
}
