// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// adoxio_fiainvestigationlog
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioFiainvestigationlog
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFiainvestigationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioFiainvestigationlog()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioFiainvestigationlog class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioFiainvestigationlog(string adoxioDetails = default(string), string adoxioTitle = default(string), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string _owninguserValue = default(string), string _owneridValue = default(string), int? importsequencenumber = default(int?), string _owningbusinessunitValue = default(string), string _adoxioInvestigationidValue = default(string), string _createdonbehalfbyValue = default(string), string adoxioFiainvestigationlogid = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), int? timezoneruleversionnumber = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string _createdbyValue = default(string), int? statecode = default(int?), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? adoxioActivitydatetime = default(System.DateTimeOffset?), int? statuscode = default(int?), long? versionnumber = default(long?), string _modifiedbyValue = default(string), string _owningteamValue = default(string), string _modifiedonbehalfbyValue = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser owninguser = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), object ownerid = default(object), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), IList<MicrosoftDynamicsCRMsyncerror> adoxioFiainvestigationlogSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFiainvestigationlogDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioFiainvestigationlogDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioFiainvestigationlogAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioFiainvestigationlogBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), MicrosoftDynamicsCRMadoxioInvestigation adoxioInvestigationId = default(MicrosoftDynamicsCRMadoxioInvestigation))
        {
            AdoxioDetails = adoxioDetails;
            AdoxioTitle = adoxioTitle;
            Modifiedon = modifiedon;
            this._owninguserValue = _owninguserValue;
            this._owneridValue = _owneridValue;
            Importsequencenumber = importsequencenumber;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._adoxioInvestigationidValue = _adoxioInvestigationidValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            AdoxioFiainvestigationlogid = adoxioFiainvestigationlogid;
            Createdon = createdon;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Overriddencreatedon = overriddencreatedon;
            this._createdbyValue = _createdbyValue;
            Statecode = statecode;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            AdoxioActivitydatetime = adoxioActivitydatetime;
            Statuscode = statuscode;
            Versionnumber = versionnumber;
            this._modifiedbyValue = _modifiedbyValue;
            this._owningteamValue = _owningteamValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Owninguser = owninguser;
            Owningteam = owningteam;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            AdoxioFiainvestigationlogSyncErrors = adoxioFiainvestigationlogSyncErrors;
            AdoxioFiainvestigationlogDuplicateMatchingRecord = adoxioFiainvestigationlogDuplicateMatchingRecord;
            AdoxioFiainvestigationlogDuplicateBaseRecord = adoxioFiainvestigationlogDuplicateBaseRecord;
            AdoxioFiainvestigationlogAsyncOperations = adoxioFiainvestigationlogAsyncOperations;
            AdoxioFiainvestigationlogBulkDeleteFailures = adoxioFiainvestigationlogBulkDeleteFailures;
            AdoxioInvestigationId = adoxioInvestigationId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_details")]
        public string AdoxioDetails { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_title")]
        public string AdoxioTitle { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_adoxio_investigationid_value")]
        public string _adoxioInvestigationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlogid")]
        public string AdoxioFiainvestigationlogid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_activitydatetime")]
        public System.DateTimeOffset? AdoxioActivitydatetime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfbyname")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfbyname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owninguser")]
        public MicrosoftDynamicsCRMsystemuser Owninguser { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public object Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlog_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioFiainvestigationlogSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlog_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFiainvestigationlogDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlog_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioFiainvestigationlogDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlog_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioFiainvestigationlogAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_fiainvestigationlog_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioFiainvestigationlogBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_InvestigationId")]
        public MicrosoftDynamicsCRMadoxioInvestigation AdoxioInvestigationId { get; set; }

    }
}
