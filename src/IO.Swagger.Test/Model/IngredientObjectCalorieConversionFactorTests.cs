/* 
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ### Helpful Links   * **Help & Support**     * [Knowledge Base &raquo;](https://desk.zoho.com/portal/chompthis/kb/chomp)     * [Support &raquo;](https://chompthis.com/api/ticket-new.php)     * [Client Center &raquo;](https://chompthis.com/api/manage.php)   * **Pricing**     * [Subscription Options &raquo;](https://chompthis.com/api/)     * [Cost Calculator &raquo;](https://chompthis.com/api/cost-calculator.php)   * **Guidelines**     * [Terms & License &raquo;](https://chompthis.com/api/terms.php)     * [Attribution &raquo;](https://chompthis.com/api/docs/attribution.php) 
 *
 * OpenAPI spec version: 1.0.0-oas3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using IO.Swagger.Api;
using IO.Swagger.Model;
using IO.Swagger.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing IngredientObjectCalorieConversionFactor
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class IngredientObjectCalorieConversionFactorTests
    {
        // TODO uncomment below to declare an instance variable for IngredientObjectCalorieConversionFactor
        //private IngredientObjectCalorieConversionFactor instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of IngredientObjectCalorieConversionFactor
            //instance = new IngredientObjectCalorieConversionFactor();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of IngredientObjectCalorieConversionFactor
        /// </summary>
        [Test]
        public void IngredientObjectCalorieConversionFactorInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" IngredientObjectCalorieConversionFactor
            //Assert.IsInstanceOfType<IngredientObjectCalorieConversionFactor> (instance, "variable 'instance' is a IngredientObjectCalorieConversionFactor");
        }


        /// <summary>
        /// Test the property 'ProteinValue'
        /// </summary>
        [Test]
        public void ProteinValueTest()
        {
            // TODO unit test for the property 'ProteinValue'
        }
        /// <summary>
        /// Test the property 'FatValue'
        /// </summary>
        [Test]
        public void FatValueTest()
        {
            // TODO unit test for the property 'FatValue'
        }
        /// <summary>
        /// Test the property 'CarbohydrateValue'
        /// </summary>
        [Test]
        public void CarbohydrateValueTest()
        {
            // TODO unit test for the property 'CarbohydrateValue'
        }

    }

}