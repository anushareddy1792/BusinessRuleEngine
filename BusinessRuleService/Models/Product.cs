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
        public int Id { get; set; }
        public ProductType Type { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
    }
}
