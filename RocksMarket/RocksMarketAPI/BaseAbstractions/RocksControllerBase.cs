using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace RocksMarketAPI.BaseAbstractions
{
    public class RocksControllerBase : ControllerBase
    {
        protected RocksControllerBase(IMediator mediator)
        {
            Mediator = mediator;
        }

        protected IMediator Mediator;
    }
}