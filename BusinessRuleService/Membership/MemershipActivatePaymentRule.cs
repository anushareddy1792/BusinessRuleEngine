using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Membership
{
    /// <summary>
    /// Implements payment rules for memebrship activation
    /// </summary>
    public class MemershipActivatePaymentRule :Membership, IPaymentRule
    {


        /// <summary>
        /// Executes rules for  a membership activation
        /// </summary>
        /// <param name="Product">A product object for a membership activation</param>
        /// <returns>true if successfuly executed</returns>
        public bool ExecuteRule(Product product)
        {
            return EmailOwner(product);
        }
    }
}
