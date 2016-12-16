# UservoiceSDK.Api.SupportersApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SupportersApi.md#get) | **GET** /admin/supporters | # List supporters
[**GetById**](SupportersApi.md#getbyid) | **GET** /admin/supporters/{id} | # Retrieve supporters by id


<a name="get"></a>
# **Get**
> SupporterResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> suggestion = null, List<int?> user = null, bool? legit = null, List<int?> forum = null, DateTime? periodStart = null, DateTime? periodEnd = null, bool? anonymous = null, List<string> includes = null)

# List supporters

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

            var apiInstance = new SupportersApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
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
                SupporterResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, suggestion, user, legit, forum, periodStart, periodEnd, anonymous, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
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
 **bulkPerPage** | **long?**|  | [optional] 
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

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
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

            var apiInstance = new SupportersApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve supporters by id
                SupporterResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
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

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

