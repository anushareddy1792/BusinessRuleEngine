﻿using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Common
{
   /// <summary>
   ///Implements generation of original packing slip
   /// </summary>
    public class OriginalPackingSlipGenerator : IGenerator
    {
        /// <summary>
        /// Generates original packing slip
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        public bool GeneratePackingSlip(List<Slip> items)
        {
            var result = false;
            if (items != null)
            {
                foreach (var item in items)
                {
                    var message = $"{ item.Message} at the cost of {item.Cost}.{item.AdditionalInfo}";
                    Console.WriteLine(message);
                    result = true;
                }
            }

            return result;

        }
    }
}
