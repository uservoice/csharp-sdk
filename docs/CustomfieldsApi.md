# UservoiceSDK.Api.CustomfieldsApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Create**](CustomfieldsApi.md#create) | **POST** /admin/custom_fields | # Create a custom field
[**DeleteById**](CustomfieldsApi.md#deletebyid) | **DELETE** /admin/custom_fields/{id} | # Delete a custom field
[**Get**](CustomfieldsApi.md#get) | **GET** /admin/custom_fields | # List custom fields
[**GetById**](CustomfieldsApi.md#getbyid) | **GET** /admin/custom_fields/{id} | # Retrieve custom fields by id
[**UpdateById**](CustomfieldsApi.md#updatebyid) | **PUT** /admin/custom_fields/{id} | # Update a custom field


<a name="create"></a>
# **Create**
> void Create (string name, string key, string fieldType, string objectType)

# Create a custom field

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

            var apiInstance = new CustomfieldsApi();
            var name = name_example;  // string | 
            var key = key_example;  // string | 
            var fieldType = fieldType_example;  // string | 
            var objectType = objectType_example;  // string | 

            try
            {
                // # Create a custom field
                apiInstance.Create(name, key, fieldType, objectType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomfieldsApi.Create: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**|  | 
 **key** | **string**|  | 
 **fieldType** | **string**|  | 
 **objectType** | **string**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletebyid"></a>
# **DeleteById**
> void DeleteById (long? id)

# Delete a custom field

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

            var apiInstance = new CustomfieldsApi();
            var id = 789;  // long? | 

            try
            {
                // # Delete a custom field
                apiInstance.DeleteById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomfieldsApi.DeleteById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **long?**|  | 

### Return type

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="get"></a>
# **Get**
> void Get (long? page = null, long? perPage = null, long? bulkPerPage = null, string sort = null, List<string> objectType = null, List<string> key = null)

# List custom fields

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

            var apiInstance = new CustomfieldsApi();
            var page = 789;  // long? |  (optional)  (default to 1)
            var perPage = 789;  // long? |  (optional)  (default to 20)
            var bulkPerPage = 789;  // long? |  (optional) 
            var sort = sort_example;  // string |  (optional)  (default to -id)
            var objectType = new List<string>(); // List<string> |  (optional) 
            var key = new List<string>(); // List<string> |  (optional) 

            try
            {
                // # List custom fields
                apiInstance.Get(page, perPage, bulkPerPage, sort, objectType, key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomfieldsApi.Get: " + e.Message );
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
 **objectType** | [**List<string>**](string.md)|  | [optional] 
 **key** | [**List<string>**](string.md)|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbyid"></a>
# **GetById**
> void GetById (List<int?> id)

# Retrieve custom fields by id

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

            var apiInstance = new CustomfieldsApi();
            var id = new List<int?>(); // List<int?> | 

            try
            {
                // # Retrieve custom fields by id
                apiInstance.GetById(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomfieldsApi.GetById: " + e.Message );
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

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatebyid"></a>
# **UpdateById**
> void UpdateById (long? id, string name = null, string key = null)

# Update a custom field

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

            var apiInstance = new CustomfieldsApi();
            var id = 789;  // long? | 
            var name = name_example;  // string |  (optional) 
            var key = key_example;  // string |  (optional) 

            try
            {
                // # Update a custom field
                apiInstance.UpdateById(id, name, key);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CustomfieldsApi.UpdateById: " + e.Message );
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
 **key** | **string**|  | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

