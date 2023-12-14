namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text.RegularExpressions;
	using Terrasoft.Configuration.Utils;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;
	using Terrasoft.Common;
	using Terrasoft.Core.Factories;
	using CoreSysSettings = Terrasoft.Core.Configuration.SysSettings;
	using HttpUtility = System.Web.HttpUtility;

    #region Class: BaseBulkEmailMacroComposer

    /// <summary>
    /// Provides methods to build macros and its values for mailing recipients.
    /// </summary>
    public abstract class BaseBulkEmailMacroComposer
	{

		#region Constants: Private

		private const string _globalMacrosSchemaBulkEmail = "BulkEmail";

		private const string _unsubscribeMacrosName = "UNSUB_URL";
		private const string _useDefaultUnsubscriptionMacrosName = "USE_DEFAULT_UNSUB";

        #endregion

        #region Fields: Private

		private readonly Guid _currentUserMacrosId = new Guid("3C5A2014-F46B-1410-2288-1C6F65E24DB2");
        private MacrosHelperV2 _macrosHelper;
		private BulkEmailRecipientMacroRepository _recipientMacroRepository;

		private Dictionary<string, string> _trackedAliases;

		#endregion

		#region Fields: Protected

		protected readonly Guid BulkEmailId;
		protected readonly Guid GlobalMacrosContactId;
		protected readonly UserConnection UserConnection;

		#endregion

		protected const string _joinColumnName = "Id";
		protected const string _personalMacrosSchema = "Contact";

		private static readonly Regex UrlEncodedMacrosAliasRegex = new Regex("^Url.*$");

		#region Constructors: Public

		/// <summary>
		/// Creates instance of BaseBulkEmailMacroComposer class, to prepare global and personal macroses.
		/// </summary>
		/// <param name="userConnection">Instance of user connection.</param>
		/// <param name="contactId">Unique identifier of the contact that will be used for 
		/// initializing collection of global macroses.</param>
		/// <param name="bulkEmailId">Unique identifier of the bulk email that will be used for 
		/// initializing collection of global macros.</param>
		public BaseBulkEmailMacroComposer(UserConnection userConnection, Guid contactId, Guid bulkEmailId) {
			UserConnection = userConnection;
			GlobalMacrosContactId = contactId;
			BulkEmailId = bulkEmailId;
		}

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets the macros helper.
		/// </summary>
		public virtual MacrosHelperV2 MacrosHelper {
			get => _macrosHelper ?? (_macrosHelper = ClassFactory.Get<MacrosHelperV2>());
			set => _macrosHelper = value;
		}

		/// <summary>
		/// Gets or sets the audience data source.
		/// </summary>
		[Obsolete]
		public IMailingAudienceDataSource AudienceDataSource { get; set; }

		/// <summary>
		/// Gets or sets the recipient macro repository.
		/// </summary>
		public BulkEmailRecipientMacroRepository RecipientMacroRepository {
			get =>
				_recipientMacroRepository ??
				(_recipientMacroRepository = new BulkEmailRecipientMacroRepository(UserConnection));
			set => _recipientMacroRepository = value;
		}

		/// <summary>
		/// Gets or sets aliases of tracked macros.
		/// </summary>
		public Dictionary<string, string> TrackedAliases {
			get => _trackedAliases ?? (_trackedAliases = new Dictionary<string, string>());
			set => _trackedAliases = value;
		}

		#endregion

		#region Methods: Private

		private Dictionary<Guid, object> CreateMacrosWorkerParameters(Select select) {
			var result = new Dictionary<Guid, object>();
			var argValue = new Dictionary<string, object> {
				{ "SubSelect", select },
				{ "JoinColumnName", _joinColumnName },
				{ "SchemaName", _personalMacrosSchema }
			};
			result.Add(Guid.Empty, argValue);
			result.Add(MailingConsts.EmailTemplateMacrosParentContactId, argValue);
			return result;
		}

		private string EncodeUrlLikeMacro(string macrosName, string macrosContent) {
			if (UrlEncodedMacrosAliasRegex.IsMatch(macrosName)) {
				macrosContent = HttpUtility.UrlPathEncode(macrosContent);
			}
			return macrosContent;
		}

		private IEnumerable<KeyValuePair<string, string>> GetBulkEmailMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection) {
			var workersParameters = new Dictionary<Guid, object> {
				{ Guid.Empty, new KeyValuePair<string, Guid>(_globalMacrosSchemaBulkEmail, BulkEmailId) }
			};
			return GetGlobalMacrosValues(macrosCollection, workersParameters);
		}

		private Dictionary<Guid, object> GetCurrentUserMacrosArgument(List<MacrosInfo> macrosInfos) {
			var arguments = new Dictionary<Guid, object>();
			if (MacrosHelper.IsCurrentUserMacrosExists(macrosInfos)) {
				arguments.Add(_currentUserMacrosId,
					new KeyValuePair<string, Guid>("Contact", UserConnection.CurrentUser.ContactId));
			}
			return arguments;
		}

		private IEnumerable<KeyValuePair<string, string>> GetCurrentUserMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection) {
			var workersParameters = GetCurrentUserMacrosArgument((List<MacrosInfo>)macrosCollection);
			IEnumerable<MacrosInfo> macros = macrosCollection
				.Where(m => !m.IsGlobal && workersParameters.ContainsKey(m.ParentId)).ToArray();
			var result = new Dictionary<string, string>();
			if (!macros.Any()) {
				return result;
			}
			result = MacrosHelper.GetMacrosValues(macros, workersParameters);
			return result;
		}

		private Dictionary<string, string> GetGlobalMacrosValues(IEnumerable<MacrosInfo> macrosCollection,
			Dictionary<Guid, object> arguments) {
			var result = new Dictionary<string, string>();
			IEnumerable<MacrosInfo> macros =
				macrosCollection.Where(m => m.IsGlobal && arguments.ContainsKey(m.ParentId));
			if (!macros.Any()) {
				return result;
			}
			result = MacrosHelper.GetMacrosValues(macros, arguments);
			return result;
		}

		private Dictionary<object, Dictionary<string, string>> GetPersonalMacrosValues(Select select,
			IEnumerable<MacrosInfo> macrosCollection) {
			IEnumerable<MacrosInfo> personalMacros = macrosCollection.Where(m => !m.IsGlobal);
			Dictionary<Guid, object> arguments = CreateMacrosWorkerParameters(select);
			return MacrosHelper.GetMacrosValuesCollection(personalMacros, arguments);
		}

		private Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>> GetRecipientMacrosSet(
			Dictionary<Guid, Guid> recipientsIds, Dictionary<object, Dictionary<string, string>> personalMacrosValues,
			Dictionary<string, string> globalMacrosValues, IEnumerable<MacrosInfo> macrosCollection) {
			var personalMergeVars = new Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>>();
			foreach (KeyValuePair<Guid, Guid> recipient in recipientsIds) {
				IEnumerable<BulkEmailMacroInfo> allMacrosValues = Enumerable.Empty<BulkEmailMacroInfo>();
				if (personalMacrosValues.ContainsKey(recipient.Value)) {
					Dictionary<string, string> recipientMacrosValues = personalMacrosValues[recipient.Value];
					recipientMacrosValues[BulkEmailHyperlinkHelper.ContactIdMacrosName] = recipient.Value.ToString();
					recipientMacrosValues[BulkEmailHyperlinkHelper.BulkEmailRecipientIdName] = recipient.Key.ToString();
					SetTrackedRecipientMacrosValues(recipientMacrosValues);
					SetTrackedRecipientMacrosValues(globalMacrosValues);
					allMacrosValues = recipientMacrosValues.Concat(globalMacrosValues)
						.Select(kvp => PrepareMacroValue(kvp.Key, kvp.Value, macrosCollection));
				}
				personalMergeVars.Add(recipient.Key, allMacrosValues);
			}
			return personalMergeVars;
		}

		private IEnumerable<KeyValuePair<string, string>> GetSenderMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection) {
			return GetGlobalMacrosValues(macrosCollection, new Dictionary<Guid, object> {
				{ MailingConsts.EmailTemplateMacrosParentGlobalId, GlobalMacrosContactId }
			});
		}

		private KeyValuePair<string, string> GetUnsubscribeMacrosValue() {
			var unsubscribeLink = (string)CoreSysSettings.GetValue(UserConnection, "RedirectUnsuscribersTo");
			return new KeyValuePair<string, string>(_unsubscribeMacrosName, unsubscribeLink);
		}

		private IEnumerable<KeyValuePair<string, string>> GetUnsubscribeMacrosValues() {
			var unsubDictionary = new Dictionary<string, string>();
			KeyValuePair<string, string> unsubMacrosValue = GetUnsubscribeMacrosValue();
			KeyValuePair<string, string> unsubFromAllMailingsMacrosValue = GetUseDefaultUnsubscriptionMacrosValue();
			unsubDictionary.Add(unsubMacrosValue.Key, unsubMacrosValue.Value);
			unsubDictionary.Add(unsubFromAllMailingsMacrosValue.Key, unsubFromAllMailingsMacrosValue.Value);
			return unsubDictionary;
		}

		private KeyValuePair<string, string> GetUseDefaultUnsubscriptionMacrosValue() {
			var unsubFromAllMailings =
				CoreSysSettings.GetValue(UserConnection, "UnsubscribeFromAllMailings").ToString();
			return new KeyValuePair<string, string>(_useDefaultUnsubscriptionMacrosName, unsubFromAllMailings);
		}

		#endregion

		#region Methods: Protected

		protected bool CanPrepareMacros(IEnumerable<MacrosInfo> macrosCollection) {
			return macrosCollection.Any();
		}

		protected virtual Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>> GetMacrosValues(
			IEnumerable<MacrosInfo> macrosCollection, Select recipientsIdsSelect, Dictionary<Guid, Guid> recipientsIds,
			Dictionary<string, string> globalMacrosValues) {
			Dictionary<object, Dictionary<string, string>> personalMacrosResult =
				GetPersonalMacrosValues(recipientsIdsSelect, macrosCollection);
			Dictionary<Guid, IEnumerable<BulkEmailMacroInfo>> recipientMacrosSet =
				GetRecipientMacrosSet(recipientsIds, personalMacrosResult, globalMacrosValues, macrosCollection);
			return recipientMacrosSet;
		}

		protected BulkEmailMacroInfo PrepareMacroValue(string macroAlias, string value,
			IEnumerable<MacrosInfo> macrosCollection) {
			MacrosInfo macro = macrosCollection.FirstOrDefault(x => x.Alias == macroAlias);
			return new BulkEmailMacroInfo {
				Alias = macro?.Alias ?? macroAlias,
				Value = EncodeUrlLikeMacro(macroAlias, value),
				MacroText = macro?.MacrosText ?? macroAlias
			};
		}

		protected void SetTrackedRecipientMacrosValues(Dictionary<string, string> macroValues) {
			foreach (KeyValuePair<string, string> trackedItem in TrackedAliases) {
				if (macroValues.TryGetValue(trackedItem.Value, out string macroValue)) {
					macroValues[trackedItem.Key] = macroValue;
				}
			}
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Returns common macros.
		/// </summary>
		/// <param name="macrosCollection">Collection of macros.</param>
		/// <returns>The common macros collection.</returns>
		public Dictionary<string, string> GetCommonMacrosValues(IEnumerable<MacrosInfo> macrosCollection) {
			var globalMacrosValues = new Dictionary<string, string>();
			IEnumerable<KeyValuePair<string, string>> currentUserMacrosValues = GetCurrentUserMacrosValues(macrosCollection);
			globalMacrosValues.AddRange(currentUserMacrosValues);
			IEnumerable<KeyValuePair<string, string>> senderMacrosValues = GetSenderMacrosValues(macrosCollection);
			globalMacrosValues.AddRange(senderMacrosValues);
			IEnumerable<KeyValuePair<string, string>>
				bulkEmailMacrosValues = GetBulkEmailMacrosValues(macrosCollection);
			globalMacrosValues.AddRange(bulkEmailMacrosValues);
			IEnumerable<KeyValuePair<string, string>> unsubscribeMacrosValues = GetUnsubscribeMacrosValues();
			globalMacrosValues.AddRange(unsubscribeMacrosValues);
			return globalMacrosValues;
		}

		/// <summary>
		/// Returns personal macros of the contacts.
		/// </summary>
		/// <param name="contactId"></param>
		/// <param name="macrosCollection">Collection of macros.</param>
		/// <returns>The recipients macros collection.</returns>
		public virtual Dictionary<string, string> GetContactMacrosValues(Guid contactId,
			IEnumerable<MacrosInfo> macrosCollection) {
			IEnumerable<MacrosInfo> personalMacros = macrosCollection.Where(m => !m.IsGlobal);
			var arguments = new Dictionary<Guid, object>();
			arguments.Add(Guid.Empty, new KeyValuePair<string, Guid>(_personalMacrosSchema, contactId));
			arguments.Add(MailingConsts.EmailTemplateMacrosParentContactId, contactId);
			return MacrosHelper.GetMacrosValues(personalMacros, arguments);
		}

		#endregion

	}

	#endregion

}






