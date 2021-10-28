/*
 * Ory Kratos API
 *
 * Documentation for all public and administrative Ory Kratos APIs. Public and administrative APIs are exposed on different ports. Public APIs can face the public internet without any protection while administrative APIs should never be exposed without prior authorization. To protect the administative API port you should use something like Nginx, Ory Oathkeeper, or any other technology capable of authorizing incoming requests. 
 *
 * The version of the OpenAPI document: v0.8.0-alpha.2
 * Contact: hi@ory.sh
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Ory.Kratos.Client.Api;
using Ory.Kratos.Client.Model;
using Ory.Kratos.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Ory.Kratos.Client.Test.Model
{
    /// <summary>
    ///  Class for testing KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBodyTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
        //private KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody instance;

        public KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBodyTests()
        {
            // TODO uncomment below to create an instance of KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
            //instance = new KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
        /// </summary>
        [Fact]
        public void KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBodyInstanceTest()
        {
            // TODO uncomment below to test "IsType" KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody
            //Assert.IsType<KratosSubmitSelfServiceSettingsFlowWithWebAuthnMethodBody>(instance);
        }


        /// <summary>
        /// Test the property 'CsrfToken'
        /// </summary>
        [Fact]
        public void CsrfTokenTest()
        {
            // TODO unit test for the property 'CsrfToken'
        }
        /// <summary>
        /// Test the property 'Method'
        /// </summary>
        [Fact]
        public void MethodTest()
        {
            // TODO unit test for the property 'Method'
        }
        /// <summary>
        /// Test the property 'WebauthnRegister'
        /// </summary>
        [Fact]
        public void WebauthnRegisterTest()
        {
            // TODO unit test for the property 'WebauthnRegister'
        }
        /// <summary>
        /// Test the property 'WebauthnRegisterDisplayname'
        /// </summary>
        [Fact]
        public void WebauthnRegisterDisplaynameTest()
        {
            // TODO unit test for the property 'WebauthnRegisterDisplayname'
        }
        /// <summary>
        /// Test the property 'WebauthnRemove'
        /// </summary>
        [Fact]
        public void WebauthnRemoveTest()
        {
            // TODO unit test for the property 'WebauthnRemove'
        }

    }

}
