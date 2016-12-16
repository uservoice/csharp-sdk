# UservoiceSDK.Api.ExternalusersApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDelete**](ExternalusersApi.md#bulkdelete) | **DELETE** /admin/external_users/bulk_delete | # Bulk delete external users by ID
[**BulkDeleteByExternalId**](ExternalusersApi.md#bulkdeletebyexternalid) | **DELETE** /admin/external_users/bulk_delete_by_external_id | # Bulk delete external users by external ID
[**Get**](ExternalusersApi.md#get) | **GET** /admin/external_users | # List external users
[**GetById**](ExternalusersApi.md#getbyid) | **GET** /admin/external_users/{id} | # Retrieve external users by id
[**Import**](ExternalusersApi.md#import) | **POST** /admin/external_users/import | # Import external users


<a name="bulkdelete"></a>
# **BulkDelete**
> ExternalUserResponse BulkDelete (List<int?> ids)

# Bulk delete external users by ID

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class BulkDeleteExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalusersApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                // # Bulk delete external users by ID
                ExternalUserResponse result = apiInstance.BulkDelete(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalusersApi.BulkDelete: " + e.Message );
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
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class BulkDeleteByExternalIdExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ExternalusersApi();
            var externalIds = new List<string>(); // List<string> | 

            try
            {
                // # Bulk delete external users by external ID
                ExternalUserResponse result = apiInstance.BulkDeleteByExternalId(externalIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalusersApi.BulkDeleteByExternalId: " + e.Message );
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
> ExternalUserResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<string> externalId = null, List<string> includes = null)

# List external users

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

            var apiInstance = new ExternalusersApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var externalId = new List<string>(); // List<string> |  (optional) 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List external users
                ExternalUserResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, externalId, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalusersApi.Get: " + e.Message );
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
 **externalId** | [**List<string>**](string.md)|  | [optional] 
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

            var apiInstance = new ExternalusersApi();
            var id = new List<int?>(); // List<int?> | 
            var includes = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # Retrieve external users by id
                ExternalUserResponse result = apiInstance.GetById(id, includes);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalusersApi.GetById: " + e.Message );
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
> ExternalUserResponse Import (List<string> users, string usersIExternalId, string usersIEmail, string usersIAccountExternalId, long? usersIUserId = null, string usersIName = null, DateTime? usersIExternalCreatedAt = null, string usersIIp = null, string usersIType = null, DateTime? usersILastSeenAt = null, long? usersISeenDays = null, string usersI_ = null, string usersIAccountName = null, string usersIAccountPlan = null, long? usersIAccountMrrCents = null, long? usersIAccountLtvCents = null, DateTime? usersIAccountExternalCreatedAt = null, string usersIAccount_ = null)

# Import external users

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

            var apiInstance = new ExternalusersApi();
            var users = new List<string>(); // List<string> | Each element with index i has these fields:
            var usersIExternalId = usersIExternalId_example;  // string | 
            var usersIEmail = usersIEmail_example;  // string | 
            var usersIAccountExternalId = usersIAccountExternalId_example;  // string | 
            var usersIUserId = 789;  // long? |  (optional) 
            var usersIName = usersIName_example;  // string |  (optional) 
            var usersIExternalCreatedAt = 2013-10-20;  // DateTime? |  (optional) 
            var usersIIp = usersIIp_example;  // string |  (optional) 
            var usersIType = usersIType_example;  // string |  (optional) 
            var usersILastSeenAt = 2013-10-20;  // DateTime? |  (optional) 
            var usersISeenDays = 789;  // long? |  (optional) 
            var usersI_ = usersI__example;  // string |  (optional) 
            var usersIAccountName = usersIAccountName_example;  // string |  (optional) 
            var usersIAccountPlan = usersIAccountPlan_example;  // string |  (optional) 
            var usersIAccountMrrCents = 789;  // long? |  (optional) 
            var usersIAccountLtvCents = 789;  // long? |  (optional) 
            var usersIAccountExternalCreatedAt = 2013-10-20;  // DateTime? |  (optional) 
            var usersIAccount_ = usersIAccount__example;  // string |  (optional) 

            try
            {
                // # Import external users
                ExternalUserResponse result = apiInstance.Import(users, usersIExternalId, usersIEmail, usersIAccountExternalId, usersIUserId, usersIName, usersIExternalCreatedAt, usersIIp, usersIType, usersILastSeenAt, usersISeenDays, usersI_, usersIAccountName, usersIAccountPlan, usersIAccountMrrCents, usersIAccountLtvCents, usersIAccountExternalCreatedAt, usersIAccount_);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalusersApi.Import: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **users** | [**List<string>**](string.md)| Each element with index i has these fields: | 
 **usersIExternalId** | **string**|  | 
 **usersIEmail** | **string**|  | 
 **usersIAccountExternalId** | **string**|  | 
 **usersIUserId** | **long?**|  | [optional] 
 **usersIName** | **string**|  | [optional] 
 **usersIExternalCreatedAt** | **DateTime?**|  | [optional] 
 **usersIIp** | **string**|  | [optional] 
 **usersIType** | **string**|  | [optional] 
 **usersILastSeenAt** | **DateTime?**|  | [optional] 
 **usersISeenDays** | **long?**|  | [optional] 
 **usersI_** | **string**|  | [optional] 
 **usersIAccountName** | **string**|  | [optional] 
 **usersIAccountPlan** | **string**|  | [optional] 
 **usersIAccountMrrCents** | **long?**|  | [optional] 
 **usersIAccountLtvCents** | **long?**|  | [optional] 
 **usersIAccountExternalCreatedAt** | **DateTime?**|  | [optional] 
 **usersIAccount_** | **string**|  | [optional] 

### Return type

[**ExternalUserResponse**](ExternalUserResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

