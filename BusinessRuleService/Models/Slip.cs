using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Models
{
    /// <summary>
    /// PackingSlip class
    /// </summary>
    public class Slip
    {
        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// cost of the product
        /// </summary>
        public int Cost { get; set; }

        /// <summary>
        /// Additioanl info about the product
        /// </summary>
        public string AdditionalInfo { get; set; }
    }
}