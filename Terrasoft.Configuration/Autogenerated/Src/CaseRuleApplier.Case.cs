namespace Terrasoft.Configuration
{
	using System;
	using System.Data;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: CaseRuleApplier

	public class CaseRuleApplier
	{

		#region Constants: Private

		private const string StatusIdColumnName = "StatusId";

		#endregion

		#region Fields: Private

		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public CaseRuleApplier(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		/// <summary>
		/// Return query with case rules.
		/// </summary>
		/// <param name="entity">Entity</param>
		/// <returns>Select for a sample of the rules.</returns>
		private Select GetRuleQuery(Guid statusId, Guid nextStatusId) {
			return new Select(_userConnection)
					.Column("CaseRuleHandler", "ClassName")
					.From("CaseRuleHandler")
						.InnerJoin("CaseRuleInStage")
							.On("CaseRuleHandler", "Id")
								.IsEqual("CaseRuleInStage", "CaseRuleHandlerId")
						.InnerJoin("CaseNextStatus")
							.On("CaseRuleInStage", "CaseNextStatusId")
								.IsEqual("CaseNextStatus", "Id")
					.Where("CaseNextStatus", "StatusId")
						.IsEqual(Column.Parameter(statusId))
					.And("CaseNextStatus", "NextStatusId")
						.IsEqual(Column.Parameter(nextStatusId))
					.And("CaseRuleInStage", "Active")
						.IsEqual(Column.Const(true))
					.OrderByAsc("CaseRuleInStage", "Position") as Select;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Create instance for case rules.
		/// </summary>
		/// <param name="entity">Entity</param>
		public void Execute(Entity entity) {
			using (var dbExecutor = _userConnection.EnsureDBConnection()) {
				var oldValue = entity.GetTypedOldColumnValue<Guid>(StatusIdColumnName);
				var value = entity.GetTypedColumnValue<Guid>(StatusIdColumnName);
				var rulesSelect = GetRuleQuery(oldValue, value);
				using (IDataReader reader = rulesSelect.ExecuteReader(dbExecutor)) {
					while (reader.Read()) {
						string ruleClassName = reader.GetColumnValue<string>("ClassName");
						var workspaceTypeProvider = ClassFactory.Get<IWorkspaceTypeProvider>();
						Type classType = workspaceTypeProvider.GetType(ruleClassName);
						var fullRuleTypeName = classType.AssemblyQualifiedName;
						ICaseRuleHandler instance = ClassFactory.ForceGet<ICaseRuleHandler>(fullRuleTypeName, new ConstructorArgument("userConnection", _userConnection));
						instance.Handle(entity);
					}
				}
			}
		}

		#endregion
	}

	#endregion
}





