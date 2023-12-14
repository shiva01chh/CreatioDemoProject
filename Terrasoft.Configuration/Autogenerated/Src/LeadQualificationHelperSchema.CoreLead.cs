namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadQualificationHelperSchema

	/// <exclude/>
	public class LeadQualificationHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadQualificationHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadQualificationHelperSchema(LeadQualificationHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b0f5b581-b090-487e-b10f-878e77de698a");
			Name = "LeadQualificationHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("574c9bf8-30b5-4eb9-aa34-ee8fc5cac038");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,84,203,106,195,48,16,60,167,208,127,16,206,165,129,54,190,231,97,8,133,182,134,20,250,202,7,168,246,58,17,200,178,89,201,129,80,250,239,149,229,71,45,37,110,147,244,80,159,172,149,118,118,118,70,43,65,83,144,57,141,128,188,1,34,149,89,162,198,183,153,72,216,186,64,170,88,38,200,199,229,197,160,144,76,172,201,235,78,42,72,167,237,186,155,129,160,227,122,103,136,176,46,179,66,161,0,19,141,59,33,225,18,104,252,92,80,206,18,22,25,204,7,224,57,160,57,239,251,62,153,201,34,77,41,238,130,122,61,108,62,178,49,7,111,134,101,168,13,127,239,183,139,113,131,228,119,160,242,226,157,179,136,176,134,73,47,145,178,69,125,126,143,139,69,134,236,21,181,120,84,171,113,11,227,187,56,179,156,34,77,137,208,122,207,61,174,137,132,177,23,184,144,54,216,204,55,57,6,98,155,177,152,44,162,146,244,34,209,13,133,49,8,213,246,113,117,95,232,237,10,117,84,26,244,89,153,1,34,174,252,176,188,137,56,149,114,66,206,178,165,182,228,47,134,152,242,125,213,251,175,75,227,82,211,197,29,227,16,235,54,158,48,83,16,41,136,143,48,209,145,217,141,244,216,151,55,21,8,106,106,153,224,59,178,146,128,122,76,4,24,71,156,229,244,7,38,171,151,37,57,167,160,84,88,142,220,34,207,121,173,202,10,121,93,200,177,185,85,72,51,210,105,69,164,50,44,117,50,234,31,35,210,193,59,94,255,233,52,0,18,33,36,115,175,199,40,207,15,142,157,131,194,210,173,51,15,191,248,212,157,140,61,80,106,105,228,5,142,228,221,220,250,70,246,52,114,229,184,108,179,189,110,60,177,235,141,204,131,57,24,56,185,115,39,123,106,14,217,118,234,67,212,245,119,80,143,114,175,201,143,160,54,89,124,138,191,255,252,146,213,154,111,25,42,45,57,57,225,97,171,148,61,172,199,161,7,207,196,202,239,11,159,164,118,57,229,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b0f5b581-b090-487e-b10f-878e77de698a"));
		}

		#endregion

	}

	#endregion

}

