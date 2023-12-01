namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWebhookParserSchema

	/// <exclude/>
	public class IWebhookParserSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWebhookParserSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWebhookParserSchema(IWebhookParserSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("df265d20-80da-4a1e-8545-4bd85da8db16");
			Name = "IWebhookParser";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,203,110,194,64,12,69,215,32,241,15,22,221,180,82,69,246,133,102,209,135,16,168,15,36,144,186,158,36,78,24,154,140,83,143,71,40,66,253,247,78,30,148,180,101,209,40,155,248,222,235,57,246,196,168,2,109,169,98,132,13,50,43,75,169,76,238,201,164,58,115,172,68,147,25,13,15,163,225,192,89,109,50,88,87,86,176,240,122,158,99,92,139,118,50,71,131,172,227,233,183,231,5,247,226,133,186,207,210,146,153,60,105,243,225,85,175,7,65,0,51,235,138,66,113,21,118,223,111,24,109,137,222,33,162,164,130,82,177,69,62,58,131,158,181,116,81,174,99,208,70,144,211,26,118,209,5,87,199,200,161,57,98,112,193,152,121,46,88,49,149,200,162,209,222,192,170,9,183,250,111,134,166,176,118,101,73,44,152,128,84,37,90,72,137,79,44,127,97,6,139,71,227,10,100,21,229,56,179,194,126,234,240,212,99,211,180,56,64,134,50,133,207,142,10,77,210,130,253,164,124,70,217,82,242,31,196,102,78,216,247,182,117,30,173,169,120,118,85,128,241,55,123,59,238,34,119,62,49,14,251,249,89,208,216,78,41,70,113,108,108,88,223,218,3,197,126,66,35,179,224,88,173,109,17,81,14,27,174,230,40,175,209,206,255,1,151,237,244,208,59,228,26,200,9,44,91,29,118,189,94,87,211,179,203,240,43,242,175,127,190,0,56,216,1,106,138,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("df265d20-80da-4a1e-8545-4bd85da8db16"));
		}

		#endregion

	}

	#endregion

}

