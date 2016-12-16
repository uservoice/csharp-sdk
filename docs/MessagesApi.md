# UservoiceSDK.Api.MessagesApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](MessagesApi.md#create) | **POST** /admin/messages | # Create a message
[**Get**](MessagesApi.md#get) | **GET** /admin/messages | # List messages
[**GetById**](MessagesApi.md#getbyid) | **GET** /admin/messages/{id} | # Retrieve messages by id


<a name="create"></a>
# **Create**
> MessageResponse Create (string body, long? linksSuggestion, string notificationEmailAddress = null, List<string> includes = null)

# Create a message

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class CreateExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var body = body_example;  // string | 
            var linksSuggestion = 789;  // long? | 
            var notificationEmailAddress = notificationEmailAddress_example;  // string |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a message
                MessageResponse result = apiInstance.Create(body, linksSuggestion, notificationEmailAddress, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.Create: " + e.Message );
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
 **notificationEmailAddress** | **string**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**MessageResponse**](MessageResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> MessageResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<string> includes = null)

# List messages

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class GetExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List messages
                MessageResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.Get: " + e.Message );
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
 **bulkPerPage** | **long?**|  | [optional] 
 **sort** | **string**|  | [optional] [default to -id]
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**MessageResponsePaginated**](MessageResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> MessageResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve messages by id

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class GetByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new MessagesApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve messages by id
                MessageResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MessagesApi.GetById: " + e.Message );
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

[**MessageResponse**](MessageResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

