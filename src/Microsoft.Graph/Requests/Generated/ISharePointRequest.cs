// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface ISharePointRequest.
    /// </summary>
    public partial interface ISharePointRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified SharePoint using PUT.
        /// </summary>
        /// <param name="sharePointToCreate">The SharePoint to create.</param>
        /// <returns>The created SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> CreateAsync(SharePoint sharePointToCreate);        /// <summary>
        /// Creates the specified SharePoint using PUT.
        /// </summary>
        /// <param name="sharePointToCreate">The SharePoint to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> CreateAsync(SharePoint sharePointToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified SharePoint.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified SharePoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified SharePoint.
        /// </summary>
        /// <returns>The SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> GetAsync();

        /// <summary>
        /// Gets the specified SharePoint.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified SharePoint using PATCH.
        /// </summary>
        /// <param name="sharePointToUpdate">The SharePoint to update.</param>
        /// <returns>The updated SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> UpdateAsync(SharePoint sharePointToUpdate);

        /// <summary>
        /// Updates the specified SharePoint using PATCH.
        /// </summary>
        /// <param name="sharePointToUpdate">The SharePoint to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The updated SharePoint.</returns>
        System.Threading.Tasks.Task<SharePoint> UpdateAsync(SharePoint sharePointToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointRequest Expand(Expression<Func<SharePoint, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        ISharePointRequest Select(Expression<Func<SharePoint, object>> selectExpression);

    }
}
