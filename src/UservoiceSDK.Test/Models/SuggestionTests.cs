/* 
 * UserVoice API
 *
 * A RESTful API to interface with UserVoice's feedback system. Online documentation available here: https://developer.uservoice.com/docs/api/v2/reference/.
 *
 * OpenAPI spec version: 2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using UserVoiceSdk.Api;
using UserVoiceSdk.Models;
using UserVoiceSdk.Client;
using System.Reflection;

namespace UserVoiceSdk.Test
{
    /// <summary>
    ///  Class for testing Suggestion
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class SuggestionTests
    {
        // TODO uncomment below to declare an instance variable for Suggestion
        //private Suggestion instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Suggestion
            //instance = new Suggestion();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Suggestion
        /// </summary>
        [Test]
        public void SuggestionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Suggestion
            //Assert.IsInstanceOfType<Suggestion> (instance, "variable 'instance' is a Suggestion");
        }

        /// <summary>
        /// Test the property 'AdminUrl'
        /// </summary>
        [Test]
        public void AdminUrlTest()
        {
            // TODO unit test for the property 'AdminUrl'
        }
        /// <summary>
        /// Test the property 'ApprovedAt'
        /// </summary>
        [Test]
        public void ApprovedAtTest()
        {
            // TODO unit test for the property 'ApprovedAt'
        }
        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Test]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }
        /// <summary>
        /// Test the property 'BodyMimeType'
        /// </summary>
        [Test]
        public void BodyMimeTypeTest()
        {
            // TODO unit test for the property 'BodyMimeType'
        }
        /// <summary>
        /// Test the property 'ClosedAt'
        /// </summary>
        [Test]
        public void ClosedAtTest()
        {
            // TODO unit test for the property 'ClosedAt'
        }
        /// <summary>
        /// Test the property 'CommentsCount'
        /// </summary>
        [Test]
        public void CommentsCountTest()
        {
            // TODO unit test for the property 'CommentsCount'
        }
        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }
        /// <summary>
        /// Test the property 'CreatorBrowser'
        /// </summary>
        [Test]
        public void CreatorBrowserTest()
        {
            // TODO unit test for the property 'CreatorBrowser'
        }
        /// <summary>
        /// Test the property 'CreatorBrowserVersion'
        /// </summary>
        [Test]
        public void CreatorBrowserVersionTest()
        {
            // TODO unit test for the property 'CreatorBrowserVersion'
        }
        /// <summary>
        /// Test the property 'CreatorMobile'
        /// </summary>
        [Test]
        public void CreatorMobileTest()
        {
            // TODO unit test for the property 'CreatorMobile'
        }
        /// <summary>
        /// Test the property 'CreatorOs'
        /// </summary>
        [Test]
        public void CreatorOsTest()
        {
            // TODO unit test for the property 'CreatorOs'
        }
        /// <summary>
        /// Test the property 'CreatorReferrer'
        /// </summary>
        [Test]
        public void CreatorReferrerTest()
        {
            // TODO unit test for the property 'CreatorReferrer'
        }
        /// <summary>
        /// Test the property 'CreatorUserAgent'
        /// </summary>
        [Test]
        public void CreatorUserAgentTest()
        {
            // TODO unit test for the property 'CreatorUserAgent'
        }
        /// <summary>
        /// Test the property 'FirstSupportAt'
        /// </summary>
        [Test]
        public void FirstSupportAtTest()
        {
            // TODO unit test for the property 'FirstSupportAt'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }
        /// <summary>
        /// Test the property 'InappropriateFlagsCount'
        /// </summary>
        [Test]
        public void InappropriateFlagsCountTest()
        {
            // TODO unit test for the property 'InappropriateFlagsCount'
        }
        /// <summary>
        /// Test the property 'Links'
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO unit test for the property 'Links'
        }
        /// <summary>
        /// Test the property 'NotesCount'
        /// </summary>
        [Test]
        public void NotesCountTest()
        {
            // TODO unit test for the property 'NotesCount'
        }
        /// <summary>
        /// Test the property 'PortalUrl'
        /// </summary>
        [Test]
        public void PortalUrlTest()
        {
            // TODO unit test for the property 'PortalUrl'
        }
        /// <summary>
        /// Test the property 'RecentEngagement'
        /// </summary>
        [Test]
        public void RecentEngagementTest()
        {
            // TODO unit test for the property 'RecentEngagement'
        }
        /// <summary>
        /// Test the property 'RequestsCount'
        /// </summary>
        [Test]
        public void RequestsCountTest()
        {
            // TODO unit test for the property 'RequestsCount'
        }
        /// <summary>
        /// Test the property 'SatisfactionDetractorCount'
        /// </summary>
        [Test]
        public void SatisfactionDetractorCountTest()
        {
            // TODO unit test for the property 'SatisfactionDetractorCount'
        }
        /// <summary>
        /// Test the property 'SatisfactionNeutralCount'
        /// </summary>
        [Test]
        public void SatisfactionNeutralCountTest()
        {
            // TODO unit test for the property 'SatisfactionNeutralCount'
        }
        /// <summary>
        /// Test the property 'SatisfactionPromoterCount'
        /// </summary>
        [Test]
        public void SatisfactionPromoterCountTest()
        {
            // TODO unit test for the property 'SatisfactionPromoterCount'
        }
        /// <summary>
        /// Test the property 'State'
        /// </summary>
        [Test]
        public void StateTest()
        {
            // TODO unit test for the property 'State'
        }
        /// <summary>
        /// Test the property 'SupportersCount'
        /// </summary>
        [Test]
        public void SupportersCountTest()
        {
            // TODO unit test for the property 'SupportersCount'
        }
        /// <summary>
        /// Test the property 'SupportingAccountsCount'
        /// </summary>
        [Test]
        public void SupportingAccountsCountTest()
        {
            // TODO unit test for the property 'SupportingAccountsCount'
        }
        /// <summary>
        /// Test the property 'Title'
        /// </summary>
        [Test]
        public void TitleTest()
        {
            // TODO unit test for the property 'Title'
        }
        /// <summary>
        /// Test the property 'UpdatedAt'
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO unit test for the property 'UpdatedAt'
        }
        /// <summary>
        /// Test the property 'VotesCount'
        /// </summary>
        [Test]
        public void VotesCountTest()
        {
            // TODO unit test for the property 'VotesCount'
        }

    }

}
