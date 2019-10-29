// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Search
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IndexesOperations.
    /// </summary>
    public static partial class IndexesOperationsExtensions
    {
            /// <summary>
            /// Creates a new search index.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The definition of the index to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Index Create(this IIndexesOperations operations, Index index, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.CreateAsync(index, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new search index.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Create-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='index'>
            /// The definition of the index to create.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Index> CreateAsync(this IIndexesOperations operations, Index index, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(index, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all indexes available for a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Indexes" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='select'>
            /// Selects which top-level properties of the index definitions to retrieve.
            /// Specified as a comma-separated list of JSON property names, or '*' for all
            /// properties. The default is all properties.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IndexListResult List(this IIndexesOperations operations, string select = default(string), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.ListAsync(select, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all indexes available for a search service.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/List-Indexes" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='select'>
            /// Selects which top-level properties of the index definitions to retrieve.
            /// Specified as a comma-separated list of JSON property names, or '*' for all
            /// properties. The default is all properties.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexListResult> ListAsync(this IIndexesOperations operations, string select = default(string), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(select, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new search index or updates an index if it already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The definition of the index to create or update.
            /// </param>
            /// <param name='index'>
            /// The definition of the index to create or update.
            /// </param>
            /// <param name='allowIndexDowntime'>
            /// Allows new analyzers, tokenizers, token filters, or char filters to be
            /// added to an index by taking the index offline for at least a few seconds.
            /// This temporarily causes indexing and query requests to fail. Performance
            /// and write availability of the index can be impaired for several minutes
            /// after the index is updated, or longer for very large indexes.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static Index CreateOrUpdate(this IIndexesOperations operations, string indexName, Index index, bool? allowIndexDowntime = default(bool?), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                return operations.CreateOrUpdateAsync(indexName, index, allowIndexDowntime, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new search index or updates an index if it already exists.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Update-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The definition of the index to create or update.
            /// </param>
            /// <param name='index'>
            /// The definition of the index to create or update.
            /// </param>
            /// <param name='allowIndexDowntime'>
            /// Allows new analyzers, tokenizers, token filters, or char filters to be
            /// added to an index by taking the index offline for at least a few seconds.
            /// This temporarily causes indexing and query requests to fail. Performance
            /// and write availability of the index can be impaired for several minutes
            /// after the index is updated, or longer for very large indexes.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Index> CreateOrUpdateAsync(this IIndexesOperations operations, string indexName, Index index, bool? allowIndexDowntime = default(bool?), SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(indexName, index, allowIndexDowntime, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a search index and all the documents it contains.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            public static void Delete(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition))
            {
                operations.DeleteAsync(indexName, searchRequestOptions, accessCondition).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a search index and all the documents it contains.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Delete-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index to delete.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='accessCondition'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), AccessCondition accessCondition = default(AccessCondition), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(indexName, searchRequestOptions, accessCondition, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves an index definition.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Index Get(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetAsync(indexName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieves an index definition.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Index" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index to retrieve.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Index> GetAsync(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(indexName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns statistics for the given index, including a document count and
            /// storage usage.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Index-Statistics" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index for which to retrieve statistics.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IndexGetStatisticsResult GetStatistics(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.GetStatisticsAsync(indexName, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns statistics for the given index, including a document count and
            /// storage usage.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/Get-Index-Statistics" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index for which to retrieve statistics.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IndexGetStatisticsResult> GetStatisticsAsync(this IIndexesOperations operations, string indexName, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetStatisticsWithHttpMessagesAsync(indexName, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Shows how an analyzer breaks text into tokens.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/test-analyzer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index for which to test an analyzer.
            /// </param>
            /// <param name='request'>
            /// The text and analyzer or analysis components to test.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static AnalyzeResult Analyze(this IIndexesOperations operations, string indexName, AnalyzeRequest request, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions))
            {
                return operations.AnalyzeAsync(indexName, request, searchRequestOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Shows how an analyzer breaks text into tokens.
            /// <see href="https://docs.microsoft.com/rest/api/searchservice/test-analyzer" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='indexName'>
            /// The name of the index for which to test an analyzer.
            /// </param>
            /// <param name='request'>
            /// The text and analyzer or analysis components to test.
            /// </param>
            /// <param name='searchRequestOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AnalyzeResult> AnalyzeAsync(this IIndexesOperations operations, string indexName, AnalyzeRequest request, SearchRequestOptions searchRequestOptions = default(SearchRequestOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AnalyzeWithHttpMessagesAsync(indexName, request, searchRequestOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
