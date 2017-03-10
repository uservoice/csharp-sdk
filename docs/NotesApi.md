# UserVoiceSdk.Api.NotesApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](NotesApi.md#create) | **POST** /admin/notes | # Create a note
[**Get**](NotesApi.md#get) | **GET** /admin/notes | # List notes
[**GetById**](NotesApi.md#getbyid) | **GET** /admin/notes/{id} | # Retrieve notes by id
[**UpdateById**](NotesApi.md#updatebyid) | **PUT** /admin/notes/{id} | # Update a note


<a name="create"></a>
# **Create**
> NoteResponse Create (string body, long? linksSuggestion, string bodyMimeType = null, string attachmentTokens = null, List<string> includes = null)

# Create a note

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
            var linksSuggestion = 789;  // long? | 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional)  (default to text/plain)
            var attachmentTokens = attachmentTokens_example;  // string |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a note
                NoteResponse result = client.Notes.Create(body, linksSuggestion, bodyMimeType, attachmentTokens, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | **string**|  | 
 **linksSuggestion** | **long?**|  | 
 **bodyMimeType** | **string**|  | [optional] [default to text/plain]
 **attachmentTokens** | **string**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**NoteResponse**](NoteResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> NoteResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, long? suggestion = null, List<string> includes = null)

# List notes

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
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var suggestion = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List notes
                NoteResponsePaginated result = client.Notes.Get(page, perPage, sort, suggestion, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.Get: " + e.Message );
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
 **sort** | **string**|  | [optional] [default to -id]
 **suggestion** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**NoteResponsePaginated**](NoteResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> NoteResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve notes by id

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
                // # Retrieve notes by id
                NoteResponse result = client.Notes.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.GetById: " + e.Message );
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

[**NoteResponse**](NoteResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebyid"></a>
# **UpdateById**
> NoteResponse UpdateById (long? id, string body, List<string> includes = null)

# Update a note

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
            var body = body_example;  // string | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Update a note
                NoteResponse result = client.Notes.UpdateById(id, body, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling NotesApi.UpdateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **body** | **string**|  | 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**NoteResponse**](NoteResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

