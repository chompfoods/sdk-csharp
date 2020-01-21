# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://chompthis.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FoodBrandedBarcodePhpGet**](DefaultApi.md#foodbrandedbarcodephpget) | **GET** /food/branded/barcode.php | Get a branded food item using a barcode
[**FoodBrandedIdPhpGet**](DefaultApi.md#foodbrandedidphpget) | **GET** /food/branded/id.php | Get a branded food item using an ID number
[**FoodBrandedNamePhpGet**](DefaultApi.md#foodbrandednamephpget) | **GET** /food/branded/name.php | Get a branded food item by name
[**FoodBrandedSearchPhpGet**](DefaultApi.md#foodbrandedsearchphpget) | **GET** /food/branded/search.php | Get data for branded food items using various search parameters
[**FoodIngredientSearchPhpGet**](DefaultApi.md#foodingredientsearchphpget) | **GET** /food/ingredient/search.php | Get raw/generic food ingredient item(s)

<a name="foodbrandedbarcodephpget"></a>
# **FoodBrandedBarcodePhpGet**
> BrandedFoodObject FoodBrandedBarcodePhpGet (string code)

Get a branded food item using a barcode

# Get data for a branded food using the food's UPC/EAN barcode.  __Example:__ ```https://chompthis.com/api/v2/food/branded/barcode.php?api_key=API_KEY&code=CODE``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FoodBrandedBarcodePhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var code = code_example;  // string | UPC/EAN barcode  __Example:__ &code=0842234000988  __Tips:__    - Use our [food lookup tool](https://chompthis.com/api/lookup.php).   - Read [this article](https://desk.zoho.com/portal/chompthis/kb/articles/im-having-trouble-getting-matches-for-barcodes-what-can-id-do) for general tips and tricks. 

            try
            {
                // Get a branded food item using a barcode
                BrandedFoodObject result = apiInstance.FoodBrandedBarcodePhpGet(code);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FoodBrandedBarcodePhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **code** | **string**| UPC/EAN barcode  __Example:__ &amp;code&#x3D;0842234000988  __Tips:__    - Use our [food lookup tool](https://chompthis.com/api/lookup.php).   - Read [this article](https://desk.zoho.com/portal/chompthis/kb/articles/im-having-trouble-getting-matches-for-barcodes-what-can-id-do) for general tips and tricks.  | 

### Return type

[**BrandedFoodObject**](BrandedFoodObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="foodbrandedidphpget"></a>
# **FoodBrandedIdPhpGet**
> BrandedFoodObject FoodBrandedIdPhpGet (int? id, string source = null)

Get a branded food item using an ID number

# Get data for a branded food using Chomp's internal ID number.  _Alternatively, set the \"source\" parameter to \"USDA\" and use the food's FDC ID._  __Example:__ ```https://chompthis.com/api/v2/food/branded/id.php?api_key=API_KEY&id=ID``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FoodBrandedIdPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var id = 56;  // int? | The ID number of a branded food item.  __Example #1:__ &id=15  __Example #2:__ &id=FDC_ID&source=USDA  ___Tip:__ Get started by using our  [ood lookup tool](https://chompthis.com/api/lookup.php)._ 
            var source = source_example;  // string | Configure the endpoint to accept food IDs from various data sources. This endpoint defaults to Chomp but can accept FDC IDs.  __Example:__ &source=Chomp  ___Important Note:__ Pass in &source=USDA if you want to look up food items using a USDA FDC ID._  (optional) 

            try
            {
                // Get a branded food item using an ID number
                BrandedFoodObject result = apiInstance.FoodBrandedIdPhpGet(id, source);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FoodBrandedIdPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The ID number of a branded food item.  __Example #1:__ &amp;id&#x3D;15  __Example #2:__ &amp;id&#x3D;FDC_ID&amp;source&#x3D;USDA  ___Tip:__ Get started by using our  [ood lookup tool](https://chompthis.com/api/lookup.php)._  | 
 **source** | **string**| Configure the endpoint to accept food IDs from various data sources. This endpoint defaults to Chomp but can accept FDC IDs.  __Example:__ &amp;source&#x3D;Chomp  ___Important Note:__ Pass in &amp;source&#x3D;USDA if you want to look up food items using a USDA FDC ID._  | [optional] 

### Return type

[**BrandedFoodObject**](BrandedFoodObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="foodbrandednamephpget"></a>
# **FoodBrandedNamePhpGet**
> BrandedFoodObject FoodBrandedNamePhpGet (string name, int? limit = null, int? page = null)

Get a branded food item by name

# Search for branded food items by name.  This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. _[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription) if you aren't sure how to upgrade your subscription._  __Example:__ ```https://chompthis.com/api/v2/food/branded/name.php?api_key=API_KEY&name=NAME``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FoodBrandedNamePhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var name = name_example;  // string | Search for branded food items using a general food name keyword. This does not have to exactly match the \"official\" name for the food.  __Example:__ &name=Starburst  ___Tip:__ Get started by using our [food lookup tool](https://chompthis.com/api/lookup.php)._ 
            var limit = 56;  // int? | Set maximum number of records you want the API to return.  __Example:__ &limit=10  (optional) 
            var page = 56;  // int? | This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on.  __Example__: &page=1  (optional) 

            try
            {
                // Get a branded food item by name
                BrandedFoodObject result = apiInstance.FoodBrandedNamePhpGet(name, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FoodBrandedNamePhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| Search for branded food items using a general food name keyword. This does not have to exactly match the \&quot;official\&quot; name for the food.  __Example:__ &amp;name&#x3D;Starburst  ___Tip:__ Get started by using our [food lookup tool](https://chompthis.com/api/lookup.php)._  | 
 **limit** | **int?**| Set maximum number of records you want the API to return.  __Example:__ &amp;limit&#x3D;10  | [optional] 
 **page** | **int?**| This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on.  __Example__: &amp;page&#x3D;1  | [optional] 

### Return type

[**BrandedFoodObject**](BrandedFoodObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="foodbrandedsearchphpget"></a>
# **FoodBrandedSearchPhpGet**
> BrandedFoodObject FoodBrandedSearchPhpGet (string allergen = null, string brand = null, string category = null, string country = null, string diet = null, string ingredient = null, string keyword = null, string mineral = null, string nutrient = null, string palmOil = null, string trace = null, string vitamin = null, int? limit = null, int? page = null)

Get data for branded food items using various search parameters

# Search for branded food items using various parameters.  This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. _[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription) if you aren't sure how to upgrade your subscription._  __Example:__ ```https://chompthis.com/api/v2/food/branded/search.php?api_key=API_KEY&brand=BRAND&country=COUNTRY&page=1```  ___Tip:__ Get started by using the [Query Builder](https://chompthis.com/api/build.php)._ 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FoodBrandedSearchPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var allergen = allergen_example;  // string | Filter the search to only include branded foods that contain a specific allergen.  __Example__: &allergen=Peanuts  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var brand = brand_example;  // string | Filter the search to only include branded foods that are owned by a specific brand.  __Example__: &brand=Starbucks  (optional) 
            var category = category_example;  // string | Filter the search to only include branded foods from a specific category.  __Example__: &category=Plant Based Foods  (optional) 
            var country = country_example;  // string | Filter the search to only include branded foods that are sold in a specific country.  __Example__: &country=United States  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var diet = diet_example;  // string | Filter the search to only include branded foods that are considered compatible with a specific diet.  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var ingredient = ingredient_example;  // string | Filter the search to only include branded foods that contain a specific ingredient.  __Example__: &ingredient=Salt  (optional) 
            var keyword = keyword_example;  // string | Filter the search to only include branded foods that are associated with a specific keyword.  __Example__: &keyword=Organic  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var mineral = mineral_example;  // string | Filter the search to only include branded foods that contain a specific mineral.  __Example__: &mineral=Potassium  (optional) 
            var nutrient = nutrient_example;  // string | Filter the search to only include branded foods that contain a specific nutrient.  __Example__: &nutrient=Caffeine  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var palmOil = palmOil_example;  // string | Filter the search to only include branded foods that contain a specific ingredient made using palm oil.  __Example__: &palm_oil=E160a Beta Carotene  (optional) 
            var trace = trace_example;  // string | Filter the search to only include branded foods that contain a specific trace ingredient.  __Example__: &trace=Tree Nuts  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  (optional) 
            var vitamin = vitamin_example;  // string | Filter the search to only include branded foods that contain a specific vitamin.  __Example__: &vitamin=Biotin  (optional) 
            var limit = 56;  // int? | Set maximum number of records you want the API to return.  __Example:__ &limit=10  (optional) 
            var page = 56;  // int? | This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on.  __Example__: &page=1  (optional) 

            try
            {
                // Get data for branded food items using various search parameters
                BrandedFoodObject result = apiInstance.FoodBrandedSearchPhpGet(allergen, brand, category, country, diet, ingredient, keyword, mineral, nutrient, palmOil, trace, vitamin, limit, page);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FoodBrandedSearchPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **allergen** | **string**| Filter the search to only include branded foods that contain a specific allergen.  __Example__: &amp;allergen&#x3D;Peanuts  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **brand** | **string**| Filter the search to only include branded foods that are owned by a specific brand.  __Example__: &amp;brand&#x3D;Starbucks  | [optional] 
 **category** | **string**| Filter the search to only include branded foods from a specific category.  __Example__: &amp;category&#x3D;Plant Based Foods  | [optional] 
 **country** | **string**| Filter the search to only include branded foods that are sold in a specific country.  __Example__: &amp;country&#x3D;United States  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **diet** | **string**| Filter the search to only include branded foods that are considered compatible with a specific diet.  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **ingredient** | **string**| Filter the search to only include branded foods that contain a specific ingredient.  __Example__: &amp;ingredient&#x3D;Salt  | [optional] 
 **keyword** | **string**| Filter the search to only include branded foods that are associated with a specific keyword.  __Example__: &amp;keyword&#x3D;Organic  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **mineral** | **string**| Filter the search to only include branded foods that contain a specific mineral.  __Example__: &amp;mineral&#x3D;Potassium  | [optional] 
 **nutrient** | **string**| Filter the search to only include branded foods that contain a specific nutrient.  __Example__: &amp;nutrient&#x3D;Caffeine  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **palmOil** | **string**| Filter the search to only include branded foods that contain a specific ingredient made using palm oil.  __Example__: &amp;palm_oil&#x3D;E160a Beta Carotene  | [optional] 
 **trace** | **string**| Filter the search to only include branded foods that contain a specific trace ingredient.  __Example__: &amp;trace&#x3D;Tree Nuts  ___Important Note:__ This parameter cannot be used alone. It must be paired with at least 1 additional parameter._  | [optional] 
 **vitamin** | **string**| Filter the search to only include branded foods that contain a specific vitamin.  __Example__: &amp;vitamin&#x3D;Biotin  | [optional] 
 **limit** | **int?**| Set maximum number of records you want the API to return.  __Example:__ &amp;limit&#x3D;10  | [optional] 
 **page** | **int?**| This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on.  __Example__: &amp;page&#x3D;1  | [optional] 

### Return type

[**BrandedFoodObject**](BrandedFoodObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="foodingredientsearchphpget"></a>
# **FoodIngredientSearchPhpGet**
> IngredientObject FoodIngredientSearchPhpGet (int? find, bool? list, bool? raw = null, int? limit = null)

Get raw/generic food ingredient item(s)

# Get data for a specific ingredient or a specific set of ingredients.  This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. _[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription) if you aren't sure how to upgrade your subscription._  __Example:__ ```https://chompthis.com/api/v2/ingredient/search.php?api_key=API_KEY&find=STRING/LIST&list=BOOLEAN&raw=BOOLEAN``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class FoodIngredientSearchPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var find = 56;  // int? | Search our database for a single ingredient or a specific set of ingredients.  __Example #1:__ &find=broccoli  __Example #2:__ &find=broccoli,cauliflower,spinach&list=true  __Important List Notes:__    - Set the \"list\" parameter to \"true\" before passing in a comma-separated list of ingredients.   - Comma-separated lists cannot contain more than __15 ingredients__. You must perform additional API calls if you are looking up more than 15 ingredients. 
            var list = true;  // bool? | Setting _&list=true_ will configure this endpoint to allow searching for ingredients using a comma-separated list. By default, this endpoint will __only__ return results for the first ingredient.  __Example:__ &list=true 
            var raw = true;  // bool? | Optionally filter the search result to only include raw ingredients.  __Example:__ &raw=true  (optional) 
            var limit = 56;  // int? | Set maximum number of records you want the API to return, per search term.  __Example:__ &limit=3  (optional) 

            try
            {
                // Get raw/generic food ingredient item(s)
                IngredientObject result = apiInstance.FoodIngredientSearchPhpGet(find, list, raw, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.FoodIngredientSearchPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **find** | **int?**| Search our database for a single ingredient or a specific set of ingredients.  __Example #1:__ &amp;find&#x3D;broccoli  __Example #2:__ &amp;find&#x3D;broccoli,cauliflower,spinach&amp;list&#x3D;true  __Important List Notes:__    - Set the \&quot;list\&quot; parameter to \&quot;true\&quot; before passing in a comma-separated list of ingredients.   - Comma-separated lists cannot contain more than __15 ingredients__. You must perform additional API calls if you are looking up more than 15 ingredients.  | 
 **list** | **bool?**| Setting _&amp;list&#x3D;true_ will configure this endpoint to allow searching for ingredients using a comma-separated list. By default, this endpoint will __only__ return results for the first ingredient.  __Example:__ &amp;list&#x3D;true  | 
 **raw** | **bool?**| Optionally filter the search result to only include raw ingredients.  __Example:__ &amp;raw&#x3D;true  | [optional] 
 **limit** | **int?**| Set maximum number of records you want the API to return, per search term.  __Example:__ &amp;limit&#x3D;3  | [optional] 

### Return type

[**IngredientObject**](IngredientObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
