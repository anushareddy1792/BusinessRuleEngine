using BusinessRuleService.Books;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Membership;
using BusinessRuleService.Models.Enums;
using BusinessRuleService.PhysicalProduct;
using BusinessRuleService.Videos;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleEngine
{
    public class Factory
    {
        private static IPaymentRule _paymentRule;
        public static IPaymentRule GetObject(ProductType type)
        {
            switch (type)
            {
                case ProductType.Book:
                    _paymentRule = new BookPaymentRule();
                    return _paymentRule;
                case ProductType.PhysicalProduct:
                    _paymentRule = new PhysicalProductPaymentRule();
                    return _paymentRule;
                case ProductType.Video:
                    _paymentRule = new VideoPaymentRule();
                    return _paymentRule;
                case ProductType.MembershipActivate:
                    _paymentRule = new MemershipActivatePaymentRule();
                    return _paymentRule;
                case ProductType.MembershipUpgrade:
                    _paymentRule = new MembershipUpgardePaymentRule();
                    return _paymentRule;
                default:
                    _paymentRule = new PhysicalProductPaymentRule();
                    return _paymentRule;

            }

        }
    }
}
