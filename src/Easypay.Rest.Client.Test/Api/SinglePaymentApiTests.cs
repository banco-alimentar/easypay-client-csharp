/*
 * Easypay API
 *
 * EasyPay - API allows you to query payment meta-data, receive payment notifications and generate payment references. Two distinct environments - [Sandbox environment](https://api.test.easypay.pt/docs) and [Production environment](https://api.prod.easypay.pt/docs).
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
    ///  Class for testing SinglePaymentApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SinglePaymentApiTests : IDisposable
    {
        private SinglePaymentApi instance;

        public SinglePaymentApiTests()
        {
            instance = new SinglePaymentApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SinglePaymentApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SinglePaymentApi
            //Assert.IsType<SinglePaymentApi>(instance);
        }

        /// <summary>
        /// Test CreateSinglePayment
        /// </summary>
        [Fact]
        public void CreateSinglePaymentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PaymentSingleRequestBody paymentSingleRequestBody = null;
            //var response = instance.CreateSinglePayment(paymentSingleRequestBody);
            //Assert.IsType<StatusDetails>(response);
        }

        /// <summary>
        /// Test ListSinglePayments
        /// </summary>
        [Fact]
        public void ListSinglePaymentsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? recordsPerPage = null;
            //string type = null;
            //string expirationTime = null;
            //PaymentSingleMethodAvailable? method = null;
            //string customer = null;
            //string id = null;
            //string key = null;
            //double? value = null;
            //string createdAt = null;
            //var response = instance.ListSinglePayments(page, recordsPerPage, type, expirationTime, method, customer, id, key, value, createdAt);
            //Assert.IsType<PropertiesHasListMetaData>(response);
        }
    }
}
