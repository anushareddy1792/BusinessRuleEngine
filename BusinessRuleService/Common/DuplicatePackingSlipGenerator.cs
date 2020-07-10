using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace BusinessRuleService.Common
{
   /// <summary>
   /// implemeting duplicate Packing slip using proxy pattern.
   /// </summary>
    public class DuplicatePackingSlipGenerator : IGenerator
    {
        private IGenerator _generator;
        public bool GeneratePackingSlip(List<Slip> items)
        {

            _generator = new OriginalPackingSlipGenerator();
            Console.WriteLine("This is from duplicate packing slip.");
            return _generator.GeneratePackingSlip(items);
           

        }
    }
}
