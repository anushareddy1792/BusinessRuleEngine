using BusinessRuleService.Common;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Books
{
    /// <summary>
    /// Implements payment rules for books
    /// </summary>
    public class BookPaymentRule :PackingSlip, IPaymentRule
    {

        /// <summary>
        /// Executes rules for  a book
        /// </summary>
        /// <param name="Product">A product object for a book</param>
        /// <returns>true if successfuly executed</returns>
        public bool ExecuteRule(Product product)
        {
          
            _generator = new DuplicatePackingSlipGenerator();
            var  isGenerated= GernerateSlip(product);
            return isGenerated;
        }
    }
}
