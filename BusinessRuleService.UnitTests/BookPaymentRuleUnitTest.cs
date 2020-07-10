using BusinessRuleService.Books;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class BookPaymentRuleUnitTest
    {
        IPaymentRule objUnderTest = new BookPaymentRule();

        [Fact]
        public void TestRule()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(testObj);
            Assert.True(result);
        }

        [Fact]
        public void TestRulewithNoItems()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(null);
            Assert.False(result);
        }

        private Product GetTestObject()
        {
            return new Product()
            {
                Type = ProductType.Book,
                Cost = 1500,
                Id = 1,
                Name="Theory of Everything"

            };
        }
    }
}
