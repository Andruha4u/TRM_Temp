using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using RM.Actions.BaseAbstractions;
using RM.Actions.Payments.Queries;
using RM.Domain.Payments;
using RM.Persistence;
using RocksMarketAPI.BaseAbstractions;

namespace RocksMarketAPI.Controllers
{
    [Route("[controller]")]
    public class UserPaymentInformationController : RocksControllerBase
    {
        public UserPaymentInformationController(IMediator mediator, MarketplaceContext ctx)
            : base(mediator)
        {
        }

        [HttpGet("{id}")]
        public Task<ValueResult<UserPaymentInformation>> Get(Guid id)
            => Mediator.Send(new UserPaymentInformationQuery(id));
    }
}