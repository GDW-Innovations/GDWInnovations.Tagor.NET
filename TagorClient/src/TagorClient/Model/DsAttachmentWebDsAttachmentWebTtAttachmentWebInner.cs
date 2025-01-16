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
    /// DsAttachmentWebDsAttachmentWebTtAttachmentWebInner
    /// </summary>
    [DataContract(Name = "dsAttachmentWeb_dsAttachmentWeb_ttAttachmentWeb_inner")]
    public partial class DsAttachmentWebDsAttachmentWebTtAttachmentWebInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DsAttachmentWebDsAttachmentWebTtAttachmentWebInner" /> class.
        /// </summary>
        /// <param name="ttFileName">ttFileName.</param>
        /// <param name="ttFilePath">ttFilePath.</param>
        /// <param name="ttComment">ttComment.</param>
        /// <param name="tDOCId">tDOCId.</param>
        /// <param name="tQDISGROEPId">tQDISGROEPId.</param>
        /// <param name="fileContent">fileContent.</param>
        /// <param name="fileType">fileType.</param>
        /// <param name="tJOBId">tJOBId.</param>
        public DsAttachmentWebDsAttachmentWebTtAttachmentWebInner(string ttFileName = default(string), string ttFilePath = default(string), string ttComment = default(string), string tDOCId = default(string), string tQDISGROEPId = default(string), string fileContent = default(string), string fileType = default(string), string tJOBId = default(string))
        {
            this.TtFileName = ttFileName;
            this.TtFilePath = ttFilePath;
            this.TtComment = ttComment;
            this.TDOCId = tDOCId;
            this.TQDISGROEPId = tQDISGROEPId;
            this.FileContent = fileContent;
            this.FileType = fileType;
            this.TJOBId = tJOBId;
        }

        /// <summary>
        /// Gets or Sets TtFileName
        /// </summary>
        [DataMember(Name = "ttFileName", EmitDefaultValue = false)]
        public string TtFileName { get; set; }

        /// <summary>
        /// Gets or Sets TtFilePath
        /// </summary>
        [DataMember(Name = "ttFilePath", EmitDefaultValue = false)]
        public string TtFilePath { get; set; }

        /// <summary>
        /// Gets or Sets TtComment
        /// </summary>
        [DataMember(Name = "ttComment", EmitDefaultValue = false)]
        public string TtComment { get; set; }

        /// <summary>
        /// Gets or Sets TDOCId
        /// </summary>
        [DataMember(Name = "TDOC_Id", EmitDefaultValue = false)]
        public string TDOCId { get; set; }

        /// <summary>
        /// Gets or Sets TQDISGROEPId
        /// </summary>
        [DataMember(Name = "TQDISGROEP_Id", EmitDefaultValue = false)]
        public string TQDISGROEPId { get; set; }

        /// <summary>
        /// Gets or Sets FileContent
        /// </summary>
        [DataMember(Name = "FileContent", EmitDefaultValue = false)]
        public string FileContent { get; set; }

        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name = "FileType", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or Sets TJOBId
        /// </summary>
        [DataMember(Name = "TJOB_Id", EmitDefaultValue = false)]
        public string TJOBId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DsAttachmentWebDsAttachmentWebTtAttachmentWebInner {\n");
            sb.Append("  TtFileName: ").Append(TtFileName).Append("\n");
            sb.Append("  TtFilePath: ").Append(TtFilePath).Append("\n");
            sb.Append("  TtComment: ").Append(TtComment).Append("\n");
            sb.Append("  TDOCId: ").Append(TDOCId).Append("\n");
            sb.Append("  TQDISGROEPId: ").Append(TQDISGROEPId).Append("\n");
            sb.Append("  FileContent: ").Append(FileContent).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  TJOBId: ").Append(TJOBId).Append("\n");
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
