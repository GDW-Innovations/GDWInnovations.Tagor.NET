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
    /// TagorServiceGetDosInfo200ResponseResponse
    /// </summary>
    [DataContract(Name = "TagorServiceGetDosInfo_200_response_response")]
    public partial class TagorServiceGetDosInfo200ResponseResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TagorServiceGetDosInfo200ResponseResponse" /> class.
        /// </summary>
        /// <param name="success">success.</param>
        /// <param name="error">error.</param>
        /// <param name="dossiernaam">dossiernaam.</param>
        /// <param name="aanlegger">aanlegger.</param>
        /// <param name="verweerder">Full name of the defendant..</param>
        /// <param name="dossiersoortId">This field will contain the file type. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {filetype_id}&#x60; will be returned..</param>
        /// <param name="statusId">statusId.</param>
        /// <param name="stadiumId">stadiumId.</param>
        /// <param name="stadiumKlantId">stadiumKlantId.</param>
        /// <param name="stopstatusId">stopstatusId.</param>
        /// <param name="alarmstatusId">alarmstatusId.</param>
        /// <param name="dosbehId">This field can contain the &#x60;file name&#x60;, the &#x60;file admin&#39;s username&#x60; or  &#x60;&#39;DBH&#39; + the file admin&#39;s user id&#x60;.</param>
        /// <param name="emailVerweerder">Email address of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request..</param>
        /// <param name="gsmVerweerder">Mobile of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request..</param>
        /// <param name="datumLtstBet">Date of the last payment..</param>
        /// <param name="bedragLtstBet">Amount of the last payment in general. Could be the same as &#x60;BedragLtstOnbvBet&#x60;.</param>
        /// <param name="datumLtstOnbvBet">datumLtstOnbvBet.</param>
        /// <param name="bedragLtstOnbvBet">Amount of the last payment which hasn&#39;t been confimed yet.</param>
        /// <param name="urlFAQ">Url pointing to the FAQ page.</param>
        public TagorServiceGetDosInfo200ResponseResponse(bool success = default(bool), string error = default(string), string dossiernaam = default(string), string aanlegger = default(string), string verweerder = default(string), string dossiersoortId = default(string), string statusId = default(string), string stadiumId = default(string), string stadiumKlantId = default(string), string stopstatusId = default(string), string alarmstatusId = default(string), string dosbehId = default(string), string emailVerweerder = default(string), string gsmVerweerder = default(string), DateOnly datumLtstBet = default(DateOnly), float bedragLtstBet = default(float), DateOnly datumLtstOnbvBet = default(DateOnly), float bedragLtstOnbvBet = default(float), string urlFAQ = default(string))
        {
            this.Success = success;
            this.Error = error;
            this.Dossiernaam = dossiernaam;
            this.Aanlegger = aanlegger;
            this.Verweerder = verweerder;
            this.DossiersoortId = dossiersoortId;
            this.StatusId = statusId;
            this.StadiumId = stadiumId;
            this.StadiumKlantId = stadiumKlantId;
            this.StopstatusId = stopstatusId;
            this.AlarmstatusId = alarmstatusId;
            this.DosbehId = dosbehId;
            this.EmailVerweerder = emailVerweerder;
            this.GsmVerweerder = gsmVerweerder;
            this.DatumLtstBet = datumLtstBet;
            this.BedragLtstBet = bedragLtstBet;
            this.DatumLtstOnbvBet = datumLtstOnbvBet;
            this.BedragLtstOnbvBet = bedragLtstOnbvBet;
            this.UrlFAQ = urlFAQ;
        }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "Success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name = "Error", EmitDefaultValue = false)]
        public string Error { get; set; }

        /// <summary>
        /// Gets or Sets Dossiernaam
        /// </summary>
        [DataMember(Name = "Dossiernaam", EmitDefaultValue = false)]
        public string Dossiernaam { get; set; }

        /// <summary>
        /// Gets or Sets Aanlegger
        /// </summary>
        [DataMember(Name = "Aanlegger", EmitDefaultValue = false)]
        public string Aanlegger { get; set; }

        /// <summary>
        /// Full name of the defendant.
        /// </summary>
        /// <value>Full name of the defendant.</value>
        [DataMember(Name = "Verweerder", EmitDefaultValue = false)]
        public string Verweerder { get; set; }

        /// <summary>
        /// This field will contain the file type. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {filetype_id}&#x60; will be returned.
        /// </summary>
        /// <value>This field will contain the file type. If a mapping with code &#x60;VOXTRON&#x60; is found in tagor, the id will converted. Otherwise &#x60;DSO + {filetype_id}&#x60; will be returned.</value>
        [DataMember(Name = "DossiersoortId", EmitDefaultValue = false)]
        public string DossiersoortId { get; set; }

        /// <summary>
        /// Gets or Sets StatusId
        /// </summary>
        [DataMember(Name = "StatusId", EmitDefaultValue = false)]
        public string StatusId { get; set; }

        /// <summary>
        /// Gets or Sets StadiumId
        /// </summary>
        [DataMember(Name = "StadiumId", EmitDefaultValue = false)]
        public string StadiumId { get; set; }

        /// <summary>
        /// Gets or Sets StadiumKlantId
        /// </summary>
        [DataMember(Name = "StadiumKlantId", EmitDefaultValue = false)]
        public string StadiumKlantId { get; set; }

        /// <summary>
        /// Gets or Sets StopstatusId
        /// </summary>
        [DataMember(Name = "StopstatusId", EmitDefaultValue = false)]
        public string StopstatusId { get; set; }

        /// <summary>
        /// Gets or Sets AlarmstatusId
        /// </summary>
        [DataMember(Name = "AlarmstatusId", EmitDefaultValue = false)]
        public string AlarmstatusId { get; set; }

        /// <summary>
        /// This field can contain the &#x60;file name&#x60;, the &#x60;file admin&#39;s username&#x60; or  &#x60;&#39;DBH&#39; + the file admin&#39;s user id&#x60;
        /// </summary>
        /// <value>This field can contain the &#x60;file name&#x60;, the &#x60;file admin&#39;s username&#x60; or  &#x60;&#39;DBH&#39; + the file admin&#39;s user id&#x60;</value>
        [DataMember(Name = "DosbehId", EmitDefaultValue = false)]
        public string DosbehId { get; set; }

        /// <summary>
        /// Email address of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request.
        /// </summary>
        /// <value>Email address of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request.</value>
        [DataMember(Name = "EmailVerweerder", EmitDefaultValue = false)]
        public string EmailVerweerder { get; set; }

        /// <summary>
        /// Mobile of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request.
        /// </summary>
        /// <value>Mobile of the first defendant or the one with the id passed as &#x60;TPAR_Id&#x60; in the request.</value>
        [DataMember(Name = "GsmVerweerder", EmitDefaultValue = false)]
        public string GsmVerweerder { get; set; }

        /// <summary>
        /// Date of the last payment.
        /// </summary>
        /// <value>Date of the last payment.</value>
        [DataMember(Name = "DatumLtstBet", EmitDefaultValue = false)]
        public DateOnly DatumLtstBet { get; set; }

        /// <summary>
        /// Amount of the last payment in general. Could be the same as &#x60;BedragLtstOnbvBet&#x60;
        /// </summary>
        /// <value>Amount of the last payment in general. Could be the same as &#x60;BedragLtstOnbvBet&#x60;</value>
        [DataMember(Name = "BedragLtstBet", EmitDefaultValue = false)]
        public float BedragLtstBet { get; set; }

        /// <summary>
        /// Gets or Sets DatumLtstOnbvBet
        /// </summary>
        [DataMember(Name = "DatumLtstOnbvBet", EmitDefaultValue = false)]
        public DateOnly DatumLtstOnbvBet { get; set; }

        /// <summary>
        /// Amount of the last payment which hasn&#39;t been confimed yet
        /// </summary>
        /// <value>Amount of the last payment which hasn&#39;t been confimed yet</value>
        [DataMember(Name = "BedragLtstOnbvBet", EmitDefaultValue = false)]
        public float BedragLtstOnbvBet { get; set; }

        /// <summary>
        /// Url pointing to the FAQ page
        /// </summary>
        /// <value>Url pointing to the FAQ page</value>
        [DataMember(Name = "UrlFAQ", EmitDefaultValue = false)]
        public string UrlFAQ { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TagorServiceGetDosInfo200ResponseResponse {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Dossiernaam: ").Append(Dossiernaam).Append("\n");
            sb.Append("  Aanlegger: ").Append(Aanlegger).Append("\n");
            sb.Append("  Verweerder: ").Append(Verweerder).Append("\n");
            sb.Append("  DossiersoortId: ").Append(DossiersoortId).Append("\n");
            sb.Append("  StatusId: ").Append(StatusId).Append("\n");
            sb.Append("  StadiumId: ").Append(StadiumId).Append("\n");
            sb.Append("  StadiumKlantId: ").Append(StadiumKlantId).Append("\n");
            sb.Append("  StopstatusId: ").Append(StopstatusId).Append("\n");
            sb.Append("  AlarmstatusId: ").Append(AlarmstatusId).Append("\n");
            sb.Append("  DosbehId: ").Append(DosbehId).Append("\n");
            sb.Append("  EmailVerweerder: ").Append(EmailVerweerder).Append("\n");
            sb.Append("  GsmVerweerder: ").Append(GsmVerweerder).Append("\n");
            sb.Append("  DatumLtstBet: ").Append(DatumLtstBet).Append("\n");
            sb.Append("  BedragLtstBet: ").Append(BedragLtstBet).Append("\n");
            sb.Append("  DatumLtstOnbvBet: ").Append(DatumLtstOnbvBet).Append("\n");
            sb.Append("  BedragLtstOnbvBet: ").Append(BedragLtstOnbvBet).Append("\n");
            sb.Append("  UrlFAQ: ").Append(UrlFAQ).Append("\n");
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
