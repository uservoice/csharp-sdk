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
    ///  Class for testing SuggestionactivityentriesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SuggestionactivityentriesApiTests
    {
        private SuggestionactivityentriesApi instance;
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
            instance = client.Suggestionactivityentries;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SuggestionactivityentriesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SuggestionactivityentriesApi
            //Assert.IsInstanceOfType(typeof(SuggestionactivityentriesApi), instance, "instance is a SuggestionactivityentriesApi");
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
            //List<int?> forum = null;
            //List<int?> user = null;
            //List<int?> suggestion = null;
            //List<string> kind = null;
            //List<string> state = null;
            //bool? spam = null;
            //bool? needsReview = null;
            //DateTime? periodStart = null;
            //DateTime? periodEnd = null;
            //List<int?> creator = null;
            //bool? categoryNone = null;
            //List<int?> category = null;
            //bool? statusNone = null;
            //List<int?> status = null;
            //List<int?> label = null;
            //bool? hasResponse = null;
            //bool? hasSmartvoteScore = null;
            //DateTime? noEngagementSince = null;
            //DateTime? engagementSince = null;
            //List<int?> uncategorizedInForum = null;
            //long? externalAccount = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, bulkPerPage, sort, forum, user, suggestion, kind, state, spam, needsReview, periodStart, periodEnd, creator, categoryNone, category, statusNone, status, label, hasResponse, hasSmartvoteScore, noEngagementSince, engagementSince, uncategorizedInForum, externalAccount, includes);
            //Assert.IsInstanceOf<SuggestionActivityEntryResponsePaginated> (response, "response is SuggestionActivityEntryResponsePaginated");
        }
        
    }

}
