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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,77,107,227,48,16,134,207,41,244,63,12,238,37,134,98,223,243,5,187,89,246,227,208,18,104,160,135,210,131,98,143,83,237,218,146,25,73,45,166,244,191,119,36,203,217,52,27,151,245,65,216,163,153,247,157,121,36,43,209,160,105,69,129,176,69,34,97,116,101,179,181,86,149,220,59,18,86,106,117,121,241,122,121,49,113,70,170,61,220,117,198,98,51,63,124,31,151,16,102,223,69,97,53,73,52,156,193,57,87,132,123,22,128,117,45,140,153,193,15,39,203,109,215,226,61,238,158,180,254,243,83,168,178,70,10,153,121,158,195,194,184,166,17,212,173,226,119,76,131,152,7,149,38,216,179,4,88,214,24,106,242,147,162,133,65,20,181,209,80,16,86,203,100,100,164,236,215,218,25,171,155,127,187,73,32,247,82,15,223,176,18,174,182,95,165,42,121,206,169,183,212,213,116,180,44,189,134,91,230,8,75,72,206,79,153,164,143,44,219,186,93,45,11,40,60,143,17,28,48,131,81,23,86,120,13,184,14,100,55,164,91,36,203,196,103,176,9,226,253,254,41,207,16,224,228,103,89,178,133,226,86,179,67,218,49,194,161,67,99,201,31,239,80,209,207,182,26,142,228,78,59,42,144,137,26,43,148,53,217,23,213,205,63,241,13,221,123,57,79,241,115,95,63,115,191,176,91,132,238,57,165,81,255,10,85,217,143,254,145,195,13,218,39,93,254,15,132,67,51,47,241,122,181,130,120,58,203,88,158,69,237,198,250,11,145,144,26,232,45,19,169,90,103,147,85,4,21,74,65,87,103,84,253,181,29,76,179,69,30,54,254,74,18,90,71,202,172,22,249,240,118,68,67,239,126,99,97,227,15,48,141,86,193,56,5,255,79,78,38,178,130,192,39,219,82,183,17,100,112,26,182,175,65,59,27,46,24,16,26,190,199,233,80,48,233,109,98,120,30,98,111,97,141,27,202,213,117,8,191,157,37,222,71,63,6,67,236,248,121,7,184,247,207,3,83,4,0,0 };
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

