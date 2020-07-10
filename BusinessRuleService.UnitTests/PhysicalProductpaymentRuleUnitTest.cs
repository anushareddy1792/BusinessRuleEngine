using BusinessRuleService.Books;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Membership;
using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using BusinessRuleService.PhysicalProduct;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class PhysicalProductpaymentRuleUnitTest
    {
        IPaymentRule objUnderTest = new PhysicalProductPaymentRule();

        [Fact]
        public void TestRule()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(testObj);
            Assert.True(result);
        }

        private Product GetTestObject()
        {
            return new Product()
            {
                Type = ProductType.PhysicalProduct,
                Cost = 500,
                Id = 1
            };
        }
    }
}
