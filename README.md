# IO.Swagger - the C# library for the Chomp Food &amp; Recipe Database API Documentation

## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. * Get a **Food Data API** key at **[https://chompthis.com/api](https://chompthis.com/api/)**. * Get a **Recipe Data API** key at **[https://chompthis.com/api/recipes](https://chompthis.com/api/recipes/)**.  ### Getting Started   * Subscribe to the **[Food Data API](https://chompthis.com/api/#pricing)** or the **[Recipe Data API](https://chompthis.com/api/recipes/#pricing)**.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Recipe response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/example-recipe-response.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### I'm a Premium subscriber. How do I access the API?   * All Premium subscribers must pass in a unique user ID for each user on their platform that is accessing data from the Chomp API. A user ID can be any string of letters and numbers that you assign to your user. Simply add \"user_id\" as a URL parameter when calling the API. *You must add a \"user_id\" URL parameter to every call you make to ANY endpoint.*     * **Example**        > ```ENDPOINT.php?api_key=API_KEY&code=CODE&user_id=USER_ID```  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Food Data API Subscription Options &raquo;](https://chompthis.com/api/)     * [Recipe Data API Subscription Options &raquo;](https://chompthis.com/api/recipes/)     * [Food Data API Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)     * [Recipe Data API Cost Calculator &raquo;](https://chompthis.com/api/recipes/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0-oas3
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out IO.Swagger.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: ApiKeyAuth
            Configuration.Default.ApiKey.Add("api_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("api_key", "Bearer");

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://chompthis.com/api/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**FoodBrandedBarcodePhpGet**](docs/DefaultApi.md#foodbrandedbarcodephpget) | **GET** /food/branded/barcode.php | Get a branded food item using a barcode
*DefaultApi* | [**FoodBrandedNamePhpGet**](docs/DefaultApi.md#foodbrandednamephpget) | **GET** /food/branded/name.php | Get a branded food item by name
*DefaultApi* | [**FoodBrandedSearchPhpGet**](docs/DefaultApi.md#foodbrandedsearchphpget) | **GET** /food/branded/search.php | Get data for branded food items using various search parameters
*DefaultApi* | [**FoodIngredientSearchPhpGet**](docs/DefaultApi.md#foodingredientsearchphpget) | **GET** /food/ingredient/search.php | Get raw/generic food ingredient item(s)
*DefaultApi* | [**RecipeIdPhpGet**](docs/DefaultApi.md#recipeidphpget) | **GET** /recipe/id.php | Get a recipe by ID
*DefaultApi* | [**RecipeIngredientPhpGet**](docs/DefaultApi.md#recipeingredientphpget) | **GET** /recipe/ingredient.php | Get recipes using a list of ingredients
*DefaultApi* | [**RecipeRandomPhpGet**](docs/DefaultApi.md#reciperandomphpget) | **GET** /recipe/random.php | Get random popular recipes
*DefaultApi* | [**RecipeSearchPhpGet**](docs/DefaultApi.md#recipesearchphpget) | **GET** /recipe/search.php | Get recipes using a title and optional filters

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BrandedFoodObject](docs/BrandedFoodObject.md)
 - [Model.BrandedFoodObjectCountryDetails](docs/BrandedFoodObjectCountryDetails.md)
 - [Model.BrandedFoodObjectDietFlags](docs/BrandedFoodObjectDietFlags.md)
 - [Model.BrandedFoodObjectDietLabels](docs/BrandedFoodObjectDietLabels.md)
 - [Model.BrandedFoodObjectDietLabelsGlutenFree](docs/BrandedFoodObjectDietLabelsGlutenFree.md)
 - [Model.BrandedFoodObjectDietLabelsVegan](docs/BrandedFoodObjectDietLabelsVegan.md)
 - [Model.BrandedFoodObjectDietLabelsVegetarian](docs/BrandedFoodObjectDietLabelsVegetarian.md)
 - [Model.BrandedFoodObjectItems](docs/BrandedFoodObjectItems.md)
 - [Model.BrandedFoodObjectNutrients](docs/BrandedFoodObjectNutrients.md)
 - [Model.BrandedFoodObjectPackage](docs/BrandedFoodObjectPackage.md)
 - [Model.BrandedFoodObjectPackagingPhotos](docs/BrandedFoodObjectPackagingPhotos.md)
 - [Model.BrandedFoodObjectPackagingPhotosFront](docs/BrandedFoodObjectPackagingPhotosFront.md)
 - [Model.BrandedFoodObjectPackagingPhotosIngredients](docs/BrandedFoodObjectPackagingPhotosIngredients.md)
 - [Model.BrandedFoodObjectPackagingPhotosNutrition](docs/BrandedFoodObjectPackagingPhotosNutrition.md)
 - [Model.BrandedFoodObjectServing](docs/BrandedFoodObjectServing.md)
 - [Model.IngredientObject](docs/IngredientObject.md)
 - [Model.IngredientObjectCalorieConversionFactor](docs/IngredientObjectCalorieConversionFactor.md)
 - [Model.IngredientObjectComponents](docs/IngredientObjectComponents.md)
 - [Model.IngredientObjectItems](docs/IngredientObjectItems.md)
 - [Model.IngredientObjectNutrients](docs/IngredientObjectNutrients.md)
 - [Model.IngredientObjectPortions](docs/IngredientObjectPortions.md)
 - [Model.RecipeObject](docs/RecipeObject.md)
 - [Model.RecipeObjectAttributes](docs/RecipeObjectAttributes.md)
 - [Model.RecipeObjectIngredients](docs/RecipeObjectIngredients.md)
 - [Model.RecipeObjectItems](docs/RecipeObjectItems.md)
 - [Model.RecipeObjectMeta](docs/RecipeObjectMeta.md)
 - [Model.RecipeObjectMetaImages](docs/RecipeObjectMetaImages.md)
 - [Model.RecipeObjectNutrients](docs/RecipeObjectNutrients.md)
 - [Model.RecipeObjectNutrientsCalories](docs/RecipeObjectNutrientsCalories.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string

