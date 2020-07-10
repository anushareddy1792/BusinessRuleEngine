using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Common
{
    /// <summary>
    /// Implements the common logic for generating packing slip
    /// </summary>
    public abstract class PackingSlip
    {
        protected List<Slip> Items { get; set; }
        protected IGenerator _generator { get; set; }

        /// <summary>
        /// Creates the slip from product details to generate the slip
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public bool GernerateSlip(Product product)
        {
            if (Items == null)
            {
                Items = new List<Slip>();
            }
            AddDetails(product);
            _generator.GeneratePackingSlip(Items);
            return true;
        }

        private void AddDetails(Product product)
        {

            Slip myItem = new Slip()
            {
                Message = $"A {product.Type.ToString()} {product.Name} is added",
                Cost = product.Cost
            };
            Items.Add(myItem);
        }


    }
}

