/*
 * Tagor API
 *
 * Release date: 29/09/2022  ## REQUIREMENTS This version __requires__ Tagor >= 2.00.0000B0. Use [`Config/Info`](#operation/ConfigInfo) to get the active API version.  ## CHANGELOG - New [`Dossier/CreateAgenda`](#operation/DossierCreateAgenda) endpoint. - New return values in GetAgenda 'TJOB_Id, TJOBM_Id, TUSER_Id, Manueel and IsGeblokkeerd' - In CreateLine you can now add if the line is fixed with 'IsFixed' - In CreateLine you can now add a subarray with the intrests  ## INFO - Using the download button at the top you can import this collection of endpoints in **Postman** - In general all TQ(...)_Id fields are default fields which you can translate with the [`Code/GetDescription`](#operation/CodeGetDescription) endpoint. If you need an id to post to one of the endpoints you can use the [`Code/GetList`](#operation/CodeGetList) endpoint to get all possible values or [`Code/GetDescription`](#operation/CodeGetDescription) to get a value by code. These id's will be marked as `code id` in the documentation. - We chose to return all ids as string because these are 64bit integers which are too big for javascript to handle. - All italic text below the endpoint description is meant for people with access to Tagor. - The user needs an email address configured in Tagor for the services to work properly. - Pass the `Accept` header with `application/json` as value to have the server return errors in json format. - Most endpoints can be batched/paged by passing a `BATCH-SIZE` and `BATCH-NUMBER` record in `dsWebContext`.  # AUTHENTICATION Pass your token via an `Authorization` header like this: `Authorization: {bearer_format} {token}`.  ex: `Authorization: TGR IcoQbVw7wE...PPUPda61ET` <!- - ReDoc-Inject: <security-definitions> - ->
 *
 * The version of the OpenAPI document: 2.00.0000B1
 * Contact: info@organi.be
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using TagorClient.Client;
using TagorClient.Api;
// uncomment below to import models
//using TagorClient.Model;

namespace TagorClient.Test.Api
{
    /// <summary>
    ///  Class for testing MessageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MessageApiTests : IDisposable
    {
        private MessageApi instance;

        public MessageApiTests()
        {
            instance = new MessageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MessageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MessageApi
            //Assert.IsType<MessageApi>(instance);
        }

        /// <summary>
        /// Test MessageAdd
        /// </summary>
        [Fact]
        public void MessageAddTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageAddRequest? messageAddRequest = null;
            //var response = instance.MessageAdd(messageAddRequest);
            //Assert.IsType<MessageAdd200Response>(response);
        }

        /// <summary>
        /// Test MessageGetListFilter
        /// </summary>
        [Fact]
        public void MessageGetListFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DossierSearchRequest? dossierSearchRequest = null;
            //var response = instance.MessageGetListFilter(dossierSearchRequest);
            //Assert.IsType<MessageAdd200Response>(response);
        }

        /// <summary>
        /// Test MessageGetLog
        /// </summary>
        [Fact]
        public void MessageGetLogTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.MessageGetLog(codeGetListRequest);
            //Assert.IsType<MessageAdd200Response>(response);
        }

        /// <summary>
        /// Test MessageGetMessage
        /// </summary>
        [Fact]
        public void MessageGetMessageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MessageGetMessageRequest? messageGetMessageRequest = null;
            //var response = instance.MessageGetMessage(messageGetMessageRequest);
            //Assert.IsType<MessageGetMessage200Response>(response);
        }

        /// <summary>
        /// Test MessageGetSenderReceiverList
        /// </summary>
        [Fact]
        public void MessageGetSenderReceiverListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.MessageGetSenderReceiverList(codeGetListRequest);
            //Assert.IsType<ConfigInfo200Response>(response);
        }

        /// <summary>
        /// Test MessageToggleRead
        /// </summary>
        [Fact]
        public void MessageToggleReadTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CodeGetListRequest? codeGetListRequest = null;
            //var response = instance.MessageToggleRead(codeGetListRequest);
            //Assert.IsType<MessageGetMessage200Response>(response);
        }
    }
}
