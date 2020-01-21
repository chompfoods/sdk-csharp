/* 
 * Chomp Food Database API Documentation
 *
 * __Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API.   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - Branded Food: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)__ API response object.   - Ingredient: __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
        public partial class IngredientObjectItems :  IEquatable<IngredientObjectItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientObjectItems" /> class.
        /// </summary>
        /// <param name="name">Item name as provided by brand owner or as shown on packaging.</param>
        /// <param name="categories">categories.</param>
        /// <param name="nutrients">nutrients.</param>
        /// <param name="calorieConversionFactor">calorieConversionFactor.</param>
        /// <param name="proteinConversionFactor">The multiplication factor used to calculate protein from nitrogen.</param>
        /// <param name="dietLabels">dietLabels.</param>
        /// <param name="components">An array of objects containing the constituent parts of a food (e.g. bone is a component of meat).</param>
        /// <param name="portions">An array of objects containing information on discrete amounts of a food found in this item.</param>
        /// <param name="commonName">Common names associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;).</param>
        /// <param name="description">A description of this item.</param>
        /// <param name="footnote">Comments on any unusual aspects of this item. Examples might include unusual aspects of the food overall..</param>
        public IngredientObjectItems(string name = default(string), List<string> categories = default(List<string>), IngredientObjectNutrients nutrients = default(IngredientObjectNutrients), BrandedFoodObjectCalorieConversionFactor calorieConversionFactor = default(BrandedFoodObjectCalorieConversionFactor), decimal? proteinConversionFactor = default(decimal?), BrandedFoodObjectDietLabels dietLabels = default(BrandedFoodObjectDietLabels), List<BrandedFoodObjectComponents> components = default(List<BrandedFoodObjectComponents>), List<BrandedFoodObjectPortions> portions = default(List<BrandedFoodObjectPortions>), string commonName = default(string), string description = default(string), string footnote = default(string))
        {
            this.Name = name;
            this.Categories = categories;
            this.Nutrients = nutrients;
            this.CalorieConversionFactor = calorieConversionFactor;
            this.ProteinConversionFactor = proteinConversionFactor;
            this.DietLabels = dietLabels;
            this.Components = components;
            this.Portions = portions;
            this.CommonName = commonName;
            this.Description = description;
            this.Footnote = footnote;
        }
        
        /// <summary>
        /// Item name as provided by brand owner or as shown on packaging
        /// </summary>
        /// <value>Item name as provided by brand owner or as shown on packaging</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// Gets or Sets Nutrients
        /// </summary>
        [DataMember(Name="nutrients", EmitDefaultValue=false)]
        public IngredientObjectNutrients Nutrients { get; set; }

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
        /// Common names associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;)
        /// </summary>
        /// <value>Common names associated with this item. These generally clarify what the item is (e.g. when the brand name is \&quot;BRAND&#x27;s Spicy Enchilada\&quot; the common name may be \&quot;Chicken enchilada\&quot;)</value>
        [DataMember(Name="common_name", EmitDefaultValue=false)]
        public string CommonName { get; set; }

        /// <summary>
        /// A description of this item
        /// </summary>
        /// <value>A description of this item</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

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
            sb.Append("class IngredientObjectItems {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Nutrients: ").Append(Nutrients).Append("\n");
            sb.Append("  CalorieConversionFactor: ").Append(CalorieConversionFactor).Append("\n");
            sb.Append("  ProteinConversionFactor: ").Append(ProteinConversionFactor).Append("\n");
            sb.Append("  DietLabels: ").Append(DietLabels).Append("\n");
            sb.Append("  Components: ").Append(Components).Append("\n");
            sb.Append("  Portions: ").Append(Portions).Append("\n");
            sb.Append("  CommonName: ").Append(CommonName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as IngredientObjectItems);
        }

        /// <summary>
        /// Returns true if IngredientObjectItems instances are equal
        /// </summary>
        /// <param name="input">Instance of IngredientObjectItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngredientObjectItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                    this.CommonName == input.CommonName ||
                    (this.CommonName != null &&
                    this.CommonName.Equals(input.CommonName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
                if (this.Components != null)
                    hashCode = hashCode * 59 + this.Components.GetHashCode();
                if (this.Portions != null)
                    hashCode = hashCode * 59 + this.Portions.GetHashCode();
                if (this.CommonName != null)
                    hashCode = hashCode * 59 + this.CommonName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
