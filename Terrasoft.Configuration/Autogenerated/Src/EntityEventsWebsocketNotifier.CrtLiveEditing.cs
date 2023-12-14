namespace Terrasoft.Configuration.LiveEditing
{
	using System;
	using System.Linq;
	using Newtonsoft.Json;
	using Terrasoft.Core;
	using Terrasoft.Core.Entities;


	#region Class: EntityEventsWebsocketNotifier

	public class EntityEventsWebsocketNotifier
	{
		#region Constants: Private

		private const string WebsocketSenderName = "LiveEditingNotifier";

		#endregion

		#region Fields: Private

		private UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public EntityEventsWebsocketNotifier(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Methods: Private

		private EntityLiveEditingEventData GetEventData(Entity entity, EntityAfterEventArgs entityEventArguments, LiveEditingEventType eventType) {
			switch (eventType) {
				case LiveEditingEventType.Inserted:
					return GetInsertedEventData(entity);
				case LiveEditingEventType.Updated:
					return GetUpdatedEventData(entity, entityEventArguments);
				case LiveEditingEventType.Deleted:
					throw new NotImplementedException();
				default:
					throw new NotImplementedException();
			}

		}

		private T GetBaseEventData<T>(Entity entity, LiveEditingEventType eventType) where T : EntityLiveEditingEventData, new() {
			T eventData = new T();
			eventData.EventType = eventType;
			eventData.EntitySchemaName = entity.SchemaName;
			eventData.PrimaryColumnValue = entity.PrimaryColumnValue;
			eventData.PrimaryColumnName = entity.Schema.PrimaryColumn.Name;
			eventData.ModifiedById = entity.GetTypedColumnValue<Guid>("ModifiedById");
			eventData.ModifiedOn = entity.GetTypedColumnValue<DateTime>("ModifiedOn");
			return eventData;
		}

		private void AddConnectedLiveEditingColumns(Entity entity, EntityLiveEditingEventData eventData) {
			var connectedLiveEditingColumns = entity.GetChangedColumnValues()
					.Where(c => c.Column.IsLookupType && c.Column.ReferenceSchema.UseLiveEditing && c.Value != default)
					.ToDictionary(c => c.Name, c => c.Value);
			if (connectedLiveEditingColumns.Any() && entity.UserConnection.CurrentUser.ConnectionType != UserType.SSP) {
				eventData.ConnectedLiveSchemaColumns = connectedLiveEditingColumns;
			}
		}

		private EntityLiveEditingEventData GetUpdatedEventData(Entity entity, EntityAfterEventArgs entityEventArguments) {
			EntityLiveEditingEventData eventData = GetBaseEventData<EntityLiveEditingEventData>(entity, LiveEditingEventType.Updated);
			eventData.ColumnNames = entityEventArguments.ModifiedColumnValues.Select(columnValue => columnValue.Column.Name).ToList();
			AddConnectedLiveEditingColumns(entity, eventData);
			return eventData;
		}

		private EntityLiveEditingEventData GetInsertedEventData(Entity entity) {
			EntityLiveEditingEventData eventData = GetBaseEventData<EntityLiveEditingEventData>(entity, LiveEditingEventType.Inserted);
			AddConnectedLiveEditingColumns(entity, eventData);
			return eventData;
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Notifies current user about changes at entity.
		/// </summary>
		/// <param name="entity">Base live editing entity.</param>
		/// <param name="entityEventArguments">Entite event arguments.</param>
		/// <param name="eventType">Type of entity event.</param>
		public void NotifyCurrentUser(Entity entity, EntityAfterEventArgs entityEventArguments, LiveEditingEventType eventType) {
			EntityLiveEditingEventData eventData = GetEventData(entity, entityEventArguments, eventType);
			MsgChannelUtilities.PostMessage(_userConnection, WebsocketSenderName, JsonConvert.SerializeObject(eventData));
		}

		#endregion

	}

	#endregion
}





