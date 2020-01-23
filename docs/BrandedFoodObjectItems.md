# IO.Swagger.Model.BrandedFoodObjectItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Barcode** | **string** | EAN/UPC barcode | [optional] 
**Name** | **string** | Item name as provided by brand owner or as shown on packaging | [optional] 
**Brand** | **string** | The brand name that owns this item | [optional] 
**Ingredients** | [**BrandedFoodObjectIngredients**](BrandedFoodObjectIngredients.md) |  | [optional] 
**Package** | [**BrandedFoodObjectPackage**](BrandedFoodObjectPackage.md) |  | [optional] 
**Serving** | [**BrandedFoodObjectServing**](BrandedFoodObjectServing.md) |  | [optional] 
**Categories** | **List&lt;string&gt;** |  | [optional] 
**Nutrients** | [**BrandedFoodObjectNutrients**](BrandedFoodObjectNutrients.md) |  | [optional] 
**DietLabels** | [**BrandedFoodObjectDietLabels**](BrandedFoodObjectDietLabels.md) |  | [optional] 
**DietFlags** | [**List&lt;BrandedFoodObjectDietFlags&gt;**](BrandedFoodObjectDietFlags.md) | An array of ingredient objects that were flagged while grading this item for compatibility with each diet | [optional] 
**PackagingPhotos** | [**BrandedFoodObjectPackagingPhotos**](BrandedFoodObjectPackagingPhotos.md) |  | [optional] 
**Allergens** | **List&lt;string&gt;** | An array of ingredients in this item that may cause allergic reactions in people | [optional] 
**BrandList** | **List&lt;string&gt;** | An array of brands we have associated with this item. Some items are sold by more than 1 brand. | [optional] 
**Countries** | **List&lt;string&gt;** | An array of countries where this item is sold | [optional] 
**CountryDetails** | [**BrandedFoodObjectCountryDetails**](BrandedFoodObjectCountryDetails.md) |  | [optional] 
**PalmOilIngredients** | **List&lt;string&gt;** | An array of ingredients made from palm oil | [optional] 
**IngredientList** | **List&lt;string&gt;** | An array of this item&#x27;s ingredients | [optional] 
**HasEnglishIngredients** | **bool?** | A boolean indicating if we have English ingredients for this item | [optional] 
**Minerals** | **List&lt;string&gt;** | An array of minerals that this item contains | [optional] 
**Traces** | **List&lt;string&gt;** | An array of trace ingredients that may be found in this item | [optional] 
**Vitamins** | **List&lt;string&gt;** | An array of vitamins that are found in this item | [optional] 
**Description** | **string** | A description of this item | [optional] 
**Keywords** | **List&lt;string&gt;** | An array of keywords that can be used to describe this item | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

