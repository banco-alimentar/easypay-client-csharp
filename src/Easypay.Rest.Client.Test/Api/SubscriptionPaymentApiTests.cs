/*
 * Easypay Payments API
 *
 * <a href='https://www.easypay.pt/en/legal-terms-and-conditions/' class='item'>Terms conditions and legal terms</a><br><a href='https://www.easypay.pt/en/privacy-and-data-protection-policy/' class='item'>Privacy Policy</a>
 *
 * The version of the OpenAPI document: 2.0
 * Contact: tec@easypay.pt
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Easypay.Rest.Client.Client;
using Easypay.Rest.Client.Api;
// uncomment below to import models
//using Easypay.Rest.Client.Model;

namespace Easypay.Rest.Client.Test.Api
{
    /// <summary>
    ///  Class for testing SubscriptionPaymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SubscriptionPaymentApiTests : IDisposable
    {
        private SubscriptionPaymentApi instance;

        public SubscriptionPaymentApiTests()
        {
            instance = new SubscriptionPaymentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SubscriptionPaymentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SubscriptionPaymentApi
            //Assert.IsType<SubscriptionPaymentApi>(instance);
        }

        /// <summary>
        /// Test SubscriptionGet
        /// </summary>
        [Fact]
        public void SubscriptionGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //decimal? page = null;
            //decimal? recordsPerPage = null;
            //string? expirationTime = null;
            //string? method = null;
            //string? customer = null;
            //string? id = null;
            //string? key = null;
            //string? createdAt = null;
            //var response = instance.SubscriptionGet(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
            //Assert.IsType<SubscriptionGet200Response>(response);
        }

        /// <summary>
        /// Test SubscriptionIdDelete
        /// </summary>
        [Fact]
        public void SubscriptionIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.SubscriptionIdDelete(id);
        }

        /// <summary>
        /// Test SubscriptionIdGet
        /// </summary>
        [Fact]
        public void SubscriptionIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.SubscriptionIdGet(id);
            //Assert.IsType<SubscriptionIdGet200Response>(response);
        }

        /// <summary>
        /// Test SubscriptionIdPatch
        /// </summary>
        [Fact]
        public void SubscriptionIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //SubscriptionIdPatchRequest body = null;
            //var response = instance.SubscriptionIdPatch(id, body);
            //Assert.IsType<SubscriptionIdPatch200Response>(response);
        }

        /// <summary>
        /// Test SubscriptionPost
        /// </summary>
        [Fact]
        public void SubscriptionPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //SubscriptionPostRequest body = null;
            //var response = instance.SubscriptionPost(body);
            //Assert.IsType<SubscriptionPost201Response>(response);
        }
    }
}
