/*
 * AvaTax Software Development Kit for C#
 *
 * (c) 2004-2022 Avalara, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Avalara Shipping Verification only
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *

 * @author     Sachin Baijal <sachin.baijal@avalara.com>
 * @author     Jonathan Wenger <jonathan.wenger@avalara.com>
 * @copyright  2004-2022 Avalara, Inc.
 * @license    https://www.apache.org/licenses/LICENSE-2.0
 * @version    2.4.19
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing AgeVerificationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AgeVerificationApiTests : IDisposable
    {
        private AgeVerificationApi instance;

        public AgeVerificationApiTests()
        {
            instance = new AgeVerificationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AgeVerificationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AgeVerificationApi
            //Assert.IsType<AgeVerificationApi>(instance);
        }

        /// <summary>
        /// Test VerifyAge
        /// </summary>
        [Fact]
        public void VerifyAgeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //AgeVerifyRequest ageVerifyRequest = null;
            //AgeVerifyFailureCode? simulatedFailureCode = null;
            //var response = instance.VerifyAge(ageVerifyRequest, simulatedFailureCode);
            //Assert.IsType<AgeVerifyResult>(response);
        }
    }
}