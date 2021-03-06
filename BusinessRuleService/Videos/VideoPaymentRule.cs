﻿using BusinessRuleService.Common;
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

            Slip freeItem = new Slip()
            {
                Cost = 0,
                Message = $"A Free First Aid Video  is added for {V_LEARNING_TO_SKI}.",
                AdditionalInfo = "(As a result of court decision in 1997)"
            };
            Items = new List<Slip>();
            Items.Add(freeItem);
            return true;


        }
        /// <summary>
        /// Executes payment rule for video
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>

        public bool ExecuteRule(Product product)
        {
            var isSlipModified = false;
            var isSlipModificationRequired = false;
            if (product.Name == V_LEARNING_TO_SKI)
            {
                isSlipModificationRequired = true;
                isSlipModified = AddFreeItemToSlip();
            }
            _generator = new OriginalPackingSlipGenerator();
            var isSlipGenerated = GernerateSlip(product);
            var isRuleeXecuted = isSlipModificationRequired ? isSlipModified : true;
            return (isRuleeXecuted & isSlipGenerated);
        }

    }
}
