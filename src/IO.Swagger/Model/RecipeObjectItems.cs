/* 
 * Chomp Food & Recipe Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. * Get a **Food Data API** key at **[https://chompthis.com/api](https://chompthis.com/api/)**. * Get a **Recipe Data API** key at **[https://chompthis.com/api/recipes](https://chompthis.com/api/recipes/)**.  ### Getting Started   * Subscribe to the **[Food Data API](https://chompthis.com/api/#pricing)** or the **[Recipe Data API](https://chompthis.com/api/recipes/#pricing)**.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**   * Recipe response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/example-recipe-response.json)**   * Error response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/error-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### I'm a Premium subscriber. How do I access the API?   * All Premium subscribers must pass in a unique user ID for each user on their platform that is accessing data from the Chomp API. A user ID can be any string of letters and numbers that you assign to your user. Simply add \"user_id\" as a URL parameter when calling the API. *You must add a \"user_id\" URL parameter to every call you make to ANY endpoint.*     * **Example**        > ```ENDPOINT.php?api_key=API_KEY&code=CODE&user_id=USER_ID```  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Food Data API Subscription Options &raquo;](https://chompthis.com/api/)     * [Recipe Data API Subscription Options &raquo;](https://chompthis.com/api/recipes/)     * [Food Data API Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)     * [Recipe Data API Cost Calculator &raquo;](https://chompthis.com/api/recipes/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
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
    /// An object containing information for this specific item.
    /// </summary>
    [DataContract]
        public partial class RecipeObjectItems :  IEquatable<RecipeObjectItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeObjectItems" /> class.
        /// </summary>
        /// <param name="id">Unique recipe ID.</param>
        /// <param name="title">Recipe title.</param>
        /// <param name="meta">meta.</param>
        /// <param name="categories">categories.</param>
        /// <param name="author">The author of this recipe. You must attribute this author when displaying this recipe..</param>
        /// <param name="keywords">keywords.</param>
        /// <param name="topics">topics.</param>
        /// <param name="attributes">attributes.</param>
        /// <param name="ingredients">An array containing this recipe&#x27;s ingredients.</param>
        /// <param name="baseIngredients">baseIngredients.</param>
        /// <param name="nutrients">nutrients.</param>
        /// <param name="diabeticExchanges">diabeticExchanges.</param>
        public RecipeObjectItems(string id = default(string), string title = default(string), RecipeObjectMeta meta = default(RecipeObjectMeta), List<string> categories = default(List<string>), string author = default(string), List<string> keywords = default(List<string>), List<string> topics = default(List<string>), RecipeObjectAttributes attributes = default(RecipeObjectAttributes), List<RecipeObjectIngredients> ingredients = default(List<RecipeObjectIngredients>), List<string> baseIngredients = default(List<string>), RecipeObjectNutrients nutrients = default(RecipeObjectNutrients), List<string> diabeticExchanges = default(List<string>))
        {
            this.Id = id;
            this.Title = title;
            this.Meta = meta;
            this.Categories = categories;
            this.Author = author;
            this.Keywords = keywords;
            this.Topics = topics;
            this.Attributes = attributes;
            this.Ingredients = ingredients;
            this.BaseIngredients = baseIngredients;
            this.Nutrients = nutrients;
            this.DiabeticExchanges = diabeticExchanges;
        }
        
        /// <summary>
        /// Unique recipe ID
        /// </summary>
        /// <value>Unique recipe ID</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Recipe title
        /// </summary>
        /// <value>Recipe title</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name="meta", EmitDefaultValue=false)]
        public RecipeObjectMeta Meta { get; set; }

        /// <summary>
        /// Gets or Sets Categories
        /// </summary>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<string> Categories { get; set; }

        /// <summary>
        /// The author of this recipe. You must attribute this author when displaying this recipe.
        /// </summary>
        /// <value>The author of this recipe. You must attribute this author when displaying this recipe.</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public string Author { get; set; }

        /// <summary>
        /// Gets or Sets Keywords
        /// </summary>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// Gets or Sets Topics
        /// </summary>
        [DataMember(Name="topics", EmitDefaultValue=false)]
        public List<string> Topics { get; set; }

        /// <summary>
        /// Gets or Sets Attributes
        /// </summary>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public RecipeObjectAttributes Attributes { get; set; }

        /// <summary>
        /// An array containing this recipe&#x27;s ingredients
        /// </summary>
        /// <value>An array containing this recipe&#x27;s ingredients</value>
        [DataMember(Name="ingredients", EmitDefaultValue=false)]
        public List<RecipeObjectIngredients> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets BaseIngredients
        /// </summary>
        [DataMember(Name="base_ingredients", EmitDefaultValue=false)]
        public List<string> BaseIngredients { get; set; }

        /// <summary>
        /// Gets or Sets Nutrients
        /// </summary>
        [DataMember(Name="nutrients", EmitDefaultValue=false)]
        public RecipeObjectNutrients Nutrients { get; set; }

        /// <summary>
        /// Gets or Sets DiabeticExchanges
        /// </summary>
        [DataMember(Name="diabetic_exchanges", EmitDefaultValue=false)]
        public List<string> DiabeticExchanges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipeObjectItems {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  Topics: ").Append(Topics).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  BaseIngredients: ").Append(BaseIngredients).Append("\n");
            sb.Append("  Nutrients: ").Append(Nutrients).Append("\n");
            sb.Append("  DiabeticExchanges: ").Append(DiabeticExchanges).Append("\n");
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
            return this.Equals(input as RecipeObjectItems);
        }

        /// <summary>
        /// Returns true if RecipeObjectItems instances are equal
        /// </summary>
        /// <param name="input">Instance of RecipeObjectItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipeObjectItems input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.Topics == input.Topics ||
                    this.Topics != null &&
                    input.Topics != null &&
                    this.Topics.SequenceEqual(input.Topics)
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Ingredients == input.Ingredients ||
                    this.Ingredients != null &&
                    input.Ingredients != null &&
                    this.Ingredients.SequenceEqual(input.Ingredients)
                ) && 
                (
                    this.BaseIngredients == input.BaseIngredients ||
                    this.BaseIngredients != null &&
                    input.BaseIngredients != null &&
                    this.BaseIngredients.SequenceEqual(input.BaseIngredients)
                ) && 
                (
                    this.Nutrients == input.Nutrients ||
                    (this.Nutrients != null &&
                    this.Nutrients.Equals(input.Nutrients))
                ) && 
                (
                    this.DiabeticExchanges == input.DiabeticExchanges ||
                    this.DiabeticExchanges != null &&
                    input.DiabeticExchanges != null &&
                    this.DiabeticExchanges.SequenceEqual(input.DiabeticExchanges)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Meta != null)
                    hashCode = hashCode * 59 + this.Meta.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.Keywords != null)
                    hashCode = hashCode * 59 + this.Keywords.GetHashCode();
                if (this.Topics != null)
                    hashCode = hashCode * 59 + this.Topics.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Ingredients != null)
                    hashCode = hashCode * 59 + this.Ingredients.GetHashCode();
                if (this.BaseIngredients != null)
                    hashCode = hashCode * 59 + this.BaseIngredients.GetHashCode();
                if (this.Nutrients != null)
                    hashCode = hashCode * 59 + this.Nutrients.GetHashCode();
                if (this.DiabeticExchanges != null)
                    hashCode = hashCode * 59 + this.DiabeticExchanges.GetHashCode();
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
