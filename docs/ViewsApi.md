# UservoiceSDK.Api.ViewsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](ViewsApi.md#create) | **POST** /admin/views | # Create a view
[**DeleteById**](ViewsApi.md#deletebyid) | **DELETE** /admin/views/{id} | # Delete a view
[**Get**](ViewsApi.md#get) | **GET** /admin/views | # List views
[**GetById**](ViewsApi.md#getbyid) | **GET** /admin/views/{id} | # Retrieve views by id
[**UpdateById**](ViewsApi.md#updatebyid) | **PUT** /admin/views/{id} | # Update a view


<a name="create"></a>
# **Create**
> ViewResponse Create (string kind, string name = null, string subKind = null, string _params = null, bool? subscribed = null, string subscriptionParams = null, long? linksSuggestion = null, long? linksSmartvoteExperiment = null, long? linksUser = null, List<string> includes = null)

# Create a view

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

            var apiInstance = new ViewsApi();
            var kind = kind_example;  // string | 
            var name = name_example;  // string |  (optional) 
            var subKind = subKind_example;  // string |  (optional) 
            var _params = _params_example;  // string |  (optional) 
            var subscribed = true;  // bool? |  (optional)  (default to false)
            var subscriptionParams = subscriptionParams_example;  // string |  (optional) 
            var linksSuggestion = 789;  // long? |  (optional) 
            var linksSmartvoteExperiment = 789;  // long? |  (optional) 
            var linksUser = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a view
                ViewResponse result = apiInstance.Create(kind, name, subKind, _params, subscribed, subscriptionParams, linksSuggestion, linksSmartvoteExperiment, linksUser, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **kind** | **string**|  | 
 **name** | **string**|  | [optional] 
 **subKind** | **string**|  | [optional] 
 **_params** | **string**|  | [optional] 
 **subscribed** | **bool?**|  | [optional] [default to false]
 **subscriptionParams** | **string**|  | [optional] 
 **linksSuggestion** | **long?**|  | [optional] 
 **linksSmartvoteExperiment** | **long?**|  | [optional] 
 **linksUser** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**ViewResponse**](ViewResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyid"></a>
# **DeleteById**
> ViewResponse DeleteById (long? id, List<string> includes = null)

# Delete a view

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class DeleteByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ViewsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Delete a view
                ViewResponse result = apiInstance.DeleteById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.DeleteById: " + e.Message );
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

[**ViewResponse**](ViewResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> ViewResponsePaginated Get (long? user, long? page = null, long? perPage = null, long? bulkPerPage = null, List<string> kind = null, string sort = null, List<string> includes = null)

# List views

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

            var apiInstance = new ViewsApi();
            var user = 789;  // long? | 
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var kind = new List<string>(); // List<string> |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -position)
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List views
                ViewResponsePaginated result = apiInstance.Get(user, page, perPage, bulkPerPage, kind, sort, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.Get: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **user** | **long?**|  | 
 **page** | **long?**|  | [optional] [default to 1]
 **perPage** | **long?**|  | [optional] [default to 20]
 **bulkPerPage** | **long?**|  | [optional] 
 **kind** | [**List<string>**](string.md)|  | [optional] 
 **sort** | **string**|  | [optional] [default to -position]
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**ViewResponsePaginated**](ViewResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> ViewResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve views by id

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

            var apiInstance = new ViewsApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve views by id
                ViewResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.GetById: " + e.Message );
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

[**ViewResponse**](ViewResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebyid"></a>
# **UpdateById**
> ViewResponse UpdateById (long? id, string name = null, bool? subscribed = null, string subscriptionParams = null, string _params = null, long? position = null, List<string> includes = null)

# Update a view

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class UpdateByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ViewsApi();
            var id = 789;  // long? | 
            var name = name_example;  // string |  (optional) 
            var subscribed = true;  // bool? |  (optional) 
            var subscriptionParams = subscriptionParams_example;  // string |  (optional) 
            var _params = _params_example;  // string |  (optional) 
            var position = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Update a view
                ViewResponse result = apiInstance.UpdateById(id, name, subscribed, subscriptionParams, _params, position, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ViewsApi.UpdateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **name** | **string**|  | [optional] 
 **subscribed** | **bool?**|  | [optional] 
 **subscriptionParams** | **string**|  | [optional] 
 **_params** | **string**|  | [optional] 
 **position** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**ViewResponse**](ViewResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

