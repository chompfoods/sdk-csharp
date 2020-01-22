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
    /// An object containing the multiplication factors to be used when calculating energy from macronutrients for a specific food.
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectCalorieConversionFactor :  IEquatable<BrandedFoodObjectCalorieConversionFactor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectCalorieConversionFactor" /> class.
        /// </summary>
        /// <param name="proteinValue">The multiplication factor for protein.</param>
        /// <param name="fatValue">The multiplication factor for fat.</param>
        /// <param name="carbohydrateValue">The multiplication factor for carbohydrates.</param>
        public BrandedFoodObjectCalorieConversionFactor(decimal? proteinValue = default(decimal?), decimal? fatValue = default(decimal?), decimal? carbohydrateValue = default(decimal?))
        {
            this.ProteinValue = proteinValue;
            this.FatValue = fatValue;
            this.CarbohydrateValue = carbohydrateValue;
        }
        
        /// <summary>
        /// The multiplication factor for protein
        /// </summary>
        /// <value>The multiplication factor for protein</value>
        [DataMember(Name="protein_value", EmitDefaultValue=false)]
        public decimal? ProteinValue { get; set; }

        /// <summary>
        /// The multiplication factor for fat
        /// </summary>
        /// <value>The multiplication factor for fat</value>
        [DataMember(Name="fat_value", EmitDefaultValue=false)]
        public decimal? FatValue { get; set; }

        /// <summary>
        /// The multiplication factor for carbohydrates
        /// </summary>
        /// <value>The multiplication factor for carbohydrates</value>
        [DataMember(Name="carbohydrate_value", EmitDefaultValue=false)]
        public decimal? CarbohydrateValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectCalorieConversionFactor {\n");
            sb.Append("  ProteinValue: ").Append(ProteinValue).Append("\n");
            sb.Append("  FatValue: ").Append(FatValue).Append("\n");
            sb.Append("  CarbohydrateValue: ").Append(CarbohydrateValue).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectCalorieConversionFactor);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectCalorieConversionFactor instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectCalorieConversionFactor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectCalorieConversionFactor input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProteinValue == input.ProteinValue ||
                    (this.ProteinValue != null &&
                    this.ProteinValue.Equals(input.ProteinValue))
                ) && 
                (
                    this.FatValue == input.FatValue ||
                    (this.FatValue != null &&
                    this.FatValue.Equals(input.FatValue))
                ) && 
                (
                    this.CarbohydrateValue == input.CarbohydrateValue ||
                    (this.CarbohydrateValue != null &&
                    this.CarbohydrateValue.Equals(input.CarbohydrateValue))
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
                if (this.ProteinValue != null)
                    hashCode = hashCode * 59 + this.ProteinValue.GetHashCode();
                if (this.FatValue != null)
                    hashCode = hashCode * 59 + this.FatValue.GetHashCode();
                if (this.CarbohydrateValue != null)
                    hashCode = hashCode * 59 + this.CarbohydrateValue.GetHashCode();
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
