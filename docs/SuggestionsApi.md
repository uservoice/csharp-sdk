# UservoiceSDK.Api.SuggestionsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ApproveById**](SuggestionsApi.md#approvebyid) | **PUT** /admin/suggestions/{id}/approve | 
[**ConvertToTicketById**](SuggestionsApi.md#converttoticketbyid) | **PUT** /admin/suggestions/{id}/convert_to_ticket | 
[**Create**](SuggestionsApi.md#create) | **POST** /admin/suggestions | # Create a suggestion
[**DeleteById**](SuggestionsApi.md#deletebyid) | **DELETE** /admin/suggestions/{id} | # Delete a suggestion
[**Get**](SuggestionsApi.md#get) | **GET** /admin/suggestions | # List suggestions  Returns a paginated list of suggestions.
[**GetById**](SuggestionsApi.md#getbyid) | **GET** /admin/suggestions/{id} | # Retrieve suggestions by id
[**Import**](SuggestionsApi.md#import) | **POST** /admin/suggestions/import | # Create a suggestion
[**PublishById**](SuggestionsApi.md#publishbyid) | **PUT** /admin/suggestions/{id}/publish | 
[**SpamById**](SuggestionsApi.md#spambyid) | **PUT** /admin/suggestions/{id}/spam | 
[**UnremoveById**](SuggestionsApi.md#unremovebyid) | **PUT** /admin/suggestions/{id}/unremove | 
[**UpdateById**](SuggestionsApi.md#updatebyid) | **PUT** /admin/suggestions/{id} | # Update a suggestion


<a name="approvebyid"></a>
# **ApproveById**
> SuggestionResponse ApproveById (long? id, List<string> includes = null)



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

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                SuggestionResponse result = apiInstance.ApproveById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.ApproveById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="converttoticketbyid"></a>
# **ConvertToTicketById**
> SuggestionResponse ConvertToTicketById (long? id, List<string> includes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class ConvertToTicketByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                SuggestionResponse result = apiInstance.ConvertToTicketById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.ConvertToTicketById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="create"></a>
# **Create**
> SuggestionResponse Create (string title, long? linksForum, string body = null, string bodyMimeType = null, string attachmentTokens = null, long? linksCategory = null, long? linksStatus = null, List<string> includes = null)

# Create a suggestion

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

            var apiInstance = new SuggestionsApi();
            var title = title_example;  // string | 
            var linksForum = 789;  // long? | 
            var body = body_example;  // string |  (optional) 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional)  (default to text/plain)
            var attachmentTokens = attachmentTokens_example;  // string |  (optional) 
            var linksCategory = 789;  // long? |  (optional) 
            var linksStatus = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a suggestion
                SuggestionResponse result = apiInstance.Create(title, linksForum, body, bodyMimeType, attachmentTokens, linksCategory, linksStatus, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**|  | 
 **linksForum** | **long?**|  | 
 **body** | **string**|  | [optional] 
 **bodyMimeType** | **string**|  | [optional] [default to text/plain]
 **attachmentTokens** | **string**|  | [optional] 
 **linksCategory** | **long?**|  | [optional] 
 **linksStatus** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyid"></a>
# **DeleteById**
> SuggestionResponse DeleteById (long? id, List<string> includes = null)

# Delete a suggestion

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

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Delete a suggestion
                SuggestionResponse result = apiInstance.DeleteById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.DeleteById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> SuggestionResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> forum = null, List<int?> creator = null, List<int?> uncategorizedInForum = null, bool? categoryNone = null, List<int?> category = null, bool? statusNone = null, List<int?> status = null, List<string> state = null, List<int?> label = null, List<int?> supporter = null, bool? hasResponse = null, bool? hasSmartvoteScore = null, DateTime? noEngagementSince = null, DateTime? engagementSince = null, DateTime? periodStart = null, DateTime? periodEnd = null, string q = null, List<string> includes = null)

# List suggestions  Returns a paginated list of suggestions.

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

            var apiInstance = new SuggestionsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var forum = new List<int?>(); // List<int?> |  (optional) 
            var creator = new List<int?>(); // List<int?> |  (optional) 
            var uncategorizedInForum = new List<int?>(); // List<int?> |  (optional) 
            var categoryNone = true;  // bool? |  (optional) 
            var category = new List<int?>(); // List<int?> |  (optional) 
            var statusNone = true;  // bool? |  (optional) 
            var status = new List<int?>(); // List<int?> |  (optional) 
            var state = new List<string>(); // List<string> |  (optional) 
            var label = new List<int?>(); // List<int?> |  (optional) 
            var supporter = new List<int?>(); // List<int?> |  (optional) 
            var hasResponse = true;  // bool? |  (optional) 
            var hasSmartvoteScore = true;  // bool? |  (optional) 
            var noEngagementSince = 2013-10-20;  // DateTime? |  (optional) 
            var engagementSince = 2013-10-20;  // DateTime? |  (optional) 
            var periodStart = 2013-10-20;  // DateTime? |  (optional) 
            var periodEnd = 2013-10-20;  // DateTime? |  (optional) 
            var q = q_example;  // string |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List suggestions  Returns a paginated list of suggestions.
                SuggestionResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, forum, creator, uncategorizedInForum, categoryNone, category, statusNone, status, state, label, supporter, hasResponse, hasSmartvoteScore, noEngagementSince, engagementSince, periodStart, periodEnd, q, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.Get: " + e.Message );
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
 **forum** | [**List<int?>**](int?.md)|  | [optional] 
 **creator** | [**List<int?>**](int?.md)|  | [optional] 
 **uncategorizedInForum** | [**List<int?>**](int?.md)|  | [optional] 
 **categoryNone** | **bool?**|  | [optional] 
 **category** | [**List<int?>**](int?.md)|  | [optional] 
 **statusNone** | **bool?**|  | [optional] 
 **status** | [**List<int?>**](int?.md)|  | [optional] 
 **state** | [**List<string>**](string.md)|  | [optional] 
 **label** | [**List<int?>**](int?.md)|  | [optional] 
 **supporter** | [**List<int?>**](int?.md)|  | [optional] 
 **hasResponse** | **bool?**|  | [optional] 
 **hasSmartvoteScore** | **bool?**|  | [optional] 
 **noEngagementSince** | **DateTime?**|  | [optional] 
 **engagementSince** | **DateTime?**|  | [optional] 
 **periodStart** | **DateTime?**|  | [optional] 
 **periodEnd** | **DateTime?**|  | [optional] 
 **q** | **string**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SuggestionResponsePaginated**](SuggestionResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> SuggestionResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve suggestions by id

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

            var apiInstance = new SuggestionsApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve suggestions by id
                SuggestionResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.GetById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> SuggestionResponse Import (string title, long? linksForum, string body = null, string bodyMimeType = null, string userName = null, string userEmail = null, string state = null, string attachmentTokens = null, long? linksUser = null, long? linksCategory = null, long? linksStatus = null, List<string> includes = null)

# Create a suggestion

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class ImportExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuggestionsApi();
            var title = title_example;  // string | 
            var linksForum = 789;  // long? | 
            var body = body_example;  // string |  (optional) 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional)  (default to text/plain)
            var userName = userName_example;  // string |  (optional) 
            var userEmail = userEmail_example;  // string |  (optional) 
            var state = state_example;  // string |  (optional)  (default to approved)
            var attachmentTokens = attachmentTokens_example;  // string |  (optional) 
            var linksUser = 789;  // long? |  (optional) 
            var linksCategory = 789;  // long? |  (optional) 
            var linksStatus = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Create a suggestion
                SuggestionResponse result = apiInstance.Import(title, linksForum, body, bodyMimeType, userName, userEmail, state, attachmentTokens, linksUser, linksCategory, linksStatus, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**|  | 
 **linksForum** | **long?**|  | 
 **body** | **string**|  | [optional] 
 **bodyMimeType** | **string**|  | [optional] [default to text/plain]
 **userName** | **string**|  | [optional] 
 **userEmail** | **string**|  | [optional] 
 **state** | **string**|  | [optional] [default to approved]
 **attachmentTokens** | **string**|  | [optional] 
 **linksUser** | **long?**|  | [optional] 
 **linksCategory** | **long?**|  | [optional] 
 **linksStatus** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="publishbyid"></a>
# **PublishById**
> SuggestionResponse PublishById (long? id, List<string> includes = null)



### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class PublishByIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                SuggestionResponse result = apiInstance.PublishById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.PublishById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="spambyid"></a>
# **SpamById**
> SuggestionResponse SpamById (long? id, List<string> includes = null)



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

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                SuggestionResponse result = apiInstance.SpamById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.SpamById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="unremovebyid"></a>
# **UnremoveById**
> SuggestionResponse UnremoveById (long? id, List<string> includes = null)



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

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // 
                SuggestionResponse result = apiInstance.UnremoveById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.UnremoveById: " + e.Message );
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

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebyid"></a>
# **UpdateById**
> SuggestionResponse UpdateById (long? id, string title = null, string body = null, string bodyMimeType = null, string attachmentTokens = null, long? linksForum = null, long? linksCategory = null, long? linksStatus = null, List<string> includes = null)

# Update a suggestion

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

            var apiInstance = new SuggestionsApi();
            var id = 789;  // long? | 
            var title = title_example;  // string |  (optional) 
            var body = body_example;  // string |  (optional) 
            var bodyMimeType = bodyMimeType_example;  // string |  (optional) 
            var attachmentTokens = attachmentTokens_example;  // string |  (optional) 
            var linksForum = 789;  // long? |  (optional) 
            var linksCategory = 789;  // long? |  (optional) 
            var linksStatus = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Update a suggestion
                SuggestionResponse result = apiInstance.UpdateById(id, title, body, bodyMimeType, attachmentTokens, linksForum, linksCategory, linksStatus, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionsApi.UpdateById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 
 **title** | **string**|  | [optional] 
 **body** | **string**|  | [optional] 
 **bodyMimeType** | **string**|  | [optional] 
 **attachmentTokens** | **string**|  | [optional] 
 **linksForum** | **long?**|  | [optional] 
 **linksCategory** | **long?**|  | [optional] 
 **linksStatus** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SuggestionResponse**](SuggestionResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

