# UservoiceSDK.Api.IdentityApi

All URIs are relative to *https://localhost/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BulkIdentify**](IdentityApi.md#bulkidentify) | **POST** /admin/bulk_identify | # Add or update traits for a batch of users.


<a name="bulkidentify"></a>
# **BulkIdentify**
> void BulkIdentify (List<string> identities, string identitiesIId = null, string identitiesIEmail = null, string identitiesIName = null, long? identitiesICreatedAt = null, string identitiesIType = null, string identitiesIAccountId = null, string identitiesIAccountName = null, long? identitiesIAccountCreatedAt = null, double? identitiesIAccountMonthlyRate = null, double? identitiesIAccountLtv = null, string identitiesIAccountPlan = null)

# Add or update traits for a batch of users.

### Example
```csharp
using System;
using System.Diagnostics;
using UservoiceSDK.Api;
using UservoiceSDK.Client;
using UservoiceSDK.Models;

namespace Example
{
    public class BulkIdentifyExample
    {
        public void main()
        {
            
            // Configure OAuth2 access token for authorization: oauth2_password
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";
            // Configure OAuth2 access token for authorization: oauth2_client_credentials
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new IdentityApi();
            var identities = new List<string>(); // List<string> | Each element with index i has these fields:
            var identitiesIId = identitiesIId_example;  // string | external identifier for this user (optional) 
            var identitiesIEmail = identitiesIEmail_example;  // string | required to match a user in the UserVoice database (optional) 
            var identitiesIName = identitiesIName_example;  // string | user’s real name (optional) 
            var identitiesICreatedAt = 789;  // long? | unix timestamp for the date the user signed up (optional) 
            var identitiesIType = identitiesIType_example;  // string | used for segmenting users by type (optional) 
            var identitiesIAccountId = identitiesIAccountId_example;  // string | external identifier for this user’s account (optional) 
            var identitiesIAccountName = identitiesIAccountName_example;  // string | account name (optional) 
            var identitiesIAccountCreatedAt = 789;  // long? | unix timestamp for the date the account was created (optional) 
            var identitiesIAccountMonthlyRate = 1.2;  // double? | decimal; monthly rate of the account (optional) 
            var identitiesIAccountLtv = 1.2;  // double? | decimal; lifetime value of the account (optional) 
            var identitiesIAccountPlan = identitiesIAccountPlan_example;  // string | plan name for the account (optional) 

            try
            {
                // # Add or update traits for a batch of users.
                apiInstance.BulkIdentify(identities, identitiesIId, identitiesIEmail, identitiesIName, identitiesICreatedAt, identitiesIType, identitiesIAccountId, identitiesIAccountName, identitiesIAccountCreatedAt, identitiesIAccountMonthlyRate, identitiesIAccountLtv, identitiesIAccountPlan);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentityApi.BulkIdentify: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identities** | [**List<string>**](string.md)| Each element with index i has these fields: | 
 **identitiesIId** | **string**| external identifier for this user | [optional] 
 **identitiesIEmail** | **string**| required to match a user in the UserVoice database | [optional] 
 **identitiesIName** | **string**| user’s real name | [optional] 
 **identitiesICreatedAt** | **long?**| unix timestamp for the date the user signed up | [optional] 
 **identitiesIType** | **string**| used for segmenting users by type | [optional] 
 **identitiesIAccountId** | **string**| external identifier for this user’s account | [optional] 
 **identitiesIAccountName** | **string**| account name | [optional] 
 **identitiesIAccountCreatedAt** | **long?**| unix timestamp for the date the account was created | [optional] 
 **identitiesIAccountMonthlyRate** | **double?**| decimal; monthly rate of the account | [optional] 
 **identitiesIAccountLtv** | **double?**| decimal; lifetime value of the account | [optional] 
 **identitiesIAccountPlan** | **string**| plan name for the account | [optional] 

### Return type

void (empty response body)

### Authorization

[oauth2_password](../README.md#oauth2_password), [oauth2_client_credentials](../README.md#oauth2_client_credentials)

### HTTP request headers

 - **Content-Type**: application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

