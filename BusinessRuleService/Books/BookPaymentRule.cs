﻿using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Books
{
    /// <summary>
    /// Implements payment rules for books
    /// </summary>
    public class BookPaymentRule : IPaymentRule
    {

        /// <summary>
        /// Executes rules for  a book
        /// </summary>
        /// <param name="Product">A product object for a book</param>
        /// <returns>true if successfuly executed</returns>
        public bool ExecuteRule(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
