# IO.Swagger - the C# library for the Chomp Food Database API Documentation

__Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API.   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - Branded Food: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)__ API response object.   - Ingredient: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 

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
            var code = code_example;  // string | UPC/EAN barcode  __Example:__ 0842234000988  __Resources:__ [Database search](https://chompthis.com/api/lookup.php)  _Read [this article](https://desk.zoho.com/portal/chompthis/kb/articles/im-having-trouble-getting-matches-for-barcodes-what-can-id-do) for tips and tricks._ 

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

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://chompthis.com/api/v2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DefaultApi* | [**FoodBrandedBarcodePhpGet**](docs/DefaultApi.md#foodbrandedbarcodephpget) | **GET** /food/branded/barcode.php | Get a branded food item using a barcode
*DefaultApi* | [**FoodBrandedIdPhpGet**](docs/DefaultApi.md#foodbrandedidphpget) | **GET** /food/branded/id.php | Get a branded food item using an ID number
*DefaultApi* | [**FoodBrandedNamePhpGet**](docs/DefaultApi.md#foodbrandednamephpget) | **GET** /food/branded/name.php | Get a branded food item by name
*DefaultApi* | [**FoodBrandedSearchPhpGet**](docs/DefaultApi.md#foodbrandedsearchphpget) | **GET** /food/branded/search.php | Get data for branded food items using various search parameters
*DefaultApi* | [**FoodIngredientSearchPhpGet**](docs/DefaultApi.md#foodingredientsearchphpget) | **GET** /food/ingredient/search.php | Get raw/generic food ingredient item(s)

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BrandedFoodObject](docs/BrandedFoodObject.md)
 - [Model.BrandedFoodObjectCalorieConversionFactor](docs/BrandedFoodObjectCalorieConversionFactor.md)
 - [Model.BrandedFoodObjectComponents](docs/BrandedFoodObjectComponents.md)
 - [Model.BrandedFoodObjectCountryDetails](docs/BrandedFoodObjectCountryDetails.md)
 - [Model.BrandedFoodObjectDietFlags](docs/BrandedFoodObjectDietFlags.md)
 - [Model.BrandedFoodObjectDietLabels](docs/BrandedFoodObjectDietLabels.md)
 - [Model.BrandedFoodObjectDietLabelsGlutenFree](docs/BrandedFoodObjectDietLabelsGlutenFree.md)
 - [Model.BrandedFoodObjectDietLabelsVegan](docs/BrandedFoodObjectDietLabelsVegan.md)
 - [Model.BrandedFoodObjectDietLabelsVegetarian](docs/BrandedFoodObjectDietLabelsVegetarian.md)
 - [Model.BrandedFoodObjectItems](docs/BrandedFoodObjectItems.md)
 - [Model.BrandedFoodObjectNutrients](docs/BrandedFoodObjectNutrients.md)
 - [Model.BrandedFoodObjectNutrientsChomp](docs/BrandedFoodObjectNutrientsChomp.md)
 - [Model.BrandedFoodObjectNutrientsUsda](docs/BrandedFoodObjectNutrientsUsda.md)
 - [Model.BrandedFoodObjectPackage](docs/BrandedFoodObjectPackage.md)
 - [Model.BrandedFoodObjectPackagingPhotos](docs/BrandedFoodObjectPackagingPhotos.md)
 - [Model.BrandedFoodObjectPackagingPhotosFront](docs/BrandedFoodObjectPackagingPhotosFront.md)
 - [Model.BrandedFoodObjectPackagingPhotosIngredients](docs/BrandedFoodObjectPackagingPhotosIngredients.md)
 - [Model.BrandedFoodObjectPackagingPhotosNutrition](docs/BrandedFoodObjectPackagingPhotosNutrition.md)
 - [Model.BrandedFoodObjectPortions](docs/BrandedFoodObjectPortions.md)
 - [Model.BrandedFoodObjectServing](docs/BrandedFoodObjectServing.md)
 - [Model.IngredientObject](docs/IngredientObject.md)
 - [Model.IngredientObjectItems](docs/IngredientObjectItems.md)
 - [Model.IngredientObjectNutrients](docs/IngredientObjectNutrients.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="ApiKeyAuth"></a>
### ApiKeyAuth

- **Type**: API key
- **API key parameter name**: api_key
- **Location**: URL query string

