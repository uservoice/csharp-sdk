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
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.IO;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using RestSharp;
using UserVoiceSdk.Api;

namespace UserVoiceSdk.Client
{
    /// <summary>
    /// API client is mainly responsible for making the HTTP call to the API backend.
    /// </summary>
    public partial class ApiClient
    {
        private JsonSerializerSettings serializerSettings = new JsonSerializerSettings
        {
            ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor
        };

        /// <summary>
        /// Allows for extending request processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        partial void InterceptRequest(IRestRequest request);

        /// <summary>
        /// Allows for extending response processing for <see cref="ApiClient"/> generated code.
        /// </summary>
        /// <param name="request">The RestSharp request object</param>
        /// <param name="response">The RestSharp response object</param>
        partial void InterceptResponse(IRestRequest request, IRestResponse response);

        /// <summary>
		/// Rate limiting information from the last successful request
		/// </summary>
		private RateLimiting _RateLimiting;
		public RateLimiting RateLimiting 
		{ 
			get 
			{
				if (_RateLimiting == null) 
				{
					_RateLimiting = new RateLimiting();
				}
				return _RateLimiting;
			} 
			set 
			{
				_RateLimiting = value;
			} 
		}

        private AttachmentsApi _Attachments;
        public AttachmentsApi Attachments 
        { 
			get 
			{
				if (_Attachments == null)
					_Attachments = new AttachmentsApi(this);
				return _Attachments;
			} 
		}

        private CategoriesApi _Categories;
        public CategoriesApi Categories 
        { 
			get 
			{
				if (_Categories == null)
					_Categories = new CategoriesApi(this);
				return _Categories;
			} 
		}

        private CommentsApi _Comments;
        public CommentsApi Comments 
        { 
			get 
			{
				if (_Comments == null)
					_Comments = new CommentsApi(this);
				return _Comments;
			} 
		}

        private Custom_fieldsApi _Custom_fields;
        public Custom_fieldsApi Custom_fields 
        { 
			get 
			{
				if (_Custom_fields == null)
					_Custom_fields = new Custom_fieldsApi(this);
				return _Custom_fields;
			} 
		}

        private External_accountsApi _External_accounts;
        public External_accountsApi External_accounts 
        { 
			get 
			{
				if (_External_accounts == null)
					_External_accounts = new External_accountsApi(this);
				return _External_accounts;
			} 
		}

        private External_usersApi _External_users;
        public External_usersApi External_users 
        { 
			get 
			{
				if (_External_users == null)
					_External_users = new External_usersApi(this);
				return _External_users;
			} 
		}

        private FeaturesApi _Features;
        public FeaturesApi Features 
        { 
			get 
			{
				if (_Features == null)
					_Features = new FeaturesApi(this);
				return _Features;
			} 
		}

        private FeedbackApi _Feedback;
        public FeedbackApi Feedback 
        { 
			get 
			{
				if (_Feedback == null)
					_Feedback = new FeedbackApi(this);
				return _Feedback;
			} 
		}

        private Filtered_columnsApi _Filtered_columns;
        public Filtered_columnsApi Filtered_columns 
        { 
			get 
			{
				if (_Filtered_columns == null)
					_Filtered_columns = new Filtered_columnsApi(this);
				return _Filtered_columns;
			} 
		}

        private Forum_invitationsApi _Forum_invitations;
        public Forum_invitationsApi Forum_invitations 
        { 
			get 
			{
				if (_Forum_invitations == null)
					_Forum_invitations = new Forum_invitationsApi(this);
				return _Forum_invitations;
			} 
		}

        private ForumsApi _Forums;
        public ForumsApi Forums 
        { 
			get 
			{
				if (_Forums == null)
					_Forums = new ForumsApi(this);
				return _Forums;
			} 
		}

        private IdentityApi _Identity;
        public IdentityApi Identity 
        { 
			get 
			{
				if (_Identity == null)
					_Identity = new IdentityApi(this);
				return _Identity;
			} 
		}

        private LabelsApi _Labels;
        public LabelsApi Labels 
        { 
			get 
			{
				if (_Labels == null)
					_Labels = new LabelsApi(this);
				return _Labels;
			} 
		}

