namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GuidTypeWebhookHandlerSchema

	/// <exclude/>
	public class GuidTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GuidTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GuidTypeWebhookHandlerSchema(GuidTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("78e0af57-7792-438f-8a76-624a4fc1bae5");
			Name = "GuidTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,107,227,48,16,134,207,41,244,63,12,238,37,134,98,223,243,5,187,89,246,227,208,18,104,160,135,210,131,98,143,83,237,218,146,25,73,45,166,244,191,87,26,203,217,52,27,151,245,65,216,163,153,247,157,121,36,43,209,160,105,69,129,176,69,34,97,116,101,179,181,86,149,220,59,18,86,106,117,121,241,122,121,49,113,70,170,61,220,117,198,98,51,63,124,31,151,16,102,223,69,97,53,73,52,62,195,231,92,17,238,189,0,172,107,97,204,12,126,56,89,110,187,22,239,113,247,164,245,159,159,66,149,53,18,103,230,121,14,11,227,154,70,80,183,138,223,49,13,98,30,84,154,96,239,37,192,122,141,161,38,63,41,90,24,68,81,27,13,5,97,181,76,70,70,202,126,173,157,177,186,249,183,155,4,242,32,245,240,13,43,225,106,251,85,170,210,207,57,13,150,186,154,142,150,165,215,112,235,57,194,18,146,243,83,38,233,163,151,109,221,174,150,5,20,129,199,8,14,152,193,168,139,87,120,101,92,7,178,27,210,45,146,245,196,103,176,97,241,126,255,148,39,7,124,242,179,44,189,133,242,173,102,135,180,99,132,67,135,198,82,56,222,161,162,159,109,53,28,201,157,118,84,160,39,106,172,80,214,100,95,84,55,255,196,151,187,15,114,129,226,231,190,97,230,126,241,110,17,122,224,148,70,253,43,84,101,63,250,71,14,55,104,159,116,249,63,16,14,205,188,196,235,213,10,242,211,89,143,229,89,212,110,172,63,142,112,42,211,91,38,82,181,206,38,171,8,138,75,65,87,103,84,195,181,29,76,179,69,206,27,127,37,9,173,35,101,86,139,124,120,59,162,161,119,191,177,176,241,7,152,70,43,54,78,33,252,147,147,137,172,128,249,100,91,234,54,130,12,78,121,251,26,180,179,124,193,128,208,248,123,156,14,5,147,222,38,134,231,28,123,227,53,110,40,87,215,28,126,59,75,188,143,126,12,114,44,60,239,54,136,130,207,75,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("78e0af57-7792-438f-8a76-624a4fc1bae5"));
		}

		#endregion

	}

	#endregion

}

