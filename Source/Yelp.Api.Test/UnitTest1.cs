﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace Yelp.Api.Test
{
    [TestClass]
    public class UnitTest1
    {
        #region Variables

        private const string APP_ID = "39ukJIrbqD1Pk5V16B5weA";
        private const string APP_SECRET = "pDgLtCkYCRAnTpI9TP15xRMV4yeX75UMud05z7Cksm0KuCpw5qpQLMfVWzmOSBKC";

        private Client _client;

        #endregion

        #region Constructors

        public UnitTest1()
        {
            _client = new Client(APP_ID, APP_SECRET);
        }

        #endregion

        [TestMethod]
        public void TestAuthToken()
        {
            var response = _client.GetTokenAsync(CancellationToken.None).Result;

            Assert.AreNotSame(null, response);
            Assert.AreSame(null, response?.Error);
        }

        [TestMethod]
        public void TestSearch()
        {
            var response = _client.SearchBusinessesAsync("cupcakes", 37.786882, -122.399972, CancellationToken.None).Result;

            Assert.AreNotSame(null, response);
            //Assert.AreSame(null, response?.Error);
        }

        [TestMethod]
        public void TestAutocomplete()
        {
            var response = _client.AutocompleteAsync("mcdonald", 37.786882, -122.399972, CancellationToken.None).Result;

            Assert.AreNotSame(null, response);
            //Assert.AreSame(null, response?.Error);
        }

        [TestMethod]
        public void TestGetBusiness()
        {
            var response = _client.GetBusinessAsync("north-india-restaurant-san-francisco", CancellationToken.None).Result;

            Assert.AreNotSame(null, response);
            //Assert.AreSame(null, response?.Error);
        }        
    }
}