        private MessagesApi _Messages;
        public MessagesApi Messages 
        { 
			get 
			{
				if (_Messages == null)
					_Messages = new MessagesApi(this);
				return _Messages;
			} 
		}

        private NotesApi _Notes;
        public NotesApi Notes 
        { 
			get 
			{
				if (_Notes == null)
					_Notes = new NotesApi(this);
				return _Notes;
			} 
		}

        private Nps_ratingsApi _Nps_ratings;
        public Nps_ratingsApi Nps_ratings 
        { 
			get 
			{
				if (_Nps_ratings == null)
					_Nps_ratings = new Nps_ratingsApi(this);
				return _Nps_ratings;
			} 
		}

        private OauthApi _Oauth;
        public OauthApi Oauth 
        { 
			get 
			{
				if (_Oauth == null)
					_Oauth = new OauthApi(this);
				return _Oauth;
			} 
		}

        private SegmentsApi _Segments;
        public SegmentsApi Segments 
        { 
			get 
			{
				if (_Segments == null)
					_Segments = new SegmentsApi(this);
				return _Segments;
			} 
		}

        private Status_updatesApi _Status_updates;
        public Status_updatesApi Status_updates 
        { 
			get 
			{
				if (_Status_updates == null)
					_Status_updates = new Status_updatesApi(this);
				return _Status_updates;
			} 
		}

        private StatusesApi _Statuses;
        public StatusesApi Statuses 
        { 
			get 
			{
				if (_Statuses == null)
					_Statuses = new StatusesApi(this);
				return _Statuses;
			} 
		}

        private Suggestion_activity_entriesApi _Suggestion_activity_entries;
        public Suggestion_activity_entriesApi Suggestion_activity_entries 
        { 
			get 
			{
				if (_Suggestion_activity_entries == null)
					_Suggestion_activity_entries = new Suggestion_activity_entriesApi(this);
				return _Suggestion_activity_entries;
			} 
		}

        private SuggestionsApi _Suggestions;
        public SuggestionsApi Suggestions 
        { 
			get 
			{
				if (_Suggestions == null)
					_Suggestions = new SuggestionsApi(this);
				return _Suggestions;
			} 
		}

        private SupportersApi _Supporters;
        public SupportersApi Supporters 
        { 
			get 
			{
				if (_Supporters == null)
					_Supporters = new SupportersApi(this);
				return _Supporters;
			} 
		}

        private UsersApi _Users;
        public UsersApi Users 
        { 
			get 
			{
				if (_Users == null)
					_Users = new UsersApi(this);
				return _Users;
			} 
		}

        private ViewsApi _Views;
        public ViewsApi Views 
        { 
			get 
			{
				if (_Views == null)
					_Views = new ViewsApi(this);
				return _Views;
			} 
		}


        private static string BaseApiPath = "/api/v2";

        public ApiClient(string subdomain,
						 string clientId,
		                 string scheme = "https",
						 string domain = "uservoice.com",
						 string clientSecret = "",
						 string username = "",
						 string password = "")
		{
			Configuration = Configuration.Default;
            Configuration.ApiClient = this;
			Configuration.ClientId = clientId;
			Configuration.ClientSecret = clientSecret;
			Configuration.Username = username;
			Configuration.Password = password;
			RestClient = new RestClient($"{scheme}://{subdomain}.{domain}{BaseApiPath}");
		}

        /// <summary>
        /// Gets or sets the default API client for making HTTP calls.
        /// </summary>
        /// <value>The default API client.</value>
        [Obsolete("ApiClient.Default is deprecated, please use 'Configuration.Default.ApiClient' instead.")]
        public static ApiClient Default;

        /// <summary>
        /// Gets or sets the Configuration.
        /// </summary>
        /// <value>An instance of the Configuration.</value>
        public Configuration Configuration { get; set; }

        /// <summary>
        /// Gets or sets the RestClient.
        /// </summary>
        /// <value>An instance of the RestClient</value>
        public RestClient RestClient { get; set; }

