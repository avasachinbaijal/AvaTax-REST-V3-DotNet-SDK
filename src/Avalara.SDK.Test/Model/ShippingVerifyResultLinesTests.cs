/*
 Avalara API Client Library
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 * The version of SDK  : 2.1.5
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
    ///  Class for testing ShippingVerifyResultLines
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ShippingVerifyResultLinesTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ShippingVerifyResultLines
        //private ShippingVerifyResultLines instance;

        public ShippingVerifyResultLinesTests()
        {
            // TODO uncomment below to create an instance of ShippingVerifyResultLines
            //instance = new ShippingVerifyResultLines();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ShippingVerifyResultLines
        /// </summary>
        [Fact]
        public void ShippingVerifyResultLinesInstanceTest()
        {
            // TODO uncomment below to test "IsType" ShippingVerifyResultLines
            //Assert.IsType<ShippingVerifyResultLines>(instance);
        }


        /// <summary>
        /// Test the property 'ResultCode'
        /// </summary>
        [Fact]
        public void ResultCodeTest()
        {
            // TODO unit test for the property 'ResultCode'
        }
        /// <summary>
        /// Test the property 'LineNumber'
        /// </summary>
        [Fact]
        public void LineNumberTest()
        {
            // TODO unit test for the property 'LineNumber'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Fact]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }
        /// <summary>
        /// Test the property 'SuccessMessages'
        /// </summary>
        [Fact]
        public void SuccessMessagesTest()
        {
            // TODO unit test for the property 'SuccessMessages'
        }
        /// <summary>
        /// Test the property 'FailureMessages'
        /// </summary>
        [Fact]
        public void FailureMessagesTest()
        {
            // TODO unit test for the property 'FailureMessages'
        }
        /// <summary>
        /// Test the property 'FailureCodes'
        /// </summary>
        [Fact]
        public void FailureCodesTest()
        {
            // TODO unit test for the property 'FailureCodes'
        }

    }

}
