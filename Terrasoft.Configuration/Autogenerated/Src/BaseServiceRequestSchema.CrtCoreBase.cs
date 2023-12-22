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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,85,77,111,218,64,16,61,7,137,255,48,74,47,205,197,190,135,180,18,113,162,40,74,83,89,192,173,202,97,177,7,186,138,189,235,236,7,42,141,248,239,157,221,5,7,140,65,197,173,132,47,120,103,230,205,190,55,111,215,8,86,162,174,88,134,48,65,165,152,150,51,19,37,82,204,248,220,42,102,184,20,81,114,63,126,150,57,22,186,223,123,239,247,250,189,11,171,185,152,195,120,169,13,150,131,198,58,26,89,97,120,137,209,24,21,103,5,255,237,123,12,60,238,147,194,57,45,32,41,152,214,215,112,203,52,82,213,130,103,56,194,55,139,218,248,170,56,142,225,70,219,178,100,106,249,117,189,246,8,144,51,152,18,6,84,168,6,35,129,184,69,27,76,188,5,250,113,199,12,35,25,70,177,204,188,80,160,178,211,130,103,144,249,70,109,59,95,4,109,53,201,84,201,10,149,225,72,76,83,15,14,249,38,61,31,120,64,67,244,20,104,247,107,126,34,12,211,71,120,197,101,84,35,226,38,228,102,193,10,139,245,114,210,10,250,168,241,130,158,177,156,162,250,252,157,44,131,47,112,73,181,151,87,78,220,70,157,54,202,57,49,172,248,19,46,225,29,230,104,6,142,211,0,86,174,202,203,67,145,7,133,94,206,42,24,179,27,108,248,148,82,207,243,248,180,191,51,180,31,155,191,49,47,232,111,181,207,13,63,103,6,29,115,218,216,0,1,80,144,2,63,127,13,196,205,214,103,249,128,167,109,6,5,220,183,208,236,81,204,228,174,93,195,102,122,51,136,253,76,211,204,142,86,30,220,241,160,163,35,172,20,106,20,116,174,179,13,59,154,82,80,86,207,137,83,171,14,254,30,161,243,79,215,209,249,41,172,179,194,113,181,26,115,71,152,47,208,107,160,87,77,140,253,61,93,11,56,205,83,106,148,132,62,137,164,175,221,174,169,92,120,251,26,53,109,254,157,225,40,174,113,148,199,93,214,46,50,161,207,246,218,146,173,186,147,152,127,12,189,98,60,255,15,211,118,109,142,207,58,109,84,116,154,52,254,170,120,248,183,235,192,49,183,120,100,160,119,33,219,241,2,251,216,246,243,7,83,215,245,241,175,7,0,0 };
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

