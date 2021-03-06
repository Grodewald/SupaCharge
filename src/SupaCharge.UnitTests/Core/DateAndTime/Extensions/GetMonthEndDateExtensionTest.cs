﻿using System;
using NUnit.Framework;
using SupaCharge.Core.DateAndTime.Extensions;
using SupaCharge.Testing;

namespace SupaCharge.UnitTests.Core.DateAndTime.Extensions {
  [TestFixture]
  public class GetMonthEndDateExtensionTest : BaseTestCase {
    [TestCase("03/08/2012", "03/31/2012")]
    [TestCase("03/31/2012", "03/31/2012")]
    [TestCase("02/28/2012", "02/29/2012")]
    [TestCase("02/27/2012", "02/29/2012")]
    [TestCase("02/27/2011", "02/28/2011")]
    [TestCase("02/28/2011", "02/28/2011")]
    [TestCase("12/31/2011", "12/31/2011")]
    [TestCase("01/01/2011", "01/31/2011")]
    public void TestGetMonthEndDate(string now, string expected) {
      Assert.That(DateTime.Parse(now).GetMonthEndDate(), Is.EqualTo(DateTime.Parse(expected)));
    }
  }
}