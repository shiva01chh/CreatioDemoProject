namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoSubmittedHandlerSchema

	/// <exclude/>
	public class AutoSubmittedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoSubmittedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoSubmittedHandlerSchema(AutoSubmittedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e");
			Name = "AutoSubmittedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,77,111,219,48,12,134,207,14,144,255,64,120,151,4,104,237,251,154,5,8,130,21,237,161,219,176,4,187,211,54,19,107,213,135,75,74,43,130,98,255,125,146,236,180,93,134,249,96,67,52,223,135,124,69,90,52,36,3,182,4,123,98,70,113,7,95,109,157,61,168,99,96,244,202,217,249,236,101,62,43,130,40,123,132,221,73,60,153,155,249,44,70,234,186,134,149,4,99,144,79,235,233,188,129,86,163,8,248,30,61,48,13,76,66,214,11,32,244,104,59,77,12,238,0,229,38,120,119,189,11,141,81,222,83,87,194,192,110,32,246,39,80,22,200,160,210,208,19,118,196,213,185,74,253,174,204,16,26,173,218,169,78,34,189,130,238,166,18,31,225,254,46,235,191,77,220,233,71,20,191,228,206,139,15,76,199,232,236,63,121,240,64,166,33,150,49,247,210,102,14,60,144,239,93,7,109,79,237,99,114,75,240,11,117,160,228,110,108,253,205,211,165,219,234,21,90,95,82,87,3,50,26,176,113,34,159,202,12,44,215,63,206,220,127,110,237,162,80,181,170,179,252,141,198,228,3,91,89,127,31,191,176,231,72,82,135,169,85,37,80,126,113,37,68,207,112,139,90,98,145,232,131,159,149,80,68,157,181,9,54,221,120,227,156,134,109,114,188,112,205,79,106,253,8,90,66,90,143,162,24,21,32,158,227,162,84,159,159,66,100,46,114,70,181,119,187,28,93,44,175,96,139,66,113,189,196,75,181,209,218,61,83,247,215,12,207,163,200,182,175,50,184,24,197,91,103,162,63,37,206,86,95,185,83,22,245,253,209,58,166,4,92,222,164,204,223,211,112,201,118,227,124,227,41,198,138,249,44,190,211,243,7,55,127,66,95,235,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e"));
		}

		#endregion

	}

	#endregion

}

