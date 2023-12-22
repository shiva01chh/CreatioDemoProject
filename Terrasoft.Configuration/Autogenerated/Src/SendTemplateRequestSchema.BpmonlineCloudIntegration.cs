namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendTemplateRequestSchema

	/// <exclude/>
	public class SendTemplateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendTemplateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendTemplateRequestSchema(SendTemplateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1b1f76d4-1295-4ca5-bbc0-4faf38c61644");
			Name = "SendTemplateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,148,193,78,227,64,12,134,207,32,241,14,86,184,192,37,185,83,64,130,130,16,135,34,68,123,91,173,42,55,113,194,72,73,38,140,29,86,221,138,119,199,51,105,160,45,85,161,244,146,218,51,254,103,190,223,113,106,172,136,27,76,9,38,228,28,178,205,37,30,218,58,55,69,235,80,140,173,227,225,237,120,100,51,42,249,232,112,113,116,120,208,178,169,11,24,207,89,168,26,108,196,241,83,91,139,169,40,30,147,51,88,154,255,65,65,119,233,190,99,71,133,6,48,44,145,249,12,198,84,103,19,170,154,18,133,158,232,165,37,150,176,45,73,18,56,231,182,170,208,205,47,151,113,40,129,220,58,112,221,78,16,11,172,2,48,67,73,159,193,230,186,144,154,198,80,45,12,179,57,200,82,56,238,5,147,13,197,115,38,194,146,45,164,142,242,139,232,91,244,248,26,153,20,234,213,164,253,109,35,72,188,218,159,27,20,212,42,113,152,202,95,77,52,237,172,52,41,164,225,206,91,40,225,12,190,138,105,221,34,224,127,216,244,232,108,67,78,12,169,87,143,65,178,91,223,244,39,36,238,72,185,213,30,246,79,121,38,160,10,77,9,218,89,198,34,184,240,213,134,46,243,138,101,75,31,225,68,75,189,53,75,91,110,189,202,168,19,137,146,203,21,157,207,178,192,63,162,106,70,238,228,65,223,37,184,128,104,121,110,116,234,253,232,13,89,21,131,254,185,128,130,100,224,239,61,128,183,125,0,107,127,148,246,221,255,95,237,246,207,57,191,81,216,77,216,23,76,189,202,58,39,139,243,3,209,119,61,84,252,26,179,235,163,201,244,197,54,185,33,183,31,226,142,234,221,120,161,112,106,178,117,178,187,214,100,93,27,239,179,223,35,249,239,131,247,221,207,175,26,181,31,81,166,142,2,234,224,7,149,190,11,240,15,217,235,9,160,252,152,209,159,63,69,217,218,60,63,182,87,178,141,241,88,87,186,9,13,113,151,93,79,134,220,234,239,29,238,67,136,172,99,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1b1f76d4-1295-4ca5-bbc0-4faf38c61644"));
		}

		#endregion

	}

	#endregion

}

