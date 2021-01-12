// <copyright file="CabInvoiceGeneratorTest.cs" company="BridgeLabz">
// Copyright (c) BridgeLabz. All rights reserved.
// </copyright>
using CabInvoiceGeneratorApp.CabInvoiceGenerator;
using NUnit.Framework;

namespace Tests
{
    public class CabInvoiceGeneratorTest
    {
        private CabInvoiceGenerator cabInvoiceGenerator;
        [SetUp]
        public void Setup()
        {

            this.cabInvoiceGenerator = new CabInvoiceGenerator();
        }

        [Test]
        public void GivenDistanceAndTime_WhenProper_ShouldReturnTotalFare()
        {
            double totalFare = this.cabInvoiceGenerator.CalculateFare(3.0, 5.0);
            Assert.AreEqual(35.0, totalFare);
        }
    }
}