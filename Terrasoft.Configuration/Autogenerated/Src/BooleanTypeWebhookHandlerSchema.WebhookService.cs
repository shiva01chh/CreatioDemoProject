namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BooleanTypeWebhookHandlerSchema

	/// <exclude/>
	public class BooleanTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BooleanTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BooleanTypeWebhookHandlerSchema(BooleanTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f16699b7-b1d3-41a0-8e54-4983dfa47e58");
			Name = "BooleanTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7950703-7230-445f-b3e5-fcd99a7a2e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,77,107,220,48,16,61,111,32,255,97,112,46,107,8,246,125,63,12,201,150,144,30,90,22,178,208,67,233,65,107,143,55,78,101,201,140,164,20,19,242,223,59,146,229,205,230,195,33,62,24,123,230,205,123,51,111,36,37,90,52,157,40,17,118,72,36,140,174,109,182,209,170,110,14,142,132,109,180,58,63,123,58,63,155,57,211,168,3,220,245,198,98,187,60,254,159,150,16,102,55,162,180,154,26,52,140,96,204,5,225,129,9,96,35,133,49,11,184,214,90,162,80,187,190,195,95,184,191,215,250,239,173,80,149,68,10,224,60,207,97,101,92,219,10,234,139,248,31,97,16,113,80,107,98,12,34,148,132,245,58,217,51,97,146,23,96,153,113,100,200,223,80,120,184,144,70,199,146,137,25,179,239,27,103,172,110,223,247,150,64,238,169,126,127,195,90,56,105,175,27,85,241,224,115,47,169,235,249,100,89,122,9,63,217,88,88,67,50,57,118,146,254,97,230,206,237,101,83,66,233,61,154,182,8,22,48,169,197,36,79,193,194,163,225,91,210,29,146,229,69,44,96,27,248,135,252,91,143,67,128,193,143,77,197,18,138,27,206,142,176,83,35,199,38,141,37,191,245,177,98,152,176,24,215,116,167,29,149,200,190,26,43,148,53,217,149,234,151,159,232,134,238,61,157,247,242,115,93,63,243,240,90,15,219,102,235,253,242,211,200,127,129,170,26,70,127,237,195,15,180,247,186,250,138,9,199,102,254,197,35,215,9,226,233,44,219,242,40,164,155,234,47,68,2,52,184,183,78,26,213,57,155,20,209,168,80,10,186,254,128,213,31,229,81,52,91,229,33,241,66,73,104,29,41,83,172,242,241,235,196,13,189,127,192,210,198,75,49,143,82,65,56,5,127,85,103,179,166,134,224,79,182,163,126,43,200,224,60,164,47,65,59,11,62,1,132,134,79,115,58,22,204,6,153,24,94,134,216,115,120,199,132,114,82,134,240,243,135,142,15,209,215,193,16,243,207,127,105,194,26,176,98,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f16699b7-b1d3-41a0-8e54-4983dfa47e58"));
		}

		#endregion

	}

	#endregion

}

