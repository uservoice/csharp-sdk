# UserVoiceSdk.Api.StatusesApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](StatusesApi.md#get) | **GET** /admin/statuses | # List statuses
[**GetById**](StatusesApi.md#getbyid) | **GET** /admin/statuses/{id} | # Retrieve statuses by id


<a name="get"></a>
# **Get**
> StatusResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<string> includes = null)

# List statuses

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
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List statuses
                StatusResponsePaginated result = client.Statuses.Get(page, perPage, sort, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusesApi.Get: " + e.Message );
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
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**StatusResponsePaginated**](StatusResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> StatusResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve statuses by id

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
                // # Retrieve statuses by id
                StatusResponse result = client.Statuses.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling StatusesApi.GetById: " + e.Message );
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

[**StatusResponse**](StatusResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

