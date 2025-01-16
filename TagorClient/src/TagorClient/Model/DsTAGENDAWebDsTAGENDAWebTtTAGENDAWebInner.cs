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
    /// DsTAGENDAWebDsTAGENDAWebTtTAGENDAWebInner
    /// </summary>
    [DataContract(Name = "dsTAGENDAWeb_dsTAGENDAWeb_ttTAGENDAWeb_inner")]
    public partial class DsTAGENDAWebDsTAGENDAWebTtTAGENDAWebInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsTAGENDAWebDsTAGENDAWebTtTAGENDAWebInner" /> class.
        /// </summary>
        /// <param name="omschrijving">omschrijving.</param>
        /// <param name="timeStampScheduled">timeStampScheduled.</param>
        /// <param name="tJOBMOmschr">tJOBMOmschr.</param>
        /// <param name="tQSTATUSId">tQSTATUSId.</param>
        /// <param name="userName">userName.</param>
        /// <param name="subject">subject.</param>
        /// <param name="tJOBId">tJOBId.</param>
        /// <param name="tJOBMId">tJOBMId.</param>
        /// <param name="tUSERId">tUSERId.</param>
        /// <param name="manueel">manueel.</param>
        /// <param name="isGeblokkeerd">isGeblokkeerd.</param>
        public DsTAGENDAWebDsTAGENDAWebTtTAGENDAWebInner(string omschrijving = default(string), string timeStampScheduled = default(string), string tJOBMOmschr = default(string), string tQSTATUSId = default(string), string userName = default(string), string subject = default(string), string tJOBId = default(string), string tJOBMId = default(string), string tUSERId = default(string), bool manueel = default(bool), bool isGeblokkeerd = default(bool))
        {
            this.Omschrijving = omschrijving;
            this.TimeStampScheduled = timeStampScheduled;
            this.TJOBMOmschr = tJOBMOmschr;
            this.TQSTATUSId = tQSTATUSId;
            this.UserName = userName;
            this.Subject = subject;
            this.TJOBId = tJOBId;
            this.TJOBMId = tJOBMId;
            this.TUSERId = tUSERId;
            this.Manueel = manueel;
            this.IsGeblokkeerd = isGeblokkeerd;
        }

        /// <summary>
        /// Gets or Sets Omschrijving
        /// </summary>
        [DataMember(Name = "Omschrijving", EmitDefaultValue = false)]
        public string Omschrijving { get; set; }

        /// <summary>
        /// Gets or Sets TimeStampScheduled
        /// </summary>
        [DataMember(Name = "TimeStampScheduled", EmitDefaultValue = false)]
        public string TimeStampScheduled { get; set; }

        /// <summary>
        /// Gets or Sets TJOBMOmschr
        /// </summary>
        [DataMember(Name = "TJOBM_Omschr", EmitDefaultValue = false)]
        public string TJOBMOmschr { get; set; }

        /// <summary>
        /// Gets or Sets TQSTATUSId
        /// </summary>
        [DataMember(Name = "TQSTATUS_Id", EmitDefaultValue = false)]
        public string TQSTATUSId { get; set; }

        /// <summary>
        /// Gets or Sets UserName
        /// </summary>
        [DataMember(Name = "UserName", EmitDefaultValue = false)]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "Subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets TJOBId
        /// </summary>
        [DataMember(Name = "TJOB_Id", EmitDefaultValue = false)]
        public string TJOBId { get; set; }

        /// <summary>
        /// Gets or Sets TJOBMId
        /// </summary>
        [DataMember(Name = "TJOBM_Id", EmitDefaultValue = false)]
        public string TJOBMId { get; set; }

        /// <summary>
        /// Gets or Sets TUSERId
        /// </summary>
        [DataMember(Name = "TUSER_Id", EmitDefaultValue = false)]
        public string TUSERId { get; set; }

        /// <summary>
        /// Gets or Sets Manueel
        /// </summary>
        [DataMember(Name = "Manueel", EmitDefaultValue = true)]
        public bool Manueel { get; set; }

        /// <summary>
        /// Gets or Sets IsGeblokkeerd
        /// </summary>
        [DataMember(Name = "IsGeblokkeerd", EmitDefaultValue = true)]
        public bool IsGeblokkeerd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DsTAGENDAWebDsTAGENDAWebTtTAGENDAWebInner {\n");
            sb.Append("  Omschrijving: ").Append(Omschrijving).Append("\n");
            sb.Append("  TimeStampScheduled: ").Append(TimeStampScheduled).Append("\n");
            sb.Append("  TJOBMOmschr: ").Append(TJOBMOmschr).Append("\n");
            sb.Append("  TQSTATUSId: ").Append(TQSTATUSId).Append("\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  TJOBId: ").Append(TJOBId).Append("\n");
            sb.Append("  TJOBMId: ").Append(TJOBMId).Append("\n");
            sb.Append("  TUSERId: ").Append(TUSERId).Append("\n");
            sb.Append("  Manueel: ").Append(Manueel).Append("\n");
            sb.Append("  IsGeblokkeerd: ").Append(IsGeblokkeerd).Append("\n");
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
