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
        /// <summary>
        /// Adds free item to slip
        /// </summary>
        /// <returns></returns>
        bool AddFreeItemToSlip();
    }
}
