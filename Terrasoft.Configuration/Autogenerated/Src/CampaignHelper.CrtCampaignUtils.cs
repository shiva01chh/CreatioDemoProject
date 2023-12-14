namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Common;
	using Core;
	using Core.Campaign;
	using Core.DB;
	using Terrasoft.Core.Entities;
	using CoreCampaignSchema = Core.Campaign.CampaignSchema;

	#region Class: CampaignHelper

	public class CampaignHelper
	{

		#region Const: Private

		private const string CampaignHelperClassName = nameof(CampaignHelper);

		private const string CampaignSchemaNotFoundException = "CampaignSchemaNotFoundException";

		private const string CampaignNotFoundException = "CampaignNotFoundException";

		#endregion

		#region Constructors: Public

		public CampaignHelper(UserConnection userConnection) {
			_userConnection = userConnection;
		}

		#endregion

		#region Fields: Private

		private UserConnection _userConnection;

		#endregion

		#region Methods: Public

		/// <summary>
		/// Gets the campaign with specified fields filled in from DB.
		/// </summary>
		/// <param name="userConnection">The user connection.</param>
		/// <param name="campaignId">The campaign identifier.</param>
		/// <param name="columnsToFetch">The columns names to fetch.</param>
		/// <returns></returns>
		public static Campaign GetCampaign(UserConnection userConnection, Guid campaignId,
				params string[] columnsToFetch) {
			EntitySchema schema = userConnection.EntitySchemaManager.GetInstanceByName("Campaign");
			Entity campaign = schema.CreateEntity(userConnection);
			IEnumerable<EntitySchemaColumn> columns = schema.Columns.GetByNames(columnsToFetch);
			if (campaign.FetchFromDB(schema.PrimaryColumn, campaignId, columns)) {
				return campaign as Campaign;
			}
			return null;
		}

		/// <summary>
		/// Gets the campaign with specified fields filled in from DB. Instnace method.
		/// </summary>
		/// <param name="campaignId">The campaign identifier.</param>
		/// <param name="columnsToFetch">The columns to fetch.</param>
		/// <returns>Instance of <see cref="Campaign"/>.</returns>
		public virtual Campaign GetCampaign(Guid campaignId,
				params string[] columnsToFetch) {
			return GetCampaign(_userConnection, campaignId, columnsToFetch);
		}

		/// <summary>
		/// Returns lightweight campaign model with status and progress state.
		/// </summary>
		/// <param name="campaignId">The campaign identifier.</param>
		/// <returns>Instance of <see cref="CampaignInfo"/>.</returns>
		public virtual CampaignInfo GetCampaignInfo(Guid campaignId) {
			CampaignInfo campaignInfo = null;
			var select = new Select(_userConnection)
				.Column("InProgress")
				.Column("CampaignStatusId")
				.From("Campaign")
				.Where("Id").IsEqual(Column.Parameter(campaignId)) as Select;
			select.SpecifyNoLockHints();
			select.ExecuteReader(dr => {
				campaignInfo = new CampaignInfo {
					CampaignStatusId = dr.GetColumnValue<Guid>("CampaignStatusId"),
					InProgress = dr.GetColumnValue<bool>("InProgress"),
					CampaignId = campaignId
				};
			});
			if (campaignInfo == null) {
				string errorText = GetLczStringValue(CampaignHelperClassName, CampaignNotFoundException);
				throw new Exception(string.Format(errorText, campaignId));
			}
			return campaignInfo;
		}

		/// <summary>
		/// Gets the campaign schema.
		/// </summary>
		/// <param name="campaignId">The campaign identifier.</param>
		/// <returns>Instance of the campaign schema.</returns>
		/// <exception cref="Exception">Will be thrown in case of campaign schema absence.</exception>
		public virtual CoreCampaignSchema GetCampaignSchema(Guid campaignId) {
			var select = new Select(_userConnection)
				.Column("CampaignSchemaUId")
				.From("Campaign")
				.Where("Id")
				.IsEqual(Column.Parameter(campaignId)) as Select;
			var schemaUid = select.ExecuteScalar<Guid>();
			if (schemaUid.IsEmpty()) {
				string message = GetLczStringValue(CampaignHelperClassName, CampaignSchemaNotFoundException);
				throw new Exception(message);
			}
			var schemaManager =
				(CampaignSchemaManager)_userConnection.GetSchemaManager("CampaignSchemaManager");
			return schemaManager.FindInstanceByUId(schemaUid);
		}

		/// <summary>
		/// Returns localized string by string name. 
		/// </summary>
		/// <param name="className">Class name for localizable string</param>
		/// <param name="lczStringName">String name</param>
		/// <returns>Localizable string</returns>
		public string GetLczStringValue(string className, string lczStringName) {
			string localizableStringName = string.Format("LocalizableStrings.{0}.Value", lczStringName);
			var localizableString = new LocalizableString(
				_userConnection.Workspace.ResourceStorage, className, localizableStringName);
			string value = localizableString.Value;
			if (value == null) {
				value = localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			}
			return value;
		}

		#endregion

	}

	#endregion

}





