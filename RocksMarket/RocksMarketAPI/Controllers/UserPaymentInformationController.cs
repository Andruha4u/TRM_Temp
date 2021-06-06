using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RM.Actions.BaseAbstractions;
using RM.Actions.Payments.Queries;
using RM.Domain.Payments;
using RocksMarketAPI.BaseAbstractions;

namespace RocksMarketAPI.Controllers
{
    public class UserPaymentInformationController : RocksControllerBase
    {
        public UserPaymentInformationController(IMediator mediator)
            : base(mediator)
        {
        }

        [HttpGet("{id}")]
        public Task<ValueResult<UserPaymentInformation>> Get(Guid id)
            => Mediator.Send(new UserPaymentInformationQuery(id));
    }
}