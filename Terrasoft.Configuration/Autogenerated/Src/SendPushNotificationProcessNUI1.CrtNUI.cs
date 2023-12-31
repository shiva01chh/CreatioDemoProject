﻿namespace Terrasoft.Core.Process
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
	using Terrasoft.Configuration;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;
	using Terrasoft.Core.Process;
	using Terrasoft.Core.Process.Configuration;

	#region Class: SendPushNotificationProcessNUI1MethodsWrapper

	/// <exclude/>
	public class SendPushNotificationProcessNUI1MethodsWrapper : ProcessModel
	{

		public SendPushNotificationProcessNUI1MethodsWrapper(Process process)
			: base(process) {
			AddScriptTaskMethod("SendPushScriptTaskExecute", SendPushScriptTaskExecute);
		}

		#region Methods: Private

		private bool SendPushScriptTaskExecute(ProcessExecutingContext context) {
			var userConnection = this.Get<UserConnection>("UserConnection");
			var pushNotification = new PushNotification(userConnection);
			string title = Get<string>("Title");
			string message = Get<string>("Message");
			Guid sysAdminUnitId = Guid.Empty;
			try {
				sysAdminUnitId = Get<Guid>("SysAdminUnitId");
			} catch(Exception e) {
			}
			if (sysAdminUnitId == Guid.Empty) {
				return true;
			}
			Guid entityUId = Guid.Empty;
			try {
				entityUId = Get<Guid>("EntityUId");
			} catch(Exception e) {
			}
			string entityName = string.Empty;
			if (entityUId != Guid.Empty) {
				EntitySchema sysSchema = userConnection.EntitySchemaManager.GetInstanceByName("SysSchema");
				Entity sysSchemaEntity = sysSchema.CreateEntity(userConnection);
				if (sysSchemaEntity.FetchFromDB("UId", entityUId, new List<string> { "Name" })) {
					entityName = sysSchemaEntity.GetTypedColumnValue<string>("Name");
				}
			}
			string recordIdStr = string.Empty;
			try {
				Guid recordId = Get<Guid>("RecordId");
				recordIdStr = recordId.ToString();
			} catch(Exception e) {
			}
			Dictionary<string, string> additionalData = new Dictionary<string, string>();
			additionalData.Add("entityName", entityName);
			additionalData.Add("recordId", recordIdStr);
			pushNotification.Send(sysAdminUnitId, title, message, additionalData);
			return true;
		}

		#endregion

	}

	#endregion

}

