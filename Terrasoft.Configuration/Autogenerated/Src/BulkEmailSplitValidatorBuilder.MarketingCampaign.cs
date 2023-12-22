namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;

	#region Class: BulkEmailSplitValidatorBuilder

	/// <summary>
	/// Rule builder for bulk email split validation.
	/// </summary>
	public class BulkEmailSplitValidatorBuilder : ISpecificValidatorBuilder<Guid>
	{

		#region Fields: Private

		private readonly MailingService _mailingService;
		private readonly DCTemplateRepository<DCTemplateModel> _templateRepository;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public BulkEmailSplitValidatorBuilder(UserConnection userConnection) {
			_userConnection = userConnection;
			_mailingService = GetMailingService();
			_templateRepository = new DCTemplateRepository<DCTemplateModel>(_userConnection);
		}

		#endregion

		#region Methods: Private

		private MailingService GetMailingService() {
			return ClassFactory.Get<MailingService>(new ConstructorArgument("userConnection", _userConnection));
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Create validation rule list.
		/// </summary>
		/// <returns>Validation rules</returns>
		public IEnumerable<IValidationRule> InitRules() {
			var result = new List<IValidationRule> {
				new ActiveContactsCountValidationRule(_userConnection),
				new PingMailingProviderValidationRule(_userConnection, _mailingService)
			};
			return result;
		}

		/// <summary>
		/// Create specific validation rule list.
		/// </summary>
		/// <returns>Specific validation rules</returns>
		public IEnumerable<ISpecificValidationRule<Guid>> InitSpecificRules() {
			var result = new List<ISpecificValidationRule<Guid>> {
				new BulkEmailSplitUserPermissionsValidationRule(_userConnection),
				new MessagesValidationRule(_mailingService, _userConnection),
				new BulkEmailStatusesValidationRule(_userConnection),
				new TemplatesValidationRule(_templateRepository, _userConnection)
			};
			return result;
		}

		#endregion

	}

	#endregion

}














