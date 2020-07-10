using BusinessRuleService.Common;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Videos
{
    /// <summary>
    /// Implements rules for a video.
    /// </summary>
   public class VideoPaymentRule : PackingSlip, IPackingSlipAction, IPaymentRule
    {

        private const string V_LEARNING_TO_SKI = "Learning to Ski";

        /// <summary>
        /// Modified packing slip to add free item
        /// </summary>
        /// <returns></returns>
        public bool AddFreeItemToSlip()
        {
            throw new NotImplementedException();
        }

        public bool ExecuteRule(Product product)
        {
            var isSlipModified = false;
            if (product.Name == V_LEARNING_TO_SKI)
            {
                isSlipModified= AddFreeItemToSlip();
            }
            _generator = new OriginalPackingSlipGenerator();
            var isSlipGenerated=GernerateSlip(product);
            return (isSlipModified & isSlipGenerated);
        }

    }
}
