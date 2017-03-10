# UserVoiceSdk.Api.FeedbackApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](FeedbackApi.md#create) | **POST** /admin/feedback | # Create a feedback
[**DeleteById**](FeedbackApi.md#deletebyid) | **DELETE** /admin/feedback/{id} | # Delete a feedback
[**Get**](FeedbackApi.md#get) | **GET** /admin/feedback | # List feedback
[**GetById**](FeedbackApi.md#getbyid) | **GET** /admin/feedback/{id} | # Retrieve feedback by id
[**UpdateById**](FeedbackApi.md#updatebyid) | **PUT** /admin/feedback/{id} | # Update a feedback


<a name="create"></a>
# **Create**
> FeedbackResponse Create (string body, string channel, long? linksSuggestion, long? linksUser, string bodyMimeType = null, string sourceUrl = null, string sourceType = null, string sourceGuid = null, bool? subscribe = null, long? linksTicket = null, List<string> includes = null)

# Create a feedback

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class CreateExample
    {
        private string ApiKey = "some_key";
        private string ApiSecret = "some_secret";
        private string Subdomain = "sub";
        private string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private string Username = "some.user@uservoice.com";
		private string Password = "Somepassword1234!";

        public void main()
        {
            var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, you can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

            var body = body_example;  // string | 
            var channel = channel_example;  // string |  (default to api)
            var linksSuggestion = 789;  // long? | 
            var linksUser = 789;  // long? | 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional)  (default to text/plain)
            var sourceUrl = sourceUrl_example;  // string |  (optional) 
            var sourceType = sourceType_example;  // string |  (optional) 
            var sourceGuid = sourceGuid_example;  // string |  (optional) 
            var subscribe = true;  // bool? |  (optional)  (default to true)
            var linksTicket = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a feedback
                FeedbackResponse result = client.Feedback.Create(body, channel, linksSuggestion, linksUser, bodyMimeType, sourceUrl, sourceType, sourceGuid, subscribe, linksTicket, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeedbackApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**|  | 
 **channel** | **string**|  | [default to api]
 **linksSuggestion** | **long?**|  | 
 **linksUser** | **long?**|  | 
 **bodyMimeType** | **string**|  | [optional] [default to text/plain]
 **sourceUrl** | **string**|  | [optional] 
 **sourceType** | **string**|  | [optional] 
 **sourceGuid** | **string**|  | [optional] 
 **subscribe** | **bool?**|  | [optional] [default to true]
 **linksTicket** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**FeedbackResponse**](FeedbackResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyid"></a>
# **DeleteById**
> FeedbackResponse DeleteById (long? id, List<string> includes = null)

# Delete a feedback

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class DeleteByIdExample
    {
        private string ApiKey = "some_key";
        private string ApiSecret = "some_secret";
        private string Subdomain = "sub";
        private string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private string Username = "some.user@uservoice.com";
		private string Password = "Somepassword1234!";

        public void main()
        {
            var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, you can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Delete a feedback
                FeedbackResponse result = client.Feedback.DeleteById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeedbackApi.DeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**FeedbackResponse**](FeedbackResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> FeedbackResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, string channel = null, string sourceUrl = null, string sourceType = null, string sourceGuid = null, List<int?> suggestion = null, List<int?> ticket = null, List<string> includes = null)

# List feedback

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class GetExample
    {
        private string ApiKey = "some_key";
        private string ApiSecret = "some_secret";
        private string Subdomain = "sub";
        private string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private string Username = "some.user@uservoice.com";
		private string Password = "Somepassword1234!";

        public void main()
        {
            var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, you can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var sort = sort_example;  // string |  (optional)  (default to -updated_at)
            var channel = channel_example;  // string |  (optional) 
            var sourceUrl = sourceUrl_example;  // string |  (optional) 
            var sourceType = sourceType_example;  // string |  (optional) 
            var sourceGuid = sourceGuid_example;  // string |  (optional) 
            var suggestion = new List<int?>(); // List<int?> |  (optional) 
            var ticket = new List<int?>(); // List<int?> |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List feedback
                FeedbackResponsePaginated result = client.Feedback.Get(page, perPage, sort, channel, sourceUrl, sourceType, sourceGuid, suggestion, ticket, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeedbackApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **long?**|  | [optional] [default to 1]
 **perPage** | **long?**|  | [optional] [default to 20]
 **sort** | **string**|  | [optional] [default to -updated_at]
 **channel** | **string**|  | [optional] 
 **sourceUrl** | **string**|  | [optional] 
 **sourceType** | **string**|  | [optional] 
 **sourceGuid** | **string**|  | [optional] 
 **suggestion** | [**List<int?>**](int?.md)|  | [optional] 
 **ticket** | [**List<int?>**](int?.md)|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**FeedbackResponsePaginated**](FeedbackResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> FeedbackResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve feedback by id

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class GetByIdExample
    {
        private string ApiKey = "some_key";
        private string ApiSecret = "some_secret";
        private string Subdomain = "sub";
        private string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private string Username = "some.user@uservoice.com";
		private string Password = "Somepassword1234!";

        public void main()
        {
            var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, you can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve feedback by id
                FeedbackResponse result = client.Feedback.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeedbackApi.GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<int?>**](int?.md)|  | 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**FeedbackResponse**](FeedbackResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebyid"></a>
# **UpdateById**
> FeedbackResponse UpdateById (long? id, string body = null, string bodyMimeType = null, string sourceUrl = null, string sourceType = null, string sourceGuid = null, bool? subscribe = null, long? linksSuggestion = null, long? linksUser = null, List<string> includes = null)

# Update a feedback

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class UpdateByIdExample
    {
        private string ApiKey = "some_key";
        private string ApiSecret = "some_secret";
        private string Subdomain = "sub";
        private string Domain = "uservoice.com";

		// Credentials for authenticating as a user
		private string Username = "some.user@uservoice.com";
		private string Password = "Somepassword1234!";

        public void main()
        {
            var client = new ApiClient(subdomain: Subdomain,
									   clientId: ApiKey,
									   domain: Domain,
									   clientSecret: ApiSecret);

			// Authentication takes place on request when a token is not available
			// However, you can explicitly login using the functions below
			//client.Login(ApiKey, ApiSecret);
			//client.LoginAsUser(ApiKey, Username, Password);

            var id = 789;  // long? | 
            var body = body_example;  // string |  (optional) 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional) 
            var sourceUrl = sourceUrl_example;  // string |  (optional) 
            var sourceType = sourceType_example;  // string |  (optional) 
            var sourceGuid = sourceGuid_example;  // string |  (optional) 
            var subscribe = true;  // bool? |  (optional) 
            var linksSuggestion = 789;  // long? |  (optional) 
            var linksUser = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Update a feedback
                FeedbackResponse result = client.Feedback.UpdateById(id, body, bodyMimeType, sourceUrl, sourceType, sourceGuid, subscribe, linksSuggestion, linksUser, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling FeedbackApi.UpdateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **body** | **string**|  | [optional] 
 **bodyMimeType** | **string**|  | [optional] 
 **sourceUrl** | **string**|  | [optional] 
 **sourceType** | **string**|  | [optional] 
 **sourceGuid** | **string**|  | [optional] 
 **subscribe** | **bool?**|  | [optional] 
 **linksSuggestion** | **long?**|  | [optional] 
 **linksUser** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**FeedbackResponse**](FeedbackResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

