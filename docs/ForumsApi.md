# UservoiceSDK.Api.ForumsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](ForumsApi.md#get) | **GET** /admin/forums | # List forums
[**GetById**](ForumsApi.md#getbyid) | **GET** /admin/forums/{id} | # Retrieve forums by id


<a name="get"></a>
# **Get**
> ForumResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, bool? open = null, List<string> includes = null)

# List forums

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

            var apiInstance = new ForumsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var open = true;  // bool? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List forums
                ForumResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, open, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumsApi.Get: " + e.Message );
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
 **open** | **bool?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**ForumResponsePaginated**](ForumResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> ForumResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve forums by id

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

            var apiInstance = new ForumsApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve forums by id
                ForumResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ForumsApi.GetById: " + e.Message );
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

[**ForumResponse**](ForumResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

