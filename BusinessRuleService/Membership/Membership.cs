using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Membership
{
    public abstract class Membership
    {
        public bool EmailOwner(Product product)
        {
            var result = false;
            var message = string.Empty;
            switch (product.Type)
            {
                case ProductType.MembershipActivate:
                    message = $"Mail sent to owner on membership activation at the cost of {product.Cost}";
                    result = true;
                    break;
                case ProductType.MembershipUpgrade:
                    message = $"Mail sent to owner on membership upgrade at the cost of {product.Cost}";
                    result = true;
                    break;
                default:
                    result= false;
                    break;
            }
            
            Console.WriteLine(message);
            return result;
        }

    }
}
