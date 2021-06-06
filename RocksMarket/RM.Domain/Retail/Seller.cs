using System;
using System.Drawing;
using RM.Domain.BaseAbstractions;

namespace RM.Domain.Retail
{
    public class Seller : EntityBase
    {
        public Seller(Guid userId)
        {
            UserId = userId;
        }

        public Guid UserId { get; protected set; }

        public SellerStatus Status { get; protected set; }
    }
}