﻿using BusinessRuleService.Interfaces;
using BusinessRuleService.Membership;
using BusinessRuleService.Models;
using BusinessRuleService.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
    public class MemUpgradePaymentRuleUnitTest
    {
        IPaymentRule objUnderTest = new MembershipUpgardePaymentRule();

        [Fact]
        public void TestRule()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(testObj);
            Assert.True(result);
        }
        [Fact]
        public void TestRuleWithNoItem()
        {
            var testObj = GetTestObject();
            var result = objUnderTest.ExecuteRule(null);
            Assert.False(result);
        }

        private Product GetTestObject()
        {
            return new Product()
            {
                Type = ProductType.MembershipUpgrade,
                Cost = 1500,
                Id = 4
            };
        }
    }
}
