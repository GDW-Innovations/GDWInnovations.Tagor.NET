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
    ///  Class for testing DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInnerTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner
        //private DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner instance;

        public DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInnerTests()
        {
            // TODO uncomment below to create an instance of DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner
            //instance = new DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner
        /// </summary>
        [Fact]
        public void DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInnerInstanceTest()
        {
            // TODO uncomment below to test "IsType" DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner
            //Assert.IsType<DsTDOSPARWebDsTDOSPARWebTtTDOSPARWebInner>(instance);
        }

        /// <summary>
        /// Test the property 'TPARId'
        /// </summary>
        [Fact]
        public void TPARIdTest()
        {
            // TODO unit test for the property 'TPARId'
        }

        /// <summary>
        /// Test the property 'Beroep'
        /// </summary>
        [Fact]
        public void BeroepTest()
        {
            // TODO unit test for the property 'Beroep'
        }

        /// <summary>
        /// Test the property 'GSM'
        /// </summary>
        [Fact]
        public void GSMTest()
        {
            // TODO unit test for the property 'GSM'
        }

        /// <summary>
        /// Test the property 'Naam'
        /// </summary>
        [Fact]
        public void NaamTest()
        {
            // TODO unit test for the property 'Naam'
        }

        /// <summary>
        /// Test the property 'Plaats'
        /// </summary>
        [Fact]
        public void PlaatsTest()
        {
            // TODO unit test for the property 'Plaats'
        }

        /// <summary>
        /// Test the property 'Postcode'
        /// </summary>
        [Fact]
        public void PostcodeTest()
        {
            // TODO unit test for the property 'Postcode'
        }

        /// <summary>
        /// Test the property 'Referentie'
        /// </summary>
        [Fact]
        public void ReferentieTest()
        {
            // TODO unit test for the property 'Referentie'
        }

        /// <summary>
        /// Test the property 'RekNr'
        /// </summary>
        [Fact]
        public void RekNrTest()
        {
            // TODO unit test for the property 'RekNr'
        }

        /// <summary>
        /// Test the property 'Straat'
        /// </summary>
        [Fact]
        public void StraatTest()
        {
            // TODO unit test for the property 'Straat'
        }

        /// <summary>
        /// Test the property 'StraatBusNr'
        /// </summary>
        [Fact]
        public void StraatBusNrTest()
        {
            // TODO unit test for the property 'StraatBusNr'
        }

        /// <summary>
        /// Test the property 'StraatNr'
        /// </summary>
        [Fact]
        public void StraatNrTest()
        {
            // TODO unit test for the property 'StraatNr'
        }

        /// <summary>
        /// Test the property 'Tel'
        /// </summary>
        [Fact]
        public void TelTest()
        {
            // TODO unit test for the property 'Tel'
        }

        /// <summary>
        /// Test the property 'TQPARSOORTId'
        /// </summary>
        [Fact]
        public void TQPARSOORTIdTest()
        {
            // TODO unit test for the property 'TQPARSOORTId'
        }

        /// <summary>
        /// Test the property 'TQSOLVABILITEITIdAdres'
        /// </summary>
        [Fact]
        public void TQSOLVABILITEITIdAdresTest()
        {
            // TODO unit test for the property 'TQSOLVABILITEITIdAdres'
        }

        /// <summary>
        /// Test the property 'TQSOLVABILITEITIdFinancieel'
        /// </summary>
        [Fact]
        public void TQSOLVABILITEITIdFinancieelTest()
        {
            // TODO unit test for the property 'TQSOLVABILITEITIdFinancieel'
        }

        /// <summary>
        /// Test the property 'SolvDtmAdres'
        /// </summary>
        [Fact]
        public void SolvDtmAdresTest()
        {
            // TODO unit test for the property 'SolvDtmAdres'
        }

        /// <summary>
        /// Test the property 'SolvDtmFinan'
        /// </summary>
        [Fact]
        public void SolvDtmFinanTest()
        {
            // TODO unit test for the property 'SolvDtmFinan'
        }

        /// <summary>
        /// Test the property 'KBOnr'
        /// </summary>
        [Fact]
        public void KBOnrTest()
        {
            // TODO unit test for the property 'KBOnr'
        }

        /// <summary>
        /// Test the property 'NationaalNr'
        /// </summary>
        [Fact]
        public void NationaalNrTest()
        {
            // TODO unit test for the property 'NationaalNr'
        }

        /// <summary>
        /// Test the property 'PartijVorm'
        /// </summary>
        [Fact]
        public void PartijVormTest()
        {
            // TODO unit test for the property 'PartijVorm'
        }

        /// <summary>
        /// Test the property 'Mail'
        /// </summary>
        [Fact]
        public void MailTest()
        {
            // TODO unit test for the property 'Mail'
        }
    }
}
