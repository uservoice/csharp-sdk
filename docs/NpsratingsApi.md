# UservoiceSDK.Api.NpsratingsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](NpsratingsApi.md#create) | **POST** /admin/nps_ratings | # Create a nps rating
[**Get**](NpsratingsApi.md#get) | **GET** /admin/nps_ratings | # List nps ratings
[**GetById**](NpsratingsApi.md#getbyid) | **GET** /admin/nps_ratings/{id} | # Retrieve nps ratings by id


<a name="create"></a>
# **Create**
> NPSRatingResponse Create (long? rating, long? linksUser, string prompt = null, string body = null, DateTime? date = null, List<string> includes = null)

# Create a nps rating

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

            var apiInstance = new NpsratingsApi();
            var rating = 789;  // long? | 
            var linksUser = 789;  // long? | 
            var prompt = prompt_example;  // string |  (optional) 
            var body = body_example;  // string |  (optional) 
            var date = 2013-10-20;  // DateTime? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a nps rating
                NPSRatingResponse result = apiInstance.Create(rating, linksUser, prompt, body, date, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NpsratingsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **rating** | **long?**|  | 
 **linksUser** | **long?**|  | 
 **prompt** | **string**|  | [optional] 
 **body** | **string**|  | [optional] 
 **date** | **DateTime?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**NPSRatingResponse**](NPSRatingResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> NPSRatingResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, DateTime? periodStart = null, DateTime? periodEnd = null, List<int?> user = null, List<int?> ticket = null, List<string> includes = null)

# List nps ratings

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

            var apiInstance = new NpsratingsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var periodStart = 2013-10-20;  // DateTime? |  (optional) 
            var periodEnd = 2013-10-20;  // DateTime? |  (optional) 
            var user = new List<int?>(); // List<int?> |  (optional) 
            var ticket = new List<int?>(); // List<int?> |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List nps ratings
                NPSRatingResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, periodStart, periodEnd, user, ticket, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NpsratingsApi.Get: " + e.Message );
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
 **periodStart** | **DateTime?**|  | [optional] 
 **periodEnd** | **DateTime?**|  | [optional] 
 **user** | [**List<int?>**](int?.md)|  | [optional] 
 **ticket** | [**List<int?>**](int?.md)|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**NPSRatingResponsePaginated**](NPSRatingResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> NPSRatingResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve nps ratings by id

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

            var apiInstance = new NpsratingsApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve nps ratings by id
                NPSRatingResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NpsratingsApi.GetById: " + e.Message );
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

[**NPSRatingResponse**](NPSRatingResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

