using System;
using CrystalSharp.Application;
using CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Responses;

namespace CrystalSharpEventStorePostgreSqlIntegrationExample.Application.Commands
{
    public class ChangeProductNameCommand : ICommand<CommandExecutionResult<ProductResponse>>
    {
        public Guid GlobalUId { get; set; }
        public string Name { get; set; }
    }
}
