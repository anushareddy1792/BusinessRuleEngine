using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Membership
{
    /// <summary>
    /// Implements common logic for membership product
    /// </summary>
    public abstract class Membership
    {

        /// <summary>
        /// Emails owner after activation or upgrade of membership
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
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
