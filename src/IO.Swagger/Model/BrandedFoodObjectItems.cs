/* 
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// An object containing information for this specific item.
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectItems :  IEquatable<BrandedFoodObjectItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectItems" /> class.
        /// </summary>
        /// <param name="barcode">EAN/UPC barcode.</param>
        /// <param name="name">Item name as provided by brand owner or as shown on packaging.</param>
        /// <param name="brand">The brand name that owns this item.</param>
        /// <param name="ingredients">ingredients.</param>
        /// <param name="package">package.</param>
        /// <param name="serving">serving.</param>
        /// <param name="categories">categories.</param>
        /// <param name="nutrients">nutrients.</param>
        /// <param name="calorieConversionFactor">calorieConversionFactor.</param>
        /// <param name="proteinConversionFactor">The multiplication factor used to calculate protein from nitrogen.</param>
        /// <param name="dietLabels">dietLabels.</param>
        /// <param name="dietFlags">An array of ingredient objects that were flagged while grading this item for compatibility with each diet.</param>
        /// <param name="packagingPhotos">packagingPhotos.</param>
        /// <param name="components">An array of objects containing the constituent parts of a food (e.g. bone is a component of meat).</param>
        /// <param name="portions">An array of objects containing information on discrete amounts of a food found in this item.</param>
        /// <param name="allergens">An array of ingredients in this item that may cause allergic reactions in people.</param>
        /// <param name="brandList">An array of brands we have associated with this item. Some items are sold by more than 1 brand..</param>
        /// <param name="countries">An array of countries where this item is sold.</param>
        /// <param name="countryDetails">countryDetails.</param>
        /// <param name="palmOilIngredients">An array of ingredients made from palm oil.</param>
        /// <param name="ingredientList">An array of this item&#x27;s ingredients.</param>
        /// <param name="hasEnglishIngredients">A boolean indicating if we have English ingredients for this item.</param>
        /// <param name="minerals">An array of minerals that this item contains.</param>
        /// <param name="traces">An array of trace ingredients that may be found in this item.</param>
        /// <param name="vitamins">An array of vitamins that are found in this item.</param>
        /// <param name="description">A description of this item.</param>
        /// <param name="keywords">An array of keywords that can be used to describe this item.</param>
        /// <param name="footnote">Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall..</param>
        public BrandedFoodObjectItems(string barcode = default(string), string name = default(string), string brand = default(string), BrandedFoodObjectIngredients ingredients = default(BrandedFoodObjectIngredients), BrandedFoodObjectPackage package = default(BrandedFoodObjectPackage), BrandedFoodObjectServing serving = default(BrandedFoodObjectServing), List<string> categories = default(List<string>), BrandedFoodObjectNutrients nutrients = default(BrandedFoodObjectNutrients), BrandedFoodObjectCalorieConversionFactor calorieConversionFactor = default(BrandedFoodObjectCalorieConversionFactor), decimal? proteinConversionFactor = default(decimal?), BrandedFoodObjectDietLabels dietLabels = default(BrandedFoodObjectDietLabels), List<BrandedFoodObjectDietFlags> dietFlags = default(List<BrandedFoodObjectDietFlags>), BrandedFoodObjectPackagingPhotos packagingPhotos = default(BrandedFoodObjectPackagingPhotos), List<BrandedFoodObjectComponents> components = default(List<BrandedFoodObjectComponents>), List<BrandedFoodObjectPortions> portions = default(List<BrandedFoodObjectPortions>), List<string> allergens = default(List<string>), List<string> brandList = default(List<string>), List<string> countries = default(List<string>), BrandedFoodObjectCountryDetails countryDetails = default(BrandedFoodObjectCountryDetails), List<string> palmOilIngredients = default(List<string>), List<string> ingredientList = default(List<string>), bool? hasEnglishIngredients = default(bool?), List<string> minerals = default(List<string>), List<string> traces = default(List<string>), List<string> vitamins = default(List<string>), string description = default(string), List<string> keywords = default(List<string>), string footnote = default(string))
        {
            this.Barcode = barcode;
            this.Name = name;
            this.Brand = brand;
            this.Ingredients = ingredients;
            this.Package = package;
            this.Serving = serving;
            this.Categories = categories;
            this.Nutrients = nutrients;
            this.CalorieConversionFactor = calorieConversionFactor;
            this.ProteinConversionFactor = proteinConversionFactor;
            this.DietLabels = dietLabels;
            this.DietFlags = dietFlags;
            this.PackagingPhotos = packagingPhotos;
            this.Components = components;
            this.Portions = portions;
            this.Allergens = allergens;
            this.BrandList = brandList;
            this.Countries = countries;
            this.CountryDetails = countryDetails;
            this.PalmOilIngredients = palmOilIngredients;
            this.IngredientList = ingredientList;
            this.HasEnglishIngredients = hasEnglishIngredients;
            this.Minerals = minerals;
            this.Traces = traces;
            this.Vitamins = vitamins;
            this.Description = description;
            this.Keywords = keywords;
            this.Footnote = footnote;
        }
        
        /// <summary>
        /// EAN/UPC barcode
        /// </summary>
        /// <value>EAN/UPC barcode</value>
        [DataMember(Name="barcode", EmitDefaultValue=false)]
        public string Barcode { get; set; }

        /// <summary>
        /// Item name as provided by brand owner or as shown on packaging
        /// </summary>
        /// <value>Item name as provided by brand owner or as shown on packaging</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The brand name that owns this item
        /// </summary>
        /// <value>The brand name that owns this item</value>
        [DataMember(Name="brand", EmitDefaultValue=false)]
        public string Brand { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public BrandedFoodObjectIngredients Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Package
        /// </summary>
        [DataMember(Name="package", EmitDefaultValue=false)]
        public BrandedFoodObjectPackage Package { get; set; }

        /// <summary>
        /// Gets or Sets Serving
        /// </summary>
        [DataMember(Name="serving", EmitDefaultValue=false)]
        public BrandedFoodObjectServing Serving { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Nutrients
        /// </summary>
        [DataMember(Name="nutrients", EmitDefaultValue=false)]
        public BrandedFoodObjectNutrients Nutrients { get; set; }

        /// <summary>
        /// Gets or Sets CalorieConversionFactor
        /// </summary>
        [DataMember(Name="calorie_conversion_factor", EmitDefaultValue=false)]
        public BrandedFoodObjectCalorieConversionFactor CalorieConversionFactor { get; set; }

        /// <summary>
        /// The multiplication factor used to calculate protein from nitrogen
        /// </summary>
        /// <value>The multiplication factor used to calculate protein from nitrogen</value>
        [DataMember(Name="protein_conversion_factor", EmitDefaultValue=false)]
        public decimal? ProteinConversionFactor { get; set; }

        /// <summary>
        /// Gets or Sets DietLabels
        /// </summary>
        [DataMember(Name="diet_labels", EmitDefaultValue=false)]
        public BrandedFoodObjectDietLabels DietLabels { get; set; }

        /// <summary>
        /// An array of ingredient objects that were flagged while grading this item for compatibility with each diet
        /// </summary>
        /// <value>An array of ingredient objects that were flagged while grading this item for compatibility with each diet</value>
        [DataMember(Name="diet_flags", EmitDefaultValue=false)]
        public List<BrandedFoodObjectDietFlags> DietFlags { get; set; }

        /// <summary>
        /// Gets or Sets PackagingPhotos
        /// </summary>
        [DataMember(Name="packaging_photos", EmitDefaultValue=false)]
        public BrandedFoodObjectPackagingPhotos PackagingPhotos { get; set; }

        /// <summary>
        /// An array of objects containing the constituent parts of a food (e.g. bone is a component of meat)
        /// </summary>
        /// <value>An array of objects containing the constituent parts of a food (e.g. bone is a component of meat)</value>
        [DataMember(Name="components", EmitDefaultValue=false)]
        public List<BrandedFoodObjectComponents> Components { get; set; }

        /// <summary>
        /// An array of objects containing information on discrete amounts of a food found in this item
        /// </summary>
        /// <value>An array of objects containing information on discrete amounts of a food found in this item</value>
        [DataMember(Name="portions", EmitDefaultValue=false)]
        public List<BrandedFoodObjectPortions> Portions { get; set; }

        /// <summary>
        /// An array of ingredients in this item that may cause allergic reactions in people
        /// </summary>
        /// <value>An array of ingredients in this item that may cause allergic reactions in people</value>
        [DataMember(Name="allergens", EmitDefaultValue=false)]
        public List<string> Allergens { get; set; }

        /// <summary>
        /// An array of brands we have associated with this item. Some items are sold by more than 1 brand.
        /// </summary>
        /// <value>An array of brands we have associated with this item. Some items are sold by more than 1 brand.</value>
        [DataMember(Name="brand_list", EmitDefaultValue=false)]
        public List<string> BrandList { get; set; }

        /// <summary>
        /// An array of countries where this item is sold
        /// </summary>
        /// <value>An array of countries where this item is sold</value>
        [DataMember(Name="countries", EmitDefaultValue=false)]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Gets or Sets CountryDetails
        /// </summary>
        [DataMember(Name="country_details", EmitDefaultValue=false)]
        public BrandedFoodObjectCountryDetails CountryDetails { get; set; }

        /// <summary>
        /// An array of ingredients made from palm oil
        /// </summary>
        /// <value>An array of ingredients made from palm oil</value>
        [DataMember(Name="palm_oil_ingredients", EmitDefaultValue=false)]
        public List<string> PalmOilIngredients { get; set; }

        /// <summary>
        /// An array of this item&#x27;s ingredients
        /// </summary>
        /// <value>An array of this item&#x27;s ingredients</value>
        [DataMember(Name="ingredient_list", EmitDefaultValue=false)]
        public List<string> IngredientList { get; set; }

        /// <summary>
        /// A boolean indicating if we have English ingredients for this item
        /// </summary>
        /// <value>A boolean indicating if we have English ingredients for this item</value>
        [DataMember(Name="has_english_ingredients", EmitDefaultValue=false)]
        public bool? HasEnglishIngredients { get; set; }

        /// <summary>
        /// An array of minerals that this item contains
        /// </summary>
        /// <value>An array of minerals that this item contains</value>
        [DataMember(Name="minerals", EmitDefaultValue=false)]
        public List<string> Minerals { get; set; }

        /// <summary>
        /// An array of trace ingredients that may be found in this item
        /// </summary>
        /// <value>An array of trace ingredients that may be found in this item</value>
        [DataMember(Name="traces", EmitDefaultValue=false)]
        public List<string> Traces { get; set; }

        /// <summary>
        /// An array of vitamins that are found in this item
        /// </summary>
        /// <value>An array of vitamins that are found in this item</value>
        [DataMember(Name="vitamins", EmitDefaultValue=false)]
        public List<string> Vitamins { get; set; }

        /// <summary>
        /// A description of this item
        /// </summary>
        /// <value>A description of this item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// An array of keywords that can be used to describe this item
        /// </summary>
        /// <value>An array of keywords that can be used to describe this item</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall.
        /// </summary>
        /// <value>Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall.</value>
        [DataMember(Name="footnote", EmitDefaultValue=false)]
        public string Footnote { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectItems {\n");
            sb.Append("  Barcode: ").Append(Barcode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Package: ").Append(Package).Append("\n");
            sb.Append("  Serving: ").Append(Serving).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Nutrients: ").Append(Nutrients).Append("\n");
            sb.Append("  CalorieConversionFactor: ").Append(CalorieConversionFactor).Append("\n");
            sb.Append("  ProteinConversionFactor: ").Append(ProteinConversionFactor).Append("\n");
            sb.Append("  DietLabels: ").Append(DietLabels).Append("\n");
            sb.Append("  DietFlags: ").Append(DietFlags).Append("\n");
            sb.Append("  PackagingPhotos: ").Append(PackagingPhotos).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Portions: ").Append(Portions).Append("\n");
            sb.Append("  Allergens: ").Append(Allergens).Append("\n");
            sb.Append("  BrandList: ").Append(BrandList).Append("\n");
            sb.Append("  Countries: ").Append(Countries).Append("\n");
            sb.Append("  CountryDetails: ").Append(CountryDetails).Append("\n");
            sb.Append("  PalmOilIngredients: ").Append(PalmOilIngredients).Append("\n");
            sb.Append("  IngredientList: ").Append(IngredientList).Append("\n");
            sb.Append("  HasEnglishIngredients: ").Append(HasEnglishIngredients).Append("\n");
            sb.Append("  Minerals: ").Append(Minerals).Append("\n");
            sb.Append("  Traces: ").Append(Traces).Append("\n");
            sb.Append("  Vitamins: ").Append(Vitamins).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Footnote: ").Append(Footnote).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as BrandedFoodObjectItems);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectItems instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Barcode == input.Barcode ||
                    (this.Barcode != null &&
                    this.Barcode.Equals(input.Barcode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    (this.Ingredients != null &&
                    this.Ingredients.Equals(input.Ingredients))
                ) && 
                (
                    this.Package == input.Package ||
                    (this.Package != null &&
                    this.Package.Equals(input.Package))
                ) && 
                (
                    this.Serving == input.Serving ||
                    (this.Serving != null &&
                    this.Serving.Equals(input.Serving))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Nutrients == input.Nutrients ||
                    (this.Nutrients != null &&
                    this.Nutrients.Equals(input.Nutrients))
                ) && 
                (
                    this.CalorieConversionFactor == input.CalorieConversionFactor ||
                    (this.CalorieConversionFactor != null &&
                    this.CalorieConversionFactor.Equals(input.CalorieConversionFactor))
                ) && 
                (
                    this.ProteinConversionFactor == input.ProteinConversionFactor ||
                    (this.ProteinConversionFactor != null &&
                    this.ProteinConversionFactor.Equals(input.ProteinConversionFactor))
                ) && 
                (
                    this.DietLabels == input.DietLabels ||
                    (this.DietLabels != null &&
                    this.DietLabels.Equals(input.DietLabels))
                ) && 
                (
                    this.DietFlags == input.DietFlags ||
                    this.DietFlags != null &&
                    input.DietFlags != null &&
                    this.DietFlags.SequenceEqual(input.DietFlags)
                ) && 
                (
                    this.PackagingPhotos == input.PackagingPhotos ||
                    (this.PackagingPhotos != null &&
                    this.PackagingPhotos.Equals(input.PackagingPhotos))
                ) && 
                (
                    this.Components == input.Components ||
                    this.Components != null &&
                    input.Components != null &&
                    this.Components.SequenceEqual(input.Components)
                ) && 
                (
                    this.Portions == input.Portions ||
                    this.Portions != null &&
                    input.Portions != null &&
                    this.Portions.SequenceEqual(input.Portions)
                ) && 
                (
                    this.Allergens == input.Allergens ||
                    this.Allergens != null &&
                    input.Allergens != null &&
                    this.Allergens.SequenceEqual(input.Allergens)
                ) && 
                (
                    this.BrandList == input.BrandList ||
                    this.BrandList != null &&
                    input.BrandList != null &&
                    this.BrandList.SequenceEqual(input.BrandList)
                ) && 
                (
                    this.Countries == input.Countries ||
                    this.Countries != null &&
                    input.Countries != null &&
                    this.Countries.SequenceEqual(input.Countries)
                ) && 
                (
                    this.CountryDetails == input.CountryDetails ||
                    (this.CountryDetails != null &&
                    this.CountryDetails.Equals(input.CountryDetails))
                ) && 
                (
                    this.PalmOilIngredients == input.PalmOilIngredients ||
                    this.PalmOilIngredients != null &&
                    input.PalmOilIngredients != null &&
                    this.PalmOilIngredients.SequenceEqual(input.PalmOilIngredients)
                ) && 
                (
                    this.IngredientList == input.IngredientList ||
                    this.IngredientList != null &&
                    input.IngredientList != null &&
                    this.IngredientList.SequenceEqual(input.IngredientList)
                ) && 
                (
                    this.HasEnglishIngredients == input.HasEnglishIngredients ||
                    (this.HasEnglishIngredients != null &&
                    this.HasEnglishIngredients.Equals(input.HasEnglishIngredients))
                ) && 
                (
                    this.Minerals == input.Minerals ||
                    this.Minerals != null &&
                    input.Minerals != null &&
                    this.Minerals.SequenceEqual(input.Minerals)
                ) && 
                (
                    this.Traces == input.Traces ||
                    this.Traces != null &&
                    input.Traces != null &&
                    this.Traces.SequenceEqual(input.Traces)
                ) && 
                (
                    this.Vitamins == input.Vitamins ||
                    this.Vitamins != null &&
                    input.Vitamins != null &&
                    this.Vitamins.SequenceEqual(input.Vitamins)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Footnote == input.Footnote ||
                    (this.Footnote != null &&
                    this.Footnote.Equals(input.Footnote))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Barcode != null)
                    hashCode = hashCode * 59 + this.Barcode.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.Package != null)
                    hashCode = hashCode * 59 + this.Package.GetHashCode();
                if (this.Serving != null)
                    hashCode = hashCode * 59 + this.Serving.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Nutrients != null)
                    hashCode = hashCode * 59 + this.Nutrients.GetHashCode();
                if (this.CalorieConversionFactor != null)
                    hashCode = hashCode * 59 + this.CalorieConversionFactor.GetHashCode();
                if (this.ProteinConversionFactor != null)
                    hashCode = hashCode * 59 + this.ProteinConversionFactor.GetHashCode();
                if (this.DietLabels != null)
                    hashCode = hashCode * 59 + this.DietLabels.GetHashCode();
                if (this.DietFlags != null)
                    hashCode = hashCode * 59 + this.DietFlags.GetHashCode();
                if (this.PackagingPhotos != null)
                    hashCode = hashCode * 59 + this.PackagingPhotos.GetHashCode();
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
                if (this.Portions != null)
                    hashCode = hashCode * 59 + this.Portions.GetHashCode();
                if (this.Allergens != null)
                    hashCode = hashCode * 59 + this.Allergens.GetHashCode();
                if (this.BrandList != null)
                    hashCode = hashCode * 59 + this.BrandList.GetHashCode();
                if (this.Countries != null)
                    hashCode = hashCode * 59 + this.Countries.GetHashCode();
                if (this.CountryDetails != null)
                    hashCode = hashCode * 59 + this.CountryDetails.GetHashCode();
                if (this.PalmOilIngredients != null)
                    hashCode = hashCode * 59 + this.PalmOilIngredients.GetHashCode();
                if (this.IngredientList != null)
                    hashCode = hashCode * 59 + this.IngredientList.GetHashCode();
                if (this.HasEnglishIngredients != null)
                    hashCode = hashCode * 59 + this.HasEnglishIngredients.GetHashCode();
                if (this.Minerals != null)
                    hashCode = hashCode * 59 + this.Minerals.GetHashCode();
                if (this.Traces != null)
                    hashCode = hashCode * 59 + this.Traces.GetHashCode();
                if (this.Vitamins != null)
                    hashCode = hashCode * 59 + this.Vitamins.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Footnote != null)
                    hashCode = hashCode * 59 + this.Footnote.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
