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
 * @version    2.4.13
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Model;
using Org.OpenAPITools.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Org.OpenAPITools.Test.Model
{
    /// <summary>
    ///  Class for testing AgeVerifyRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class AgeVerifyRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for AgeVerifyRequest
        //private AgeVerifyRequest instance;

        public AgeVerifyRequestTests()
        {
            // TODO uncomment below to create an instance of AgeVerifyRequest
            //instance = new AgeVerifyRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AgeVerifyRequest
        /// </summary>
        [Fact]
        public void AgeVerifyRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" AgeVerifyRequest
            //Assert.IsType<AgeVerifyRequest>(instance);
        }


        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Fact]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Fact]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'Address'
        /// </summary>
        [Fact]
        public void AddressTest()
        {
            // TODO unit test for the property 'Address'
        }
        /// <summary>
        /// Test the property 'DOB'
        /// </summary>
        [Fact]
        public void DOBTest()
        {
            // TODO unit test for the property 'DOB'
        }

    }

}
