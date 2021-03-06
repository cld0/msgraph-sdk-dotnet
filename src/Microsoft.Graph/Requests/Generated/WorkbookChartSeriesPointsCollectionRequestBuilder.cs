// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type WorkbookChartSeriesPointsCollectionRequestBuilder.
    /// </summary>
    public partial class WorkbookChartSeriesPointsCollectionRequestBuilder : BaseRequestBuilder, IWorkbookChartSeriesPointsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new WorkbookChartSeriesPointsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public WorkbookChartSeriesPointsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IWorkbookChartSeriesPointsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IWorkbookChartSeriesPointsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new WorkbookChartSeriesPointsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IWorkbookChartPointRequestBuilder"/> for the specified WorkbookChartSeriesWorkbookChartPoint.
        /// </summary>
        /// <param name="id">The ID for the WorkbookChartSeriesWorkbookChartPoint.</param>
        /// <returns>The <see cref="IWorkbookChartPointRequestBuilder"/>.</returns>
        public IWorkbookChartPointRequestBuilder this[string id]
        {
            get
            {
                return new WorkbookChartPointRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartPointItemAt.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointItemAtRequestBuilder"/>.</returns>
        public IWorkbookChartPointItemAtRequestBuilder ItemAt(
            Int32 index)
        {
            return new WorkbookChartPointItemAtRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.itemAt"),
                this.Client,
                index);
        }

        /// <summary>
        /// Gets the request builder for WorkbookChartPointCount.
        /// </summary>
        /// <returns>The <see cref="IWorkbookChartPointCountRequestBuilder"/>.</returns>
        public IWorkbookChartPointCountRequestBuilder Count()
        {
            return new WorkbookChartPointCountRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.count"),
                this.Client);
        }
    }
}
