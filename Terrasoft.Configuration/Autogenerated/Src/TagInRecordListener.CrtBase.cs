namespace Terrasoft.Configuration
{
	using System;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: TagInRecordListener

	/// <summary>
	/// Listener for 'TagInRecord' entity events.
	/// </summary>
	[EntityEventListener(SchemaName = "TagInRecord")]
	public class TagInRecordListener : BaseEntityEventListener
	{

		#region Methods: Private

		private void SetTagRecordIdIfNeed(Entity entity) {
			var tagId = entity.GetTypedColumnValue<Guid>("TagId");
			if (!tagId.Equals(Guid.Empty)) {
				entity.SetColumnValue("TagRecordId", tagId);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles entity Inserting event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="EntityBeforeEventArgs"/> instance containing the event data.</param>
		public override void OnInserting(object sender, EntityBeforeEventArgs e) {
			var entity = (Entity)sender;
			SetTagRecordIdIfNeed(entity);
			base.OnInserting(sender, e);
		}

		/// <summary>
		/// Handles entity Updating event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="EntityBeforeEventArgs"/> instance containing the event data.</param>
		public override void OnUpdating(object sender, EntityBeforeEventArgs e) {
			var entity = (Entity)sender;
			SetTagRecordIdIfNeed(entity);
			base.OnUpdating(sender, e);
		}


		#endregion
	}

	#endregion
}












