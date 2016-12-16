# UservoiceSDK.Api.CommentsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApproveById**](CommentsApi.md#approvebyid) | **PUT** /admin/comments/{id}/approve | 
[**Create**](CommentsApi.md#create) | **POST** /admin/comments | # Create a comment
[**DeleteById**](CommentsApi.md#deletebyid) | **DELETE** /admin/comments/{id} | # Delete a comment
[**Get**](CommentsApi.md#get) | **GET** /admin/comments | # List comments
[**GetById**](CommentsApi.md#getbyid) | **GET** /admin/comments/{id} | # Retrieve comments by id
[**SpamById**](CommentsApi.md#spambyid) | **PUT** /admin/comments/{id}/spam | 
[**UnremoveById**](CommentsApi.md#unremovebyid) | **PUT** /admin/comments/{id}/unremove | 


<a name="approvebyid"></a>
# **ApproveById**
> CommentResponse ApproveById (long? id, List<string> includes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class ApproveByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                CommentResponse result = apiInstance.ApproveById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.ApproveById: " + e.Message );
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

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> CommentResponse Create (string body, long? linksSuggestion, string bodyMimeType = null, List<string> includes = null)

# Create a comment

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

            var apiInstance = new CommentsApi();
            var body = body_example;  // string | 
            var linksSuggestion = 789;  // long? | 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional)  (default to text/plain)
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a comment
                CommentResponse result = apiInstance.Create(body, linksSuggestion, bodyMimeType, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.Create: " + e.Message );
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
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyid"></a>
# **DeleteById**
> CommentResponse DeleteById (long? id, List<string> includes = null)

# Delete a comment

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

            var apiInstance = new CommentsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Delete a comment
                CommentResponse result = apiInstance.DeleteById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.DeleteById: " + e.Message );
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

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> CommentResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<string> state = null, List<string> includes = null)

# List comments

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

            var apiInstance = new CommentsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var state = new List<string>(); // List<string> |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List comments
                CommentResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, state, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.Get: " + e.Message );
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
 **state** | [**List<string>**](string.md)|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**CommentResponsePaginated**](CommentResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> CommentResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve comments by id

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

            var apiInstance = new CommentsApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve comments by id
                CommentResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.GetById: " + e.Message );
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

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spambyid"></a>
# **SpamById**
> CommentResponse SpamById (long? id, List<string> includes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class SpamByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                CommentResponse result = apiInstance.SpamById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.SpamById: " + e.Message );
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

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unremovebyid"></a>
# **UnremoveById**
> CommentResponse UnremoveById (long? id, List<string> includes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class UnremoveByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CommentsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                CommentResponse result = apiInstance.UnremoveById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CommentsApi.UnremoveById: " + e.Message );
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

[**CommentResponse**](CommentResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

