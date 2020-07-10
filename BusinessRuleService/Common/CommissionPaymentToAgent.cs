using BusinessRuleService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Common
{
    /// <summary>
    ///Implements  Commission Payment to Agent
    /// </summary>
    public class CommissionPaymentToAgent : ICommision
    {
        /// <summary>
        /// Pays commission to agent
        /// </summary>
        /// <returns></returns>
        public bool PayCommission()
        {
            Console.WriteLine("Commision paid to agent");
            return true;

        }
    }
}
