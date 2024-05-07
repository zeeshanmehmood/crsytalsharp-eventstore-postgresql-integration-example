using System;
using CrystalSharp.Application;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Commands
{
    public class DeleteProductCommand : ICommand<CommandExecutionResult<DeleteProductResponse>>
    {
        public Guid GlobalUId { get; set; }
    }
}
