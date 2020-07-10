using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BusinessRuleService.Common
{
   
    public class DuplicatePackingSlipGenerator : IGenerator
    {
        private IGenerator _generator;
        public bool GeneratePackingSlip(List<Slip> items)
        {
            _generator = new OriginalPackingSlipGenerator();
            Console.WriteLine("This is from duplicate packing slip.");
            _generator.GeneratePackingSlip(items);
            return true;

        }
    }
}
