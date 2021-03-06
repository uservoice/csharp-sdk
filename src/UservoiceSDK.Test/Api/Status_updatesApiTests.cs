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
    ///  Class for testing Status_updatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class Status_updatesApiTests
    {
        private Status_updatesApi instance;
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
            instance = client.Status_updates;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Status_updatesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' Status_updatesApi
            //Assert.IsInstanceOfType(typeof(Status_updatesApi), instance, "instance is a Status_updatesApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //long? linksSuggestion = null;
            //bool? notifySupporters = null;
            //string notificationEmailAddress = null;
            //long? linksStatus = null;
            //List<string> includes = null;
            //var response = instance.Create(body, linksSuggestion, notifySupporters, notificationEmailAddress, linksStatus, includes);
            //Assert.IsInstanceOf<StatusUpdateResponse> (response, "response is StatusUpdateResponse");
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
            //Assert.IsInstanceOf<StatusUpdateResponse> (response, "response is StatusUpdateResponse");
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
            //List<int?> suggestion = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, sort, suggestion, includes);
            //Assert.IsInstanceOf<StatusUpdateResponsePaginated> (response, "response is StatusUpdateResponsePaginated");
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
            //Assert.IsInstanceOf<StatusUpdateResponse> (response, "response is StatusUpdateResponse");
        }
        
        /// <summary>
        /// Test UpdateById
        /// </summary>
        [Test]
        public void UpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string body = null;
            //List<string> includes = null;
            //var response = instance.UpdateById(id, body, includes);
            //Assert.IsInstanceOf<StatusUpdateResponse> (response, "response is StatusUpdateResponse");
        }
        
    }

}
