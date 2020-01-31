/* 
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
    /// An object containing photos of this item&#x27;s nutrition label
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectPackagingPhotosNutrition :  IEquatable<BrandedFoodObjectPackagingPhotosNutrition>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectPackagingPhotosNutrition" /> class.
        /// </summary>
        /// <param name="small">Small photo of this item&#x27;s nutrition label.</param>
        /// <param name="thumb">Thumbnail photo of this item&#x27;s nutrition label.</param>
        /// <param name="display">Full-sized photo of this item&#x27;s nutrition label.</param>
        public BrandedFoodObjectPackagingPhotosNutrition(string small = default(string), string thumb = default(string), string display = default(string))
        {
            this.Small = small;
            this.Thumb = thumb;
            this.Display = display;
        }
        
        /// <summary>
        /// Small photo of this item&#x27;s nutrition label
        /// </summary>
        /// <value>Small photo of this item&#x27;s nutrition label</value>
        [DataMember(Name="small", EmitDefaultValue=false)]
        public string Small { get; set; }

        /// <summary>
        /// Thumbnail photo of this item&#x27;s nutrition label
        /// </summary>
        /// <value>Thumbnail photo of this item&#x27;s nutrition label</value>
        [DataMember(Name="thumb", EmitDefaultValue=false)]
        public string Thumb { get; set; }

        /// <summary>
        /// Full-sized photo of this item&#x27;s nutrition label
        /// </summary>
        /// <value>Full-sized photo of this item&#x27;s nutrition label</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectPackagingPhotosNutrition {\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Thumb: ").Append(Thumb).Append("\n");
            sb.Append("  Display: ").Append(Display).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectPackagingPhotosNutrition);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectPackagingPhotosNutrition instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectPackagingPhotosNutrition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectPackagingPhotosNutrition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Small == input.Small ||
                    (this.Small != null &&
                    this.Small.Equals(input.Small))
                ) && 
                (
                    this.Thumb == input.Thumb ||
                    (this.Thumb != null &&
                    this.Thumb.Equals(input.Thumb))
                ) && 
                (
                    this.Display == input.Display ||
                    (this.Display != null &&
                    this.Display.Equals(input.Display))
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
                if (this.Small != null)
                    hashCode = hashCode * 59 + this.Small.GetHashCode();
                if (this.Thumb != null)
                    hashCode = hashCode * 59 + this.Thumb.GetHashCode();
                if (this.Display != null)
                    hashCode = hashCode * 59 + this.Display.GetHashCode();
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
