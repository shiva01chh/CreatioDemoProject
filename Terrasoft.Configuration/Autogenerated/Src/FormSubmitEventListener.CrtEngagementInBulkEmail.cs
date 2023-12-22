namespace Terrasoft.Configuration
{
	using Terrasoft.Common;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Entities.Events;

	#region Class: FormSubmitEventListener

	/// <summary>
	/// Listener for <see cref="FormSubmit"/> entity events.
	/// </summary>
	/// <seealso cref="BaseEntityEventListener" />
	[EntityEventListener(SchemaName = nameof(FormSubmit))]
	public class FormSubmitEventListener : BaseEntityEventListener
	{

		#region Properties: Public

		/// <summary>
		/// Instance of <see cref="MarketingUtmParser"/> to find linked entities by utm params.
		/// </summary>
		private MarketingUtmParser _utmParser;
		public MarketingUtmParser UtmParser {
			get => _utmParser ?? (_utmParser = new MarketingUtmParser());
			set => _utmParser = value;
		}

		#endregion

		#region Methods: Private

		private void BindLinkedEntities(FormSubmit entity) {
			if (!entity.IsColumnValueLoaded("LandingPageURL")) {
				return;
			}
			var landingPageUrl = entity.GetTypedColumnValue<string>("LandingPageURL");
			if (string.IsNullOrWhiteSpace(landingPageUrl)) {
				return;
			}
			var bulkEmailId = UtmParser.GetBulkEmailByUtm(entity.UserConnection, landingPageUrl);
			if (bulkEmailId.IsNotEmpty()) {
				entity.SetColumnValue("BulkEmailId", bulkEmailId);
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles <see cref="FormSubmit"/> entity <see cref="OnInserting"/> event.
		/// </summary>
		/// <param name="sender">Event sender.</param>
		/// <param name="e">The <see cref="T:Terrasoft.Core.Entities.EntityBeforeEventArgs" /> instance containing the
		/// event data.</param>
		public override void OnInserting(object sender, EntityBeforeEventArgs e) {
			base.OnInserting(sender, e);
			var entity = (FormSubmit)sender;
			BindLinkedEntities(entity);
		}

		#endregion

	}

	#endregion

}














