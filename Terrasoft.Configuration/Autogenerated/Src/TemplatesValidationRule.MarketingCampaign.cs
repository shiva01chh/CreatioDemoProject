namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using Terrasoft.Common;
	using Terrasoft.Configuration.DynamicContent;
	using Terrasoft.Configuration.DynamicContent.Models;
	using Terrasoft.Core;
	using Terrasoft.Core.DB;

	#region Class: TemplatesValidationRule

	/// <summary>
	/// Validation rule for templates.
	/// </summary>
	public class TemplatesValidationRule : ISpecificValidationRule<Guid>
	{

		#region Fields: Private

		private string ErrorLczStringValue => "EmptyTemplateExistMessage";
		private readonly DCTemplateRepository<DCTemplateModel> _templateRepository;
		private readonly UserConnection _userConnection;

		#endregion

		#region Constructors: Public

		public TemplatesValidationRule(DCTemplateRepository<DCTemplateModel> templateRepository,
			UserConnection userConnection) {
			_templateRepository = templateRepository;
			_userConnection = userConnection;
		}

		#endregion

		#region Properties: Public

		public string Error { get; private set; }

		#endregion

		#region Methods: Private

		private bool CheckEmptyTemplates(IEnumerable<Guid> bulkEmailIds) {
			var repositoryReadOptions = new DCRepositoryReadOptions<DCTemplateModel, DCReplicaModel> {
				TemplateReadOptions =
					DCTemplateReadOption.ExcludeAttributes | DCTemplateReadOption.ExcludeReplicaHtmlContent
			};
			foreach (Guid bulkEmailId in bulkEmailIds) {
				DCTemplateModel existingTemplate =
					_templateRepository.ReadByRecordId(bulkEmailId, repositoryReadOptions);
				if (existingTemplate == null || existingTemplate.Id.IsEmpty()) {
					return true;
				}
			}
			return false;
		}

		private IEnumerable<Guid> GetBulkEmailIdsWithEmptyHtml(Guid splitTestId) {
			var emailIdsWithEmptyHtml = new List<Guid>();
			var selectCount = new Select(_userConnection).Column("Id").From("BulkEmail").Where("SplitTestId")
				.IsEqual(Column.Parameter(splitTestId)).And(Func.Len("TemplateBody"))
				.IsEqual(Column.Parameter(0)) as Select;
			selectCount.SpecifyNoLockHints();
			selectCount.ExecuteReader(reader => {
				emailIdsWithEmptyHtml.Add(reader.GetColumnValue<Guid>("Id"));
			});
			return emailIdsWithEmptyHtml;
		}

		private bool IsEmptyTemplateExist(Guid splitTestId) {
			bool isDCFeatureEnabled = _userConnection.GetIsFeatureEnabled("BulkEmailDynamicContentBuilder");
			IEnumerable<Guid> emptyHtmlBulkEmailIds = GetBulkEmailIdsWithEmptyHtml(splitTestId);
			if (emptyHtmlBulkEmailIds.Any() && isDCFeatureEnabled) {
				return CheckEmptyTemplates(emptyHtmlBulkEmailIds);
			}
			return emptyHtmlBulkEmailIds.Any();
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Validate templates
		/// </summary>
		/// <param name="splitTestId">Unique identifier of split test to validate</param>
		public bool Validate(Guid splitTestId) {
			if (IsEmptyTemplateExist(splitTestId)) {
				Error = ErrorLczStringValue.GetLczStringValue(_userConnection);
				return false;
			}
			return true;
		}

		#endregion

	}

	#endregion

}




