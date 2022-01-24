/*
 Avalara API Client Library
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 * The version of SDK  : 22.1.0
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Avalara.SDK.Api;
using Avalara.SDK.Model;
using Avalara.SDK.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Avalara.SDK.Test.Model
{
    /// <summary>
    ///  Class for testing AgeVerifyRequestAddress
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AgeVerifyRequestAddressTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AgeVerifyRequestAddress
        //private AgeVerifyRequestAddress instance;

        public AgeVerifyRequestAddressTests()
        {
            // TODO uncomment below to create an instance of AgeVerifyRequestAddress
            //instance = new AgeVerifyRequestAddress();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AgeVerifyRequestAddress
        /// </summary>
        [Fact]
        public void AgeVerifyRequestAddressInstanceTest()
        {
            // TODO uncomment below to test "IsType" AgeVerifyRequestAddress
            //Assert.IsType<AgeVerifyRequestAddress>(instance);
        }


        /// <summary>
        /// Test the property 'Line1'
        /// </summary>
        [Fact]
        public void Line1Test()
        {
            // TODO unit test for the property 'Line1'
        }
        /// <summary>
        /// Test the property 'City'
        /// </summary>
        [Fact]
        public void CityTest()
        {
            // TODO unit test for the property 'City'
        }
        /// <summary>
        /// Test the property 'Region'
        /// </summary>
        [Fact]
        public void RegionTest()
        {
            // TODO unit test for the property 'Region'
        }
        /// <summary>
        /// Test the property 'Country'
        /// </summary>
        [Fact]
        public void CountryTest()
        {
            // TODO unit test for the property 'Country'
        }
        /// <summary>
        /// Test the property 'PostalCode'
        /// </summary>
        [Fact]
        public void PostalCodeTest()
        {
            // TODO unit test for the property 'PostalCode'
        }

    }

}