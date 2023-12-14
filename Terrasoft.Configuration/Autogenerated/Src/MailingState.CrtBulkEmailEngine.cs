﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Entities;
	using Terrasoft.Core.Factories;

	#region Class: MailingState

	/// <summary>
	/// Abstract class of mailing state.
	/// </summary>
	public abstract class MailingState
	{

		#region Properties: Protected

		private ISendingEmailProgressRepository _sendingRepo;
		protected ISendingEmailProgressRepository SendingEmailProgressRepository {
			get =>
				_sendingRepo ?? ClassFactory.Get<SendingEmailProgressRepository>(
					new ConstructorArgument("userConnection", Context.UserConnection));
			set => _sendingRepo = value;
		}

		protected virtual IMailingStateValidationRule StateValidationRule => new StatusValidationRule();

		protected abstract string ErrorMessageStringCode { get; }

		protected abstract string EventLczStringCode { get; }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Gets or sets the context of sending.
		/// </summary>
		public MailingContext Context { get; set; }
		
		public BulkEmailEventLogger BulkEmailEventLogger { get; set; }

		public abstract Guid[] AvailableForExecutionStatuses { get; }

		#endregion

		#region Methods: Private

		private void CreateReminding(Entity entity, string lczStringName, string caption, params object[] parameters) {
			string description = parameters.Any() ? string.Format(GetLczStringValue(lczStringName), parameters)
				: GetLczStringValue(lczStringName);
			MailingUtilities.CreateReminding(Context.UserConnection, entity, description, caption);
		}

		#endregion

		#region Methods: Protected

		/// <summary>
		/// Creates the reminding.
		/// </summary>
		/// <param name="entity">The entity.</param>
		/// <param name="lczStringName">Name of the localizible string.</param>
		/// <param name="parameters">The parameters.</param>
		protected void CreateReminding(Entity entity, string lczStringName, params object[] parameters) {
			if (lczStringName != null) {
				CreateReminding(entity, lczStringName, GetLczStringValue("RemindingMsgCaption"), parameters);
			}
		}

		protected string GetLczStringValue(string lczName) {
			string localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(Context.UserConnection.Workspace.ResourceStorage,
				"CESMailingProvider", localizableStringName);
			string value = localizableString.Value ??
				localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
			return value;
		}
		
		/// <summary>
		/// Tries to format the given string template with the given arguments.
		/// </summary>
		/// <param name="lczName">The localizable string name.</param>
		/// <param name="formattedItems">The arguments for localizable string template.</param>
		/// <returns>Formatted localizable string value or string.Empty when formatting error occurs.</returns>
		protected string TryGetFormattedLczStringValue(string lczName, params object[] formattedItems) {
			string localizableStringName = $"LocalizableStrings.{lczName}.Value";
			var localizableString = new LocalizableString(Context.UserConnection.Workspace.ResourceStorage,
				"CESMailingProvider", localizableStringName);
			string msgTemplate;
			try {
				msgTemplate = localizableString.Value ??
					localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
				return string.Format(msgTemplate, formattedItems);
			} catch {
				try {
					msgTemplate = localizableString.GetCultureValue(GeneralResourceStorage.DefCulture, false);
					return string.Format(msgTemplate, formattedItems);
				} catch {
					return string.Empty;
				}
			}
		}

		/// <summary>
		/// Sets the bulk email status.
		/// </summary>
		/// <param name="bulkEmailId">The bulk email identifier.</param>
		/// <param name="bulkEmailStatusId">The bulk email status identifier.</param>
		protected virtual void SetBulkEmailStatus(Guid bulkEmailId, Guid bulkEmailStatusId) {
			if (bulkEmailStatusId != Guid.Empty) {
				var bulkEmail = new BulkEmail(Context.UserConnection);
				bulkEmail.FetchFromDB(bulkEmailId);
				bulkEmail.SetColumnValue("StatusId", bulkEmailStatusId);
				bulkEmail.Save();
			}
		}

		protected virtual bool CanHandle() {
			var validationResult = StateValidationRule.Validate(this);
			return validationResult.Success;
		}

		/// <summary>
		/// Handles the step with step-specific logic.
		/// </summary>
		/// <returns>Instance of <see cref="MailingStateExecutionResult"/>.</returns>
		protected abstract MailingStateExecutionResult HandleStepInternal();

		#endregion

		#region Methods: Public

		/// <summary>
		/// Handles the state.
		/// </summary>
		/// <returns>Instance of <see cref="MailingStateExecutionResult"/>.</returns>
		public virtual MailingStateExecutionResult Handle() {
			var bulkEmail = (BulkEmail)Context.BulkEmailEntity;
			try {
				if (CanHandle()) {
					return HandleStepInternal();
				}
			} catch (Exception e) {
				MailingUtilities.Log.ErrorFormat(
					$"[{GetType().Name}.Handle]: Error when execute mailing state for BulkEmail with Id: {0},",
					e, bulkEmail.Id);
				return new MailingStateExecutionResult(this.GetType()) {
					Success = false,
					Status = MailingStateExecutionStatus.Failed,
					Exception = e,
					EventLczStringCode = EventLczStringCode,
					NotificationLcsStringCodes = new [] { ErrorMessageStringCode }
				};
			}
			return new MailingStateExecutionResult(this.GetType()) {
				Success = true,
				Status = MailingStateExecutionStatus.Skipped
			};
		}

		/// <summary>
		/// Initializes the instance.
		/// </summary>
		public virtual void Initialize() {
			if (Context == null) {
				throw new ArgumentNullException(nameof(Context));
			}
			BulkEmailEventLogger = new BulkEmailEventLogger(Context.UserConnection);
		}

		#endregion

	}

	#endregion

	#region MailingStateHandleException

	/// <summary>
	/// Represents exception during mailing state execution.
	/// </summary>
	public class MailingStateHandleException : Exception
	{
		
		public MailingStateHandleException() { }

		public MailingStateHandleException(string message)
			: base(message) { }
		
	}

	#endregion

}






