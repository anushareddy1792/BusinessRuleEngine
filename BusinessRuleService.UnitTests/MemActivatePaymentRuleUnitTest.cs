using BusinessRuleService.Books;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Membership;
using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class MemActivatePaymentRuleUnitTest
    {
        IPaymentRule objUnderTest = new MemershipActivatePaymentRule();

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
                Type = ProductType.MembershipActivate,
                Cost = 2000,
                Id = 3
               

            };
        }
    }
}
