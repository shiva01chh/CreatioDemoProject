namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Applications.Abstractions;
	using Terrasoft.Core.Entities;

	#region Class: BaseApplicationSchemaQueryExecutor

	/// <summary>
	/// Base query executor provides methods for get application schemas.
	/// </summary>
	public abstract class BaseApplicationSchemaQueryExecutor<TSchemaManagerSchema> : IEntityQueryExecutor
		where TSchemaManagerSchema : Schema, ISchemaManagerSchema<TSchemaManagerSchema>
	{

		#region Fields: Private

		private readonly IAppManager _appManager;

		private readonly EntitySchemaManager _entitySchemaManager;

		#endregion

		#region Constructors: Protected

		protected BaseApplicationSchemaQueryExecutor(UserConnection userConnection, IAppManager appManager) {
			UserConnection = userConnection;
			_appManager = appManager;
			_entitySchemaManager = userConnection.EntitySchemaManager;
		}

		#endregion

		#region Properties: Protected

		protected UserConnection UserConnection { get; }

		/// <summary>
		/// The name of the virtual entity on which will be triggered this executor.
		/// </summary>
		protected abstract string ResultEntitySchemaName { get; }

		#endregion

		#region Methods: Private

		private static bool TryGetColumnFilter(EntitySchemaQueryFilterCollection filters, string columnName,
				out EntitySchemaQueryFilter result) {
			result = filters.OfType<EntitySchemaQueryFilter>().FirstOrDefault(filter => {
				EntitySchemaQueryExpression leftExpression = filter.LeftExpression;
				return leftExpression.ExpressionType == EntitySchemaQueryExpressionType.SchemaColumn &&
					leftExpression.SchemaColumn.Name == columnName;
			});
			return result != null;
		}

		private Entity MapSchemaManagerItemToEntity(EntitySchema resultEntitySchema,
				ISchemaManagerItem<TSchemaManagerSchema> schemaManagerItem, Guid appId) {
			Entity entity = resultEntitySchema.CreateEntity(UserConnection);
			entity.SetDefColumnValues();
			entity.SetColumnValue("Id", schemaManagerItem.RealUId);
			entity.SetColumnValue("UId", schemaManagerItem.RealUId);
			entity.SetColumnValue("ModifiedOn", schemaManagerItem.ModifiedOn);
			entity.SetColumnValue("Name", schemaManagerItem.Name);
			entity.SetColumnValue("Caption", schemaManagerItem.Caption);
			entity.SetColumnValue("ApplicationId", appId);
			entity.SetColumnValue("PackageUId", schemaManagerItem.PackageUId);
			MapAdditionalColumns(entity, schemaManagerItem);
			return entity;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Gets required column filter value.
		/// </summary>
		/// <param name="filters">Collection of filters.</param>
		/// <param name="columnName">Required column of filter.</param>
		/// <returns>Value of specific filter.</returns>
		protected static T GetRequiredColumnFilterValue<T>(EntitySchemaQueryFilterCollection filters, string columnName) {
			if (!TryGetColumnFilter(filters, columnName, out EntitySchemaQueryFilter filter) ||
					filter.RightExpressions.Count == 0) {
				throw new
					Common.ItemNotFoundException("Filter for schema column \"{0}\" not found in query", columnName);
			}
			return (T)filter.RightExpressions[0].ParameterValue;
		}

		/// <summary>
		/// Defines which schema manager use for getting data.
		/// </summary>
		protected abstract SchemaManager<TSchemaManagerSchema> GetSchemaManager();

		/// <summary>
		/// Returns schema manager items for the application.
		/// </summary>
		protected virtual IEnumerable<ISchemaManagerItem<TSchemaManagerSchema>> GetSchemaManagerItems(Guid appId) {
			return _appManager.GetAppSchemaItems(appId, GetSchemaManager());
		}

		/// <summary>
		/// Returns additional manager items filter.
		/// </summary>
		protected virtual Func<ISchemaManagerItem<TSchemaManagerSchema>, bool>
				GetManagerItemsFilter(EntitySchemaQueryFilterCollection filters) {
			return null;
		}

		/// <summary>
		/// Maps additional columns of schema item to entity.
		/// <param name="entity">Result entity.</param>
		/// <param name="schemaManagerItem">Schema item whose properties are mapping to the result entity.</param>
		/// </summary>
		protected virtual void MapAdditionalColumns(Entity entity,
				ISchemaManagerItem<TSchemaManagerSchema> schemaManagerItem) {
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		public virtual EntityCollection GetEntityCollection(EntitySchemaQuery esq) {
			EntitySchema resultEntitySchema = _entitySchemaManager.GetInstanceByName(ResultEntitySchemaName);
			Guid appId = GetRequiredColumnFilterValue<Guid>(esq.Filters, "Application");
			IEnumerable<ISchemaManagerItem<TSchemaManagerSchema>> managerItems = GetSchemaManagerItems(appId);
			Func<ISchemaManagerItem<TSchemaManagerSchema>, bool> filter = GetManagerItemsFilter(esq.Filters);
			if (filter != null) {
				managerItems = managerItems.Where(filter);
			}
			IEnumerable<Entity> resultEntities = managerItems
				.Select(x => MapSchemaManagerItemToEntity(resultEntitySchema, x, appId));
			var result = new EntityCollection(UserConnection, ResultEntitySchemaName);
			result.AddRange(resultEntities);
			return result;
		}

		#endregion

	}

	#endregion

}














