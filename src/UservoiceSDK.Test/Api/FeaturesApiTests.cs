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

using UserVoiceSdk.Client;
using UserVoiceSdk.Api;
using UserVoiceSdk.Models;

namespace UserVoiceSdk.Test
{
    /// <summary>
    ///  Class for testing FeaturesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FeaturesApiTests
    {
        private FeaturesApi instance;
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
            instance = client.Features;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FeaturesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FeaturesApi
            //Assert.IsInstanceOfType(typeof(FeaturesApi), instance, "instance is a FeaturesApi");
        }

        
        /// <summary>
        /// Test Create
        /// </summary>
        [Test]
        public void CreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string description = null;
            //string  = null;
            //List<string> includes = null;
            //var response = instance.Create(name, description, , includes);
            //Assert.IsInstanceOf<FeatureResponse> (response, "response is FeatureResponse");
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
            //Assert.IsInstanceOf<FeatureResponse> (response, "response is FeatureResponse");
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
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, sort, includes);
            //Assert.IsInstanceOf<FeatureResponsePaginated> (response, "response is FeatureResponsePaginated");
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
            //Assert.IsInstanceOf<FeatureResponse> (response, "response is FeatureResponse");
        }
        
        /// <summary>
        /// Test UpdateById
        /// </summary>
        [Test]
        public void UpdateByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //string name = null;
            //string description = null;
            //string  = null;
            //List<string> includes = null;
            //var response = instance.UpdateById(id, name, description, , includes);
            //Assert.IsInstanceOf<FeatureResponse> (response, "response is FeatureResponse");
        }
        
    }

}