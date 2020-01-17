/* 
 * Chomp Food Database API Documentation
 *
 * __Important:__   - An __[API key](https://chompthis.com/api/)__ is required for access to this API.   - Get yours at __[https://chompthis.com/api](https://chompthis.com/api/)__.  - -- --  __Getting Started:__   - __[Subscribe](https://chompthis.com/api/#pricing)__ to the API   - Scroll down and click the \"__Authorize__\" button.   - Enter your API key into the \"__value__\" input, click the \"__Authorize__\" button, then click the \"__Close__\" button.   - Scroll down to the section titled \"__default__\" and click on the API endpoint you wish to use.   - Click the \"__Try it out__\" button.   - Enter the information the endpoint requires.   - Click the \"__Execute__\" button.  __Example:__    - __[View example](https://raw.githubusercontent.com/chompfoods/examples/master/response-object.json)__ API response object.  - -- --  __How Do I Find My API Key?__   - Your API key was sent to the email address you used to create your subscription.   - You will also find your API key in the __[Client Center](https://chompthis.com/api/manage.php)__.   - _Read __[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)__ for more information._  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
    /// An object containing additional information on the countries where this item is found
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectCountryDetails :  IEquatable<BrandedFoodObjectCountryDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectCountryDetails" /> class.
        /// </summary>
        /// <param name="englishSpeaking">The number of countries where English is the country&#x27;s primary language.</param>
        /// <param name="nonEnglishSpeaking">The number of countries where English is not the country&#x27;s primary language.</param>
        public BrandedFoodObjectCountryDetails(int? englishSpeaking = default(int?), int? nonEnglishSpeaking = default(int?))
        {
            this.EnglishSpeaking = englishSpeaking;
            this.NonEnglishSpeaking = nonEnglishSpeaking;
        }
        
        /// <summary>
        /// The number of countries where English is the country&#x27;s primary language
        /// </summary>
        /// <value>The number of countries where English is the country&#x27;s primary language</value>
        [DataMember(Name="english_speaking", EmitDefaultValue=false)]
        public int? EnglishSpeaking { get; set; }

        /// <summary>
        /// The number of countries where English is not the country&#x27;s primary language
        /// </summary>
        /// <value>The number of countries where English is not the country&#x27;s primary language</value>
        [DataMember(Name="non_english_speaking", EmitDefaultValue=false)]
        public int? NonEnglishSpeaking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectCountryDetails {\n");
            sb.Append("  EnglishSpeaking: ").Append(EnglishSpeaking).Append("\n");
            sb.Append("  NonEnglishSpeaking: ").Append(NonEnglishSpeaking).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectCountryDetails);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectCountryDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectCountryDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectCountryDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnglishSpeaking == input.EnglishSpeaking ||
                    (this.EnglishSpeaking != null &&
                    this.EnglishSpeaking.Equals(input.EnglishSpeaking))
                ) && 
                (
                    this.NonEnglishSpeaking == input.NonEnglishSpeaking ||
                    (this.NonEnglishSpeaking != null &&
                    this.NonEnglishSpeaking.Equals(input.NonEnglishSpeaking))
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
                if (this.EnglishSpeaking != null)
                    hashCode = hashCode * 59 + this.EnglishSpeaking.GetHashCode();
                if (this.NonEnglishSpeaking != null)
                    hashCode = hashCode * 59 + this.NonEnglishSpeaking.GetHashCode();
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
