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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace UservoiceSDK.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOauthApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Token</returns>
        Token GetOauthToken (string grantType, string clientId, string username = null, string password = null, string clientSecret = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        ApiResponse<Token> GetOauthTokenWithHttpInfo (string grantType, string clientId, string username = null, string password = null, string clientSecret = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of Token</returns>
        System.Threading.Tasks.Task<Token> GetOauthTokenAsync (string grantType, string clientId, string username = null, string password = null, string clientSecret = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        System.Threading.Tasks.Task<ApiResponse<Token>> GetOauthTokenAsyncWithHttpInfo (string grantType, string clientId, string username = null, string password = null, string clientSecret = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OauthApi : IOauthApi
    {
        private UservoiceSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        public OauthApi(ApiClient client) 
		{ 
			this.Client = client;

			ExceptionFactory = UservoiceSDK.Client.Configuration.DefaultExceptionFactory;

			// ensure API client has configuration ready
			if (Configuration.ApiClient.Configuration == null)
			{
				this.Configuration.ApiClient.Configuration = this.Configuration;
			}
		}

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient Client {get; set;}

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get { return Client.Configuration; }}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public UservoiceSDK.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Token</returns>
        public Token GetOauthToken (string grantType, string clientId, string username = null, string password = null, string clientSecret = null)
        {
             ApiResponse<Token> localVarResponse = GetOauthTokenWithHttpInfo(grantType, clientId, username, password, clientSecret);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>ApiResponse of Token</returns>
        public ApiResponse< Token > GetOauthTokenWithHttpInfo (string grantType, string clientId, string username = null, string password = null, string clientSecret = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling OauthApi->GetOauthToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->GetOauthToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOauthToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of Token</returns>
        public async System.Threading.Tasks.Task<Token> GetOauthTokenAsync (string grantType, string clientId, string username = null, string password = null, string clientSecret = null)
        {
             ApiResponse<Token> localVarResponse = await GetOauthTokenAsyncWithHttpInfo(grantType, clientId, username, password, clientSecret);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="grantType"></param>
        /// <param name="clientId"></param>
        /// <param name="username"> (optional)</param>
        /// <param name="password"> (optional)</param>
        /// <param name="clientSecret"> (optional)</param>
        /// <returns>Task of ApiResponse (Token)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Token>> GetOauthTokenAsyncWithHttpInfo (string grantType, string clientId, string username = null, string password = null, string clientSecret = null)
        {
            // verify the required parameter 'grantType' is set
            if (grantType == null)
                throw new ApiException(400, "Missing required parameter 'grantType' when calling OauthApi->GetOauthToken");
            // verify the required parameter 'clientId' is set
            if (clientId == null)
                throw new ApiException(400, "Missing required parameter 'clientId' when calling OauthApi->GetOauthToken");

            var localVarPath = "/oauth/token";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (grantType != null) localVarFormParams.Add("grant_type", Configuration.ApiClient.ParameterToString(grantType)); // form parameter
            if (username != null) localVarFormParams.Add("username", Configuration.ApiClient.ParameterToString(username)); // form parameter
            if (password != null) localVarFormParams.Add("password", Configuration.ApiClient.ParameterToString(password)); // form parameter
            if (clientId != null) localVarFormParams.Add("client_id", Configuration.ApiClient.ParameterToString(clientId)); // form parameter
            if (clientSecret != null) localVarFormParams.Add("client_secret", Configuration.ApiClient.ParameterToString(clientSecret)); // form parameter

            // authentication (oauth2_password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetOauthToken", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Token>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Token) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Token)));
            
        }

    }
}
