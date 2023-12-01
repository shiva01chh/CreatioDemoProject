 namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;

	#region Class: SysApprovalNotificationProvider

	/// <summary>
	/// Visas notification provider for sections.
	/// </summary>
	public class SysApprovalNotificationProvider : BaseVisaNotificationProvider, INotification
	{

		#region Constructors: Public

		/// <summary>
		/// Initializes a new instance of the <see cref="SysApprovalNotificationProvider"/> class with parameters.
		/// </summary>
		/// <param name="parameters">Parameters dictionary.</param>
		public SysApprovalNotificationProvider(Dictionary<string, object> parameters)
			: base(parameters) {
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="SysApprovalNotificationProvider"/> class with parameters.
		/// </summary>
		/// <param name="userConnection">UserConnection.</param>
		public SysApprovalNotificationProvider(UserConnection userConnection)
			: base(userConnection) {
		}

		#endregion

		#region Methods: Private

		private Select GetSysModuleSelect() {
			var select =
				new Select(UserConnection)
					.Column("SysModuleEntity", "SysEntitySchemaUId").As("EntitySchemaUId")
					.Column("SysModule", "Image32Id")
				.From("SysModule")
					.InnerJoin("SysModuleEntity").On("SysModuleEntity", "Id")
						.IsEqual("SysModule", "SysModuleEntityId")
					.Where("SysModule", "Code")
					.In(GetVisaEntitiesSelect()) as Select;
			return select;
		}
		
		private Select GetVisaEntitiesSelect() {
			var select =
				new Select(UserConnection)
					.Distinct()
					.Column("ReferenceSchemaName")
					.From("SysApproval") as Select;
			return select;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Return number of section notification.
		/// </summary>
		/// <returns>A number of notification.</returns>
		public override int GetCount() {
			Select entitySelect = GetEntitiesSelect();
			if (entitySelect == null) {
				return 0;
			}
			Select countSelect =
				new Select(UserConnection)
					.Column(Func.Count("Id"))
					.Distinct()
				.From(entitySelect).As("CountSelect") as Select;
			return countSelect.ExecuteScalar<int>();
		}

		/// <summary>
		/// Returns <see cref="Select"/> for section visas./>
		/// </summary>
		/// <returns>A <see cref="Select"/> instance.</returns>
		public override Select GetEntitiesSelect() {
			Select entitiesSelect = null;
			GetSysModuleSelect().ExecuteReader(reader => {
				Guid entitySchemaUId = reader.GetColumnValue<Guid>("EntitySchemaUId");
				Guid sysModuleImage32Id = reader.GetColumnValue<Guid>("Image32Id");
				EntitySchema entitySchema = EntitySchemaManager.GetInstanceByUId(entitySchemaUId);
				var sysModuleVisaProvider = new BaseVisaNotificationProvider(parameters) {
					Name = entitySchema.Name,
					Caption = entitySchema.Caption,
					Visa = "SysApproval",
					VisaMasterColumn = "EntityId",
					TitleColumn = entitySchema.PrimaryDisplayColumn.ColumnValueName,
					ImageId = sysModuleImage32Id
				};
				Select sysModuleVisaSelect = sysModuleVisaProvider.GetEntitiesSelect();
				entitiesSelect = entitiesSelect == null
					? sysModuleVisaSelect
					: entitiesSelect.UnionAll(sysModuleVisaSelect) as Select;
			});
			return entitiesSelect;
		}

		/// <summary>
		/// Returns notification. Method is not implemented.
		/// </summary>
		public IEnumerable<INotificationInfo> GetNotifications() {
			throw new NotImplementedException();
		}

		#endregion

	}

	#endregion
}



