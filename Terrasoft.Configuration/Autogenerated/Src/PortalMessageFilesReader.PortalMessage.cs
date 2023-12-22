namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.RightsService;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region  Class: PortalMessageFilesReader

	/// <summary>
	/// Class for reading Portal Message files.
	/// </summary>
	public class PortalMessageFilesReader : IPortalMessageFileReader
	{

		/// <summary>
		/// Represents file loader wich can set UserConnection.
		/// </summary>
		protected class PortalMessageFileLoader : FileService.FileService
		{

			#region Method: Public

			/// <summary>
			/// Set UserConnection property.
			/// </summary>
			/// <param name="userConnection">The user connection.<see cref="UserConnection"/></param>
			public void SetUserConnection(UserConnection userConnection) {
				UserConnection = userConnection;
			}

			#endregion

		}

		#region Constants: Private 

		private readonly string _portalMessageFileAlias = "pmf";
		private readonly string _portalMessageFileIdAlias = "PortalMessageFileId";
		private readonly string PortalMessageFileSchemaUId = "55C1FE71-17A1-4BD2-A4B2-7799CCAAC996";

		#endregion

		#region Properties: Protected

		protected UserConnection userConnection;

		#endregion

		#region Properties: Public

		private RightsHelper _rightsHelper;
		public RightsHelper RightsHelper =>
			_rightsHelper ?? (_rightsHelper = new RightsHelper(userConnection));

		private PortalMessageFileLoader _portalMessageFileLoader;
		protected PortalMessageFileLoader PortalFileLoader =>
		_portalMessageFileLoader ?? (_portalMessageFileLoader = new PortalMessageFileLoader());

		#endregion

		#region Constructors: Public

		/// <summary>
		/// Initialize PortalMessageFilesReader.
		/// </summary>
		/// <param name="userConnection">UserConnection  <see cref="ReadingUserConnectionOptions"/>.</param>
		public PortalMessageFilesReader(UserConnection userConnection) {
			this.userConnection = userConnection;
			PortalFileLoader.SetUserConnection(userConnection.AppConnection.SystemUserConnection);
		}

		#endregion

		#region Methods: Private

		private Select GetPortalMessageFilesSelect(string portalMessageId) {
			return new Select(userConnection)
				.Column(_portalMessageFileAlias, "Id").As(_portalMessageFileIdAlias)
				.Column(_portalMessageFileAlias, "CreatedById")
				.Column(_portalMessageFileAlias, "CreatedOn")
				.Column(_portalMessageFileAlias, "Notes")
				.Column(_portalMessageFileAlias, "TypeId")
				.Column(_portalMessageFileAlias, "Version")
				.Column(_portalMessageFileAlias, "Name")
				.Column(_portalMessageFileAlias, "Size")
				.Column("ft", "Name").As("FileTypeName")
				.Column("pm", "EntityId")
				.Column("pm", "EntitySchemaUId")
				.From("PortalMessageFile", _portalMessageFileAlias)
				.LeftOuterJoin("PortalMessage").As("pm")
				.On("pm", "Id").IsEqual(_portalMessageFileAlias, "PortalMessageId")
				.LeftOuterJoin("FileType").As("ft")
				.On(_portalMessageFileAlias, "TypeId").IsEqual("ft", "Id")
				.Where(_portalMessageFileAlias, "PortalMessageId").IsEqual(Column.Const(Guid.Parse(portalMessageId)))
				.And("pm", "HideOnPortal").IsEqual(Column.Const(false)) as Select;
		}

		private bool CheckIfUserCanReadFiles(Guid entitySchemaUId, Guid entityId, out bool canReadData) {
			if (entitySchemaUId != default(Guid)) {
				var schemaName = userConnection.EntitySchemaManager.GetInstanceByUId(entitySchemaUId).Name;
				canReadData = RightsHelper.GetCanReadSchemaRecordRight(schemaName, entityId);
			} else {
				canReadData = true;
			}
			return canReadData;
		}

		private PortalMessageFileDTO CreatePortalMessageDTO(IDataReader reader) {
			return new PortalMessageFileDTO {
				Id = reader.GetColumnValue<Guid>(_portalMessageFileIdAlias),
				CreatedBy = reader.GetColumnValue<Guid>("CreatedById"),
				CreatedOn = reader.GetColumnValue<string>("CreatedOn"),
				Name = reader.GetColumnValue<string>("Name"),
				Size = reader.GetColumnValue<int>("Size"),
				Notes = reader.GetColumnValue<string>("Notes"),
				Type = GetPortalMessageTypeLookUpValue(reader),
				Version = reader.GetColumnValue<int>("Version")
			};
		}

		private LookupColumn GetPortalMessageTypeLookUpValue(IDataReader reader) {
			return new LookupColumn {
				DisplayValue = reader.GetColumnValue<string>("FileTypeName"),
				PrimaryImageValue = string.Empty,
				Value = reader.GetColumnValue<Guid>("TypeId")
			};
		}

		private PageableSelectOptions GetPageableOptions(ReadingOptions readingOptions) {
			var idExpression = new QueryColumnExpression(_portalMessageFileAlias, "Id");
			idExpression.Alias = _portalMessageFileIdAlias;
			var lastValueParameter = new QueryParameter("IdLastValue", readingOptions.LastValue);
			var pageableSelectCondition = new PageableSelectCondition {
				LastValueParameter = lastValueParameter,
				LeftExpression = idExpression,
				OrderByItem = new OrderByItem(idExpression, OrderDirectionStrict.Ascending)
			};
			return new PageableSelectOptions(pageableSelectCondition, readingOptions.RowCount, PageableSelectDirection.Next);
		}

		private bool CheckAccessToPortalMessage(string messageHistorySchemaName, string messageHistoryId) {
			var portalMessageSelect = GetPortalMessageSelect(messageHistorySchemaName, messageHistoryId);
			var portalMessages = portalMessageSelect.ExecuteEnumerable(r => new {
				Id = r.GetColumnValue<Guid>("PortalMessageId"),
				HideOnPortal = r.GetColumnValue<bool>("HideOnPortal")
			}).ToList();
			return portalMessages.Any(p => !p.HideOnPortal);
		}


		protected Select GetPortalMessageSelect(string messageHistorySchemaName, string messageHistoryId) {
			var esq = new EntitySchemaQuery(userConnection.EntitySchemaManager, messageHistorySchemaName);
			esq.PrimaryQueryColumn.IsAlwaysSelect = true;
			var primaryKeyFilter = esq.CreateFilterWithParameters(FilterComparisonType.Equal,
				esq.RootSchema.GetPrimaryColumnName(), messageHistoryId);
			esq.Filters.Add(primaryKeyFilter);
			var caseMessageHistorySelect = esq.GetSelectQuery(userConnection);
			caseMessageHistorySelect.InnerJoin("PortalMessage").As("PM").On("PM", "Id").IsEqual(messageHistorySchemaName, "RecordId");
			caseMessageHistorySelect.Column("PM", "Id").As("PortalMessageId");
			caseMessageHistorySelect.Column("PM", "HideOnPortal").As("HideOnPortal");
			return caseMessageHistorySelect;
		}


		#endregion

		#region Methods: Public

		/// <summary>
		/// Get portal message files.
		/// </summary>
		/// <param name="PortalMessageId">Portal message uniqueidentifier.</param>
		/// <param name="readingOptions">Readin message options <see cref="ReadingOptions"/>.</param>
		/// <returns>Container with Portal message files collection <see cref="PortalFileServiceResponse"/>.</returns>
		public IEnumerable<PortalMessageFileDTO> GetPortalMessageFiles(string portalMessageId, ReadingOptions readingOptions) {
			var options = GetPageableOptions(readingOptions);
			var portalMessageFileSelect = GetPortalMessageFilesSelect(portalMessageId).ToPageable(options);
			var files = new List<PortalMessageFileDTO>();
			using (DBExecutor dbExec = userConnection.EnsureDBConnection()) {
				using (IDataReader reader = portalMessageFileSelect.ExecuteReader(dbExec)) {
					var canReadData = false;
					while (reader.Read() && ((canReadData || CheckIfUserCanReadFiles(reader.GetColumnValue<Guid>("EntitySchemaUId"),
						reader.GetColumnValue<Guid>("EntityId"), out canReadData)))) {
						files.Add(CreatePortalMessageDTO(reader));
					}
				}
			}
			return files;
		}

		/// <summary>
		/// Loads accessible file.
		/// </summary>
		/// <param name="historySchemaName">Name of schema for history data.</param>
		/// <param name="messageHistoryId">Identifier of record on history schema.</param>
		/// <param name="fileId">File identifier to be loaded.</param>
		/// <returns>Stream of file data.</returns>
		public Stream GetPortalMessageFile(string historySchemaName, string messageHistoryId, string fileId) {
			if (CheckAccessToPortalMessage(historySchemaName, messageHistoryId)) {
				return PortalFileLoader.GetFile(PortalMessageFileSchemaUId, fileId);
			}
			return Stream.Null;
		}

		#endregion
	}

	#endregion

}













