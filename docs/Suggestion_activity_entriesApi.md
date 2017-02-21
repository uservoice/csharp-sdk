# UserVoiceSdk.Api.Suggestion_activity_entriesApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**Get**](Suggestion_activity_entriesApi.md#get) | **GET** /admin/suggestion_activity_entries | # List suggestion activity entries


<a name="get"></a>
# **Get**
> SuggestionActivityEntryResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<int?> forum = null, List<int?> user = null, List<int?> suggestion = null, List<string> kind = null, List<string> state = null, bool? spam = null, bool? needsReview = null, DateTime? periodStart = null, DateTime? periodEnd = null, List<int?> creator = null, bool? categoryNone = null, List<int?> category = null, bool? statusNone = null, List<int?> status = null, List<int?> label = null, bool? hasResponse = null, bool? hasSmartvoteScore = null, DateTime? noEngagementSince = null, DateTime? engagementSince = null, List<int?> uncategorizedInForum = null, long? externalAccount = null, List<string> includes = null)

# List suggestion activity entries

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class GetExample
    {
        private string ApiKey = "some_key";
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

            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
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
                SuggestionActivityEntryResponsePaginated result = client.Suggestion_activity_entries.Get(page, perPage, sort, forum, user, suggestion, kind, state, spam, needsReview, periodStart, periodEnd, creator, categoryNone, category, statusNone, status, label, hasResponse, hasSmartvoteScore, noEngagementSince, engagementSince, uncategorizedInForum, externalAccount, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling Suggestion_activity_entriesApi.Get: " + e.Message );
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

