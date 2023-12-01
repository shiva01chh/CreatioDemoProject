namespace Terrasoft.Configuration
{

	using DataContract = Terrasoft.Nui.ServiceModel.DataContract;
	using Newtonsoft.Json;
	using Newtonsoft.Json.Linq;
	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Data;
	using System.Drawing;
	using System.Globalization;
	using System.IO;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Common.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.DcmProcess;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;
	using Terrasoft.GlobalSearch.Indexing;
	using Terrasoft.UI.WebControls.Controls;
	using Terrasoft.UI.WebControls.Utilities.Json.Converters;

	#region Class: PortalMessage_PortalMessageEventsProcess

	public partial class PortalMessage_PortalMessageEventsProcess<TEntity>
	{

		#region Methods: Public

		public virtual void CopyFiles() {
			var recordId = Entity.GetTypedColumnValue<Guid>("EntityId");
			var entityUId = Entity.GetTypedColumnValue<Guid>("EntitySchemaUId");
			var schemaName = UserConnection.EntitySchemaManager.GetInstanceByUId(entityUId).Name;
			
			if(Entity.GetTypedColumnValue<bool>("IsNotPublished") && recordId.IsNotEmpty()) {
				Entity.SetColumnValue("IsNotPublished", false);
				var ignoreSchemaListForCopingFiles = GetIgnoreForCopyFilesSchemaList();
				if (ignoreSchemaListForCopingFiles.Contains(schemaName)) {
					return;
				}
				var schemasWithSpecifiedClassForCopying = GetSchemasWithSpecifiedClassForCopying();
				if (schemasWithSpecifiedClassForCopying.Contains(schemaName)) {
					var copyingUtility = GetInstanceOfSpecifiedClassForCopying(schemaName);
					if(copyingUtility != null) {
						copyingUtility.CopyAll("PortalMessage", Entity.PrimaryColumnValue, recordId);
						return;
					}
				}
				Terrasoft.Configuration.CommonUtilities
					.CopyFileDetail(UserConnection, Entity.PrimaryColumnValue, recordId, "PortalMessage", schemaName, false);
			}
		}

		public virtual void NotifyListeners() {
			if(this.Entity.GetTypedColumnValue<bool>("IsNotPublished")){
				return;
			}
			var notifier = new PortalMessageNotifier(this.Entity);
			var manager = new MessageHistoryManager(UserConnection, notifier);
			manager.Notify();
		}

		public virtual List<string> GetIgnoreForCopyFilesSchemaList() {
			return new List<string> { "Lead" };
		}

		public virtual List<string> GetSchemasWithSpecifiedClassForCopying() {
			return new List<string> { "Case" };
		}

		public virtual IEntityFileCopier GetInstanceOfSpecifiedClassForCopying(string schemaName) {
			var fileUserConnection = UserConnection is SSPUserConnection
				? UserConnection.AppConnection.SystemUserConnection
				: UserConnection;
			var userConnectionArgument = new ConstructorArgument("userConnection", fileUserConnection);
			return ClassFactory.Get<IEntityFileCopier>(schemaName, userConnectionArgument);
		}

		#endregion

	}

	#endregion

}

