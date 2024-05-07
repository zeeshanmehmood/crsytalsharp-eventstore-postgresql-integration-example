using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Domain.Aggregates.ProductAggregate.Events;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.EventHandlers
{
    public class ProductNameChangedDomainEventHandler : ISynchronousDomainEventHandler<ProductNameChangedDomainEvent>
    {
        public async Task Handle(ProductNameChangedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}
