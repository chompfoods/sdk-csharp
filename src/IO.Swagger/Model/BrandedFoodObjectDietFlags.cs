/* 
 * Chomp Food & Recipe Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. * Get a **Food Data API** key at **[https://chompthis.com/api](https://chompthis.com/api/)**. * Get a **Recipe Data API** key at **[https://chompthis.com/api/recipes](https://chompthis.com/api/recipes/)**.  ### Getting Started   * Subscribe to the **[Food Data API](https://chompthis.com/api/#pricing)** or the **[Recipe Data API](https://chompthis.com/api/recipes/#pricing)**.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Recipe response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/example-recipe-response.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### I'm a Premium subscriber. How do I access the API?   * All Premium subscribers must pass in a unique user ID for each user on their platform that is accessing data from the Chomp API. A user ID can be any string of letters and numbers that you assign to your user. Simply add \"user_id\" as a URL parameter when calling the API. *You must add a \"user_id\" URL parameter to every call you make to ANY endpoint.*     * **Example**        > ```ENDPOINT.php?api_key=API_KEY&code=CODE&user_id=USER_ID```  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Food Data API Subscription Options &raquo;](https://chompthis.com/api/)     * [Recipe Data API Subscription Options &raquo;](https://chompthis.com/api/recipes/)     * [Food Data API Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)     * [Recipe Data API Cost Calculator &raquo;](https://chompthis.com/api/recipes/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
