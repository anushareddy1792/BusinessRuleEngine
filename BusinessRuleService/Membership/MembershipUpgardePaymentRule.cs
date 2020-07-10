using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Membership
{
    /// <summary>
    /// Implements payment rules for membership upgrade
    /// </summary>
    public class MembershipUpgardePaymentRule :Membership, IPaymentRule
    {
        /// <summary>
        /// Executes rules for  a membership upgrade
        /// </summary>
        /// <param name="Product">A product object for a membership upgrade</param>
        /// <returns>true if successfuly executed</returns>
        public bool ExecuteRule(Product product)
        {
           return EmailOwner(product);
        }
    }
}
