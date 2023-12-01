namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Core;
	using Terrasoft.Core.Applications.Abstractions;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;

	#region Class

	/// <summary>
	/// Query executor for business processes.
	/// </summary>
	[DefaultBinding(typeof(IEntityQueryExecutor), Name = "ApplicationProcessQueryExecutor")]
	public class ApplicationProcessQueryExecutor : BaseApplicationSchemaQueryExecutor<ProcessSchema>
	{

		#region Constructors: Public

		public ApplicationProcessQueryExecutor(UserConnection userConnection, IAppManager appManager)
			: base(userConnection, appManager) { }

		#endregion

		#region Methods: Protected

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override string ResultEntitySchemaName => "ApplicationProcess";

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override SchemaManager<ProcessSchema> GetSchemaManager() => UserConnection.ProcessSchemaManager;

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override IEnumerable<ISchemaManagerItem<ProcessSchema>> GetSchemaManagerItems(Guid appId) {
			return base.GetSchemaManagerItems(appId).Where(item =>
				UserConnection.ProcessSchemaManager.GetIsActiveVersion(item.Id));
		}

		/// <summary>
		/// <inheritdoc />
		/// </summary>
		protected override void MapAdditionalColumns(Entity entity,
				ISchemaManagerItem<ProcessSchema> schemaManagerItem) {
			entity.SetColumnValue("IsEnabled",
				UserConnection.ProcessSchemaManager.GetIsProcessEnabled(schemaManagerItem.Id));
		}

		#endregion

	}

	#endregion

}





