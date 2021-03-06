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
    ///  Class for testing SuggestionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class SuggestionsApiTests
    {
        private SuggestionsApi instance;
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
            instance = client.Suggestions;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SuggestionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' SuggestionsApi
            //Assert.IsInstanceOfType(typeof(SuggestionsApi), instance, "instance is a SuggestionsApi");
        }

        
        /// <summary>
        /// Test ApproveById
        /// </summary>
        [Test]
        public void ApproveByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.ApproveById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test ConvertToTicketById
        /// </summary>
        [Test]
        public void ConvertToTicketByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.ConvertToTicketById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string title = null;
            //long? linksForum = null;
            //string body = null;
            //string bodyMimeType = null;
            //string attachmentTokens = null;
            //long? linksCategory = null;
            //long? linksStatus = null;
            //List<string> includes = null;
            //var response = instance.Create(title, linksForum, body, bodyMimeType, attachmentTokens, linksCategory, linksStatus, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test DeleteById
        /// </summary>
        [Test]
        public void DeleteByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.DeleteById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
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
            //List<int?> forum = null;
            //List<int?> creator = null;
            //List<int?> uncategorizedInForum = null;
            //bool? categoryNone = null;
            //List<int?> category = null;
            //bool? statusNone = null;
            //List<int?> status = null;
            //List<string> state = null;
            //List<int?> label = null;
            //List<int?> supporter = null;
            //List<int?> externalAccount = null;
            //List<int?> feature = null;
            //bool? hasResponse = null;
            //bool? hasSmartvoteScore = null;
            //DateTime? noEngagementSince = null;
            //DateTime? engagementSince = null;
            //DateTime? periodStart = null;
            //DateTime? periodEnd = null;
            //string q = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, sort, forum, creator, uncategorizedInForum, categoryNone, category, statusNone, status, state, label, supporter, externalAccount, feature, hasResponse, hasSmartvoteScore, noEngagementSince, engagementSince, periodStart, periodEnd, q, includes);
            //Assert.IsInstanceOf<SuggestionResponsePaginated> (response, "response is SuggestionResponsePaginated");
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
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test Import
        /// </summary>
        [Test]
        public void ImportTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string title = null;
            //long? linksForum = null;
            //string body = null;
            //string bodyMimeType = null;
            //string userName = null;
            //string userEmail = null;
            //string state = null;
            //string attachmentTokens = null;
            //long? linksUser = null;
            //long? linksCategory = null;
            //long? linksStatus = null;
            //List<string> includes = null;
            //var response = instance.Import(title, linksForum, body, bodyMimeType, userName, userEmail, state, attachmentTokens, linksUser, linksCategory, linksStatus, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test PublishById
        /// </summary>
        [Test]
        public void PublishByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.PublishById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test SpamById
        /// </summary>
        [Test]
        public void SpamByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.SpamById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test UnremoveById
        /// </summary>
        [Test]
        public void UnremoveByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.UnremoveById(id, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
        /// <summary>
        /// Test UpdateById
        /// </summary>
        [Test]
        public void UpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string title = null;
            //string body = null;
            //string bodyMimeType = null;
            //string attachmentTokens = null;
            //long? linksForum = null;
            //long? linksCategory = null;
            //long? linksStatus = null;
            //List<string> includes = null;
            //var response = instance.UpdateById(id, title, body, bodyMimeType, attachmentTokens, linksForum, linksCategory, linksStatus, includes);
            //Assert.IsInstanceOf<SuggestionResponse> (response, "response is SuggestionResponse");
        }
        
    }

}
