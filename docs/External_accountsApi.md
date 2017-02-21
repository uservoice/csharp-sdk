# UserVoiceSdk.Api.External_accountsApi

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDelete**](External_accountsApi.md#bulkdelete) | **DELETE** /admin/external_accounts/bulk_delete | # Bulk delete external accounts by ID
[**BulkDeleteByExternalId**](External_accountsApi.md#bulkdeletebyexternalid) | **DELETE** /admin/external_accounts/bulk_delete_by_external_id | # Bulk delete external accounts by external ID
[**Get**](External_accountsApi.md#get) | **GET** /admin/external_accounts | # List external accounts
[**GetById**](External_accountsApi.md#getbyid) | **GET** /admin/external_accounts/{id} | # Retrieve external accounts by id
[**Import**](External_accountsApi.md#import) | **POST** /admin/external_accounts/import | 


<a name="bulkdelete"></a>
# **BulkDelete**
> ExternalAccountResponse BulkDelete (List<int?> ids)

# Bulk delete external accounts by ID

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
        pprivate string ApiKey = "some_key";
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
                // # Bulk delete external accounts by ID
                ExternalAccountResponse result = client.External_accounts.BulkDelete(ids);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_accountsApi.BulkDelete: " + e.Message );
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

[**ExternalAccountResponse**](ExternalAccountResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="bulkdeletebyexternalid"></a>
# **BulkDeleteByExternalId**
> ExternalAccountResponse BulkDeleteByExternalId (List<string> externalIds)

# Bulk delete external accounts by external ID

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
        pprivate string ApiKey = "some_key";
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
                // # Bulk delete external accounts by external ID
                ExternalAccountResponse result = client.External_accounts.BulkDeleteByExternalId(externalIds);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_accountsApi.BulkDeleteByExternalId: " + e.Message );
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

[**ExternalAccountResponse**](ExternalAccountResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> ExternalAccountResponsePaginated Get (long? page = null, long? perPage = null, string sort = null, List<string> externalId = null, List<int?> suggestion = null, List<int?> feature = null, string q = null)

# List external accounts

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
        pprivate string ApiKey = "some_key";
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
            var sort = sort_example;  // string |  (optional)  (default to -last_active_at)
            var externalId = new List<string>(); // List<string> |  (optional) 
            var suggestion = new List<int?>(); // List<int?> |  (optional) 
            var feature = new List<int?>(); // List<int?> |  (optional) 
            var q = q_example;  // string |  (optional) 

            try
            {
                // # List external accounts
                ExternalAccountResponsePaginated result = client.External_accounts.Get(page, perPage, sort, externalId, suggestion, feature, q);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_accountsApi.Get: " + e.Message );
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
 **sort** | **string**|  | [optional] [default to -last_active_at]
 **externalId** | [**List<string>**](string.md)|  | [optional] 
 **suggestion** | [**List<int?>**](int?.md)|  | [optional] 
 **feature** | [**List<int?>**](int?.md)|  | [optional] 
 **q** | **string**|  | [optional] 

### Return type

[**ExternalAccountResponsePaginated**](ExternalAccountResponsePaginated.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> ExternalAccountResponse GetById (List<int?> id)

# Retrieve external accounts by id

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
        pprivate string ApiKey = "some_key";
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

            try
            {
                // # Retrieve external accounts by id
                ExternalAccountResponse result = client.External_accounts.GetById(id);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_accountsApi.GetById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**List<int?>**](int?.md)|  | 

### Return type

[**ExternalAccountResponse**](ExternalAccountResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="import"></a>
# **Import**
> ExternalAccountResponse Import (List<string> accounts, string accountsIExternalId, string accountsIName = null, string accountsIPlan = null, long? accountsIMrrCents = null, long? accountsILtvCents = null, DateTime? accountsIExternalCreatedAt = null, string accountsICustomFields = null)



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
        pprivate string ApiKey = "some_key";
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

            var accounts = new List<string>(); // List<string> | Each element with index i has these fields:
            var accountsIExternalId = accountsIExternalId_example;  // string | 
            var accountsIName = accountsIName_example;  // string |  (optional) 
            var accountsIPlan = accountsIPlan_example;  // string |  (optional) 
            var accountsIMrrCents = 789;  // long? |  (optional) 
            var accountsILtvCents = 789;  // long? |  (optional) 
            var accountsIExternalCreatedAt = 2013-10-20;  // DateTime? |  (optional) 
            var accountsICustomFields = accountsICustomFields_example;  // string |  (optional) 

            try
            {
                // 
                ExternalAccountResponse result = client.External_accounts.Import(accounts, accountsIExternalId, accountsIName, accountsIPlan, accountsIMrrCents, accountsILtvCents, accountsIExternalCreatedAt, accountsICustomFields);
                Debug.WriteLine(result);
            }
            catch (RateLimitException rle)
            {
                Debug.Print(string.Format("Rate limit exceeded. Limit: {0}, Remaining: {1}, Reset: {2}", client.RateLimiting.Limit, client.RateLimiting.Remaining, client.RateLimiting.Reset);
                Debug.Print(string.Format("Reset in {0} seconds. Reset at {1} UTC", client.RateLimiting.ResetIn(), client.RateLimiting.ResetAt());
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling External_accountsApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accounts** | [**List<string>**](string.md)| Each element with index i has these fields: | 
 **accountsIExternalId** | **string**|  | 
 **accountsIName** | **string**|  | [optional] 
 **accountsIPlan** | **string**|  | [optional] 
 **accountsIMrrCents** | **long?**|  | [optional] 
 **accountsILtvCents** | **long?**|  | [optional] 
 **accountsIExternalCreatedAt** | **DateTime?**|  | [optional] 
 **accountsICustomFields** | **string**|  | [optional] 

### Return type

[**ExternalAccountResponse**](ExternalAccountResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

