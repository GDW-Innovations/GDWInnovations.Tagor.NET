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
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TagorClient.Client.OpenAPIDateConverter;

namespace TagorClient.Model
{
    /// <summary>
    /// ActionsSendSmsRequestRequest
    /// </summary>
    [DataContract(Name = "ActionsSendSms_request_request")]
    public partial class ActionsSendSmsRequestRequest : IValidatableObject
    {
        /// <summary>
        /// Defines CodeSms
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeSmsEnum
        {
            /// <summary>
            /// Enum SALDO for value: SALDO
            /// </summary>
            [EnumMember(Value = "SALDO")]
            SALDO = 1,

            /// <summary>
            /// Enum AFBETALINGSPLAN for value: AFBETALINGSPLAN
            /// </summary>
            [EnumMember(Value = "AFBETALINGSPLAN")]
            AFBETALINGSPLAN = 2
        }


        /// <summary>
        /// Gets or Sets CodeSms
        /// </summary>
        [DataMember(Name = "CodeSms", IsRequired = true, EmitDefaultValue = true)]
        public CodeSmsEnum CodeSms { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSendSmsRequestRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ActionsSendSmsRequestRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionsSendSmsRequestRequest" /> class.
        /// </summary>
        /// <param name="tDOSId">tDOSId.</param>
        /// <param name="tPARId">tPARId.</param>
        /// <param name="gsmnr">gsmnr.</param>
        /// <param name="codeSms">codeSms (required).</param>
        public ActionsSendSmsRequestRequest(string tDOSId = default(string), string tPARId = default(string), string gsmnr = default(string), CodeSmsEnum codeSms = default(CodeSmsEnum))
        {
            this.CodeSms = codeSms;
            this.TDOSId = tDOSId;
            this.TPARId = tPARId;
            this.Gsmnr = gsmnr;
        }

        /// <summary>
        /// Gets or Sets TDOSId
        /// </summary>
        [DataMember(Name = "TDOS_Id", EmitDefaultValue = false)]
        public string TDOSId { get; set; }

        /// <summary>
        /// Gets or Sets TPARId
        /// </summary>
        [DataMember(Name = "TPAR_Id", EmitDefaultValue = false)]
        public string TPARId { get; set; }

        /// <summary>
        /// Gets or Sets Gsmnr
        /// </summary>
        [DataMember(Name = "Gsmnr", EmitDefaultValue = false)]
        public string Gsmnr { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ActionsSendSmsRequestRequest {\n");
            sb.Append("  TDOSId: ").Append(TDOSId).Append("\n");
            sb.Append("  TPARId: ").Append(TPARId).Append("\n");
            sb.Append("  Gsmnr: ").Append(Gsmnr).Append("\n");
            sb.Append("  CodeSms: ").Append(CodeSms).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
