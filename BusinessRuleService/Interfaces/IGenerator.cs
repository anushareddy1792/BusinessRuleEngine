using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessRuleService.Interfaces
{
   
        public interface IGenerator
        {
            bool GeneratePackingSlip(List<PackingSlip> items);
        }
 }