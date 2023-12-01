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

	#region Class: SetAccessRightsToTagProcessMethodsWrapper

	/// <exclude/>
	public class SetAccessRightsToTagProcessMethodsWrapper : ProcessModel
	{

		public SetAccessRightsToTagProcessMethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("ScriptTask1Execute", ScriptTask1Execute);
		}

		#region Methods: Private

		private bool ScriptTask1Execute(ProcessExecutingContext context) {
			Set("IsPortalRole", GetIsPortalRole());
			return true;
		}

			public bool GetIsPortalRole() {
				Guid sysAdminUnitId = Get<Guid>("SysAdminUnitId");
				if (sysAdminUnitId == null || sysAdminUnitId == Guid.Empty) {
					return false;
				}
				Select checkSelect = new Select(UserConnection)
					.Column(Func.Count("Id"))
					.From("SysAdminUnit")
					.Where("Id").IsEqual(Column.Parameter(sysAdminUnitId))
						.And("ConnectionType").IsEqual(Column.Parameter(UserType.SSP)) as Select;
				int count = checkSelect.ExecuteScalar<int>();
				return count == 1;
			}

		#endregion

	}

	#endregion

}

