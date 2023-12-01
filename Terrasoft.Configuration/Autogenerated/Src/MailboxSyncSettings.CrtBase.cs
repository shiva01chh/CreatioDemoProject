namespace Terrasoft.Configuration
{

	using System.Data;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;

	#region Class: MailboxSyncSettings_CrtBaseEventsProcess

	public partial class MailboxSyncSettings_CrtBaseEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void DeleteSharedRights() {
			var currentUserId = UserConnection.CurrentUser.Id;
			var del = new Delete(UserConnection)
				.From("SysMailboxSyncSettingsRight")
				.Where("RecordId").IsEqual(Column.Parameter(Entity.Id))
				.And("SysAdminUnitId").IsNotEqual(Column.Parameter(currentUserId)) as Delete;
			del.Execute();
			var sel = new Select(UserConnection)
				.Column("Id")
				.From("SysMailboxSyncSettingsRight")
				.Where("RecordId").IsEqual(Column.Parameter(Entity.Id))
				.And("SysAdminUnitId").IsEqual(Column.Parameter(currentUserId)) as Select;
			using (DBExecutor dbExecutor = UserConnection.EnsureDBConnection()) {
				using (IDataReader dr = sel.ExecuteReader(dbExecutor)) {
					if(!dr.Read()) {
						Insert ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Read))
								.Set("RightLevel", Column.Parameter(EntitySchemaRecordRightLevel.AllowAndGrant))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
						ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Edit))
								.Set("RightLevel", Column.Parameter(EntitySchemaRecordRightLevel.AllowAndGrant))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
						ins =
							new Insert(UserConnection)
								.Into("SysMailboxSyncSettingsRight")
								.Set("RecordId", Column.Parameter(Entity.Id))
								.Set("SysAdminUnitId", Column.Parameter(currentUserId))
								.Set("Operation", Column.Parameter(EntitySchemaRecordRightOperation.Delete))
								.Set("RightLevel", Column.Parameter(EntitySchemaRecordRightLevel.AllowAndGrant))
								.Set("Position", Column.Parameter(0))
								.Set("SourceId", Column.Parameter("8A248A03-E9A5-DF11-9989-485B39C18470"))
								 as Insert;
						ins.Execute();
					}
				}
			}
		}

		#endregion

	}

	#endregion

}

