// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A Class representing a ManagedInstanceDatabaseSchemaTableColumn along with the instance operations that can be performed on it. </summary>
    public partial class ManagedInstanceDatabaseSchemaTableColumn : ArmResource
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ManagedDatabaseColumnsRestOperations _managedDatabaseColumnsRestClient;
        private readonly ManagedDatabaseSensitivityLabelsRestOperations _managedDatabaseSensitivityLabelsRestClient;
        private readonly DatabaseColumnData _data;

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> class for mocking. </summary>
        protected ManagedInstanceDatabaseSchemaTableColumn()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "ManagedInstanceDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="resource"> The resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumn(ArmResource options, DatabaseColumnData resource) : base(options, resource.Id)
        {
            HasData = true;
            _data = resource;
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseColumnsRestClient = new ManagedDatabaseColumnsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="options"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumn(ArmResource options, ResourceIdentifier id) : base(options, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseColumnsRestClient = new ManagedDatabaseColumnsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Initializes a new instance of the <see cref="ManagedInstanceDatabaseSchemaTableColumn"/> class. </summary>
        /// <param name="clientOptions"> The client options to build client context. </param>
        /// <param name="credential"> The credential to build client context. </param>
        /// <param name="uri"> The uri to build client context. </param>
        /// <param name="pipeline"> The pipeline to build client context. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal ManagedInstanceDatabaseSchemaTableColumn(ArmClientOptions clientOptions, TokenCredential credential, Uri uri, HttpPipeline pipeline, ResourceIdentifier id) : base(clientOptions, credential, uri, pipeline, id)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _managedDatabaseColumnsRestClient = new ManagedDatabaseColumnsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
            _managedDatabaseSensitivityLabelsRestClient = new ManagedDatabaseSensitivityLabelsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Sql/managedInstances/databases/schemas/tables/columns";

        /// <summary> Gets the valid resource type for the operations. </summary>
        protected override ResourceType ValidResourceType => ResourceType;

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual DatabaseColumnData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response<ManagedInstanceDatabaseSchemaTableColumn>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = await _managedDatabaseColumnsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseColumns_Get
        /// <summary> Get managed database column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ManagedInstanceDatabaseSchemaTableColumn> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.Get");
            scope.Start();
            try
            {
                var response = _managedDatabaseColumnsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ManagedInstanceDatabaseSchemaTableColumn(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public async virtual Task<IEnumerable<Location>> GetAvailableLocationsAsync(CancellationToken cancellationToken = default)
        {
            return await ListAvailableLocationsAsync(ResourceType, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Lists all available geo-locations. </summary>
        /// <param name="cancellationToken"> A token to allow the caller to cancel the call to the service. The default value is <see cref="CancellationToken.None" />. </param>
        /// <returns> A collection of locations that may take multiple service requests to iterate over. </returns>
        public virtual IEnumerable<Location> GetAvailableLocations(CancellationToken cancellationToken = default)
        {
            return ListAvailableLocations(ResourceType, cancellationToken);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> DisableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.DisableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/disable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_DisableRecommendation
        /// <summary> Disables sensitivity recommendations on a given column. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response DisableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.DisableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.DisableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async virtual Task<Response> EnableRecommendationManagedDatabaseSensitivityLabelAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = await _managedDatabaseSensitivityLabelsRestClient.EnableRecommendationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}/sensitivityLabels/{sensitivityLabelSource}/enable
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/managedInstances/{managedInstanceName}/databases/{databaseName}/schemas/{schemaName}/tables/{tableName}/columns/{columnName}
        /// OperationId: ManagedDatabaseSensitivityLabels_EnableRecommendation
        /// <summary> Enables sensitivity recommendations on a given column (recommendations are enabled by default on all columns). </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response EnableRecommendationManagedDatabaseSensitivityLabel(CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ManagedInstanceDatabaseSchemaTableColumn.EnableRecommendationManagedDatabaseSensitivityLabel");
            scope.Start();
            try
            {
                var response = _managedDatabaseSensitivityLabelsRestClient.EnableRecommendation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Parent.Parent.Name, Id.Parent.Parent.Parent.Name, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        #region ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel

        /// <summary> Gets an object representing a ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel along with the instance operations that can be performed on it in the ManagedInstanceDatabaseSchemaTableColumn. </summary>
        /// <returns> Returns a <see cref="ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel" /> object. </returns>
        public ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel GetManagedInstanceDatabaseSchemaTableColumnSensitivityLabel()
        {
            return new ManagedInstanceDatabaseSchemaTableColumnSensitivityLabel(this, Id + "/sensitivityLabels/current");
        }
        #endregion
    }
}