        /// <summary>
		/// Attempt to get and set an OAuth token with client id and secret
		/// </summary>
		public void Login(string clientId, string clientSecret) 
		{
			if (string.IsNullOrEmpty(clientId)) 
			{ 
				throw new ApiException(400, "Missing required paramater clientId");
			}
			// Login as user if available
			if (!string.IsNullOrEmpty(this.Configuration.Username)
				&& !string.IsNullOrEmpty(this.Configuration.Password))
			{
				LoginAsUser(clientId, this.Configuration.Username, this.Configuration.Password);
				return;
			}
			// Must be logging in with id and secret
			if (string.IsNullOrEmpty(clientSecret))
			{
				throw new ApiException(400, "Missing required paramater clientSecret");
			}
			var token = Oauth.GetOauthToken(
				new Models.Request55(
					ClientId: clientId, 
					ClientSecret: clientSecret, 
					GrantType: Models.Request55.GrantTypeEnum.Clientcredentials
				)
			);
			this.Configuration.AccessToken = token.AccessToken;
		}

		/// <summary>
		/// Attempt to get and set an OAuth token with client id, username, and password
		/// </summary>
		public void LoginAsUser(string clientId, string username, string password) 
		{
			if (string.IsNullOrEmpty(clientId))
			{
				throw new ApiException(400, "Missing required paramater clientId");
			}
			if (string.IsNullOrEmpty(username))
			{
				throw new ApiException(400, "Missing required paramater username");
			}
			if (string.IsNullOrEmpty(password))
			{
				throw new ApiException(400, "Missing required paramater password");
			}
            var token = Oauth.GetOauthToken(
				new Models.Request55(
					ClientId: clientId,
					Username: username,
					Password: password,
					GrantType: Models.Request55.GrantTypeEnum.Password
				)
			);
			this.Configuration.AccessToken = token.AccessToken;
		}

        // Creates and sets up a RestRequest prior to a call.
        private RestRequest PrepareRequest(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            var request = new RestRequest(path, method);

            // add path parameter, if any
            foreach(var param in pathParams)
                request.AddParameter(param.Key, param.Value, ParameterType.UrlSegment);

            // add header parameter, if any
            foreach(var param in headerParams)
                request.AddHeader(param.Key, param.Value);

            // add query parameter, if any
            foreach(var param in queryParams)
                request.AddQueryParameter(param.Key, param.Value);

            // add form parameter, if any
            foreach(var param in formParams)
                request.AddParameter(param.Key, param.Value);

            // add file parameter, if any
            foreach(var param in fileParams)
            {
                request.AddFile(param.Value.Name, param.Value.Writer, param.Value.FileName, param.Value.ContentType);
            }

            if (postBody != null) // http body (model or byte[]) parameter
            {
                if (postBody.GetType() == typeof(String))
                {
                    request.AddParameter("application/json", postBody, ParameterType.RequestBody);
                }
                else if (postBody.GetType() == typeof(byte[]))
                {
                    request.AddParameter(contentType, postBody, ParameterType.RequestBody);
                }
            }

            return request;
        }

        /// <summary>
        /// Makes the HTTP request (Sync).
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content Type of the request</param>
        /// <returns>Object</returns>
        public Object CallApi(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            // Make sure user is logged in
            // Don't verify if this is the oauth path
			if (!path.ToLower().Contains("oauth") && string.IsNullOrEmpty(this.Configuration.AccessToken)) 
			{
				Login(this.Configuration.ClientId, this.Configuration.ClientSecret);
			}

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);

            // set timeout
            RestClient.Timeout = Configuration.Timeout;
            // set user agent
            RestClient.UserAgent = Configuration.UserAgent;

            InterceptRequest(request);
            var response = RestClient.Execute(request);
            InterceptResponse(request, response);
            RateLimiting = new RateLimiting(response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()));

