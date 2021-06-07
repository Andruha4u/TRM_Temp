using RM.DataAccess.BaseAbstractions;
using RM.Domain.Payments;
using RM.Persistence;

namespace RM.DataAccess.Payments
{
    public class UserPaymentInformationAccess : EntityAccessBase<UserPaymentInformation>
    {
        protected UserPaymentInformationAccess(MarketplaceContext context) 
            : base(context)
        {
        }
    }
}