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
 * @version    2.4.14-beta
 * @link       https://github.com/avadev/AvaTax-REST-V3-DotNet-SDK
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
    ///  Class for testing ErrorDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ErrorDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for ErrorDetails
        //private ErrorDetails instance;

        public ErrorDetailsTests()
        {
            // TODO uncomment below to create an instance of ErrorDetails
            //instance = new ErrorDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ErrorDetails
        /// </summary>
        [Fact]
        public void ErrorDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" ErrorDetails
            //Assert.IsType<ErrorDetails>(instance);
        }


        /// <summary>
        /// Test the property 'Error'
        /// </summary>
        [Fact]
        public void ErrorTest()
        {
            // TODO unit test for the property 'Error'
        }

    }

}
