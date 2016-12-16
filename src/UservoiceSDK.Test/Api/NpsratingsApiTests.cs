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
using UservoiceSDK.Models;

namespace UservoiceSDK.Test
{
    /// <summary>
    ///  Class for testing NpsratingsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class NpsratingsApiTests
    {
        private NpsratingsApi instance;
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
            instance = client.Npsratings;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of NpsratingsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' NpsratingsApi
            //Assert.IsInstanceOfType(typeof(NpsratingsApi), instance, "instance is a NpsratingsApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? rating = null;
            //long? linksUser = null;
            //string prompt = null;
            //string body = null;
            //DateTime? date = null;
            //List<string> includes = null;
            //var response = instance.Create(rating, linksUser, prompt, body, date, includes);
            //Assert.IsInstanceOf<NPSRatingResponse> (response, "response is NPSRatingResponse");
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
            //long? bulkPerPage = null;
            //string sort = null;
            //DateTime? periodStart = null;
            //DateTime? periodEnd = null;
            //List<int?> user = null;
            //List<int?> ticket = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, bulkPerPage, sort, periodStart, periodEnd, user, ticket, includes);
            //Assert.IsInstanceOf<NPSRatingResponsePaginated> (response, "response is NPSRatingResponsePaginated");
        }
        
        /// <summary>
        /// Test GetById
        /// </summary>
        [Test]
        public void GetByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<int?> id = null;
            //List<string> includes = null;
            //var response = instance.GetById(id, includes);
            //Assert.IsInstanceOf<NPSRatingResponse> (response, "response is NPSRatingResponse");
        }
        
    }

}
