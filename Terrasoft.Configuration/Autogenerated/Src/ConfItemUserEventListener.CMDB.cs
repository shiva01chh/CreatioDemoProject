﻿namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.Configuration;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;
	using SystemSettings = Terrasoft.Core.Configuration.SysSettings;


	#region Class: ConfItemUserEventListener


	[EntityEventListener(SchemaName = "ConfItemUser")]
	public class ConfItemUserEventListener : BaseEntityEventListener
	{

		#region Methods: Private

		public void ChangeReadRights(Entity entity, EntitySchemaRecordRightLevel rightLevel) {
			bool rightsEnabled = SystemSettings.GetValue(entity.UserConnection, "EnableRightsOnServiceObjects", false);
			if (rightsEnabled) {
				var regulator = new ServiceObjectsRightsRegulator(entity.UserConnection, "ConfItem");
				Guid confItemId = entity.GetTypedColumnValue<Guid>("ConfItemId");
				regulator.ChangeContactReadRightsLevel(entity.GetTypedColumnValue<Guid>("ContactId"), confItemId, rightLevel);
				regulator.ChangeOrganizationReadRightsLevel(entity.GetTypedColumnValue<Guid>("AccountId"), confItemId, rightLevel);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// <see cref="BaseEntityEventListener.OnInserted"/>
		/// </summary>
		public override void OnInserted(object sender, EntityAfterEventArgs e) {
			base.OnInserted(sender, e);
			Entity entity = (Entity)sender;
			ChangeReadRights(entity, EntitySchemaRecordRightLevel.Allow);
		}

		/// <summary>
		/// <see cref="BaseEntityEventListener.OnDeleted"/>
		/// </summary>
		public override void OnDeleted(object sender, EntityAfterEventArgs e) {
			base.OnDeleted(sender, e);
			Entity entity = (Entity)sender;
			ChangeReadRights(entity, EntitySchemaRecordRightLevel.Deny);
		}

		#endregion

	}

	#endregion

}






