namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Runtime.Serialization;
	using Terrasoft.Nui.ServiceModel.DataContract;

	#region  Class: PortalMessageFileDTO

	[DataContract]
	public class PortalMessageFileDTO
	{
		#region Properties: Public

		[DataMember(Name = "Id")]
		public Guid Id { get; set; }

		[DataMember(Name = "CreatedBy")]
		public Guid CreatedBy { get; set; }

		[DataMember(Name = "CreatedOn")]
		public string CreatedOn { get; set; }

		[DataMember(Name = "Name")]
		public string Name { get; set; }

		[DataMember(Name = "Size")]
		public int Size { get; set; }

		[DataMember(Name = "Notes")]
		public string Notes { get; set; }

		[DataMember(Name = "Type")]
		public LookupColumn Type { get; set; }

		[DataMember(Name = "Version")]
		public int Version { get; set; }

		#endregion
	}

	#endregion

	#region  Class: LookupColumn

	/// <summary>
	/// Class that represent lookup column.
	/// </summary>
	[DataContract]
	public class LookupColumn
	{
		[DataMember(Name = "displayValue")]
		public string DisplayValue { get; set; }
		[DataMember(Name = "primaryImageValue")]
		public string PrimaryImageValue { get; set; }
		[DataMember(Name = "value")]
		public Guid Value { get; set; }
	}

	#endregion

	#region Interface: IPortalMessageFileReader

	/// <summary>
	/// Interface for getting portal message file data.
	/// </summary>
	public interface IPortalMessageFileReader {

		/// <summary>
		/// Loads list of portal message files by portal message.
		/// </summary>
		/// <param name="portalMessageId">Identifier of portal message.</param>
		/// <param name="readingOptions">Esq reading options.</param>
		/// <returns></returns>
		IEnumerable<PortalMessageFileDTO> GetPortalMessageFiles(string portalMessageId, ReadingOptions readingOptions);

		/// <summary>
		/// Loads accessible file.
		/// </summary>
		/// <param name="historySchemaName">Name of schema for history data.</param>
		/// <param name="messageHistoryId">Identifier of record on history schema.</param>
		/// <param name="fileId">File identifier to be loaded.</param>
		/// <returns>Stream of file data.</returns>
		Stream GetPortalMessageFile(string historySchemaName, string historySchemaId, string fileId);
	}

	#endregion

}




