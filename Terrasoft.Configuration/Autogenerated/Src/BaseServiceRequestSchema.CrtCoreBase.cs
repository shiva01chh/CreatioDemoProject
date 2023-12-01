namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseServiceRequestSchema

	/// <exclude/>
	public class BaseServiceRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseServiceRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseServiceRequestSchema(BaseServiceRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("56f508aa-2354-4a52-b001-b51958e64e5c");
			Name = "BaseServiceRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,77,111,218,64,16,61,7,137,255,48,34,151,230,98,223,67,90,137,56,85,20,165,84,22,112,171,114,88,236,129,174,106,239,58,251,129,66,35,254,123,103,119,193,9,142,65,137,83,9,95,240,206,204,155,125,111,222,174,17,172,68,93,177,12,97,134,74,49,45,23,38,74,164,88,240,165,85,204,112,41,162,228,251,116,44,115,44,116,191,247,220,239,245,123,103,86,115,177,132,233,90,27,44,135,141,117,52,177,194,240,18,163,41,42,206,10,254,215,247,24,122,220,185,194,37,45,32,41,152,214,151,112,205,52,82,213,138,103,56,193,71,139,218,248,170,56,142,225,74,219,178,100,106,253,109,187,246,8,144,11,152,19,6,84,168,6,35,129,184,69,59,76,252,10,244,235,134,25,70,50,140,98,153,121,160,64,101,231,5,207,32,243,141,218,118,62,11,218,106,146,169,146,21,42,195,145,152,166,30,28,242,77,122,62,112,139,134,232,41,208,238,215,252,70,24,165,119,240,7,215,81,141,136,155,144,171,21,43,44,214,203,89,43,232,165,198,11,26,99,57,71,245,229,39,89,6,95,97,64,181,131,11,39,110,167,78,27,229,156,24,85,252,30,215,240,12,75,52,67,199,105,8,27,87,229,229,161,200,131,66,47,103,19,140,217,15,54,124,74,169,231,105,124,122,187,51,180,31,155,247,152,23,244,183,218,231,134,159,51,131,142,57,109,108,128,0,40,72,129,159,191,6,226,102,235,179,124,192,211,54,131,2,238,71,104,118,39,22,114,223,174,81,51,189,27,196,219,76,211,204,142,86,30,220,241,160,163,19,172,20,106,20,116,174,179,29,59,154,82,80,86,207,137,83,171,14,254,30,161,243,169,235,232,252,20,214,89,225,184,90,141,185,35,204,87,232,53,208,171,38,198,254,158,110,5,124,204,83,106,148,132,62,137,164,175,221,190,169,92,120,251,26,53,109,254,157,224,40,110,113,148,199,125,214,46,50,163,207,246,214,146,87,117,31,98,254,50,244,138,241,252,63,76,219,181,57,62,235,180,81,209,105,210,248,84,241,240,111,215,129,99,110,241,200,64,111,66,182,227,5,246,49,122,254,1,121,6,60,38,166,7,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("56f508aa-2354-4a52-b001-b51958e64e5c"));
		}

		#endregion

	}

	#endregion

}

