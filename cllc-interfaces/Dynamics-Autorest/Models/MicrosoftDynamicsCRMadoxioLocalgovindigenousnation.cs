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
    /// adoxio_localgovindigenousnation
    /// </summary>
    public partial class MicrosoftDynamicsCRMadoxioLocalgovindigenousnation
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLocalgovindigenousnation class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMadoxioLocalgovindigenousnation class.
        /// </summary>
        public MicrosoftDynamicsCRMadoxioLocalgovindigenousnation(string _createdbyValue = default(string), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), string adoxioEmail = default(string), string _modifiedbyValue = default(string), bool? adoxioIsindigenousnation = default(bool?), int? timezoneruleversionnumber = default(int?), string adoxioPosition = default(string), string _createdonbehalfbyValue = default(string), int? statecode = default(int?), string adoxioFaxnumber = default(string), long? versionnumber = default(long?), string adoxioLocalgovindigenousnationid = default(string), int? utcconversiontimezonecode = default(int?), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), string adoxioName = default(string), int? adoxioCommunicationsregion = default(int?), int? importsequencenumber = default(int?), string _modifiedonbehalfbyValue = default(string), int? adoxioIssuingcannabislicences = default(int?), string _organizationidValue = default(string), string adoxioContactname = default(string), int? statuscode = default(int?), System.DateTimeOffset? adoxioPendingdate = default(System.DateTimeOffset?), string adoxioPhonenumber = default(string), MicrosoftDynamicsCRMsystemuser createdbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser createdonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMsystemuser modifiedonbehalfbyname = default(MicrosoftDynamicsCRMsystemuser), MicrosoftDynamicsCRMorganization organizationid = default(MicrosoftDynamicsCRMorganization), IList<MicrosoftDynamicsCRMsyncerror> adoxioLocalgovindigenousnationSyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLocalgovindigenousnationDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> adoxioLocalgovindigenousnationDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMasyncoperation> adoxioLocalgovindigenousnationAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMbulkdeletefailure> adoxioLocalgovindigenousnationBulkDeleteFailures = default(IList<MicrosoftDynamicsCRMbulkdeletefailure>), IList<MicrosoftDynamicsCRMadoxioApplication> adoxioLocalgovindigenousnationApplications = default(IList<MicrosoftDynamicsCRMadoxioApplication>), IList<MicrosoftDynamicsCRMannotation> adoxioLocalgovindigenousnationAnnotations = default(IList<MicrosoftDynamicsCRMannotation>), IList<MicrosoftDynamicsCRMadoxioEstablishment> adoxioLocalgovindigenousnationAdoxioEstablishmentLGIN = default(IList<MicrosoftDynamicsCRMadoxioEstablishment>), IList<MicrosoftDynamicsCRMadoxioLicences> adoxioLocalgovindigenousnationAdoxioLicencesLGIN = default(IList<MicrosoftDynamicsCRMadoxioLicences>))
        {
            this._createdbyValue = _createdbyValue;
            Createdon = createdon;
            Modifiedon = modifiedon;
            AdoxioEmail = adoxioEmail;
            this._modifiedbyValue = _modifiedbyValue;
            AdoxioIsindigenousnation = adoxioIsindigenousnation;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            AdoxioPosition = adoxioPosition;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            Statecode = statecode;
            AdoxioFaxnumber = adoxioFaxnumber;
            Versionnumber = versionnumber;
            AdoxioLocalgovindigenousnationid = adoxioLocalgovindigenousnationid;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Overriddencreatedon = overriddencreatedon;
            AdoxioName = adoxioName;
            AdoxioCommunicationsregion = adoxioCommunicationsregion;
            Importsequencenumber = importsequencenumber;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            AdoxioIssuingcannabislicences = adoxioIssuingcannabislicences;
            this._organizationidValue = _organizationidValue;
            AdoxioContactname = adoxioContactname;
            Statuscode = statuscode;
            AdoxioPendingdate = adoxioPendingdate;
            AdoxioPhonenumber = adoxioPhonenumber;
            Createdbyname = createdbyname;
            Createdonbehalfbyname = createdonbehalfbyname;
            Modifiedbyname = modifiedbyname;
            Modifiedonbehalfbyname = modifiedonbehalfbyname;
            Organizationid = organizationid;
            AdoxioLocalgovindigenousnationSyncErrors = adoxioLocalgovindigenousnationSyncErrors;
            AdoxioLocalgovindigenousnationDuplicateMatchingRecord = adoxioLocalgovindigenousnationDuplicateMatchingRecord;
            AdoxioLocalgovindigenousnationDuplicateBaseRecord = adoxioLocalgovindigenousnationDuplicateBaseRecord;
            AdoxioLocalgovindigenousnationAsyncOperations = adoxioLocalgovindigenousnationAsyncOperations;
            AdoxioLocalgovindigenousnationBulkDeleteFailures = adoxioLocalgovindigenousnationBulkDeleteFailures;
            AdoxioLocalgovindigenousnationApplications = adoxioLocalgovindigenousnationApplications;
            AdoxioLocalgovindigenousnationAnnotations = adoxioLocalgovindigenousnationAnnotations;
            AdoxioLocalgovindigenousnationAdoxioEstablishmentLGIN = adoxioLocalgovindigenousnationAdoxioEstablishmentLGIN;
            AdoxioLocalgovindigenousnationAdoxioLicencesLGIN = adoxioLocalgovindigenousnationAdoxioLicencesLGIN;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_email")]
        public string AdoxioEmail { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_isindigenousnation")]
        public bool? AdoxioIsindigenousnation { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_position")]
        public string AdoxioPosition { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_faxnumber")]
        public string AdoxioFaxnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public long? Versionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnationid")]
        public string AdoxioLocalgovindigenousnationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_name")]
        public string AdoxioName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_communicationsregion")]
        public int? AdoxioCommunicationsregion { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_issuingcannabislicences")]
        public int? AdoxioIssuingcannabislicences { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_organizationid_value")]
        public string _organizationidValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_contactname")]
        public string AdoxioContactname { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_pendingdate")]
        public System.DateTimeOffset? AdoxioPendingdate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_phonenumber")]
        public string AdoxioPhonenumber { get; set; }

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
        [JsonProperty(PropertyName = "organizationid")]
        public MicrosoftDynamicsCRMorganization Organizationid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> AdoxioLocalgovindigenousnationSyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLocalgovindigenousnationDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> AdoxioLocalgovindigenousnationDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> AdoxioLocalgovindigenousnationAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_BulkDeleteFailures")]
        public IList<MicrosoftDynamicsCRMbulkdeletefailure> AdoxioLocalgovindigenousnationBulkDeleteFailures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_applications")]
        public IList<MicrosoftDynamicsCRMadoxioApplication> AdoxioLocalgovindigenousnationApplications { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_Annotations")]
        public IList<MicrosoftDynamicsCRMannotation> AdoxioLocalgovindigenousnationAnnotations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_adoxio_establishment_LGIN")]
        public IList<MicrosoftDynamicsCRMadoxioEstablishment> AdoxioLocalgovindigenousnationAdoxioEstablishmentLGIN { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "adoxio_localgovindigenousnation_adoxio_licences_LGIN")]
        public IList<MicrosoftDynamicsCRMadoxioLicences> AdoxioLocalgovindigenousnationAdoxioLicencesLGIN { get; set; }

    }
}
