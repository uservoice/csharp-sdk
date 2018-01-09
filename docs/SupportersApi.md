# UserVoiceSdk.Api.SupportersApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SupportersApi.md#get) | **GET** /admin/supporters | # List supporters
[**GetById**](SupportersApi.md#getbyid) | **GET** /admin/supporters/{id} | # Retrieve supporters by id


<a name="get"></a>
# **Get**
> SupporterResponsePaginated Get (long? page = null, long? perPage = null, string pageToken = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)

# List supporters

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
            var pageToken = pageToken_example;  // string |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var suggestion = new List<int?>(); // List<int?> |  (optional) 
            var user = new List<int?>(); // List<int?> |  (optional) 
            var legit = true;  // bool? |  (optional) 
            var forum = new List<int?>(); // List<int?> |  (optional) 
            var periodStart = 2013-10-20;  // DateTime? |  (optional) 
            var periodEnd = 2013-10-20;  // DateTime? |  (optional) 
            var anonymous = true;  // bool? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List supporters
                SupporterResponsePaginated result = client.Supporters.Get(page, perPage, pageToken, sort, suggestion, user, legit, forum, periodStart, periodEnd, anonymous, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SupportersApi.Get: " + e.Message );
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
 **pageToken** | **string**|  | [optional] 
 **sort** | **string**|  | [optional] [default to -id]
 **suggestion** | [**List<int?>**](int?.md)|  | [optional] 
 **user** | [**List<int?>**](int?.md)|  | [optional] 
 **legit** | **bool?**|  | [optional] 
 **forum** | [**List<int?>**](int?.md)|  | [optional] 
 **periodStart** | **DateTime?**|  | [optional] 
 **periodEnd** | **DateTime?**|  | [optional] 
 **anonymous** | **bool?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SupporterResponsePaginated**](SupporterResponsePaginated.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials), [oauth2_password](../README.md#oauth2_password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> SupporterResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve supporters by id

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
                // # Retrieve supporters by id
                SupporterResponse result = client.Supporters.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling SupportersApi.GetById: " + e.Message );
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

[**SupporterResponse**](SupporterResponse.md)

### Authorization

[oauth2_client_credentials](../README.md#oauth2_client_credentials), [oauth2_password](../README.md#oauth2_password)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

