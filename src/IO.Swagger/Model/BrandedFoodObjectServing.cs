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
    /// An object containing serving information for this item
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectServing :  IEquatable<BrandedFoodObjectServing>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectServing" /> class.
        /// </summary>
        /// <param name="size">Serving size.</param>
        /// <param name="measurementUnit">Measurement unit for each serving (e.g. if measure is 3 tsp, the unit is tsp).</param>
        /// <param name="sizeFulltext">Serving size description.</param>
        public BrandedFoodObjectServing(string size = default(string), string measurementUnit = default(string), string sizeFulltext = default(string))
        {
            this.Size = size;
            this.MeasurementUnit = measurementUnit;
            this.SizeFulltext = sizeFulltext;
        }
        
        /// <summary>
        /// Serving size
        /// </summary>
        /// <value>Serving size</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public string Size { get; set; }

        /// <summary>
        /// Measurement unit for each serving (e.g. if measure is 3 tsp, the unit is tsp)
        /// </summary>
        /// <value>Measurement unit for each serving (e.g. if measure is 3 tsp, the unit is tsp)</value>
        [DataMember(Name="measurement_unit", EmitDefaultValue=false)]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Serving size description
        /// </summary>
        /// <value>Serving size description</value>
        [DataMember(Name="size_fulltext", EmitDefaultValue=false)]
        public string SizeFulltext { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectServing {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  SizeFulltext: ").Append(SizeFulltext).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectServing);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectServing instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectServing to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectServing input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.MeasurementUnit == input.MeasurementUnit ||
                    (this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(input.MeasurementUnit))
                ) && 
                (
                    this.SizeFulltext == input.SizeFulltext ||
                    (this.SizeFulltext != null &&
                    this.SizeFulltext.Equals(input.SizeFulltext))
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
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.MeasurementUnit != null)
                    hashCode = hashCode * 59 + this.MeasurementUnit.GetHashCode();
                if (this.SizeFulltext != null)
                    hashCode = hashCode * 59 + this.SizeFulltext.GetHashCode();
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