            return (Object) response;
        }
        /// <summary>
        /// Makes the asynchronous HTTP request.
        /// </summary>
        /// <param name="path">URL path.</param>
        /// <param name="method">HTTP method.</param>
        /// <param name="queryParams">Query parameters.</param>
        /// <param name="postBody">HTTP body (POST request).</param>
        /// <param name="headerParams">Header parameters.</param>
        /// <param name="formParams">Form parameters.</param>
        /// <param name="fileParams">File parameters.</param>
        /// <param name="pathParams">Path parameters.</param>
        /// <param name="contentType">Content type.</param>
        /// <returns>The Task instance.</returns>
        public async System.Threading.Tasks.Task<Object> CallApiAsync(
            String path, RestSharp.Method method, Dictionary<String, String> queryParams, Object postBody,
            Dictionary<String, String> headerParams, Dictionary<String, String> formParams,
            Dictionary<String, FileParameter> fileParams, Dictionary<String, String> pathParams,
            String contentType)
        {
            // Make sure user is logged in
			// Don't verify if this is the oauth path
			if (!path.ToLower().Contains("oauth") && string.IsNullOrEmpty(this.Configuration.AccessToken)) 
			{
				Login(this.Configuration.ClientId, this.Configuration.ClientSecret);
			}

            // authentication (oauth2_client_credentials) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            // authentication (oauth2_password) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                headerParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }
            
            var request = PrepareRequest(
                path, method, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, contentType);
            InterceptRequest(request);
            var response = await RestClient.ExecuteTaskAsync(request);
            InterceptResponse(request, response);
            RateLimiting = new RateLimiting(response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()));
            
            return (Object)response;
        }

        /// <summary>
        /// Escape string (url-encoded).
        /// </summary>
        /// <param name="str">String to be escaped.</param>
        /// <returns>Escaped string.</returns>
        public string EscapeString(string str)
        {
            return UrlEncode(str);
        }

        /// <summary>
        /// Create FileParameter based on Stream.
        /// </summary>
        /// <param name="name">Parameter name.</param>
        /// <param name="stream">Input stream.</param>
        /// <returns>FileParameter.</returns>
        public FileParameter ParameterToFile(string name, Stream stream)
        {
            if (stream is FileStream)
                return FileParameter.Create(name, ReadAsBytes(stream), Path.GetFileName(((FileStream)stream).Name));
            else
                return FileParameter.Create(name, ReadAsBytes(stream), "no_file_name_provided");
        }

        /// <summary>
        /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
        /// If parameter is a list, join the list with ",".
        /// Otherwise just return the string.
        /// </summary>
        /// <param name="obj">The parameter (header, path, query, form).</param>
        /// <returns>Formatted string.</returns>
        public string ParameterToString(object obj)
        {
            if (obj is DateTime)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTime)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is DateTimeOffset)
                // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
                // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
                // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
                // For example: 2009-06-15T13:45:30.0000000
                return ((DateTimeOffset)obj).ToString (Configuration.DateTimeFormat);
            else if (obj is IList)
            {
                var flattenedString = new StringBuilder();
                foreach (var param in (IList)obj)
                {
                    if (flattenedString.Length > 0)
                        flattenedString.Append(",");
                    flattenedString.Append(param);
                }
                return flattenedString.ToString();
            }
            else
                return Convert.ToString (obj);
        }

        /// <summary>
        /// Deserialize the JSON string into a proper object.
        /// </summary>
        /// <param name="response">The HTTP response.</param>
        /// <param name="type">Object type.</param>
        /// <returns>Object representation of the JSON string.</returns>
        public object Deserialize(IRestResponse response, Type type)
        {
            IList<Parameter> headers = response.Headers;
            if (type == typeof(byte[])) // return byte array
            {
                return response.RawBytes;
            }

            if (type == typeof(Stream))
            {
                if (headers != null)
                {
                    var filePath = String.IsNullOrEmpty(Configuration.TempFolderPath)
                        ? Path.GetTempPath()
                        : Configuration.TempFolderPath;
                    var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                    foreach (var header in headers)
                    {
                        var match = regex.Match(header.ToString());
                        if (match.Success)
                        {
                            string fileName = filePath + SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                            File.WriteAllBytes(fileName, response.RawBytes);
                            return new FileStream(fileName, FileMode.Open);
                        }
                    }
                }
                var stream = new MemoryStream(response.RawBytes);
                return stream;
            }

            if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            {
                return DateTime.Parse(response.Content,  null, System.Globalization.DateTimeStyles.RoundtripKind);
            }

            if (type == typeof(String) || type.Name.StartsWith("System.Nullable")) // return primitive type
            {
                return ConvertType(response.Content, type);
            }

            // at this point, it must be a model (json)
            try
            {
                return JsonConvert.DeserializeObject(response.Content, type, serializerSettings);
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Serialize an input (model) into JSON string
        /// </summary>
        /// <param name="obj">Object.</param>
        /// <returns>JSON string.</returns>
        public String Serialize(object obj)
        {
            try
            {
                return obj != null ? JsonConvert.SerializeObject(obj) : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        /// <summary>
        /// Select the Content-Type header's value from the given content-type array:
        /// if JSON exists in the given array, use it;
        /// otherwise use the first one defined in 'consumes'
        /// </summary>
        /// <param name="contentTypes">The Content-Type array to select from.</param>
        /// <returns>The Content-Type header to use.</returns>
        public String SelectHeaderContentType(String[] contentTypes)
        {
            if (contentTypes.Length == 0)
                return null;

            if (contentTypes.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return contentTypes[0]; // use the first content type specified in 'consumes'
        }

        /// <summary>
        /// Select the Accept header's value from the given accepts array:
        /// if JSON exists in the given array, use it;
        /// otherwise use all of them (joining into a string)
        /// </summary>
        /// <param name="accepts">The accepts array to select from.</param>
        /// <returns>The Accept header to use.</returns>
        public String SelectHeaderAccept(String[] accepts)
        {
            if (accepts.Length == 0)
                return null;

            if (accepts.Contains("application/json", StringComparer.OrdinalIgnoreCase))
                return "application/json";

            return String.Join(",", accepts);
        }

        /// <summary>
        /// Encode string in base64 format.
        /// </summary>
        /// <param name="text">String to be encoded.</param>
        /// <returns>Encoded string.</returns>
        public static string Base64Encode(string text)
        {
            return System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(text));
        }

        /// <summary>
        /// Dynamically cast the object into target type.
        /// Ref: http://stackoverflow.com/questions/4925718/c-dynamic-runtime-cast
        /// </summary>
        /// <param name="source">Object to be casted</param>
        /// <param name="dest">Target type</param>
        /// <returns>Casted object</returns>
        public static dynamic ConvertType(dynamic source, Type dest)
        {
            return Convert.ChangeType(source, dest);
        }

        /// <summary>
        /// Convert stream to byte array
        /// Credit/Ref: http://stackoverflow.com/a/221941/677735
        /// </summary>
        /// <param name="input">Input stream to be converted</param>
        /// <returns>Byte array</returns>
        public static byte[] ReadAsBytes(Stream input)
        {
            byte[] buffer = new byte[16*1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// URL encode a string
        /// Credit/Ref: https://github.com/restsharp/RestSharp/blob/master/RestSharp/Extensions/StringExtensions.cs#L50
        /// </summary>
        /// <param name="input">String to be URL encoded</param>
        /// <returns>Byte array</returns>
        public static string UrlEncode(string input)
        {
            const int maxLength = 32766;

            if (input == null)
            {
                throw new ArgumentNullException("input");
            }

            if (input.Length <= maxLength)
            {
                return Uri.EscapeDataString(input);
            }

            StringBuilder sb = new StringBuilder(input.Length * 2);
            int index = 0;

            while (index < input.Length)
            {
                int length = Math.Min(input.Length - index, maxLength);
                string subString = input.Substring(index, length);

                sb.Append(Uri.EscapeDataString(subString));
                index += subString.Length;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Sanitize filename by removing the path
        /// </summary>
        /// <param name="filename">Filename</param>
        /// <returns>Filename</returns>
        public static string SanitizeFilename(string filename)
        {
            Match match = Regex.Match(filename, @".*[/\\](.*)$");

            if (match.Success)
            {
                return match.Groups[1].Value;
            }
            else
            {
                return filename;
            }
        }
    }
}
