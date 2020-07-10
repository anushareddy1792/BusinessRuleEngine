using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;

namespace BusinessRuleService.Interfaces
{
    /// <summary>
    /// Interface for payment rules
    /// </summary>
    public interface IPaymentRule
    {
        /// <summary>
        /// Executes rules for a given product
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        bool ExecuteRule(Product product);
    }
}
