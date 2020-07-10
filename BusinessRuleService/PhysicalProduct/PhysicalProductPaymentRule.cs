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
        ICommision commision = new CommissionPaymentToAgent();
        /// <summary>
        /// Executes rules for a physical product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public bool ExecuteRule(Product product)
        {
            _generator = new OriginalPackingSlipGenerator();
           var isGenerated= GernerateSlip(product);
            var isCommissionpaid = commision.PayCommission();
            return (isGenerated && isCommissionpaid);

        }
    }
}
