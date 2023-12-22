using System;
using global::Common.Logging;
using Terrasoft.Core;
using Terrasoft.Core.Entities;
using Terrasoft.Core.Entities.Events;

namespace Terrasoft.Configuration.LiveEditing
{

	#region Class: LiveEditingBaseEntityEventListener

	[EntityEventListener(SchemaName = "BaseEntity")]
	public class LiveEditingBaseEntityEventListener : BaseEntityEventListener
	{

		private ILog _log;
		protected ILog Log
		{
			get
			{
				return _log ?? (_log = LogManager.GetLogger("LiveEditingListener"));
			}
		}

		private bool NeedNotify(Entity entity, UserConnection userConnection) {
			return userConnection.GetIsFeatureEnabled("LiveEditingForCurrentUser") && entity.Schema.UseLiveEditing;
		}

		public override void OnUpdated(object sender, EntityAfterEventArgs e) {
			base.OnUpdated(sender, e);
			try {
				var entity = (Entity)sender;
				var userConnection = entity.UserConnection;
				if (!userConnection.GetIsFeatureEnabled("LiveEditing")) {
					return;
				}
				if (NeedNotify(entity, userConnection)) {
					EntityEventsWebsocketNotifier notifier = new EntityEventsWebsocketNotifier(userConnection);
					notifier.NotifyCurrentUser(entity, e, LiveEditingEventType.Updated);
				}
			} catch (Exception ex) {
				Log.Error(ex.Message);
			}
		}

		public override void OnInserted(object sender, EntityAfterEventArgs e) {
			base.OnInserted(sender, e);
			try {
				var entity = (Entity)sender;
				var userConnection = entity.UserConnection;
				if (!userConnection.GetIsFeatureEnabled("LiveEditing")) {
					return;
				}
				if (NeedNotify(entity, userConnection)) {
					EntityEventsWebsocketNotifier notifier = new EntityEventsWebsocketNotifier(userConnection);
					notifier.NotifyCurrentUser(entity, e, LiveEditingEventType.Inserted);
				}
			} catch (Exception ex) {
				Log.Error(ex.Message);
			}
		}
	}

	#endregion

}













