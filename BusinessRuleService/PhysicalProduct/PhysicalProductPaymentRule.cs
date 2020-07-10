using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.PhysicalProduct
{
    /// <summary>
    /// Implements rules for a physical product.
    /// </summary>
    public class PhysicalProductPaymentRule : IPaymentRule
    {
        /// <summary>
        /// Executes rules for a physical product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public bool ExecuteRule(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
