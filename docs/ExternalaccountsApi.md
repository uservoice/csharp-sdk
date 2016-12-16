# UservoiceSDK.Api.ExternalaccountsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkDelete**](ExternalaccountsApi.md#bulkdelete) | **DELETE** /admin/external_accounts/bulk_delete | # Bulk delete external accounts by ID
[**BulkDeleteByExternalId**](ExternalaccountsApi.md#bulkdeletebyexternalid) | **DELETE** /admin/external_accounts/bulk_delete_by_external_id | # Bulk delete external accounts by external ID
[**Get**](ExternalaccountsApi.md#get) | **GET** /admin/external_accounts | # List external accounts
[**GetById**](ExternalaccountsApi.md#getbyid) | **GET** /admin/external_accounts/{id} | # Retrieve external accounts by id
[**Import**](ExternalaccountsApi.md#import) | **POST** /admin/external_accounts/import | 


<a name="bulkdelete"></a>
# **BulkDelete**
> ExternalAccountResponse BulkDelete (List<int?> ids)

# Bulk delete external accounts by ID

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

            var apiInstance = new ExternalaccountsApi();
            var ids = new List<int?>(); // List<int?> | 

            try
            {
                // # Bulk delete external accounts by ID
                ExternalAccountResponse result = apiInstance.BulkDelete(ids);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalaccountsApi.BulkDelete: " + e.Message );
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

            var apiInstance = new ExternalaccountsApi();
            var externalIds = new List<string>(); // List<string> | 

            try
            {
                // # Bulk delete external accounts by external ID
                ExternalAccountResponse result = apiInstance.BulkDeleteByExternalId(externalIds);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalaccountsApi.BulkDeleteByExternalId: " + e.Message );
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
> ExternalAccountResponsePaginated Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<string> externalId = null, List<int?> suggestion = null)

# List external accounts

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

            var apiInstance = new ExternalaccountsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -last_active_at)
            var externalId = new List<string>(); // List<string> |  (optional) 
            var suggestion = new List<int?>(); // List<int?> |  (optional) 

            try
            {
                // # List external accounts
                ExternalAccountResponsePaginated result = apiInstance.Get(page, perPage, bulkPerPage, sort, externalId, suggestion);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalaccountsApi.Get: " + e.Message );
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
 **sort** | **string**|  | [optional] [default to -last_active_at]
 **externalId** | [**List<string>**](string.md)|  | [optional] 
 **suggestion** | [**List<int?>**](int?.md)|  | [optional] 

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

            var apiInstance = new ExternalaccountsApi();
            var id = new List<int?>(); // List<int?> | 

            try
            {
                // # Retrieve external accounts by id
                ExternalAccountResponse result = apiInstance.GetById(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalaccountsApi.GetById: " + e.Message );
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
> ExternalAccountResponse Import (List<string> accounts, string accountsIExternalId, string accountsIName = null, string accountsIPlan = null, long? accountsIMrrCents = null, long? accountsILtvCents = null, DateTime? accountsIExternalCreatedAt = null, string accountsI_ = null)



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

            var apiInstance = new ExternalaccountsApi();
            var accounts = new List<string>(); // List<string> | Each element with index i has these fields:
            var accountsIExternalId = accountsIExternalId_example;  // string | 
            var accountsIName = accountsIName_example;  // string |  (optional) 
            var accountsIPlan = accountsIPlan_example;  // string |  (optional) 
            var accountsIMrrCents = 789;  // long? |  (optional) 
            var accountsILtvCents = 789;  // long? |  (optional) 
            var accountsIExternalCreatedAt = 2013-10-20;  // DateTime? |  (optional) 
            var accountsI_ = accountsI__example;  // string |  (optional) 

            try
            {
                // 
                ExternalAccountResponse result = apiInstance.Import(accounts, accountsIExternalId, accountsIName, accountsIPlan, accountsIMrrCents, accountsILtvCents, accountsIExternalCreatedAt, accountsI_);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ExternalaccountsApi.Import: " + e.Message );
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
 **accountsI_** | **string**|  | [optional] 

### Return type

[**ExternalAccountResponse**](ExternalAccountResponse.md)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

