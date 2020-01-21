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
    /// An object containing photos of the front of this item&#x27;s packaging
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectPackagingPhotosFront :  IEquatable<BrandedFoodObjectPackagingPhotosFront>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectPackagingPhotosFront" /> class.
        /// </summary>
        /// <param name="small">Small photo of the front of this item&#x27;s packaging.</param>
        /// <param name="thumb">Thumbnail photo of the front of this item&#x27;s packaging.</param>
        /// <param name="display">Full-sized photo of the front of this item&#x27;s packaging.</param>
        public BrandedFoodObjectPackagingPhotosFront(string small = default(string), string thumb = default(string), string display = default(string))
        {
            this.Small = small;
            this.Thumb = thumb;
            this.Display = display;
        }
        
        /// <summary>
        /// Small photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Small photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="small", EmitDefaultValue=false)]
        public string Small { get; set; }

        /// <summary>
        /// Thumbnail photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Thumbnail photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="thumb", EmitDefaultValue=false)]
        public string Thumb { get; set; }

        /// <summary>
        /// Full-sized photo of the front of this item&#x27;s packaging
        /// </summary>
        /// <value>Full-sized photo of the front of this item&#x27;s packaging</value>
        [DataMember(Name="display", EmitDefaultValue=false)]
        public string Display { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectPackagingPhotosFront {\n");
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
            return this.Equals(input as BrandedFoodObjectPackagingPhotosFront);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectPackagingPhotosFront instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectPackagingPhotosFront to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectPackagingPhotosFront input)
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
