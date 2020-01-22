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
    /// An object containing this item&#x27;s compatibility grades for each supported diet
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectDietLabels :  IEquatable<BrandedFoodObjectDietLabels>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectDietLabels" /> class.
        /// </summary>
        /// <param name="vegan">vegan.</param>
        /// <param name="vegetarian">vegetarian.</param>
        /// <param name="glutenFree">glutenFree.</param>
        public BrandedFoodObjectDietLabels(BrandedFoodObjectDietLabelsVegan vegan = default(BrandedFoodObjectDietLabelsVegan), BrandedFoodObjectDietLabelsVegetarian vegetarian = default(BrandedFoodObjectDietLabelsVegetarian), BrandedFoodObjectDietLabelsGlutenFree glutenFree = default(BrandedFoodObjectDietLabelsGlutenFree))
        {
            this.Vegan = vegan;
            this.Vegetarian = vegetarian;
            this.GlutenFree = glutenFree;
        }
        
        /// <summary>
        /// Gets or Sets Vegan
        /// </summary>
        [DataMember(Name="vegan", EmitDefaultValue=false)]
        public BrandedFoodObjectDietLabelsVegan Vegan { get; set; }

        /// <summary>
        /// Gets or Sets Vegetarian
        /// </summary>
        [DataMember(Name="vegetarian", EmitDefaultValue=false)]
        public BrandedFoodObjectDietLabelsVegetarian Vegetarian { get; set; }

        /// <summary>
        /// Gets or Sets GlutenFree
        /// </summary>
        [DataMember(Name="gluten_free", EmitDefaultValue=false)]
        public BrandedFoodObjectDietLabelsGlutenFree GlutenFree { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectDietLabels {\n");
            sb.Append("  Vegan: ").Append(Vegan).Append("\n");
            sb.Append("  Vegetarian: ").Append(Vegetarian).Append("\n");
            sb.Append("  GlutenFree: ").Append(GlutenFree).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectDietLabels);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectDietLabels instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectDietLabels to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectDietLabels input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Vegan == input.Vegan ||
                    (this.Vegan != null &&
                    this.Vegan.Equals(input.Vegan))
                ) && 
                (
                    this.Vegetarian == input.Vegetarian ||
                    (this.Vegetarian != null &&
                    this.Vegetarian.Equals(input.Vegetarian))
                ) && 
                (
                    this.GlutenFree == input.GlutenFree ||
                    (this.GlutenFree != null &&
                    this.GlutenFree.Equals(input.GlutenFree))
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
                if (this.Vegan != null)
                    hashCode = hashCode * 59 + this.Vegan.GetHashCode();
                if (this.Vegetarian != null)
                    hashCode = hashCode * 59 + this.Vegetarian.GetHashCode();
                if (this.GlutenFree != null)
                    hashCode = hashCode * 59 + this.GlutenFree.GetHashCode();
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
