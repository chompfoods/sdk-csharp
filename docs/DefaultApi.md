# IO.Swagger.Api.DefaultApi

All URIs are relative to *https://chompthis.com/api/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**FoodBrandedBarcodePhpGet**](DefaultApi.md#foodbrandedbarcodephpget) | **GET** /food/branded/barcode.php | Get a branded food item using a barcode
[**FoodBrandedNamePhpGet**](DefaultApi.md#foodbrandednamephpget) | **GET** /food/branded/name.php | Get a branded food item by name
[**FoodBrandedSearchPhpGet**](DefaultApi.md#foodbrandedsearchphpget) | **GET** /food/branded/search.php | Get data for branded food items using various search parameters
[**FoodIngredientSearchPhpGet**](DefaultApi.md#foodingredientsearchphpget) | **GET** /food/ingredient/search.php | Get raw/generic food ingredient item(s)
[**RecipeIdPhpGet**](DefaultApi.md#recipeidphpget) | **GET** /recipe/id.php | Get a recipe by ID
[**RecipeIngredientPhpGet**](DefaultApi.md#recipeingredientphpget) | **GET** /recipe/ingredient.php | Get recipes using a list of ingredients
[**RecipeRandomPhpGet**](DefaultApi.md#reciperandomphpget) | **GET** /recipe/random.php | Get random popular recipes
[**RecipeSearchPhpGet**](DefaultApi.md#recipesearchphpget) | **GET** /recipe/search.php | Get recipes using a title and optional filters

<a name="foodbrandedbarcodephpget"></a>
# **FoodBrandedBarcodePhpGet**
> BrandedFoodObject FoodBrandedBarcodePhpGet (string code, string userId = null)

Get a branded food item using a barcode

## Get data for a branded food using the food's UPC/EAN barcode.  **You must have a Food API key to use this endpoint.** Get a [Food API key](https://chompthis.com/api/).  **Example**  > ```https://chompthis.com/api/v2/food/branded/barcode.php?api_key=API_KEY&code=CODE```  **Tips**   * Read our **[Knowledge Base article](https://desk.zoho.com/portal/chompthis/kb/articles/im-having-trouble-getting-matches-for-barcodes-what-can-id-do)** for helpful tips and tricks.   * Perform a [check-digit](https://en.wikipedia.org/wiki/Check_digit#UPC) on the barcode you are using.   * Use a barcode from our website [ChompThis.com](https://chompthis.com/?r=api). Search for a food and use the barcode shown in the search results.   * It is possible that our database contains the food you're looking for, but does not have the same barcode you are using. This can happen if a manufacturer introduces a variation of the same food, or the barcode you got was from a 2 oz bag of chips when our database has the food packaged in a 4 oz bag.   * [Contact us](https://chompthis.com/contact.php?api=y) if you are having trouble. 

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
            var code = code_example;  // string | #### UPC/EAN barcode  **Example** > ```&code=0842234000988``` 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get a branded food item using a barcode
                BrandedFoodObject result = apiInstance.FoodBrandedBarcodePhpGet(code, userId);
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
 **code** | **string**| #### UPC/EAN barcode  **Example** &gt; &#x60;&#x60;&#x60;&amp;code&#x3D;0842234000988&#x60;&#x60;&#x60;  | 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

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
> BrandedFoodObject FoodBrandedNamePhpGet (string name, int? limit = null, int? page = null, string userId = null)

Get a branded food item by name

## Search for branded food items by name.  **You must have a Food API key to use this endpoint.** Get a [Food API key](https://chompthis.com/api/).  **Example** > ```https://chompthis.com/api/v2/food/branded/name.php?api_key=API_KEY&name=NAME```  **Tips**   * Get started by using our **[food lookup tool](https://chompthis.com/api/lookup.php)**.  > This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. **[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription)** if you aren't sure how to upgrade your subscription. 

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
            var name = name_example;  // string | #### Search for branded food items using a general food name keyword. This does not have to exactly match the \"official\" name for the food.  **Example** > ```&name=Starburst``` 
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return. The default value is \"**10**.\"  **Example** > ```&limit=10```  (optional) 
            var page = 56;  // int? | #### This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on. The default value is \"**1**.\"  **Example** > ```&page=1```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get a branded food item by name
                BrandedFoodObject result = apiInstance.FoodBrandedNamePhpGet(name, limit, page, userId);
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
 **name** | **string**| #### Search for branded food items using a general food name keyword. This does not have to exactly match the \&quot;official\&quot; name for the food.  **Example** &gt; &#x60;&#x60;&#x60;&amp;name&#x3D;Starburst&#x60;&#x60;&#x60;  | 
 **limit** | **int?**| #### Set maximum number of records you want the API to return. The default value is \&quot;**10**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;10&#x60;&#x60;&#x60;  | [optional] 
 **page** | **int?**| #### This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on. The default value is \&quot;**1**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;page&#x3D;1&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

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
> BrandedFoodObject FoodBrandedSearchPhpGet (string allergen = null, string brand = null, string category = null, string country = null, string diet = null, string ingredient = null, string keyword = null, string mineral = null, string nutrient = null, string palmOil = null, string trace = null, string vitamin = null, int? limit = null, int? page = null, string userId = null)

Get data for branded food items using various search parameters

## Search for branded food items using various parameters.  **You must have a Food API key to use this endpoint.** Get a [Food API key](https://chompthis.com/api/).  **Example** > ```https://chompthis.com/api/v2/food/branded/search.php?api_key=API_KEY&brand=BRAND&country=COUNTRY&page=1```  **Tips**    * Get started by using the **[Query Builder](https://chompthis.com/api/build.php)**.  > This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. **[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription)** if you aren't sure how to upgrade your subscription. 

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
            var allergen = allergen_example;  // string | #### Filter the search to only include branded foods that contain a specific allergen.  **Example** > ```&allergen=Peanuts```  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var brand = brand_example;  // string | #### Filter the search to only include branded foods that are owned by a specific brand.  **Example** > ```&brand=Starbucks```  (optional) 
            var category = category_example;  // string | #### Filter the search to only include branded foods from a specific category.  **Example** > ```&category=Plant Based Foods```  (optional) 
            var country = country_example;  // string | #### Filter the search to only include branded foods that are sold in a specific country.  **Example** > ```&country=United States```  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var diet = diet_example;  // string | #### Filter the search to only include branded foods that are considered compatible with a specific diet.  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var ingredient = ingredient_example;  // string | #### Filter the search to only include branded foods that contain a specific ingredient.  **Example** > ```&ingredient=Salt```  (optional) 
            var keyword = keyword_example;  // string | #### Filter the search to only include branded foods that are associated with a specific keyword.  **Example** > ```&keyword=Organic```  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var mineral = mineral_example;  // string | #### Filter the search to only include branded foods that contain a specific mineral.  **Example** > ```&mineral=Potassium```  (optional) 
            var nutrient = nutrient_example;  // string | #### Filter the search to only include branded foods that contain a specific nutrient.  **Example** > ```&nutrient=Caffeine```  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var palmOil = palmOil_example;  // string | #### Filter the search to only include branded foods that contain a specific ingredient made using palm oil.  **Example** > ```&palm_oil=E160a Beta Carotene```  (optional) 
            var trace = trace_example;  // string | ### Filter the search to only include branded foods that contain a specific trace ingredient.  **Example** > ```&trace=Tree Nuts```  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  (optional) 
            var vitamin = vitamin_example;  // string | #### Filter the search to only include branded foods that contain a specific vitamin.  **Example** > ```&vitamin=Biotin```  (optional) 
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return. The default value is \"**10**.\"  **Example** > ```&limit=10```  (optional) 
            var page = 56;  // int? | #### This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on. The default value is \"**1**.\"  **Example** > ```&page=1```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get data for branded food items using various search parameters
                BrandedFoodObject result = apiInstance.FoodBrandedSearchPhpGet(allergen, brand, category, country, diet, ingredient, keyword, mineral, nutrient, palmOil, trace, vitamin, limit, page, userId);
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
 **allergen** | **string**| #### Filter the search to only include branded foods that contain a specific allergen.  **Example** &gt; &#x60;&#x60;&#x60;&amp;allergen&#x3D;Peanuts&#x60;&#x60;&#x60;  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **brand** | **string**| #### Filter the search to only include branded foods that are owned by a specific brand.  **Example** &gt; &#x60;&#x60;&#x60;&amp;brand&#x3D;Starbucks&#x60;&#x60;&#x60;  | [optional] 
 **category** | **string**| #### Filter the search to only include branded foods from a specific category.  **Example** &gt; &#x60;&#x60;&#x60;&amp;category&#x3D;Plant Based Foods&#x60;&#x60;&#x60;  | [optional] 
 **country** | **string**| #### Filter the search to only include branded foods that are sold in a specific country.  **Example** &gt; &#x60;&#x60;&#x60;&amp;country&#x3D;United States&#x60;&#x60;&#x60;  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **diet** | **string**| #### Filter the search to only include branded foods that are considered compatible with a specific diet.  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **ingredient** | **string**| #### Filter the search to only include branded foods that contain a specific ingredient.  **Example** &gt; &#x60;&#x60;&#x60;&amp;ingredient&#x3D;Salt&#x60;&#x60;&#x60;  | [optional] 
 **keyword** | **string**| #### Filter the search to only include branded foods that are associated with a specific keyword.  **Example** &gt; &#x60;&#x60;&#x60;&amp;keyword&#x3D;Organic&#x60;&#x60;&#x60;  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **mineral** | **string**| #### Filter the search to only include branded foods that contain a specific mineral.  **Example** &gt; &#x60;&#x60;&#x60;&amp;mineral&#x3D;Potassium&#x60;&#x60;&#x60;  | [optional] 
 **nutrient** | **string**| #### Filter the search to only include branded foods that contain a specific nutrient.  **Example** &gt; &#x60;&#x60;&#x60;&amp;nutrient&#x3D;Caffeine&#x60;&#x60;&#x60;  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **palmOil** | **string**| #### Filter the search to only include branded foods that contain a specific ingredient made using palm oil.  **Example** &gt; &#x60;&#x60;&#x60;&amp;palm_oil&#x3D;E160a Beta Carotene&#x60;&#x60;&#x60;  | [optional] 
 **trace** | **string**| ### Filter the search to only include branded foods that contain a specific trace ingredient.  **Example** &gt; &#x60;&#x60;&#x60;&amp;trace&#x3D;Tree Nuts&#x60;&#x60;&#x60;  **Important Note**: This parameter cannot be used alone. It must be paired with at least 1 additional parameter.  | [optional] 
 **vitamin** | **string**| #### Filter the search to only include branded foods that contain a specific vitamin.  **Example** &gt; &#x60;&#x60;&#x60;&amp;vitamin&#x3D;Biotin&#x60;&#x60;&#x60;  | [optional] 
 **limit** | **int?**| #### Set maximum number of records you want the API to return. The default value is \&quot;**10**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;10&#x60;&#x60;&#x60;  | [optional] 
 **page** | **int?**| #### This is how you paginate the search result. By default, you will see the first 10 records. You must increment the page number to access the next 10 records, and so on. The default value is \&quot;**1**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;page&#x3D;1&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

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
> IngredientObject FoodIngredientSearchPhpGet (string find, int? limit = null, string userId = null)

Get raw/generic food ingredient item(s)

## Get data for a specific ingredient or a specific set of ingredients.  **You must have a Food API key to use this endpoint.** Get a [Food API key](https://chompthis.com/api/).  **Example #1: Single Ingredient** > ```https://chompthis.com/api/v2/food/ingredient/search.php?api_key=API_KEY&find=raw broccoli```  **Example #2: Set of Ingredients** > ```https://chompthis.com/api/v2/food/ingredient/search.php?api_key=API_KEY&find=raw broccoli,mashed potatoes,chicken drumstick```  **Tips**   * Expose ingredient endpoints by using our **[food lookup tool](https://chompthis.com/api/lookup.php)**.  > This API endpoint is only available to Standard and Premium API subscribers. Please consider upgrading your subscription if you are subscribed to the Limited plan. **[Read this](https://desk.zoho.com/portal/chompthis/kb/articles/can-i-upgrade-downgrade-my-subscription)** if you aren't sure how to upgrade your subscription. 

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
            var find = find_example;  // string | Search our database for a single ingredient or a specific set of ingredients.  **Example #1: Single Ingredient** > ```&find=raw broccoli```  **Example #2: Set of Ingredients** > ```&find=raw broccoli,buttermilk waffle,mashed potatoes```  **Important Notes**    * Comma-separated lists cannot contain more than **10 ingredients**. You must perform additional API calls if you are looking up more than 10 ingredients. 
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return, per search term. The default value is \"**1**.\"  **Example** > ```&limit=3```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get raw/generic food ingredient item(s)
                IngredientObject result = apiInstance.FoodIngredientSearchPhpGet(find, limit, userId);
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
 **find** | **string**| Search our database for a single ingredient or a specific set of ingredients.  **Example #1: Single Ingredient** &gt; &#x60;&#x60;&#x60;&amp;find&#x3D;raw broccoli&#x60;&#x60;&#x60;  **Example #2: Set of Ingredients** &gt; &#x60;&#x60;&#x60;&amp;find&#x3D;raw broccoli,buttermilk waffle,mashed potatoes&#x60;&#x60;&#x60;  **Important Notes**    * Comma-separated lists cannot contain more than **10 ingredients**. You must perform additional API calls if you are looking up more than 10 ingredients.  | 
 **limit** | **int?**| #### Set maximum number of records you want the API to return, per search term. The default value is \&quot;**1**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;3&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

### Return type

[**IngredientObject**](IngredientObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="recipeidphpget"></a>
# **RecipeIdPhpGet**
> RecipeObject RecipeIdPhpGet (string id, string userId = null)

Get a recipe by ID

## Get a specific recipe using an ID.  **You must have a Recipe API key to use this endpoint.** Get a [Recipe API key](https://chompthis.com/api/recipes/).  **Example** > ```https://chompthis.com/api/v2/recipe/id.php?api_key=API_KEY&id=RECIPE_ID``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipeIdPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var id = id_example;  // string | #### A recipe ID. Recipe IDs are exposed in the /recipe/search and /recipe/ingredient endpoints.  **Example** > ```&list=tdm_1143_0459d0028fcf8990724785b9e6775037``` 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get a recipe by ID
                RecipeObject result = apiInstance.RecipeIdPhpGet(id, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RecipeIdPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **string**| #### A recipe ID. Recipe IDs are exposed in the /recipe/search and /recipe/ingredient endpoints.  **Example** &gt; &#x60;&#x60;&#x60;&amp;list&#x3D;tdm_1143_0459d0028fcf8990724785b9e6775037&#x60;&#x60;&#x60;  | 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

### Return type

[**RecipeObject**](RecipeObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="recipeingredientphpget"></a>
# **RecipeIngredientPhpGet**
> RecipeObject RecipeIngredientPhpGet (string list, int? limit = null, int? page = null, string userId = null)

Get recipes using a list of ingredients

## Get recipes that include all ingredients from a list.  **You must have a Recipe API key to use this endpoint.** Get a [Recipe API key](https://chompthis.com/api/recipes/).  **Example #1** > ```https://chompthis.com/api/v2/recipe/ingredient.php?api_key=API_KEY&list=INGREDIENT```  **Example #2** > ```https://chompthis.com/api/v2/recipe/ingredient.php?api_key=API_KEY&list=INGREDIENT,INGREDIENT,INGREDIENT``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipeIngredientPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var list = list_example;  // string | #### A single ingredient, or a comma-separated list of up to 3 ingredients. Recipes with each of these ingredients will be returned. **You can pass in up to 3 ingredients at a time.**  **Example** > ```&list=cheese,tomato,milk``` 
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return. The default value is \"**3**.\"  **Example** > ```&limit=3```  (optional) 
            var page = 56;  // int? | #### This is how you paginate the search result. By default, you will see the first 3 records. You must increment the page number to access the next 3 records, and so on. The default value is \"**1**.\"  **Example** > ```&page=1```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get recipes using a list of ingredients
                RecipeObject result = apiInstance.RecipeIngredientPhpGet(list, limit, page, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RecipeIngredientPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **list** | **string**| #### A single ingredient, or a comma-separated list of up to 3 ingredients. Recipes with each of these ingredients will be returned. **You can pass in up to 3 ingredients at a time.**  **Example** &gt; &#x60;&#x60;&#x60;&amp;list&#x3D;cheese,tomato,milk&#x60;&#x60;&#x60;  | 
 **limit** | **int?**| #### Set maximum number of records you want the API to return. The default value is \&quot;**3**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;3&#x60;&#x60;&#x60;  | [optional] 
 **page** | **int?**| #### This is how you paginate the search result. By default, you will see the first 3 records. You must increment the page number to access the next 3 records, and so on. The default value is \&quot;**1**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;page&#x3D;1&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

### Return type

[**RecipeObject**](RecipeObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="reciperandomphpget"></a>
# **RecipeRandomPhpGet**
> RecipeObject RecipeRandomPhpGet (int? limit = null, string userId = null)

Get random popular recipes

## Get random recipes that have instructions and nutrients  **You must have a Recipe API key to use this endpoint.** Get a [Recipe API key](https://chompthis.com/api/recipes/).  **Example** > ```https://chompthis.com/api/v2/recipe/random.php?api_key=API_KEY``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipeRandomPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return. The default value is \"**5**.\"  **Example** > ```&limit=5```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get random popular recipes
                RecipeObject result = apiInstance.RecipeRandomPhpGet(limit, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RecipeRandomPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| #### Set maximum number of records you want the API to return. The default value is \&quot;**5**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;5&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

### Return type

[**RecipeObject**](RecipeObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="recipesearchphpget"></a>
# **RecipeSearchPhpGet**
> RecipeObject RecipeSearchPhpGet (string title, string excludedCuisine = null, string includedCuisine = null, string excludedIngredient = null, string includedIngredient = null, int? nutrientsRequired = null, int? limit = null, int? page = null, string userId = null)

Get recipes using a title and optional filters

## Get recipes using a title and optional filters.  **You must have a Recipe API key to use this endpoint.** Get a [Recipe API key](https://chompthis.com/api/recipes/).  **Example**  > ```https://chompthis.com/api/v2/recipe/search.php?api_key=API_KEY&title=TITLE``` 

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class RecipeSearchPhpGetExample
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.AddApiKey("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("api_key", "Bearer");

            var apiInstance = new DefaultApi();
            var title = title_example;  // string | #### A recipe title  **Example** > ```&title=Banana Bread``` 
            var excludedCuisine = excludedCuisine_example;  // string | #### A specific cuisine you want excluded from results  **Example** > ```&excluded_cuisine=Italian```  (optional) 
            var includedCuisine = includedCuisine_example;  // string | #### A specific cuisine you want included in results  **Example** > ```&included_cuisine=Chinese```  (optional) 
            var excludedIngredient = excludedIngredient_example;  // string | #### Recipes with this ingredient will be excluded from results  **Example** > ```&excluded_ingredient=egg```  (optional) 
            var includedIngredient = includedIngredient_example;  // string | #### Only recipes with this ingredient will be returned  **Example** > ```&included_ingredient=apple```  (optional) 
            var nutrientsRequired = 56;  // int? | #### Optionally require all recipes to include nutrition info. Recipes with, or without, nutrition info are returned by default.  **Example** > ```&nutrients_required=1```  (optional) 
            var limit = 56;  // int? | #### Set maximum number of records you want the API to return. The default value is \"**5**.\"  **Example** > ```&limit=3```  (optional) 
            var page = 56;  // int? | #### This is how you paginate the search result. By default, you will see the first 5 records. You must increment the page number to access the next 5 records, and so on. The default value is \"**1**.\"  **Example** > ```&page=1```  (optional) 
            var userId = userId_example;  // string | #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn't have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** > ```&user_id=fehef8w4ha```  (optional) 

            try
            {
                // Get recipes using a title and optional filters
                RecipeObject result = apiInstance.RecipeSearchPhpGet(title, excludedCuisine, includedCuisine, excludedIngredient, includedIngredient, nutrientsRequired, limit, page, userId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DefaultApi.RecipeSearchPhpGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **title** | **string**| #### A recipe title  **Example** &gt; &#x60;&#x60;&#x60;&amp;title&#x3D;Banana Bread&#x60;&#x60;&#x60;  | 
 **excludedCuisine** | **string**| #### A specific cuisine you want excluded from results  **Example** &gt; &#x60;&#x60;&#x60;&amp;excluded_cuisine&#x3D;Italian&#x60;&#x60;&#x60;  | [optional] 
 **includedCuisine** | **string**| #### A specific cuisine you want included in results  **Example** &gt; &#x60;&#x60;&#x60;&amp;included_cuisine&#x3D;Chinese&#x60;&#x60;&#x60;  | [optional] 
 **excludedIngredient** | **string**| #### Recipes with this ingredient will be excluded from results  **Example** &gt; &#x60;&#x60;&#x60;&amp;excluded_ingredient&#x3D;egg&#x60;&#x60;&#x60;  | [optional] 
 **includedIngredient** | **string**| #### Only recipes with this ingredient will be returned  **Example** &gt; &#x60;&#x60;&#x60;&amp;included_ingredient&#x3D;apple&#x60;&#x60;&#x60;  | [optional] 
 **nutrientsRequired** | **int?**| #### Optionally require all recipes to include nutrition info. Recipes with, or without, nutrition info are returned by default.  **Example** &gt; &#x60;&#x60;&#x60;&amp;nutrients_required&#x3D;1&#x60;&#x60;&#x60;  | [optional] 
 **limit** | **int?**| #### Set maximum number of records you want the API to return. The default value is \&quot;**5**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;limit&#x3D;3&#x60;&#x60;&#x60;  | [optional] 
 **page** | **int?**| #### This is how you paginate the search result. By default, you will see the first 5 records. You must increment the page number to access the next 5 records, and so on. The default value is \&quot;**1**.\&quot;  **Example** &gt; &#x60;&#x60;&#x60;&amp;page&#x3D;1&#x60;&#x60;&#x60;  | [optional] 
 **userId** | **string**| #### **Only required for Premium subscribers.** The unique identifier assigned to each user on your platform. This can be any string of letters or numbers and doesn&#x27;t have to relate to your own database. [Learn more](https://desk.zoho.com/portal/chompthis/en/kb/articles/monthly-active-users)  **Example** &gt; &#x60;&#x60;&#x60;&amp;user_id&#x3D;fehef8w4ha&#x60;&#x60;&#x60;  | [optional] 

### Return type

[**RecipeObject**](RecipeObject.md)

### Authorization

[ApiKeyAuth](../README.md#ApiKeyAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
