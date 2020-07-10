using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Interfaces
{
    /// <summary>
    /// Interface for modifying packing slip
    /// </summary>
    public interface IPackingSlipAction
    {
        bool AddFreeItemToSlip();
    }
}
