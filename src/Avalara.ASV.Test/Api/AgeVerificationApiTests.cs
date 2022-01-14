/*
 * Avalara Shipping Verification for Beverage Alcohol
 *
 * API for evaluating transactions against direct-to-consumer Beverage Alcohol shipping regulations.  This API is currently in beta. 
 *
 Generated by AVALARA
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Avalara.ASV.Client;
using Avalara.ASV.Api;
// uncomment below to import models
//using Avalara.ASV.Model;

namespace Avalara.ASV.Test.Api
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
