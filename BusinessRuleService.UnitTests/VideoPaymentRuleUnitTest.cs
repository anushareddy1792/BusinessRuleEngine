using BusinessRuleService.Books;
using BusinessRuleService.Interfaces;
using BusinessRuleService.Membership;
using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using BusinessRuleService.Videos;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class VideoPaymentRuleUnitTest
    {
        IPaymentRule objUnderTest = new VideoPaymentRule();
        IPackingSlipAction packingSlipActionForTest = new VideoPaymentRule();

        [Fact]
        public void TestRule()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(testObj);
            Assert.True(result);
        }
        [Fact]
        public void TestAddFreeItemToSlip()
        {
            var result = packingSlipActionForTest.AddFreeItemToSlip();
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
