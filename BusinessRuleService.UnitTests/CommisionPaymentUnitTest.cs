using BusinessRuleService.Common;
using BusinessRuleService.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace BusinessRuleService.UnitTests
{
   public  class CommisionPaymentUnitTest
    {
        ICommision objUnderTest = new CommissionPaymentToAgent();

        [Fact]
        public void TestGenerator()
        {
          
            var result = objUnderTest.PayCommission();
            Assert.True(result);
        }

    }
}
