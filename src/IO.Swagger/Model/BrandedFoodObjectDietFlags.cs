/* 
 * Chomp Food Database API Documentation
 *
 * __Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API.   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
    /// An object containing information on an individual ingredient that was flagged as potentially not being compatible with a certain diet
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectDietFlags :  IEquatable<BrandedFoodObjectDietFlags>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectDietFlags" /> class.
        /// </summary>
        /// <param name="ingredient">Ingredient name.</param>
        /// <param name="ingredientDescription">Description of the ingredient.</param>
        /// <param name="dietLabel">Name of the diet with which this ingredient may not be compatible.</param>
        /// <param name="isCompatible">A description of if we believe this ingredient is compatible with the diet.</param>
        /// <param name="compatibilityLevel">A numeric representation of if we believe this ingredient is compatible with the diet. Higher values indicate more compatibility.</param>
        /// <param name="compatibilityDescription">A description of how we graded this ingredient for compatibility with the diet.</param>
        /// <param name="isAllergen">Boolean representing if the ingredient is a known allergen.</param>
        public BrandedFoodObjectDietFlags(string ingredient = default(string), string ingredientDescription = default(string), string dietLabel = default(string), string isCompatible = default(string), int? compatibilityLevel = default(int?), string compatibilityDescription = default(string), bool? isAllergen = default(bool?))
        {
            this.Ingredient = ingredient;
            this.IngredientDescription = ingredientDescription;
            this.DietLabel = dietLabel;
            this.IsCompatible = isCompatible;
            this.CompatibilityLevel = compatibilityLevel;
            this.CompatibilityDescription = compatibilityDescription;
            this.IsAllergen = isAllergen;
        }
        
        /// <summary>
        /// Ingredient name
        /// </summary>
        /// <value>Ingredient name</value>
        [DataMember(Name="ingredient", EmitDefaultValue=false)]
        public string Ingredient { get; set; }

        /// <summary>
        /// Description of the ingredient
        /// </summary>
        /// <value>Description of the ingredient</value>
        [DataMember(Name="ingredient_description", EmitDefaultValue=false)]
        public string IngredientDescription { get; set; }

        /// <summary>
        /// Name of the diet with which this ingredient may not be compatible
        /// </summary>
        /// <value>Name of the diet with which this ingredient may not be compatible</value>
        [DataMember(Name="diet_label", EmitDefaultValue=false)]
        public string DietLabel { get; set; }

        /// <summary>
        /// A description of if we believe this ingredient is compatible with the diet
        /// </summary>
        /// <value>A description of if we believe this ingredient is compatible with the diet</value>
        [DataMember(Name="is_compatible", EmitDefaultValue=false)]
        public string IsCompatible { get; set; }

        /// <summary>
        /// A numeric representation of if we believe this ingredient is compatible with the diet. Higher values indicate more compatibility
        /// </summary>
        /// <value>A numeric representation of if we believe this ingredient is compatible with the diet. Higher values indicate more compatibility</value>
        [DataMember(Name="compatibility_level", EmitDefaultValue=false)]
        public int? CompatibilityLevel { get; set; }

        /// <summary>
        /// A description of how we graded this ingredient for compatibility with the diet
        /// </summary>
        /// <value>A description of how we graded this ingredient for compatibility with the diet</value>
        [DataMember(Name="compatibility_description", EmitDefaultValue=false)]
        public string CompatibilityDescription { get; set; }

        /// <summary>
        /// Boolean representing if the ingredient is a known allergen
        /// </summary>
        /// <value>Boolean representing if the ingredient is a known allergen</value>
        [DataMember(Name="is_allergen", EmitDefaultValue=false)]
        public bool? IsAllergen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectDietFlags {\n");
            sb.Append("  Ingredient: ").Append(Ingredient).Append("\n");
            sb.Append("  IngredientDescription: ").Append(IngredientDescription).Append("\n");
            sb.Append("  DietLabel: ").Append(DietLabel).Append("\n");
            sb.Append("  IsCompatible: ").Append(IsCompatible).Append("\n");
            sb.Append("  CompatibilityLevel: ").Append(CompatibilityLevel).Append("\n");
            sb.Append("  CompatibilityDescription: ").Append(CompatibilityDescription).Append("\n");
            sb.Append("  IsAllergen: ").Append(IsAllergen).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectDietFlags);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectDietFlags instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectDietFlags to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectDietFlags input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Ingredient == input.Ingredient ||
                    (this.Ingredient != null &&
                    this.Ingredient.Equals(input.Ingredient))
                ) && 
                (
                    this.IngredientDescription == input.IngredientDescription ||
                    (this.IngredientDescription != null &&
                    this.IngredientDescription.Equals(input.IngredientDescription))
                ) && 
                (
                    this.DietLabel == input.DietLabel ||
                    (this.DietLabel != null &&
                    this.DietLabel.Equals(input.DietLabel))
                ) && 
                (
                    this.IsCompatible == input.IsCompatible ||
                    (this.IsCompatible != null &&
                    this.IsCompatible.Equals(input.IsCompatible))
                ) && 
                (
                    this.CompatibilityLevel == input.CompatibilityLevel ||
                    (this.CompatibilityLevel != null &&
                    this.CompatibilityLevel.Equals(input.CompatibilityLevel))
                ) && 
                (
                    this.CompatibilityDescription == input.CompatibilityDescription ||
                    (this.CompatibilityDescription != null &&
                    this.CompatibilityDescription.Equals(input.CompatibilityDescription))
                ) && 
                (
                    this.IsAllergen == input.IsAllergen ||
                    (this.IsAllergen != null &&
                    this.IsAllergen.Equals(input.IsAllergen))
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
                if (this.Ingredient != null)
                    hashCode = hashCode * 59 + this.Ingredient.GetHashCode();
                if (this.IngredientDescription != null)
                    hashCode = hashCode * 59 + this.IngredientDescription.GetHashCode();
                if (this.DietLabel != null)
                    hashCode = hashCode * 59 + this.DietLabel.GetHashCode();
                if (this.IsCompatible != null)
                    hashCode = hashCode * 59 + this.IsCompatible.GetHashCode();
                if (this.CompatibilityLevel != null)
                    hashCode = hashCode * 59 + this.CompatibilityLevel.GetHashCode();
                if (this.CompatibilityDescription != null)
                    hashCode = hashCode * 59 + this.CompatibilityDescription.GetHashCode();
                if (this.IsAllergen != null)
                    hashCode = hashCode * 59 + this.IsAllergen.GetHashCode();
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
