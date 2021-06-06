using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RM.Actions.BaseAbstractions;
using RM.Domain.Payments;

namespace RM.Actions.Payments.Queries
{
    public record UserPaymentInformationQuery (Guid Id) : IRequest<ValueResult<UserPaymentInformation>>;
        
    public class UserPaymentInformationQueryHandler : IRequestHandler<UserPaymentInformationQuery, ValueResult<UserPaymentInformation>>
    {
        public Task<ValueResult<UserPaymentInformation>> Handle(UserPaymentInformationQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new ValueResult<UserPaymentInformation>(new UserPaymentInformation(), ResultStatus.Success));
        }
    }
}