namespace Terrasoft.Configuration.Tagging
{
	using System;
	using System.Runtime.Serialization;
	using System.ServiceModel;
	using System.ServiceModel.Activation;
	using System.ServiceModel.Web;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Factories;
	using Terrasoft.Web.Common;

	#region Class: TaggingServiceRequest

	/// <summary>
	/// Class of request tagging service.
	/// </summary>
	[DataContract]
	public class TaggingServiceRequest
	{

		#region Properties: Public

		/// <summary>
		/// Serialized entity schema query of records.
		/// </summary>
		[DataMember(Name = "recordsEsqSerialized", IsRequired = true)]
		public string RecordsEsqSerialized { get; set; }

		/// <summary>
		/// Serialized entity schema query of tags.
		/// </summary>
		[DataMember(Name = "tagsEsqSerialized", IsRequired = true)]
		public string TagsEsqSerialized { get; set; }

		#endregion

	}

	#endregion

	#region Class: TaggingServiceResponse

	/// <summary>
	/// Class of response tagging service.
	/// </summary>
	[DataContract]
	public class TaggingServiceResponse : ConfigurationServiceResponse
	{

		#region Constroctors: Public

		public TaggingServiceResponse() { }

		public TaggingServiceResponse(Exception e)
			: base(e) { }

		public TaggingServiceResponse(int processedRecordsCount) { this.ProcessedRecordsCount = processedRecordsCount; }

		#endregion

		#region Properties: Public

		/// <summary>
		/// Count of processed records.
		/// </summary>
		[DataMember(Name = "processedRecordsCount")]
		public int ProcessedRecordsCount { get; set; }

		#endregion

	}

	#endregion

	#region Class: TaggingService

	/// <summary>
	/// Provides web-service for work with tags.
	/// </summary>
	[ServiceContract]
	[AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
	public class TaggingService : BaseService
	{

		#region Fields: Private

		private ITaggingManager _taggingManager;

		#endregion

		#region Properties: Private

		private ITaggingManager TaggingManager =>
			_taggingManager ??
			(_taggingManager =
				ClassFactory.Get<ITaggingManager>(new ConstructorArgument("userConnection", UserConnection)));

		#endregion

		#region Constroctors: Public

		public TaggingService() { }

		public TaggingService(UserConnection userConnection)
			: base(userConnection) { }

		#endregion

		#region Methods: Private

		private void CheckRequest(TaggingServiceRequest request) {
			request.CheckArgumentNull("request");
			request.RecordsEsqSerialized.CheckArgumentNull("RecordsEsqSerialized");
			request.TagsEsqSerialized.CheckArgumentNull("TagsEsqSerialized");
		}

		#endregion

		#region Methods: Public

		/// <summary>
		/// Adds tags to records.
		/// </summary>
		/// <param name="request">Tagging service request.</param>
		/// <returns>Tagging service response.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "AddTags", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public TaggingServiceResponse AddTags(TaggingServiceRequest request) {
			try {
				CheckRequest(request);
				var processedRecordsCount =
					TaggingManager.AddTags(request.RecordsEsqSerialized, request.TagsEsqSerialized);
				return new TaggingServiceResponse(processedRecordsCount);
			} catch (Exception e) {
				return new TaggingServiceResponse(e);
			}
		}

		/// <summary>
		/// Removes tags from records.
		/// </summary>
		/// <param name="request">Tagging service request.</param>
		/// <returns>Tagging service response.</returns>
		[OperationContract]
		[WebInvoke(Method = "POST", UriTemplate = "RemoveTags", BodyStyle = WebMessageBodyStyle.WrappedRequest,
			RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
		public TaggingServiceResponse RemoveTags(TaggingServiceRequest request) {
			try {
				CheckRequest(request);
				var processedRecordsCount =
					TaggingManager.RemoveTags(request.RecordsEsqSerialized, request.TagsEsqSerialized);
				return new TaggingServiceResponse(processedRecordsCount);
			} catch (Exception e) {
				return new TaggingServiceResponse(e);
			}
		}

		#endregion

	}

	#endregion

}




