namespace Terrasoft.Configuration.Tagging
{
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Nui.ServiceModel.DataContract;
	using Terrasoft.Nui.ServiceModel.Extensions;
	using EntitySchema = Terrasoft.Core.Entities.EntitySchema;

	#region Interface: ITaggingManager

	/// <summary>
	/// Interface of tagging manager.
	/// </summary>
	public interface ITaggingManager
	{
		/// <summary>
		/// Adds tags to records.
		/// </summary>
		/// <param name="recordsEsqSerialized">Serialized entity schema query of records.</param>
		/// <param name="tagsEsqSerialized">Serialized entity schema query of tags.</param>
		/// <returns>Count of processed records.</returns>
		int AddTags(string recordsEsqSerialized, string tagsEsqSerialized);

		/// <summary>
		/// Removes tags from records.
		/// </summary>
		/// <param name="recordsEsqSerialized">Serialized entity schema query of records.</param>
		/// <param name="tagsEsqSerialized">Serialized entity schema query of tags.</param>
		/// <returns>Count of processed records.</returns>
		int RemoveTags(string recordsEsqSerialized, string tagsEsqSerialized);
	}

	#endregion

	#region Class: TaggingManager

	/// <summary>
	/// Tagging manager.
	/// </summary>
	[DefaultBinding(typeof(ITaggingManager), Name = "TaggingManager")]
	public class TaggingManager : ITaggingManager
	{

		#region Properties: Private

		private UserConnection UserConnection { get; set; }

		#endregion

		#region Counstructors: Public

		public TaggingManager(UserConnection userConnection) {
			this.UserConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private EntitySchemaQuery CreateEntitySchemaQueryBySerializedEsq(string esqSerialized, string argumentName) {
			var selectQuery = CreateSelectQueryFromSerializedEsq(esqSerialized, argumentName);
			return CreateEntitySchemaQueryFromSelectQuery(selectQuery, argumentName);
		}

		private SelectQuery CreateSelectQueryFromSerializedEsq(string esqSerialized, string argumentName) {
			var selectQuery = Json.Deserialize<SelectQuery>(esqSerialized);
			selectQuery.CheckArgumentNull($"Deserialized {argumentName}");
			return selectQuery;
		}

		private EntitySchemaQuery CreateTagInRecordSchemaQueryByRecordsAndTags(EntitySchemaQuery recordsSchemaQuery,
			EntitySchemaQuery tagsSchemaQuery) {
			var esq = new EntitySchemaQuery(UserConnection.EntitySchemaManager, "TagInRecord");
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			esq.UseAdminRights = false;
			esq.Filters.LogicalOperation = LogicalOperationStrict.And;
			var recordFilter = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			var tagFilter = new EntitySchemaQueryFilterCollection(esq, LogicalOperationStrict.Or);
			foreach (Entity record in recordsSchemaQuery.GetEntityCollection(UserConnection)) {
				recordFilter.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "RecordId",
					record.PrimaryColumnValue));
			}
			foreach (Entity tag in tagsSchemaQuery.GetEntityCollection(UserConnection)) {
				tagFilter.Add(esq.CreateFilterWithParameters(FilterComparisonType.Equal, "Tag",
					tag.PrimaryColumnValue));
			}
			esq.Filters.Add(recordFilter);
			esq.Filters.Add(tagFilter);
			return esq;
		}

		private EntitySchemaQuery CreateEntitySchemaQueryFromSelectQuery(SelectQuery selectQuery, string argumentName) {
			var entitySchemaQuery = selectQuery.BuildEsq(UserConnection);
			entitySchemaQuery.CheckArgumentNull($"EntitySchemaQuery {argumentName}");
			entitySchemaQuery.UseAdminRights = false;
			entitySchemaQuery.ChunkSize =
				Core.Configuration.SysSettings.GetValue(UserConnection, "ReadDataChunkSize", 50);
			entitySchemaQuery.PrimaryQueryColumn.IsAlwaysSelect = true;
			return entitySchemaQuery;
		}

