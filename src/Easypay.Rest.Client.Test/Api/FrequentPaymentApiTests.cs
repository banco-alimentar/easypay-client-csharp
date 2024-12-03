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
    ///  Class for testing FrequentPaymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class FrequentPaymentApiTests : IDisposable
    {
        private FrequentPaymentApi instance;

        public FrequentPaymentApiTests()
        {
            instance = new FrequentPaymentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of FrequentPaymentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' FrequentPaymentApi
            //Assert.IsType<FrequentPaymentApi>(instance);
        }

        /// <summary>
        /// Test FrequentAuthorisation
        /// </summary>
        [Fact]
        public void FrequentAuthorisationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //FrequentAuthorisationRequest frequentAuthorisationRequest = null;
            //var response = instance.FrequentAuthorisation(id, frequentAuthorisationRequest);
            //Assert.IsType<FrequentAuthorisation201Response>(response);
        }

        /// <summary>
        /// Test FrequentGet
        /// </summary>
        [Fact]
        public void FrequentGetTest()
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
            //var response = instance.FrequentGet(page, recordsPerPage, expirationTime, method, customer, id, key, createdAt);
            //Assert.IsType<FrequentGet200Response>(response);
        }

        /// <summary>
        /// Test FrequentIdDelete
        /// </summary>
        [Fact]
        public void FrequentIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //instance.FrequentIdDelete(id);
        }

        /// <summary>
        /// Test FrequentIdGet
        /// </summary>
        [Fact]
        public void FrequentIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //var response = instance.FrequentIdGet(id);
            //Assert.IsType<Frequent>(response);
        }

        /// <summary>
        /// Test FrequentIdPatch
        /// </summary>
        [Fact]
        public void FrequentIdPatchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid id = null;
            //FrequentIdPatchRequest frequentIdPatchRequest = null;
            //var response = instance.FrequentIdPatch(id, frequentIdPatchRequest);
            //Assert.IsType<FrequentIdPatch200Response>(response);
        }

        /// <summary>
        /// Test FrequentPost
        /// </summary>
        [Fact]
        public void FrequentPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //FrequentPostRequest? frequentPostRequest = null;
            //var response = instance.FrequentPost(frequentPostRequest);
            //Assert.IsType<FrequentPost201Response>(response);
        }
    }
}