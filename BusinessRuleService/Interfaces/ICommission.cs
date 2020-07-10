using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Interfaces
{
    /// <summary>
    /// Interface for commmission
    /// </summary>
    public interface ICommision
    {
        /// <summary>
        /// pays commission to agent
        /// </summary>
        /// <returns></returns>
        bool PayCommission();
    }
}
