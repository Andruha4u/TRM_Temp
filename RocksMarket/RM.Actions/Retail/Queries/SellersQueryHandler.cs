using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RM.Actions.BaseAbstractions;
using RM.Domain.Retail;

namespace RM.Actions.Retail.Queries
{
    public record SellerQuery (Guid Id) : IRequest<ValueResult<Seller>>;
        
    public class SellersQueryHandler : IRequestHandler<SellerQuery, ValueResult<Seller>>
    {
        public Task<ValueResult<Seller>> Handle(SellerQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ValueResult<Seller>(new Seller(Guid.NewGuid()), ResultStatus.Success));
        }
    }
}