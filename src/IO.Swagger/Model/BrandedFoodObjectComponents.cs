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
    /// An object containing information on a specific component of this food item
    /// </summary>
    [DataContract]
        public partial class BrandedFoodObjectComponents :  IEquatable<BrandedFoodObjectComponents>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandedFoodObjectComponents" /> class.
        /// </summary>
        /// <param name="name">The kind of component, e.g. bone.</param>
        /// <param name="pctWeight">The weight of the component as a percentage of the total weight of the food.</param>
        /// <param name="gramWeight">The weight of the component in grams.</param>
        /// <param name="isRefuse">Whether the component is refuse, i.e. not edible.</param>
        /// <param name="dataPoints">The number of obersvations on which the measure is based.</param>
        public BrandedFoodObjectComponents(string name = default(string), decimal? pctWeight = default(decimal?), decimal? gramWeight = default(decimal?), bool? isRefuse = default(bool?), int? dataPoints = default(int?))
        {
            this.Name = name;
            this.PctWeight = pctWeight;
            this.GramWeight = gramWeight;
            this.IsRefuse = isRefuse;
            this.DataPoints = dataPoints;
        }
        
        /// <summary>
        /// The kind of component, e.g. bone
        /// </summary>
        /// <value>The kind of component, e.g. bone</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The weight of the component as a percentage of the total weight of the food
        /// </summary>
        /// <value>The weight of the component as a percentage of the total weight of the food</value>
        [DataMember(Name="pct_weight", EmitDefaultValue=false)]
        public decimal? PctWeight { get; set; }

        /// <summary>
        /// The weight of the component in grams
        /// </summary>
        /// <value>The weight of the component in grams</value>
        [DataMember(Name="gram_weight", EmitDefaultValue=false)]
        public decimal? GramWeight { get; set; }

        /// <summary>
        /// Whether the component is refuse, i.e. not edible
        /// </summary>
        /// <value>Whether the component is refuse, i.e. not edible</value>
        [DataMember(Name="is_refuse", EmitDefaultValue=false)]
        public bool? IsRefuse { get; set; }

        /// <summary>
        /// The number of obersvations on which the measure is based
        /// </summary>
        /// <value>The number of obersvations on which the measure is based</value>
        [DataMember(Name="data_points", EmitDefaultValue=false)]
        public int? DataPoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandedFoodObjectComponents {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PctWeight: ").Append(PctWeight).Append("\n");
            sb.Append("  GramWeight: ").Append(GramWeight).Append("\n");
            sb.Append("  IsRefuse: ").Append(IsRefuse).Append("\n");
            sb.Append("  DataPoints: ").Append(DataPoints).Append("\n");
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
            return this.Equals(input as BrandedFoodObjectComponents);
        }

        /// <summary>
        /// Returns true if BrandedFoodObjectComponents instances are equal
        /// </summary>
        /// <param name="input">Instance of BrandedFoodObjectComponents to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandedFoodObjectComponents input)
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
                    this.PctWeight == input.PctWeight ||
                    (this.PctWeight != null &&
                    this.PctWeight.Equals(input.PctWeight))
                ) && 
                (
                    this.GramWeight == input.GramWeight ||
                    (this.GramWeight != null &&
                    this.GramWeight.Equals(input.GramWeight))
                ) && 
                (
                    this.IsRefuse == input.IsRefuse ||
                    (this.IsRefuse != null &&
                    this.IsRefuse.Equals(input.IsRefuse))
                ) && 
                (
                    this.DataPoints == input.DataPoints ||
                    (this.DataPoints != null &&
                    this.DataPoints.Equals(input.DataPoints))
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
                if (this.PctWeight != null)
                    hashCode = hashCode * 59 + this.PctWeight.GetHashCode();
                if (this.GramWeight != null)
                    hashCode = hashCode * 59 + this.GramWeight.GetHashCode();
                if (this.IsRefuse != null)
                    hashCode = hashCode * 59 + this.IsRefuse.GetHashCode();
                if (this.DataPoints != null)
                    hashCode = hashCode * 59 + this.DataPoints.GetHashCode();
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
