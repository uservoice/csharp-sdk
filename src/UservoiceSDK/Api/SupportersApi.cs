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
    public interface ISupportersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// # List supporters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>SupporterResponsePaginated</returns>
        SupporterResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null);

        /// <summary>
        /// # List supporters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of SupporterResponsePaginated</returns>
        ApiResponse<SupporterResponsePaginated> GetWithHttpInfo (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null);
        /// <summary>
        /// # Retrieve supporters by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>SupporterResponse</returns>
        SupporterResponse GetById (List<int?> id, List<string> includes = null);

        /// <summary>
        /// # Retrieve supporters by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of SupporterResponse</returns>
        ApiResponse<SupporterResponse> GetByIdWithHttpInfo (List<int?> id, List<string> includes = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// # List supporters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of SupporterResponsePaginated</returns>
        System.Threading.Tasks.Task<SupporterResponsePaginated> GetAsync (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null);

        /// <summary>
        /// # List supporters
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (SupporterResponsePaginated)</returns>
        System.Threading.Tasks.Task<ApiResponse<SupporterResponsePaginated>> GetAsyncWithHttpInfo (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null);
        /// <summary>
        /// # Retrieve supporters by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of SupporterResponse</returns>
        System.Threading.Tasks.Task<SupporterResponse> GetByIdAsync (List<int?> id, List<string> includes = null);

        /// <summary>
        /// # Retrieve supporters by id
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (SupporterResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<SupporterResponse>> GetByIdAsyncWithHttpInfo (List<int?> id, List<string> includes = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SupportersApi : ISupportersApi
    {
        private UservoiceSDK.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        public SupportersApi(ApiClient client) 
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
        /// # List supporters 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>SupporterResponsePaginated</returns>
        public SupporterResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)
        {
             ApiResponse<SupporterResponsePaginated> localVarResponse = GetWithHttpInfo(page, perPage, bulkPerPage, sort, suggestion, user, legit, forum, periodStart, periodEnd, anonymous, includes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// # List supporters 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of SupporterResponsePaginated</returns>
        public ApiResponse< SupporterResponsePaginated > GetWithHttpInfo (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)
        {

            var localVarPath = "/admin/supporters";
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
            if (bulkPerPage != null) localVarQueryParams.Add("bulk_per_page", Configuration.ApiClient.ParameterToString(bulkPerPage)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (suggestion != null) localVarQueryParams.Add("suggestion", Configuration.ApiClient.ParameterToString(suggestion)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (legit != null) localVarQueryParams.Add("legit", Configuration.ApiClient.ParameterToString(legit)); // query parameter
            if (forum != null) localVarQueryParams.Add("forum", Configuration.ApiClient.ParameterToString(forum)); // query parameter
            if (periodStart != null) localVarQueryParams.Add("period_start", Configuration.ApiClient.ParameterToString(periodStart)); // query parameter
            if (periodEnd != null) localVarQueryParams.Add("period_end", Configuration.ApiClient.ParameterToString(periodEnd)); // query parameter
            if (anonymous != null) localVarQueryParams.Add("anonymous", Configuration.ApiClient.ParameterToString(anonymous)); // query parameter
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

            return new ApiResponse<SupporterResponsePaginated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SupporterResponsePaginated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupporterResponsePaginated)));
            
        }

        /// <summary>
        /// # List supporters 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of SupporterResponsePaginated</returns>
        public async System.Threading.Tasks.Task<SupporterResponsePaginated> GetAsync (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)
        {
             ApiResponse<SupporterResponsePaginated> localVarResponse = await GetAsyncWithHttpInfo(page, perPage, bulkPerPage, sort, suggestion, user, legit, forum, periodStart, periodEnd, anonymous, includes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// # List supporters 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="page"> (optional, default to 1)</param>
        /// <param name="perPage"> (optional, default to 20)</param>
        /// <param name="bulkPerPage"> (optional)</param>
        /// <param name="sort"> (optional, default to -id)</param>
        /// <param name="suggestion"> (optional)</param>
        /// <param name="user"> (optional)</param>
        /// <param name="legit"> (optional)</param>
        /// <param name="forum"> (optional)</param>
        /// <param name="periodStart"> (optional)</param>
        /// <param name="periodEnd"> (optional)</param>
        /// <param name="anonymous"> (optional)</param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (SupporterResponsePaginated)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SupporterResponsePaginated>> GetAsyncWithHttpInfo (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)
        {

            var localVarPath = "/admin/supporters";
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
            if (bulkPerPage != null) localVarQueryParams.Add("bulk_per_page", Configuration.ApiClient.ParameterToString(bulkPerPage)); // query parameter
            if (sort != null) localVarQueryParams.Add("sort", Configuration.ApiClient.ParameterToString(sort)); // query parameter
            if (suggestion != null) localVarQueryParams.Add("suggestion", Configuration.ApiClient.ParameterToString(suggestion)); // query parameter
            if (user != null) localVarQueryParams.Add("user", Configuration.ApiClient.ParameterToString(user)); // query parameter
            if (legit != null) localVarQueryParams.Add("legit", Configuration.ApiClient.ParameterToString(legit)); // query parameter
            if (forum != null) localVarQueryParams.Add("forum", Configuration.ApiClient.ParameterToString(forum)); // query parameter
            if (periodStart != null) localVarQueryParams.Add("period_start", Configuration.ApiClient.ParameterToString(periodStart)); // query parameter
            if (periodEnd != null) localVarQueryParams.Add("period_end", Configuration.ApiClient.ParameterToString(periodEnd)); // query parameter
            if (anonymous != null) localVarQueryParams.Add("anonymous", Configuration.ApiClient.ParameterToString(anonymous)); // query parameter
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

            return new ApiResponse<SupporterResponsePaginated>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SupporterResponsePaginated) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupporterResponsePaginated)));
            
        }

        /// <summary>
        /// # Retrieve supporters by id 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>SupporterResponse</returns>
        public SupporterResponse GetById (List<int?> id, List<string> includes = null)
        {
             ApiResponse<SupporterResponse> localVarResponse = GetByIdWithHttpInfo(id, includes);
             return localVarResponse.Data;
        }

        /// <summary>
        /// # Retrieve supporters by id 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>ApiResponse of SupporterResponse</returns>
        public ApiResponse< SupporterResponse > GetByIdWithHttpInfo (List<int?> id, List<string> includes = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SupportersApi->GetById");

            var localVarPath = "/admin/supporters/{id}";
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

            return new ApiResponse<SupporterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SupporterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupporterResponse)));
            
        }

        /// <summary>
        /// # Retrieve supporters by id 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of SupporterResponse</returns>
        public async System.Threading.Tasks.Task<SupporterResponse> GetByIdAsync (List<int?> id, List<string> includes = null)
        {
             ApiResponse<SupporterResponse> localVarResponse = await GetByIdAsyncWithHttpInfo(id, includes);
             return localVarResponse.Data;

        }

        /// <summary>
        /// # Retrieve supporters by id 
        /// </summary>
        /// <exception cref="UservoiceSDK.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id"></param>
        /// <param name="includes"> (optional)</param>
        /// <returns>Task of ApiResponse (SupporterResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SupporterResponse>> GetByIdAsyncWithHttpInfo (List<int?> id, List<string> includes = null)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SupportersApi->GetById");

            var localVarPath = "/admin/supporters/{id}";
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

            return new ApiResponse<SupporterResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SupporterResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SupporterResponse)));
            
        }

    }
}
