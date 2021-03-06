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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace UserVoiceSdk.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMessagesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// # Create a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponse</returns>
        MessageResponse Create (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null);

        /// <summary>
        /// # Create a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponse</returns>
        ApiResponse<MessageResponse> CreateWithHttpInfo (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null);
        /// <summary>
        /// # List messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponsePaginated</returns>
        MessageResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<string> includes = null);

        /// <summary>
        /// # List messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponsePaginated</returns>
        ApiResponse<MessageResponsePaginated> GetWithHttpInfo (long? page = null, long? perPage = null, string sort = null, List<string> includes = null);
        /// <summary>
        /// # Retrieve messages by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponse</returns>
        MessageResponse GetById (List<int?> id, List<string> includes = null);

        /// <summary>
        /// # Retrieve messages by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponse</returns>
        ApiResponse<MessageResponse> GetByIdWithHttpInfo (List<int?> id, List<string> includes = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// # Create a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        System.Threading.Tasks.Task<MessageResponse> CreateAsync (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null);

        /// <summary>
        /// # Create a message
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageResponse>> CreateAsyncWithHttpInfo (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null);
        /// <summary>
        /// # List messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponsePaginated</returns>
        System.Threading.Tasks.Task<MessageResponsePaginated> GetAsync (long? page = null, long? perPage = null, string sort = null, List<string> includes = null);

        /// <summary>
        /// # List messages
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponsePaginated)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageResponsePaginated>> GetAsyncWithHttpInfo (long? page = null, long? perPage = null, string sort = null, List<string> includes = null);
        /// <summary>
        /// # Retrieve messages by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        System.Threading.Tasks.Task<MessageResponse> GetByIdAsync (List<int?> id, List<string> includes = null);

        /// <summary>
        /// # Retrieve messages by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MessageResponse>> GetByIdAsyncWithHttpInfo (List<int?> id, List<string> includes = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MessagesApi : IMessagesApi
    {
        private UserVoiceSdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        public MessagesApi(ApiClient client) 
		{ 
			this.Client = client;

			ExceptionFactory = UserVoiceSdk.Client.Configuration.DefaultExceptionFactory;

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
        public UserVoiceSdk.Client.ExceptionFactory ExceptionFactory
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
        /// # Create a message 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponse</returns>
        public MessageResponse Create (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null)
        {
             ApiResponse<MessageResponse> localVarResponse = CreateWithHttpInfo(body, linksSuggestion, notificationEmailAddress, includes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// # Create a message 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponse</returns>
        public ApiResponse< MessageResponse > CreateWithHttpInfo (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagesApi->Create");
            // verify the required parameter 'linksSuggestion' is set
            if (linksSuggestion == null)
                throw new ApiException(400, "Missing required parameter 'linksSuggestion' when calling MessagesApi->Create");

            var localVarPath = "/admin/messages";
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
            if (body != null) localVarFormParams.Add("body", Configuration.ApiClient.ParameterToString(body)); // form parameter
            if (notificationEmailAddress != null) localVarFormParams.Add("notification_email_address", Configuration.ApiClient.ParameterToString(notificationEmailAddress)); // form parameter
            if (linksSuggestion != null) localVarFormParams.Add("links.suggestion", Configuration.ApiClient.ParameterToString(linksSuggestion)); // form parameter
            if (includes != null) localVarFormParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // form parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }

        /// <summary>
        /// # Create a message 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        public async System.Threading.Tasks.Task<MessageResponse> CreateAsync (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null)
        {
             ApiResponse<MessageResponse> localVarResponse = await CreateAsyncWithHttpInfo(body, linksSuggestion, notificationEmailAddress, includes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// # Create a message 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="linksSuggestion"></param>
        /// <param name="notificationEmailAddress"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageResponse>> CreateAsyncWithHttpInfo (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling MessagesApi->Create");
            // verify the required parameter 'linksSuggestion' is set
            if (linksSuggestion == null)
                throw new ApiException(400, "Missing required parameter 'linksSuggestion' when calling MessagesApi->Create");

            var localVarPath = "/admin/messages";
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
            if (body != null) localVarFormParams.Add("body", Configuration.ApiClient.ParameterToString(body)); // form parameter
            if (notificationEmailAddress != null) localVarFormParams.Add("notification_email_address", Configuration.ApiClient.ParameterToString(notificationEmailAddress)); // form parameter
            if (linksSuggestion != null) localVarFormParams.Add("links.suggestion", Configuration.ApiClient.ParameterToString(linksSuggestion)); // form parameter
            if (includes != null) localVarFormParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // form parameter

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
                Exception exception = ExceptionFactory("Create", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }

        /// <summary>
        /// # List messages 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponsePaginated</returns>
        public MessageResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<string> includes = null)
        {
             ApiResponse<MessageResponsePaginated> localVarResponse = GetWithHttpInfo(page, perPage, sort, includes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// # List messages 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponsePaginated</returns>
        public ApiResponse< MessageResponsePaginated > GetWithHttpInfo (long? page = null, long? perPage = null, string sort = null, List<string> includes = null)
        {

            var localVarPath = "/admin/messages";
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
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (includes != null) localVarQueryParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponsePaginated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponsePaginated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponsePaginated)));
            
        }

        /// <summary>
        /// # List messages 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponsePaginated</returns>
        public async System.Threading.Tasks.Task<MessageResponsePaginated> GetAsync (long? page = null, long? perPage = null, string sort = null, List<string> includes = null)
        {
             ApiResponse<MessageResponsePaginated> localVarResponse = await GetAsyncWithHttpInfo(page, perPage, sort, includes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// # List messages 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponsePaginated)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageResponsePaginated>> GetAsyncWithHttpInfo (long? page = null, long? perPage = null, string sort = null, List<string> includes = null)
        {

            var localVarPath = "/admin/messages";
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
            if (page != null) localVarQueryParams.Add("page", Configuration.ApiClient.ParameterToString(page)); // query parameter
            if (perPage != null) localVarQueryParams.Add("per_page", Configuration.ApiClient.ParameterToString(perPage)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (includes != null) localVarQueryParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // query parameter

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponsePaginated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponsePaginated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponsePaginated)));
            
        }

        /// <summary>
        /// # Retrieve messages by id 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>MessageResponse</returns>
        public MessageResponse GetById (List<int?> id, List<string> includes = null)
        {
             ApiResponse<MessageResponse> localVarResponse = GetByIdWithHttpInfo(id, includes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// # Retrieve messages by id 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of MessageResponse</returns>
        public ApiResponse< MessageResponse > GetByIdWithHttpInfo (List<int?> id, List<string> includes = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MessagesApi->GetById");

            var localVarPath = "/admin/messages/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (includes != null) localVarQueryParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }

        /// <summary>
        /// # Retrieve messages by id 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of MessageResponse</returns>
        public async System.Threading.Tasks.Task<MessageResponse> GetByIdAsync (List<int?> id, List<string> includes = null)
        {
             ApiResponse<MessageResponse> localVarResponse = await GetByIdAsyncWithHttpInfo(id, includes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// # Retrieve messages by id 
        /// </summary>
        /// <exception cref="UserVoiceSdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (MessageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MessageResponse>> GetByIdAsyncWithHttpInfo (List<int?> id, List<string> includes = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling MessagesApi->GetById");

            var localVarPath = "/admin/messages/{id}";
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
            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            if (includes != null) localVarQueryParams.Add("includes", Configuration.ApiClient.ParameterToString(includes)); // query parameter

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
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MessageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (MessageResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(MessageResponse)));
            
        }

    }
}
