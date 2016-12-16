# UservoiceSDK.Api.SuggestionactivityentriesApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](SuggestionactivityentriesApi.md#get) | **GET** /admin/suggestion_activity_entries | # List suggestion activity entries


<a name="get"></a>
# **Get**
> SuggestionActivityEntryResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<int?> forum = null, List<int?> user = null, List<int?> suggestion = null, List<string> kind = null, List<string> state = null, bool? spam = null, bool? needsReview = null, DateTime? periodStart = null, DateTime? periodEnd = null, List<int?> creator = null, bool? categoryNone = null, List<int?> category = null, bool? statusNone = null, List<int?> status = null, List<int?> label = null, bool? hasResponse = null, bool? hasSmartvoteScore = null, DateTime? noEngagementSince = null, DateTime? engagementSince = null, List<int?> uncategorizedInForum = null, long? externalAccount = null, List<string> includes = null)

# List suggestion activity entries

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

            var apiInstance = new SuggestionactivityentriesApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -created_at)
            var forum = new List<int?>(); // List<int?> |  (optional) 
            var user = new List<int?>(); // List<int?> |  (optional) 
            var suggestion = new List<int?>(); // List<int?> |  (optional) 
            var kind = new List<string>(); // List<string> |  (optional) 
            var state = new List<string>(); // List<string> |  (optional) 
            var spam = true;  // bool? |  (optional) 
            var needsReview = true;  // bool? |  (optional) 
            var periodStart = 2013-10-20;  // DateTime? |  (optional) 
            var periodEnd = 2013-10-20;  // DateTime? |  (optional) 
            var creator = new List<int?>(); // List<int?> |  (optional) 
            var categoryNone = true;  // bool? |  (optional) 
            var category = new List<int?>(); // List<int?> |  (optional) 
            var statusNone = true;  // bool? |  (optional) 
            var status = new List<int?>(); // List<int?> |  (optional) 
            var label = new List<int?>(); // List<int?> |  (optional) 
            var hasResponse = true;  // bool? |  (optional) 
            var hasSmartvoteScore = true;  // bool? |  (optional) 
            var noEngagementSince = 2013-10-20;  // DateTime? |  (optional) 
            var engagementSince = 2013-10-20;  // DateTime? |  (optional) 
            var uncategorizedInForum = new List<int?>(); // List<int?> |  (optional) 
            var externalAccount = 789;  // long? |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List suggestion activity entries
                SuggestionActivityEntryResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, forum, user, suggestion, kind, state, spam, needsReview, periodStart, periodEnd, creator, categoryNone, category, statusNone, status, label, hasResponse, hasSmartvoteScore, noEngagementSince, engagementSince, uncategorizedInForum, externalAccount, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SuggestionactivityentriesApi.Get: " + e.Message );
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
 **sort** | **string**|  | [optional] [default to -created_at]
 **forum** | [**List<int?>**](int?.md)|  | [optional] 
 **user** | [**List<int?>**](int?.md)|  | [optional] 
 **suggestion** | [**List<int?>**](int?.md)|  | [optional] 
 **kind** | [**List<string>**](string.md)|  | [optional] 
 **state** | [**List<string>**](string.md)|  | [optional] 
 **spam** | **bool?**|  | [optional] 
 **needsReview** | **bool?**|  | [optional] 
 **periodStart** | **DateTime?**|  | [optional] 
 **periodEnd** | **DateTime?**|  | [optional] 
 **creator** | [**List<int?>**](int?.md)|  | [optional] 
 **categoryNone** | **bool?**|  | [optional] 
 **category** | [**List<int?>**](int?.md)|  | [optional] 
 **statusNone** | **bool?**|  | [optional] 
 **status** | [**List<int?>**](int?.md)|  | [optional] 
 **label** | [**List<int?>**](int?.md)|  | [optional] 
 **hasResponse** | **bool?**|  | [optional] 
 **hasSmartvoteScore** | **bool?**|  | [optional] 
 **noEngagementSince** | **DateTime?**|  | [optional] 
 **engagementSince** | **DateTime?**|  | [optional] 
 **uncategorizedInForum** | [**List<int?>**](int?.md)|  | [optional] 
 **externalAccount** | **long?**|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**SuggestionActivityEntryResponsePaginated**](SuggestionActivityEntryResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

