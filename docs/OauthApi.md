# UservoiceSDK.Api.OauthApi

All URIs are relative to *https://localhost/api/v2*

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
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class GetOauthTokenExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new OauthApi();
            var grantType = grantType_example;  // string | 
            var clientId = clientId_example;  // string | 
            var username = username_example;  // string |  (optional) 
            var password = password_example;  // string |  (optional) 
            var clientSecret = clientSecret_example;  // string |  (optional) 

            try
            {
                // 
                Token result = apiInstance.GetOauthToken(grantType, clientId, username, password, clientSecret);
                Debug.WriteLine(result);
            }
            catch (Exception e)
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

