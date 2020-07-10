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
    public class VideoPaymentRule : IPaymentRule
    {
        /// <summary>
        /// Executes rules for a video
        /// </summary>
        /// <param name="Product"></param>
        /// <returns></returns>
        public bool ExecuteRule(Product Product)
        {
            throw new NotImplementedException();
        }
    }
}
