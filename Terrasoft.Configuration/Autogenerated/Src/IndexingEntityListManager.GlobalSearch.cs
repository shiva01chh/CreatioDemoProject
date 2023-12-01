﻿namespace Terrasoft.Configuration.GlobalSearch
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using global::Common.Logging;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
    using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.GlobalSearch.Interfaces;

	#region Class: IndexingEntityListManager

	/// <summary>
	/// Manages all indexed entities.
	/// </summary>
	public class IndexingEntityListManager
	{
		#region Constants: Private

		/// <summary>
		/// Logger.
		/// </summary>
		private static readonly ILog _log = LogManager.GetLogger("GlobalSearch");

		/// <summary>
		/// <see cref="UserConnection"/> instance.
		/// </summary>
		private readonly UserConnection _userConnection;

		#endregion

		#region Properties: Protected

		/// <summary>
		/// Indexing section list builder.
		/// </summary>
		private IndexingSectionListBuilder _indexingSectionListBuilder;
		protected virtual IndexingSectionListBuilder IndexingSectionListBuilder => 
			_indexingSectionListBuilder ?? (_indexingSectionListBuilder =
				ClassFactory.Get<IndexingSectionListBuilder>
					(new ConstructorArgument("userConnection", _userConnection)));

		/// <summary>
		/// Single indexing section list builder.
		/// </summary>
		private SingleIndexingSectionListBuilder _singleIndexingSectionListBuilder;
		protected virtual SingleIndexingSectionListBuilder SingleIndexingSectionListBuilder =>
			_singleIndexingSectionListBuilder ?? (_singleIndexingSectionListBuilder =
				ClassFactory.Get<SingleIndexingSectionListBuilder>(
					new ConstructorArgument("userConnection", _userConnection)));

		/// <summary>
		/// Indexing detail list builder.
		/// </summary>
		private IndexingDetailListBuilder _indexingDetailListBuilder;
		protected virtual IndexingDetailListBuilder IndexingDetailListBuilder => 
			_indexingDetailListBuilder ?? (_indexingDetailListBuilder = 
				ClassFactory.Get<IndexingDetailListBuilder>(
					new ConstructorArgument("userConnection", _userConnection)));

		/// <summary>
		/// Single indexing detail list builder.
		/// </summary>
		private SingleIndexingDetailListBuilder _singleIndexingDetailListBuilder;
		protected virtual SingleIndexingDetailListBuilder SingleIndexingDetailListBuilder => 
			_singleIndexingDetailListBuilder ?? (_singleIndexingDetailListBuilder =
				ClassFactory.Get<SingleIndexingDetailListBuilder>(
					new ConstructorArgument("userConnection", _userConnection)));

		private IGlobalSearchIndexingSchemasRepository _globalSearchIndexingSchemasRepository;
		protected virtual IGlobalSearchIndexingSchemasRepository GlobalSearchIndexingSchemasRepository =>
			_globalSearchIndexingSchemasRepository ?? (_globalSearchIndexingSchemasRepository =
				ClassFactory.Get<IGlobalSearchIndexingSchemasRepository>());

		#endregion

		#region Constructors: Public

		/// <summary>Initializes a new instance of the <see cref="UserConnection" /> class.</summary>
		public IndexingEntityListManager(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Apply activity type filter.
		/// </summary>
		/// <param name="esq"><see cref="EntitySchemaQuery"/> instance.</param>
		protected virtual void ApplyActivityTypeFilter(EntitySchemaQuery esq) {
			var entitySchema = esq.RootSchema;
			if (entitySchema.Name == "Activity") {
				var filter = esq.CreateFilterWithParameters(FilterComparisonType.NotEqual, "Type", ActivityConsts.EmailTypeUId);
				esq.Filters.Add(filter);
			}
		}

		/// <summary>
		/// Apply activity file type filter.
		/// </summary>
		/// <param name="esq"><see cref="EntitySchemaQuery"/> instance.</param>
		protected virtual void ApplyActivityFileTypeFilter(EntitySchemaQuery esq) {
			var entitySchema = esq.RootSchema;
			if (entitySchema.Name == "ActivityFile") {
				esq.Filters.Add(esq.CreateFilterWithParameters(FilterComparisonType.NotEqual,
				"Activity.Type", ActivityConsts.EmailTypeUId));
			}
		}

		/// <summary>
		/// Initialize builders.
		/// </summary>
		protected virtual void InitializeBuilders() {
			var sectionsUIds = GlobalSearchIndexingSchemasRepository.GetIndexingSectionUIds(_userConnection).ToList();
			IndexingSectionListBuilder.IndexingSectionsUIds = sectionsUIds;
			SingleIndexingSectionListBuilder.IndexingSectionsUIds = sectionsUIds;
			if (IgnoreEmails()) {
				IndexingSectionListBuilder.AddEsqFuncFilter(ApplyActivityTypeFilter);
				IndexingSectionListBuilder.AddEsqFuncFilter(ApplyActivityFileTypeFilter);
				SingleIndexingSectionListBuilder.AddEsqFuncFilter(ApplyActivityTypeFilter);
				SingleIndexingSectionListBuilder.AddEsqFuncFilter(ApplyActivityFileTypeFilter);
			}
		}

		/// <summary>
		/// Gets single indexing entities.
		/// </summary>
		/// <returns>Indexing entities from single builders.</returns>
		protected virtual List<IndexingEntityConfig> BuildSingleIndexingEntities() {
			try {
				List<IndexingEntityConfig> singleIndexingDetailEntityList = SingleIndexingDetailListBuilder.Build();
				List<string> parentSchemas = singleIndexingDetailEntityList.Select(x => x.ParentEntityName).ToList();
				SingleIndexingSectionListBuilder.SetIndexingType(parentSchemas, IndexingType.Upsert);
				var singleIndexingSectionEntityList = SingleIndexingSectionListBuilder.Build();
				singleIndexingSectionEntityList.AddRange(singleIndexingDetailEntityList);
				_log.Info("BuildSingleIndexingEntities entities prepared successfully.");
				return singleIndexingSectionEntityList;
			}
			catch (Exception e) {
				_log.Error(e);
			}
			return null;
		}

		/// <summary>
		/// Gets indexing entities.
		/// </summary>
		/// <returns>Indexing entities from builders.</returns>
		protected virtual List<IndexingEntityConfig> BuildIndexingEntities() {
			try {
				List<IndexingEntityConfig> indexingDetailEntityList = IndexingDetailListBuilder.Build();
				List<string> parentSchemas = indexingDetailEntityList.Select(x => x.ParentEntityName).ToList();
				IndexingSectionListBuilder.SetIndexingType(parentSchemas, IndexingType.Upsert);
				var indexingSectionEntityList = IndexingSectionListBuilder.Build();
				indexingSectionEntityList.AddRange(indexingDetailEntityList);
				_log.Info("BuildIndexingEntities entities prepared successfully.");
				return indexingSectionEntityList;
			}
			catch (Exception e) {
				_log.Error(e);
			}
			return null;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Checks if email entities should be skipped in indexation.
		/// </summary>
		/// <returns><c>True</c> if email entities should be skipped in indexation. Otherwise returns <c>false</c>.
		/// </returns>
		public virtual bool IgnoreEmails() {
			return !GlobalAppSettings.UseMasterRecordRights;
		}

		/// <summary>
		/// Gets all need indexing entities.
		/// </summary>
		/// <returns>List of the all need indexing entities.</returns>
		public virtual List<IndexingEntityConfig> GetIndexingEntities() {
			InitializeBuilders();
			var singleIndexingEntities = BuildSingleIndexingEntities();
			var indexingEntities = BuildIndexingEntities();
			indexingEntities.AddRange(singleIndexingEntities);
			return indexingEntities;
		}
		
		#endregion

	}

	#endregion
}






