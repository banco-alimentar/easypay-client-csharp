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
    ///  Class for testing ReportsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ReportsApiTests : IDisposable
    {
        private ReportsApi instance;

        public ReportsApiTests()
        {
            instance = new ReportsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ReportsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ReportsApi
            //Assert.IsType<ReportsApi>(instance);
        }

        /// <summary>
        /// Test ReportLedgerGet
        /// </summary>
        [Fact]
        public void ReportLedgerGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? cursor = null;
            //decimal? limit = null;
            //string? createdAt = null;
            //string? transactionType = null;
            //string? transferBatch = null;
            //var response = instance.ReportLedgerGet(cursor, limit, createdAt, transactionType, transferBatch);
            //Assert.IsType<InlineObject2>(response);
        }

        /// <summary>
        /// Test ReportTransactionsGet
        /// </summary>
        [Fact]
        public void ReportTransactionsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? startDate = null;
            //string? endDate = null;
            //decimal? page = null;
            //decimal? recordsPerPage = null;
            //var response = instance.ReportTransactionsGet(startDate, endDate, page, recordsPerPage);
            //Assert.IsType<ReportTransactionsGet200Response>(response);
        }
    }
}