using BusinessRuleService.Common;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class DuplicatePackingSlipGeneratorUnitTest
    {
        IGenerator objUnderTest = new DuplicatePackingSlipGenerator();

        [Fact]
        public void TestGenerator()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.GeneratePackingSlip(testObj);
            Assert.True(result);
        }
        [Fact]
        public void TestGeneratorWithNoItmes()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.GeneratePackingSlip(null);
            Assert.False(result);
        }

        private List<Slip> GetTestObject()
        {
            return new List<Slip>()
            {
                new Slip(){
               Message="A book is purchased",
               Cost=200,
               AdditionalInfo=""
               }

            };
        }
    }
}
