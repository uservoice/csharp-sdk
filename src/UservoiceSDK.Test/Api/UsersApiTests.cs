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
    ///  Class for testing UsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class UsersApiTests
    {
        private UsersApi instance;
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
            instance = client.Users;
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of UsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' UsersApi
            //Assert.IsInstanceOfType(typeof(UsersApi), instance, "instance is a UsersApi");
        }

        
        /// <summary>
        /// Test BlockById
        /// </summary>
        [Test]
        public void BlockByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.BlockById(id, includes);
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
        }
        
        /// <summary>
        /// Test Current
        /// </summary>
        [Test]
        public void CurrentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> includes = null;
            //var response = instance.Current(includes);
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
        }
        
        /// <summary>
        /// Test FindOrCreate
        /// </summary>
        [Test]
        public void FindOrCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //string email = null;
            //List<string> includes = null;
            //var response = instance.FindOrCreate(name, email, includes);
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
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
            //string q = null;
            //List<string> emailAddress = null;
            //List<string> allowedState = null;
            //bool? internalUser = null;
            //List<int?> team = null;
            //List<string> includes = null;
            //var response = instance.Get(page, perPage, bulkPerPage, sort, q, emailAddress, allowedState, internalUser, team, includes);
            //Assert.IsInstanceOf<UserResponsePaginated> (response, "response is UserResponsePaginated");
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
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
        }
        
        /// <summary>
        /// Test UnblockById
        /// </summary>
        [Test]
        public void UnblockByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? id = null;
            //List<string> includes = null;
            //var response = instance.UnblockById(id, includes);
            //Assert.IsInstanceOf<UserResponse> (response, "response is UserResponse");
        }
        
    }

}
