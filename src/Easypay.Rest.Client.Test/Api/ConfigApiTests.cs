/*
 * Easypay API
 *
 * EasyPay - API
 *
 * The version of the OpenAPI document: 2.0.2
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
    ///  Class for testing ConfigApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ConfigApiTests : IDisposable
    {
        private ConfigApi instance;

        public ConfigApiTests()
        {
            instance = new ConfigApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ConfigApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ConfigApi
            //Assert.IsType<ConfigApi>(instance);
        }

        /// <summary>
        /// Test GetAccountConfig
        /// </summary>
        [Fact]
        public void GetAccountConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetAccountConfig();
            //Assert.IsType<ConfigDetailsResponse>(response);
        }

        /// <summary>
        /// Test SetAccountConfig
        /// </summary>
        [Fact]
        public void SetAccountConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AccountConfigRequest accountConfigRequest = null;
            //var response = instance.SetAccountConfig(accountConfigRequest);
            //Assert.IsType<ConfigDetailsResponse>(response);
        }
    }
}