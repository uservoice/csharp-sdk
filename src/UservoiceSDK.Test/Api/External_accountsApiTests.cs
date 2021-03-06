/* 
 * UserVoice API
 *
 * A RESTful API to interface with UserVoice's feedback system. Online documentation available here: https://developer.uservoice.com/docs/api/v2/reference/.
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

using UserVoiceSdk.Client;
using UserVoiceSdk.Api;
using UserVoiceSdk.Models;

namespace UserVoiceSdk.Test
{
    /// <summary>
    ///  Class for testing External_accountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class External_accountsApiTests
    {
        private External_accountsApi instance;
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
            instance = client.External_accounts;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of External_accountsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' External_accountsApi
            //Assert.IsInstanceOfType(typeof(External_accountsApi), instance, "instance is a External_accountsApi");
        }

        
        /// <summary>
        /// Test BulkDelete
        /// </summary>
        [Test]
        public void BulkDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> ids = null;
            //var response = instance.BulkDelete(ids);
            //Assert.IsInstanceOf<ExternalAccountResponse> (response, "response is ExternalAccountResponse");
        }
        
        /// <summary>
        /// Test BulkDeleteByExternalId
        /// </summary>
        [Test]
        public void BulkDeleteByExternalIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> externalIds = null;
            //var response = instance.BulkDeleteByExternalId(externalIds);
            //Assert.IsInstanceOf<ExternalAccountResponse> (response, "response is ExternalAccountResponse");
        }
        
        /// <summary>
        /// Test Get
        /// </summary>
        [Test]
        public void GetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? page = null;
            //long? perPage = null;
            //string sort = null;
            //List<string> externalId = null;
            //List<int?> suggestion = null;
            //List<int?> feature = null;
            //string q = null;
            //var response = instance.Get(page, perPage, sort, externalId, suggestion, feature, q);
            //Assert.IsInstanceOf<ExternalAccountResponsePaginated> (response, "response is ExternalAccountResponsePaginated");
        }
        
        /// <summary>
        /// Test GetById
        /// </summary>
        [Test]
        public void GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> id = null;
            //var response = instance.GetById(id);
            //Assert.IsInstanceOf<ExternalAccountResponse> (response, "response is ExternalAccountResponse");
        }
        
        /// <summary>
        /// Test Import
        /// </summary>
        [Test]
        public void ImportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> accounts = null;
            //string accountsIExternalId = null;
            //string accountsIName = null;
            //string accountsIPlan = null;
            //long? accountsIMrrCents = null;
            //long? accountsILtvCents = null;
            //DateTime? accountsIExternalCreatedAt = null;
            //string accountsICustomFields = null;
            //var response = instance.Import(accounts, accountsIExternalId, accountsIName, accountsIPlan, accountsIMrrCents, accountsILtvCents, accountsIExternalCreatedAt, accountsICustomFields);
            //Assert.IsInstanceOf<ExternalAccountResponse> (response, "response is ExternalAccountResponse");
        }
        
    }

}