		private int GetTagInRecordRecordsCount(EntitySchemaQuery tagInRecordSchemaQuery) {
			var esq = new EntitySchemaQuery(tagInRecordSchemaQuery);
			esq.IsDistinct = true;
			esq.AddColumn("RecordId");
			return esq.GetEntityCollection(UserConnection).Count;
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Process to add tags.
		/// </summary>
		/// <param name="recordsSchemaQuery">Serialized entity schema query of records.</param>
		/// <param name="tagsSchemaQuery">Serialized entity schema query of tags.</param>
		/// <returns>Count of processed records.</returns>
		protected int ProcessAddTags(EntitySchemaQuery recordsSchemaQuery, EntitySchemaQuery tagsSchemaQuery) {
			var recordsCollection = recordsSchemaQuery.GetEntityCollection(UserConnection);
			var tagsCollection = tagsSchemaQuery.GetEntityCollection(UserConnection);
			var tagInRecordSchema = UserConnection.EntitySchemaManager.GetInstanceByName("TagInRecord");
			foreach (Entity record in recordsCollection) {
				foreach (Entity tag in tagsCollection) {
					CreateAndSaveTagInRecord(tagInRecordSchema, recordsSchemaQuery.RootSchema.Name, record, tag);
				}
			}
			return recordsCollection.Count;
		}

		/// <summary>
		/// Creates tag in record entity.
		/// </summary>
		/// <param name="schema">Entity schema.</param>
		/// <param name="recordSchemaName">Record schema name.</param>
		/// <param name="record">Record entity.</param>
		/// <param name="tag">Tag entity.</param>
		/// <returns>Tag in record entity.</returns>
		protected Entity CreateTagInRecord(EntitySchema schema, string recordSchemaName, Entity record, Entity tag) {
			var tagInRecordEntity = schema.CreateEntity(UserConnection);
			tagInRecordEntity.SetDefColumnValues();
			tagInRecordEntity.SetColumnValue("RecordSchemaName", recordSchemaName);
			tagInRecordEntity.SetColumnValue("TagId", tag.PrimaryColumnValue);
			tagInRecordEntity.SetColumnValue("RecordId", record.PrimaryColumnValue);
			return tagInRecordEntity;
		}

		/// <summary>
		/// Creates tag in record entity end save.
		/// </summary>
		/// <param name="schema">Entity schema.</param>
		/// <param name="recordSchemaName">Record schema name.</param>
		/// <param name="record">Record entity.</param>
		/// <param name="tag">Tag entity.</param>
		/// <returns>Boolean value that indicates successfully saved entity.</returns>
		protected bool CreateAndSaveTagInRecord(EntitySchema schema, string recordSchemaName, Entity record,
			Entity tag) {
			try {
				return CreateTagInRecord(schema, recordSchemaName, record, tag).Save();
			} catch {
				return false;
			}
		}

		/// <summary>
		/// Process to remove tags.
		/// </summary>
		/// <param name="recordsSchemaQuery">Serialized entity schema query of records.</param>
		/// <param name="tagsSchemaQuery">Serialized entity schema query of tags.</param>
		/// <returns>Count of processed records.</returns>
		protected int ProcessRemoveTags(EntitySchemaQuery recordsSchemaQuery, EntitySchemaQuery tagsSchemaQuery) {
			var esq = CreateTagInRecordSchemaQueryByRecordsAndTags(recordsSchemaQuery, tagsSchemaQuery);
			var processedRecordsCount = GetTagInRecordRecordsCount(esq);
			esq.GetEntityCollection(UserConnection).ToList().ForEach(entity => RemoveTagInRecord(entity));
			return processedRecordsCount;
		}

		/// <summary>
		/// Remove TagInRecord.
		/// </summary>
		/// <param name="tagInRecord">TagInRecord entity.</param>
		/// <returns>Boolean value that indicates successfully deleted entity.</returns>
		protected bool RemoveTagInRecord(Entity tagInRecord) {
			try {
				return tagInRecord.Delete();
			} catch {
				return false;
			}
		}

		#endregion

		#region Methods: Public

		///<inheritdoc />
		public int AddTags(string recordsEsqSerialized, string tagsEsqSerialized) {
			var recordsSchemaQuery = CreateEntitySchemaQueryBySerializedEsq(recordsEsqSerialized,
				nameof(recordsEsqSerialized));
			var tagsSchemaQuery = CreateEntitySchemaQueryBySerializedEsq(tagsEsqSerialized, nameof(tagsEsqSerialized));
			return ProcessAddTags(recordsSchemaQuery, tagsSchemaQuery);
		}

		///<inheritdoc />
		public int RemoveTags(string recordsEsqSerialized, string tagsEsqSerialized) {
			var recordsSchemaQuery = CreateEntitySchemaQueryBySerializedEsq(recordsEsqSerialized,
				nameof(recordsEsqSerialized));
			var tagsSchemaQuery = CreateEntitySchemaQueryBySerializedEsq(tagsEsqSerialized, nameof(tagsEsqSerialized));
			return ProcessRemoveTags(recordsSchemaQuery, tagsSchemaQuery);
		}

		#endregion

	}

	#endregion

}





