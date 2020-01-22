/* 
 * Chomp Food Database API Documentation
 *
 * ## Important An **[API key](https://chompthis.com/api/)** is required for access to this API. Get yours at **[https://chompthis.com/api](https://chompthis.com/api/)**.  ### Getting Started   * **[Subscribe](https://chompthis.com/api/#pricing)** to the API.   * Scroll down and click the \"**Authorize**\" button.   * Enter your API key into the \"**value**\" input, click the \"**Authorize**\" button, then click the \"**Close**\" button.   * Scroll down to the section titled \"**default**\" and click on the API endpoint you wish to use.   * Click the \"**Try it out**\" button.   * Enter the information the endpoint requires.   * Click the \"**Execute**\" button.  ### Example    * Branded food response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/branded-food-response-object.json)**   * Ingredient response object: **[View example &raquo;](https://raw.githubusercontent.com/chompfoods/examples/master/ingredient-response-object.json)**  ### How Do I Find My API Key?   * Your API key was sent to the email address you used to create your subscription.   * You will also find your API key in the **[Client Center](https://chompthis.com/api/manage.php)**.   * Read **[this article](https://desk.zoho.com/portal/chompthis/kb/articles/how-do-i-find-my-api-key)** for more information.  ||| | - -- -- -- | - -- -- -- - | | [Knowledge Base](https://desk.zoho.com/portal/chompthis/kb/chomp) | [Pricing](https://chompthis.com/api/) | | [Attribution](https://chompthis.com/api/docs/attribution.php) | [Cost Calculator](https://chompthis.com/api/cost-calculator.php) | | [Terms & License](https://chompthis.com/api/terms.php) | [Database Search](https://chompthis.com/api/lookup.php) | | [Support](https://chompthis.com/api/ticket-new.php) | [Query Builder](https://chompthis.com/api/build.php) | | [Client Center](https://chompthis.com/api/manage.php) | | 
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
    ///  Class for testing BrandedFoodObjectItems
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class BrandedFoodObjectItemsTests
    {
        // TODO uncomment below to declare an instance variable for BrandedFoodObjectItems
        //private BrandedFoodObjectItems instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of BrandedFoodObjectItems
            //instance = new BrandedFoodObjectItems();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BrandedFoodObjectItems
        /// </summary>
        [Test]
        public void BrandedFoodObjectItemsInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" BrandedFoodObjectItems
            //Assert.IsInstanceOfType<BrandedFoodObjectItems> (instance, "variable 'instance' is a BrandedFoodObjectItems");
        }


        /// <summary>
        /// Test the property 'Barcode'
        /// </summary>
        [Test]
        public void BarcodeTest()
        {
            // TODO unit test for the property 'Barcode'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Brand'
        /// </summary>
        [Test]
        public void BrandTest()
        {
            // TODO unit test for the property 'Brand'
        }
        /// <summary>
        /// Test the property 'Ingredients'
        /// </summary>
        [Test]
        public void IngredientsTest()
        {
            // TODO unit test for the property 'Ingredients'
        }
        /// <summary>
        /// Test the property 'Package'
        /// </summary>
        [Test]
        public void PackageTest()
        {
            // TODO unit test for the property 'Package'
        }
        /// <summary>
        /// Test the property 'Serving'
        /// </summary>
        [Test]
        public void ServingTest()
        {
            // TODO unit test for the property 'Serving'
        }
        /// <summary>
        /// Test the property 'Categories'
        /// </summary>
        [Test]
        public void CategoriesTest()
        {
            // TODO unit test for the property 'Categories'
        }
        /// <summary>
        /// Test the property 'Nutrients'
        /// </summary>
        [Test]
        public void NutrientsTest()
        {
            // TODO unit test for the property 'Nutrients'
        }
        /// <summary>
        /// Test the property 'CalorieConversionFactor'
        /// </summary>
        [Test]
        public void CalorieConversionFactorTest()
        {
            // TODO unit test for the property 'CalorieConversionFactor'
        }
        /// <summary>
        /// Test the property 'ProteinConversionFactor'
        /// </summary>
        [Test]
        public void ProteinConversionFactorTest()
        {
            // TODO unit test for the property 'ProteinConversionFactor'
        }
        /// <summary>
        /// Test the property 'DietLabels'
        /// </summary>
        [Test]
        public void DietLabelsTest()
        {
            // TODO unit test for the property 'DietLabels'
        }
        /// <summary>
        /// Test the property 'DietFlags'
        /// </summary>
        [Test]
        public void DietFlagsTest()
        {
            // TODO unit test for the property 'DietFlags'
        }
        /// <summary>
        /// Test the property 'PackagingPhotos'
        /// </summary>
        [Test]
        public void PackagingPhotosTest()
        {
            // TODO unit test for the property 'PackagingPhotos'
        }
        /// <summary>
        /// Test the property 'Components'
        /// </summary>
        [Test]
        public void ComponentsTest()
        {
            // TODO unit test for the property 'Components'
        }
        /// <summary>
        /// Test the property 'Portions'
        /// </summary>
        [Test]
        public void PortionsTest()
        {
            // TODO unit test for the property 'Portions'
        }
        /// <summary>
        /// Test the property 'Allergens'
        /// </summary>
        [Test]
        public void AllergensTest()
        {
            // TODO unit test for the property 'Allergens'
        }
        /// <summary>
        /// Test the property 'BrandList'
        /// </summary>
        [Test]
        public void BrandListTest()
        {
            // TODO unit test for the property 'BrandList'
        }
        /// <summary>
        /// Test the property 'Countries'
        /// </summary>
        [Test]
        public void CountriesTest()
        {
            // TODO unit test for the property 'Countries'
        }
        /// <summary>
        /// Test the property 'CountryDetails'
        /// </summary>
        [Test]
        public void CountryDetailsTest()
        {
            // TODO unit test for the property 'CountryDetails'
        }
        /// <summary>
        /// Test the property 'PalmOilIngredients'
        /// </summary>
        [Test]
        public void PalmOilIngredientsTest()
        {
            // TODO unit test for the property 'PalmOilIngredients'
        }
        /// <summary>
        /// Test the property 'IngredientList'
        /// </summary>
        [Test]
        public void IngredientListTest()
        {
            // TODO unit test for the property 'IngredientList'
        }
        /// <summary>
        /// Test the property 'HasEnglishIngredients'
        /// </summary>
        [Test]
        public void HasEnglishIngredientsTest()
        {
            // TODO unit test for the property 'HasEnglishIngredients'
        }
        /// <summary>
        /// Test the property 'Minerals'
        /// </summary>
        [Test]
        public void MineralsTest()
        {
            // TODO unit test for the property 'Minerals'
        }
        /// <summary>
        /// Test the property 'Traces'
        /// </summary>
        [Test]
        public void TracesTest()
        {
            // TODO unit test for the property 'Traces'
        }
        /// <summary>
        /// Test the property 'Vitamins'
        /// </summary>
        [Test]
        public void VitaminsTest()
        {
            // TODO unit test for the property 'Vitamins'
        }
        /// <summary>
        /// Test the property 'CommonNames'
        /// </summary>
        [Test]
        public void CommonNamesTest()
        {
            // TODO unit test for the property 'CommonNames'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'Keywords'
        /// </summary>
        [Test]
        public void KeywordsTest()
        {
            // TODO unit test for the property 'Keywords'
        }
        /// <summary>
        /// Test the property 'Footnote'
        /// </summary>
        [Test]
        public void FootnoteTest()
        {
            // TODO unit test for the property 'Footnote'
        }

    }

}
