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
    /// TagorServiceSendMailRequestRequest
    /// </summary>
    [DataContract(Name = "TagorServiceSendMail_request_request")]
    public partial class TagorServiceSendMailRequestRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagorServiceSendMailRequestRequest" /> class.
        /// </summary>
        /// <param name="tDOSId">tDOSId.</param>
        /// <param name="tPARId">tPARId.</param>
        /// <param name="emailadres">emailadres.</param>
        /// <param name="codeEmail">codeEmail.</param>
        public TagorServiceSendMailRequestRequest(string tDOSId = default(string), string tPARId = default(string), string emailadres = default(string), string codeEmail = default(string))
        {
            this.TDOSId = tDOSId;
            this.TPARId = tPARId;
            this.Emailadres = emailadres;
            this.CodeEmail = codeEmail;
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
        /// Gets or Sets Emailadres
        /// </summary>
        [DataMember(Name = "Emailadres", EmitDefaultValue = false)]
        public string Emailadres { get; set; }

        /// <summary>
        /// Gets or Sets CodeEmail
        /// </summary>
        [DataMember(Name = "CodeEmail", EmitDefaultValue = false)]
        public string CodeEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagorServiceSendMailRequestRequest {\n");
            sb.Append("  TDOSId: ").Append(TDOSId).Append("\n");
            sb.Append("  TPARId: ").Append(TPARId).Append("\n");
            sb.Append("  Emailadres: ").Append(Emailadres).Append("\n");
            sb.Append("  CodeEmail: ").Append(CodeEmail).Append("\n");
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
