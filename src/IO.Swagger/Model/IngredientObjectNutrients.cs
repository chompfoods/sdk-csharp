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
    /// An object containing information for a specific nutrient found in this food item
    /// </summary>
    [DataContract]
        public partial class IngredientObjectNutrients :  IEquatable<IngredientObjectNutrients>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IngredientObjectNutrients" /> class.
        /// </summary>
        /// <param name="name">Nutrient name.</param>
        /// <param name="per100g">Amount of the nutrient per 100g of food.</param>
        /// <param name="measurementUnit">The unit used for the measure of this nutrient.</param>
        /// <param name="min">Minimum nutrient value.</param>
        /// <param name="max">Maximum nutrient value.</param>
        /// <param name="median">Median nutrient value.</param>
        /// <param name="rank">Nutrient rank.</param>
        /// <param name="dataPoints">Number of observations on which the value is based.</param>
        /// <param name="footnote">Comments on any unusual aspect of the food nutrient. Examples might include why a nutrient value is different than typically expected..</param>
        /// <param name="description">Description of the nutrient source.</param>
        public IngredientObjectNutrients(string name = default(string), decimal? per100g = default(decimal?), string measurementUnit = default(string), decimal? min = default(decimal?), decimal? max = default(decimal?), decimal? median = default(decimal?), int? rank = default(int?), int? dataPoints = default(int?), string footnote = default(string), string description = default(string))
        {
            this.Name = name;
            this.Per100g = per100g;
            this.MeasurementUnit = measurementUnit;
            this.Min = min;
            this.Max = max;
            this.Median = median;
            this.Rank = rank;
            this.DataPoints = dataPoints;
            this.Footnote = footnote;
            this.Description = description;
        }
        
        /// <summary>
        /// Nutrient name
        /// </summary>
        /// <value>Nutrient name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Amount of the nutrient per 100g of food
        /// </summary>
        /// <value>Amount of the nutrient per 100g of food</value>
        [DataMember(Name="per_100g", EmitDefaultValue=false)]
        public decimal? Per100g { get; set; }

        /// <summary>
        /// The unit used for the measure of this nutrient
        /// </summary>
        /// <value>The unit used for the measure of this nutrient</value>
        [DataMember(Name="measurement_unit", EmitDefaultValue=false)]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// Minimum nutrient value
        /// </summary>
        /// <value>Minimum nutrient value</value>
        [DataMember(Name="min", EmitDefaultValue=false)]
        public decimal? Min { get; set; }

        /// <summary>
        /// Maximum nutrient value
        /// </summary>
        /// <value>Maximum nutrient value</value>
        [DataMember(Name="max", EmitDefaultValue=false)]
        public decimal? Max { get; set; }

        /// <summary>
        /// Median nutrient value
        /// </summary>
        /// <value>Median nutrient value</value>
        [DataMember(Name="median", EmitDefaultValue=false)]
        public decimal? Median { get; set; }

        /// <summary>
        /// Nutrient rank
        /// </summary>
        /// <value>Nutrient rank</value>
        [DataMember(Name="rank", EmitDefaultValue=false)]
        public int? Rank { get; set; }

        /// <summary>
        /// Number of observations on which the value is based
        /// </summary>
        /// <value>Number of observations on which the value is based</value>
        [DataMember(Name="data_points", EmitDefaultValue=false)]
        public int? DataPoints { get; set; }

        /// <summary>
        /// Comments on any unusual aspect of the food nutrient. Examples might include why a nutrient value is different than typically expected.
        /// </summary>
        /// <value>Comments on any unusual aspect of the food nutrient. Examples might include why a nutrient value is different than typically expected.</value>
        [DataMember(Name="footnote", EmitDefaultValue=false)]
        public string Footnote { get; set; }

        /// <summary>
        /// Description of the nutrient source
        /// </summary>
        /// <value>Description of the nutrient source</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IngredientObjectNutrients {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Per100g: ").Append(Per100g).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  Min: ").Append(Min).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
            sb.Append("  Median: ").Append(Median).Append("\n");
            sb.Append("  Rank: ").Append(Rank).Append("\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
            sb.Append("  Footnote: ").Append(Footnote).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as IngredientObjectNutrients);
        }

        /// <summary>
        /// Returns true if IngredientObjectNutrients instances are equal
        /// </summary>
        /// <param name="input">Instance of IngredientObjectNutrients to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IngredientObjectNutrients input)
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
                    this.Per100g == input.Per100g ||
                    (this.Per100g != null &&
                    this.Per100g.Equals(input.Per100g))
                ) && 
                (
                    this.MeasurementUnit == input.MeasurementUnit ||
                    (this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(input.MeasurementUnit))
                ) && 
                (
                    this.Min == input.Min ||
                    (this.Min != null &&
                    this.Min.Equals(input.Min))
                ) && 
                (
                    this.Max == input.Max ||
                    (this.Max != null &&
                    this.Max.Equals(input.Max))
                ) && 
                (
                    this.Median == input.Median ||
                    (this.Median != null &&
                    this.Median.Equals(input.Median))
                ) && 
                (
                    this.Rank == input.Rank ||
                    (this.Rank != null &&
                    this.Rank.Equals(input.Rank))
                ) && 
                (
                    this.DataPoints == input.DataPoints ||
                    (this.DataPoints != null &&
                    this.DataPoints.Equals(input.DataPoints))
                ) && 
                (
                    this.Footnote == input.Footnote ||
                    (this.Footnote != null &&
                    this.Footnote.Equals(input.Footnote))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Per100g != null)
                    hashCode = hashCode * 59 + this.Per100g.GetHashCode();
                if (this.MeasurementUnit != null)
                    hashCode = hashCode * 59 + this.MeasurementUnit.GetHashCode();
                if (this.Min != null)
                    hashCode = hashCode * 59 + this.Min.GetHashCode();
                if (this.Max != null)
                    hashCode = hashCode * 59 + this.Max.GetHashCode();
                if (this.Median != null)
                    hashCode = hashCode * 59 + this.Median.GetHashCode();
                if (this.Rank != null)
                    hashCode = hashCode * 59 + this.Rank.GetHashCode();
                if (this.DataPoints != null)
                    hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
                if (this.Footnote != null)
                    hashCode = hashCode * 59 + this.Footnote.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
