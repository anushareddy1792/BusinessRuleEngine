using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Interfaces
{
    /// <summary>
    /// Interface for modifying packing slip
    /// </summary>
    interface IPackingSlipAction
    {
        bool AddFreeItemToSlip();
    }
}
