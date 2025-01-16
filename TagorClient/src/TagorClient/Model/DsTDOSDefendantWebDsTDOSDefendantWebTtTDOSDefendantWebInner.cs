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
    /// DsTDOSDefendantWebDsTDOSDefendantWebTtTDOSDefendantWebInner
    /// </summary>
    [DataContract(Name = "dsTDOSDefendantWeb_dsTDOSDefendantWeb_ttTDOSDefendantWeb_inner")]
    public partial class DsTDOSDefendantWebDsTDOSDefendantWebTtTDOSDefendantWebInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsTDOSDefendantWebDsTDOSDefendantWebTtTDOSDefendantWebInner" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="statusId">statusId.</param>
        /// <param name="defendant">defendant.</param>
        /// <param name="creditor">creditor.</param>
        /// <param name="balanceDefendant">balanceDefendant.</param>
        /// <param name="balanceOffice">balanceOffice.</param>
        /// <param name="fileName">fileName.</param>
        public DsTDOSDefendantWebDsTDOSDefendantWebTtTDOSDefendantWebInner(string id = default(string), string statusId = default(string), string defendant = default(string), string creditor = default(string), decimal balanceDefendant = default(decimal), decimal balanceOffice = default(decimal), string fileName = default(string))
        {
            this.Id = id;
            this.StatusId = statusId;
            this.Defendant = defendant;
            this.Creditor = creditor;
            this.BalanceDefendant = balanceDefendant;
            this.BalanceOffice = balanceOffice;
            this.FileName = fileName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name = "status_id&quot;", EmitDefaultValue = false)]
        public string StatusId { get; set; }

        /// <summary>
        /// Gets or Sets Defendant
        /// </summary>
        [DataMember(Name = "defendant&quot;", EmitDefaultValue = false)]
        public string Defendant { get; set; }

        /// <summary>
        /// Gets or Sets Creditor
        /// </summary>
        [DataMember(Name = "creditor&quot;", EmitDefaultValue = false)]
        public string Creditor { get; set; }

        /// <summary>
        /// Gets or Sets BalanceDefendant
        /// </summary>
        [DataMember(Name = "balance_defendant&quot;", EmitDefaultValue = false)]
        public decimal BalanceDefendant { get; set; }

        /// <summary>
        /// Gets or Sets BalanceOffice
        /// </summary>
        [DataMember(Name = "balance_office&quot;", EmitDefaultValue = false)]
        public decimal BalanceOffice { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        [DataMember(Name = "file_name", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DsTDOSDefendantWebDsTDOSDefendantWebTtTDOSDefendantWebInner {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  Defendant: ").Append(Defendant).Append("\n");
            sb.Append("  Creditor: ").Append(Creditor).Append("\n");
            sb.Append("  BalanceDefendant: ").Append(BalanceDefendant).Append("\n");
            sb.Append("  BalanceOffice: ").Append(BalanceOffice).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
