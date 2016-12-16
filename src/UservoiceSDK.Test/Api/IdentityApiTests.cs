/* 
 * UserVoice API
 *
 * No descripton provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using UservoiceSDK.Client;
using UservoiceSDK.Api;

namespace UservoiceSDK.Test
{
    /// <summary>
    ///  Class for testing IdentityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class IdentityApiTests
    {
        private IdentityApi instance;
        private ApiClient client;
        private string subdomain = ""; // TODO
        private string clientId = ""; // TODO
        private string clientSecret = ""; // TODO

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            client = new ApiClient(subdomain, clientId, clientSecret: clientSecret);
            instance = client.Identity;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IdentityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' IdentityApi
            //Assert.IsInstanceOfType(typeof(IdentityApi), instance, "instance is a IdentityApi");
        }

        
        /// <summary>
        /// Test BulkIdentify
        /// </summary>
        [Test]
        public void BulkIdentifyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> identities = null;
            //string identitiesIId = null;
            //string identitiesIEmail = null;
            //string identitiesIName = null;
            //long? identitiesICreatedAt = null;
            //string identitiesIType = null;
            //string identitiesIAccountId = null;
            //string identitiesIAccountName = null;
            //long? identitiesIAccountCreatedAt = null;
            //double? identitiesIAccountMonthlyRate = null;
            //double? identitiesIAccountLtv = null;
            //string identitiesIAccountPlan = null;
            //instance.BulkIdentify(identities, identitiesIId, identitiesIEmail, identitiesIName, identitiesICreatedAt, identitiesIType, identitiesIAccountId, identitiesIAccountName, identitiesIAccountCreatedAt, identitiesIAccountMonthlyRate, identitiesIAccountLtv, identitiesIAccountPlan);
            
        }
        
    }

}
