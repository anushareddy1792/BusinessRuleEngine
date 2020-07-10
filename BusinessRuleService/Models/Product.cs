using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Models
{
    /// <summary>
    /// Product class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Id 
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Product type
        /// </summary>
        public ProductType Type { get; set; }

        /// <summary>
        /// Name of the prodcut
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Cost of the product
        /// </summary>
        public int Cost { get; set; }
    }
}
