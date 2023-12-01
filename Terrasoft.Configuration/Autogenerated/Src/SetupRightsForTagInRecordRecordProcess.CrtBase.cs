namespace Terrasoft.Core.Process
{

	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Drawing;
	using System.Globalization;
	using System.Text;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SetupRightsForTagInRecordRecordProcessMethodsWrapper

	/// <exclude/>
	public class SetupRightsForTagInRecordRecordProcessMethodsWrapper : ProcessModel
	{

		public SetupRightsForTagInRecordRecordProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			CopyTagRecordRights();
			return true;
		}

			public void CopyTagRecordRights() {
				Guid tagId = Get<Guid>("TagId");
				Guid tagInRecordId = Get<Guid>("TagInRecordId");
				if (tagId == null || tagId == Guid.Empty || tagInRecordId == null || tagInRecordId == Guid.Empty) {
					return;
				}
				string tagRecordRightsSchemaName = UserConnection.DBSecurityEngine.GetRecordRightsSchemaName("Tag");
				string tagInRecordRecordRightsSchemaName = UserConnection.DBSecurityEngine.GetRecordRightsSchemaName("TagInRecord");
				if (tagRecordRightsSchemaName.IsNullOrEmpty() || tagInRecordRecordRightsSchemaName.IsNullOrEmpty()) {
					return;
				}
				var notExistSelect = new Select(UserConnection)
					.Distinct()
					.Column("str", "SysAdminUnitId")
					.Column("str", "Operation")
					.Column("str", "RightLevel")
					.From(tagInRecordRecordRightsSchemaName).As("str")
					.Where("str", "RecordId").IsEqual(Column.Parameter(tagInRecordId))
					.And("st", "SysAdminUnitId").IsEqual("str", "SysAdminUnitId")
					.And("st", "Operation").IsEqual("str", "Operation")
					.And("st", "RightLevel").IsEqual("str", "RightLevel") as Select;
				var subSelect = new Select(UserConnection)
						.Column(Column.Parameter(tagInRecordId))
						.Column("st", "SysAdminUnitId")
						.Column("st", "Operation")
						.Column("st", "RightLevel")
						.Column("st", "Position")
						.From(tagRecordRightsSchemaName).As("st")
						.Where("st", "RecordId").IsEqual(Column.Parameter(tagId))
						.And().Not().Exists(notExistSelect) as Select;
				var insertSelect = new InsertSelect(UserConnection)
					.Into(tagInRecordRecordRightsSchemaName)
					.Set("RecordId")
					.Set("SysAdminUnitId")
					.Set("Operation")
					.Set("RightLevel")
					.Set("Position")
					.FromSelect(subSelect) as InsertSelect;
				insertSelect.Execute();
			}

		#endregion

	}

	#endregion

}

