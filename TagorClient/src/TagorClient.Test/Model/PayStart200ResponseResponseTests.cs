/*
 * Tagor API
 *
 * Release date: 29/09/2022  ## REQUIREMENTS This version __requires__ Tagor >= 2.00.0000B0. Use [`Config/Info`](#operation/ConfigInfo) to get the active API version.  ## CHANGELOG - New [`Dossier/CreateAgenda`](#operation/DossierCreateAgenda) endpoint. - New return values in GetAgenda 'TJOB_Id, TJOBM_Id, TUSER_Id, Manueel and IsGeblokkeerd' - In CreateLine you can now add if the line is fixed with 'IsFixed' - In CreateLine you can now add a subarray with the intrests  ## INFO - Using the download button at the top you can import this collection of endpoints in **Postman** - In general all TQ(...)_Id fields are default fields which you can translate with the [`Code/GetDescription`](#operation/CodeGetDescription) endpoint. If you need an id to post to one of the endpoints you can use the [`Code/GetList`](#operation/CodeGetList) endpoint to get all possible values or [`Code/GetDescription`](#operation/CodeGetDescription) to get a value by code. These id's will be marked as `code id` in the documentation. - We chose to return all ids as string because these are 64bit integers which are too big for javascript to handle. - All italic text below the endpoint description is meant for people with access to Tagor. - The user needs an email address configured in Tagor for the services to work properly. - Pass the `Accept` header with `application/json` as value to have the server return errors in json format. - Most endpoints can be batched/paged by passing a `BATCH-SIZE` and `BATCH-NUMBER` record in `dsWebContext`.  # AUTHENTICATION Pass your token via an `Authorization` header like this: `Authorization: {bearer_format} {token}`.  ex: `Authorization: TGR IcoQbVw7wE...PPUPda61ET` <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2.00.0000B1
 * Contact: info@organi.be
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using TagorClient.Model;
using TagorClient.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace TagorClient.Test.Model
{
    /// <summary>
    ///  Class for testing PayStart200ResponseResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PayStart200ResponseResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for PayStart200ResponseResponse
        //private PayStart200ResponseResponse instance;

        public PayStart200ResponseResponseTests()
        {
            // TODO uncomment below to create an instance of PayStart200ResponseResponse
            //instance = new PayStart200ResponseResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PayStart200ResponseResponse
        /// </summary>
        [Fact]
        public void PayStart200ResponseResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" PayStart200ResponseResponse
            //Assert.IsType<PayStart200ResponseResponse>(instance);
        }

        /// <summary>
        /// Test the property 'RedirectionData'
        /// </summary>
        [Fact]
        public void RedirectionDataTest()
        {
            // TODO unit test for the property 'RedirectionData'
        }

        /// <summary>
        /// Test the property 'RedirectionStatusCode'
        /// </summary>
        [Fact]
        public void RedirectionStatusCodeTest()
        {
            // TODO unit test for the property 'RedirectionStatusCode'
        }

        /// <summary>
        /// Test the property 'RedirectionStatusMessage'
        /// </summary>
        [Fact]
        public void RedirectionStatusMessageTest()
        {
            // TODO unit test for the property 'RedirectionStatusMessage'
        }

        /// <summary>
        /// Test the property 'RedirectionUrl'
        /// </summary>
        [Fact]
        public void RedirectionUrlTest()
        {
            // TODO unit test for the property 'RedirectionUrl'
        }

        /// <summary>
        /// Test the property 'RedirectionVersion'
        /// </summary>
        [Fact]
        public void RedirectionVersionTest()
        {
            // TODO unit test for the property 'RedirectionVersion'
        }

        /// <summary>
        /// Test the property 'Seal'
        /// </summary>
        [Fact]
        public void SealTest()
        {
            // TODO unit test for the property 'Seal'
        }
    }
}
