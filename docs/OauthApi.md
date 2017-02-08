# UserVoiceSdk.Api.OauthApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetOauthToken**](OauthApi.md#getoauthtoken) | **POST** /oauth/token | 


<a name="getoauthtoken"></a>
# **GetOauthToken**
> Token GetOauthToken (string grantType, string clientId, string username = null, string password = null, string clientSecret = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class GetOauthTokenExample
    {
        pprivate string ApiKey = "some_key";
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

            var grantType = grantType_example;  // string | 
            var clientId = clientId_example;  // string | 
            var username = username_example;  // string |  (optional) 
            var password = password_example;  // string |  (optional) 
            var clientSecret = clientSecret_example;  // string |  (optional) 

            try
            {
                // 
                Token result = client.Oauth.GetOauthToken(grantType, clientId, username, password, clientSecret);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OauthApi.GetOauthToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **grantType** | **string**|  | 
 **clientId** | **string**|  | 
 **username** | **string**|  | [optional] 
 **password** | **string**|  | [optional] 
 **clientSecret** | **string**|  | [optional] 

### Return type

[**Token**](Token.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

