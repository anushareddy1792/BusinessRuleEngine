using BusinessRuleService.Common;
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
    public class PhysicalProductPaymentRule : PackingSlip,IPaymentRule
    {
        /// <summary>
        /// Executes rules for a physical product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public bool ExecuteRule(Product product)
        {
            _generator = new OriginalPackingSlipGenerator();
           var isGenerated= GernerateSlip(product);
            return isGenerated;

        }
    }
}
