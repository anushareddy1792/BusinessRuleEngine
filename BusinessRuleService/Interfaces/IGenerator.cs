using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Interfaces
{
    /// <summary>
    /// Interafce for packing slip generator
    /// </summary>
    public interface IGenerator
    {
        /// <summary>
        /// geberates packing slip
        /// </summary>
        /// <param name="items"></param>
        /// <returns></returns>
        bool GeneratePackingSlip(List<Slip> items);
    }
}