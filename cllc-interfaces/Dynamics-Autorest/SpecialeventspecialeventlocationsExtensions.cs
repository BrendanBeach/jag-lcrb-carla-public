// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Specialeventspecialeventlocations.
    /// </summary>
    public static partial class SpecialeventspecialeventlocationsExtensions
    {
            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSpecialeventlocationCollection Get(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.GetAsync(adoxioSpecialeventid, top, skip, search, filter, count, orderby, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventlocationCollection> GetAsync(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(adoxioSpecialeventid, top, skip, search, filter, count, orderby, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='top'>
            /// </param>
            /// <param name='skip'>
            /// </param>
            /// <param name='search'>
            /// </param>
            /// <param name='filter'>
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='orderby'>
            /// Order items by property values
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventlocationCollection> GetWithHttpMessages(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, int? top = default(int?), int? skip = default(int?), string search = default(string), string filter = default(string), bool? count = default(bool?), IList<string> orderby = default(IList<string>), IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.GetWithHttpMessagesAsync(adoxioSpecialeventid, top, skip, search, filter, count, orderby, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='adoxioSpecialeventlocationid'>
            /// key: adoxio_specialeventlocationid of adoxio_specialeventlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            public static MicrosoftDynamicsCRMadoxioSpecialeventlocation SpecialeventlocationsByKey(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, string adoxioSpecialeventlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>))
            {
                return operations.SpecialeventlocationsByKeyAsync(adoxioSpecialeventid, adoxioSpecialeventlocationid, select, expand).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='adoxioSpecialeventlocationid'>
            /// key: adoxio_specialeventlocationid of adoxio_specialeventlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<MicrosoftDynamicsCRMadoxioSpecialeventlocation> SpecialeventlocationsByKeyAsync(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, string adoxioSpecialeventlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.SpecialeventlocationsByKeyWithHttpMessagesAsync(adoxioSpecialeventid, adoxioSpecialeventlocationid, select, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get adoxio_specialevent_specialeventlocations from adoxio_specialevents
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='adoxioSpecialeventid'>
            /// key: adoxio_specialeventid of adoxio_specialevent
            /// </param>
            /// <param name='adoxioSpecialeventlocationid'>
            /// key: adoxio_specialeventlocationid of adoxio_specialeventlocation
            /// </param>
            /// <param name='select'>
            /// Select properties to be returned
            /// </param>
            /// <param name='expand'>
            /// Expand related entities
            /// </param>
            /// <param name='customHeaders'>
            /// Headers that will be added to request.
            /// </param>
            public static HttpOperationResponse<MicrosoftDynamicsCRMadoxioSpecialeventlocation> SpecialeventlocationsByKeyWithHttpMessages(this ISpecialeventspecialeventlocations operations, string adoxioSpecialeventid, string adoxioSpecialeventlocationid, IList<string> select = default(IList<string>), IList<string> expand = default(IList<string>), Dictionary<string, List<string>> customHeaders = null)
            {
                return operations.SpecialeventlocationsByKeyWithHttpMessagesAsync(adoxioSpecialeventid, adoxioSpecialeventlocationid, select, expand, customHeaders, CancellationToken.None).ConfigureAwait(false).GetAwaiter().GetResult();
            }

    }
}