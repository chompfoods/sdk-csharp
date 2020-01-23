/* 
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
