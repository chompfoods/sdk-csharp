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
    /// An object containing information on this item&#x27;s compatibility with Vegetarian diets
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectDietLabelsVegetarian :  IEquatable<BrandedFoodObjectDietLabelsVegetarian>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectDietLabelsVegetarian" /> class.
        /// </summary>
        /// <param name="name">Diet name.</param>
        /// <param name="isCompatible">Boolean describing if this item is compatible with this diet.</param>
        /// <param name="compatibilityLevel">Numeric representation of how compatible this item is with this diet. Higher values indicate more compatibility.</param>
        /// <param name="confidence">Boolean that indicates if we are confident in how this item is graded for this diet.</param>
        /// <param name="confidenceDescription">Description of our confidence that this item was graded correctly.</param>
        public BrandedFoodObjectDietLabelsVegetarian(string name = default(string), bool? isCompatible = default(bool?), int? compatibilityLevel = default(int?), int? confidence = default(int?), string confidenceDescription = default(string))
        {
            this.Name = name;
            this.IsCompatible = isCompatible;
            this.CompatibilityLevel = compatibilityLevel;
            this.Confidence = confidence;
            this.ConfidenceDescription = confidenceDescription;
        }
        
        /// <summary>
        /// Diet name
        /// </summary>
        /// <value>Diet name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Boolean describing if this item is compatible with this diet
        /// </summary>
        /// <value>Boolean describing if this item is compatible with this diet</value>
        [DataMember(Name="is_compatible", EmitDefaultValue=false)]
        public bool? IsCompatible { get; set; }

        /// <summary>
        /// Numeric representation of how compatible this item is with this diet. Higher values indicate more compatibility
        /// </summary>
        /// <value>Numeric representation of how compatible this item is with this diet. Higher values indicate more compatibility</value>
        [DataMember(Name="compatibility_level", EmitDefaultValue=false)]
        public int? CompatibilityLevel { get; set; }

        /// <summary>
        /// Boolean that indicates if we are confident in how this item is graded for this diet
        /// </summary>
        /// <value>Boolean that indicates if we are confident in how this item is graded for this diet</value>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public int? Confidence { get; set; }

        /// <summary>
        /// Description of our confidence that this item was graded correctly
        /// </summary>
        /// <value>Description of our confidence that this item was graded correctly</value>
        [DataMember(Name="confidence_description", EmitDefaultValue=false)]
        public string ConfidenceDescription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectDietLabelsVegetarian {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsCompatible: ").Append(IsCompatible).Append("\n");
            sb.Append("  CompatibilityLevel: ").Append(CompatibilityLevel).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  ConfidenceDescription: ").Append(ConfidenceDescription).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectDietLabelsVegetarian);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectDietLabelsVegetarian instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectDietLabelsVegetarian to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectDietLabelsVegetarian input)
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
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.ConfidenceDescription == input.ConfidenceDescription ||
                    (this.ConfidenceDescription != null &&
                    this.ConfidenceDescription.Equals(input.ConfidenceDescription))
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
                if (this.IsCompatible != null)
                    hashCode = hashCode * 59 + this.IsCompatible.GetHashCode();
                if (this.CompatibilityLevel != null)
                    hashCode = hashCode * 59 + this.CompatibilityLevel.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.ConfidenceDescription != null)
                    hashCode = hashCode * 59 + this.ConfidenceDescription.GetHashCode();
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
