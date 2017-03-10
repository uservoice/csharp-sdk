# UserVoiceSdk.Api.External_usersApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDelete**](External_usersApi.md#bulkdelete) | **DELETE** /admin/external_users/bulk_delete | # Bulk delete external users by ID
[**BulkDeleteByExternalId**](External_usersApi.md#bulkdeletebyexternalid) | **DELETE** /admin/external_users/bulk_delete_by_external_id | # Bulk delete external users by external ID
[**Get**](External_usersApi.md#get) | **GET** /admin/external_users | # List external users
[**GetById**](External_usersApi.md#getbyid) | **GET** /admin/external_users/{id} | # Retrieve external users by id
[**Import**](External_usersApi.md#import) | **POST** /admin/external_users/import | # Import external users


<a name="bulkdelete"></a>
# **BulkDelete**
> ExternalUserResponse BulkDelete (List<int?> ids)

# Bulk delete external users by ID

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class BulkDeleteExample
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

            var ids = new List<int?>(); // List<int?> | 

            try
            {
                // # Bulk delete external users by ID
                ExternalUserResponse result = client.External_users.BulkDelete(ids);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_usersApi.BulkDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **ids** | [**List<int?>**](int?.md)|  | 

### Return type

[**ExternalUserResponse**](ExternalUserResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeletebyexternalid"></a>
# **BulkDeleteByExternalId**
> ExternalUserResponse BulkDeleteByExternalId (List<string> externalIds)

# Bulk delete external users by external ID

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class BulkDeleteByExternalIdExample
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

            var externalIds = new List<string>(); // List<string> | 

            try
            {
                // # Bulk delete external users by external ID
                ExternalUserResponse result = client.External_users.BulkDeleteByExternalId(externalIds);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_usersApi.BulkDeleteByExternalId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **externalIds** | [**List<string>**](string.md)|  | 

### Return type

[**ExternalUserResponse**](ExternalUserResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> ExternalUserResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<string> externalId = null, List<int?> user = null, List<string> includes = null)

# List external users

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
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var externalId = new List<string>(); // List<string> |  (optional) 
            var user = new List<int?>(); // List<int?> |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List external users
                ExternalUserResponsePaginated result = client.External_users.Get(page, perPage, sort, externalId, user, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_usersApi.Get: " + e.Message );
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
 **sort** | **string**|  | [optional] [default to -id]
 **externalId** | [**List<string>**](string.md)|  | [optional] 
 **user** | [**List<int?>**](int?.md)|  | [optional] 
 **includes** | [**List<string>**](string.md)|  | [optional] 

### Return type

[**ExternalUserResponsePaginated**](ExternalUserResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> ExternalUserResponse GetById (List<int?> id, List<string> includes = null)

# Retrieve external users by id

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class GetByIdExample
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

            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve external users by id
                ExternalUserResponse result = client.External_users.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_usersApi.GetById: " + e.Message );
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

[**ExternalUserResponse**](ExternalUserResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> ExternalUserResponse Import (List<string> users, string usersIExternalId, string usersIEmail, string usersIAccountExternalId, long? usersIUserId = null, string usersIName = null, DateTime? usersIExternalCreatedAt = null, string usersIIp = null, string usersIType = null, string usersICustomFields = null, string usersIAccountName = null, string usersIAccountPlan = null, long? usersIAccountMrrCents = null, long? usersIAccountLtvCents = null, DateTime? usersIAccountExternalCreatedAt = null, string usersIAccountCustomFields = null)

# Import external users

### Example
```csharp
using System;
using System.Diagnostics;
using UserVoiceSdk.Api;
using UserVoiceSdk.Client;
using UserVoiceSdk.Models;

namespace Example
{
    public class ImportExample
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

            var users = new List<string>(); // List<string> | Each element with index i has these fields:
            var usersIExternalId = usersIExternalId_example;  // string | User ID in your system. Recommended length: 128 or fewer characters.
            var usersIEmail = usersIEmail_example;  // string | Primary way we link the external user to the user's UV profile. Recommended length: 128 or fewer characters.
            var usersIAccountExternalId = usersIAccountExternalId_example;  // string | Account ID in your system; only required if an embedded account is provided. Recommended length: 128 or fewer characters.
            var usersIUserId = 789;  // long? | User's ID in UserVoice. If you pass a UV ID, we will use it to link to an existing UV Profile rather than email. (optional) 
            var usersIName = usersIName_example;  // string | Name of the user. Recommended length: 128 or fewer characters. (optional) 
            var usersIExternalCreatedAt = 2013-10-20;  // DateTime? | Date user was created in your system. (optional) 
            var usersIIp = usersIIp_example;  // string | Defaults to IP address as determined by UserVoice. Recommended length: 128 or fewer characters. (optional) 
            var usersIType = usersIType_example;  // string | Type for the user, e.g. 'admin' or 'owner'. Recommended length: 128 or fewer characters. (optional) 
            var usersICustomFields = usersICustomFields_example;  // string |  (optional) 
            var usersIAccountName = usersIAccountName_example;  // string | Name of the account. Recommended length: 128 or fewer characters. (optional) 
            var usersIAccountPlan = usersIAccountPlan_example;  // string | Plan name of account. Recommended length: 128 or fewer characters. (optional) 
            var usersIAccountMrrCents = 789;  // long? |  (optional) 
            var usersIAccountLtvCents = 789;  // long? |  (optional) 
            var usersIAccountExternalCreatedAt = 2013-10-20;  // DateTime? |  (optional) 
            var usersIAccountCustomFields = usersIAccountCustomFields_example;  // string |  (optional) 

            try
            {
                // # Import external users
                ExternalUserResponse result = client.External_users.Import(users, usersIExternalId, usersIEmail, usersIAccountExternalId, usersIUserId, usersIName, usersIExternalCreatedAt, usersIIp, usersIType, usersICustomFields, usersIAccountName, usersIAccountPlan, usersIAccountMrrCents, usersIAccountLtvCents, usersIAccountExternalCreatedAt, usersIAccountCustomFields);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset));
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt()));
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_usersApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **users** | [**List<string>**](string.md)| Each element with index i has these fields: | 
 **usersIExternalId** | **string**| User ID in your system. Recommended length: 128 or fewer characters. | 
 **usersIEmail** | **string**| Primary way we link the external user to the user&#39;s UV profile. Recommended length: 128 or fewer characters. | 
 **usersIAccountExternalId** | **string**| Account ID in your system; only required if an embedded account is provided. Recommended length: 128 or fewer characters. | 
 **usersIUserId** | **long?**| User&#39;s ID in UserVoice. If you pass a UV ID, we will use it to link to an existing UV Profile rather than email. | [optional] 
 **usersIName** | **string**| Name of the user. Recommended length: 128 or fewer characters. | [optional] 
 **usersIExternalCreatedAt** | **DateTime?**| Date user was created in your system. | [optional] 
 **usersIIp** | **string**| Defaults to IP address as determined by UserVoice. Recommended length: 128 or fewer characters. | [optional] 
 **usersIType** | **string**| Type for the user, e.g. &#39;admin&#39; or &#39;owner&#39;. Recommended length: 128 or fewer characters. | [optional] 
 **usersICustomFields** | **string**|  | [optional] 
 **usersIAccountName** | **string**| Name of the account. Recommended length: 128 or fewer characters. | [optional] 
 **usersIAccountPlan** | **string**| Plan name of account. Recommended length: 128 or fewer characters. | [optional] 
 **usersIAccountMrrCents** | **long?**|  | [optional] 
 **usersIAccountLtvCents** | **long?**|  | [optional] 
 **usersIAccountExternalCreatedAt** | **DateTime?**|  | [optional] 
 **usersIAccountCustomFields** | **string**|  | [optional] 

### Return type

[**ExternalUserResponse**](ExternalUserResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

