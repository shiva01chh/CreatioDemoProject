﻿namespace Terrasoft.Configuration.ServiceDesigner
{
	using System.Collections.Generic;
	using System.Runtime.Serialization;
	using Terrasoft.Core.ServiceModelContract;

	#region Class: GetXmlSchemaFilesContentResponse

	[DataContract]
	public class GetXmlSchemaFilesContentResponse : BaseResponse
	{

		#region Properties: Public

		[DataMember(Name = "files")]
		public Dictionary<string, int[]> Files {
			get;
			set;
		}

		#endregion

	}

	#endregion

}






