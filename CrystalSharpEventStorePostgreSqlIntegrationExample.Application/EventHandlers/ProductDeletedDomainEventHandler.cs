using System.Threading;
using System.Threading.Tasks;
using CrystalSharp.Domain.Infrastructure;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Domain.Aggregates.ProductAggregate.Events;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.EventHandlers
{
    public class ProductDeletedDomainEventHandler : ISynchronousDomainEventHandler<ProductDeletedDomainEvent>
    {
        public async Task Handle(ProductDeletedDomainEvent notification, CancellationToken cancellationToken = default)
        {
            //
        }
    }
}
