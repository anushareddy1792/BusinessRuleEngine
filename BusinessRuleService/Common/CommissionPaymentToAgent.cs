using BusinessRuleService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Common
{
    public class CommissionPaymentToAgent : ICommision
    {
        public bool PayCommission()
        {
            return true;

        }
    }
}
