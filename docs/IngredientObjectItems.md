# IO.Swagger.Model.IngredientObjectItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Item name as provided by brand owner or as shown on packaging | [optional] 
**Categories** | **List&lt;string&gt;** |  | [optional] 
**Nutrients** | [**IngredientObjectNutrients**](IngredientObjectNutrients.md) |  | [optional] 
**CalorieConversionFactor** | [**BrandedFoodObjectCalorieConversionFactor**](BrandedFoodObjectCalorieConversionFactor.md) |  | [optional] 
**ProteinConversionFactor** | [**decimal?**](BigDecimal.md) | The multiplication factor used to calculate protein from nitrogen | [optional] 
**DietLabels** | [**BrandedFoodObjectDietLabels**](BrandedFoodObjectDietLabels.md) |  | [optional] 
**Components** | [**List&lt;IngredientObjectComponents&gt;**](IngredientObjectComponents.md) | An array of objects containing the constituent parts of a food (e.g. bone is a component of meat) | [optional] 
**Portions** | [**List&lt;IngredientObjectPortions&gt;**](IngredientObjectPortions.md) | An array of objects containing information on discrete amounts of a food found in this item | [optional] 
**CommonNames** | **string** | Common names associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;) | [optional] 
**Description** | **string** | A description of this item | [optional] 
**Footnote** | **string** | Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

