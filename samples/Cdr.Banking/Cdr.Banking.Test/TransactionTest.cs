﻿using Cdr.Banking.Api;
using Cdr.Banking.Common.Agents;
using Cdr.Banking.Common.Entities;
using NUnit.Framework;
using System;
using System.Linq;
using System.Net;
using UnitTestEx;
using UnitTestEx.Expectations;
using UnitTestEx.NUnit;

namespace Cdr.Banking.Test
{
    [TestFixture]
    public class TransactionTest : UsingApiTester<Startup>
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            ApiTester.UseUser("jessica");
            Assert.IsTrue(TestSetUp.Default.SetUp());
        }

        [Test]
        public void B110_GetTransactions_FromDate()
        {
            var v = Agent<TransactionAgent, TransactionCollectionResult>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01) })).Value;

            Assert.IsNotNull(v);
            Assert.IsNotNull(v!.Items);
            Assert.AreEqual(3, v.Items.Count);
            Assert.AreEqual(new string[] { "X0007", "X0003", "X0001" }, v.Items.Select(x => x.Id).ToArray());
        }

        [Test]
        public void B120_GetTransactions_DateRange()
        {
            var v = Agent<TransactionAgent, TransactionCollectionResult>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01), ToDate = new DateTime(2019, 07, 01) })).Value;

            Assert.IsNotNull(v);
            Assert.IsNotNull(v!.Items);
            Assert.AreEqual(2, v.Items.Count);
            Assert.AreEqual(new string[] { "X0003", "X0001" }, v.Items.Select(x => x.Id).ToArray());
        }

        [Test]
        public void B130_GetTransactions_MinAmount()
        {
            var v = Agent<TransactionAgent, TransactionCollectionResult>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01), MinAmount = 0 })).Value;

            Assert.IsNotNull(v);
            Assert.IsNotNull(v!.Items);
            Assert.AreEqual(1, v.Items.Count);
            Assert.AreEqual(new string[] { "X0003" }, v.Items.Select(x => x.Id).ToArray());
        }

        [Test]
        public void B140_GetTransactions_MaxAmount()
        {
            var v = Agent<TransactionAgent, TransactionCollectionResult>()
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01), MaxAmount = 0 })).Value;

            Assert.IsNotNull(v);
            Assert.IsNotNull(v!.Items);
            Assert.AreEqual(2, v.Items.Count);
            Assert.AreEqual(new string[] { "X0007", "X0001" }, v.Items.Select(x => x.Id).ToArray());
        }

        [Test]
        public void B150_GetTransactions_Text()
        {
            var v = Agent<TransactionAgent, TransactionCollectionResult>()
                .WithUser("jenny")
                .ExpectStatusCode(HttpStatusCode.OK)
                .Run(a => a.GetTransactionsAsync("23456789", new TransactionArgs { FromDate = new DateTime(2019, 04, 01), Text = "usb" })).Value;

            Assert.IsNotNull(v);
            Assert.IsNotNull(v!.Items);
            Assert.AreEqual(2, v.Items.Count);
            Assert.AreEqual(new string[] { "X0006", "X0002" }, v.Items.Select(x => x.Id).ToArray());
        }

        [Test]
        public void B160_GetTransactions_AccountAuth()
        {
            Agent<TransactionAgent, TransactionCollectionResult>()
                .WithUser("jenny")
                .ExpectStatusCode(HttpStatusCode.Forbidden)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01) }));
        }

        [Test]
        public void B170_GetTransactions_Auth()
        {
            Agent<TransactionAgent, TransactionCollectionResult>()
                .WithUser("john")
                .ExpectStatusCode(HttpStatusCode.Unauthorized)
                .Run(a => a.GetTransactionsAsync("12345678", new TransactionArgs { FromDate = new DateTime(2019, 04, 01) }));
        }
    }
}