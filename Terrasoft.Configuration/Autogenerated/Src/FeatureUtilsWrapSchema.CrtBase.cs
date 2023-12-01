namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FeatureUtilsWrapSchema

	/// <exclude/>
	public class FeatureUtilsWrapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FeatureUtilsWrapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FeatureUtilsWrapSchema(FeatureUtilsWrapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("857989eb-d198-4858-9f7a-b2ad3d351897");
			Name = "FeatureUtilsWrap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,79,107,2,49,16,197,207,43,248,29,6,189,184,32,238,221,254,1,107,171,120,40,20,90,233,161,244,16,147,89,13,196,100,201,36,135,69,250,221,155,236,90,177,110,165,69,109,110,153,188,247,203,188,12,209,108,141,84,48,142,240,130,214,50,50,185,27,140,141,206,229,210,91,230,164,209,237,214,166,221,74,60,73,189,132,231,146,28,174,175,118,251,125,139,197,99,245,193,132,113,103,172,68,10,138,160,233,90,92,6,48,140,21,35,26,194,4,153,243,22,231,78,42,122,181,172,168,52,111,247,152,51,175,220,157,212,34,16,123,174,44,208,228,189,217,158,88,186,64,76,211,247,160,46,252,66,73,14,60,2,27,60,24,66,195,22,60,155,234,158,93,51,143,232,86,70,132,118,158,42,86,125,152,101,25,92,75,189,66,43,157,48,225,2,139,249,77,167,65,27,76,209,205,104,91,125,208,108,161,80,244,230,132,54,60,164,70,30,95,177,15,228,108,8,146,118,178,219,72,222,118,188,48,70,193,239,110,240,252,11,0,220,8,76,33,206,36,73,44,6,79,60,253,177,131,74,25,135,146,124,252,87,156,62,76,189,20,151,9,85,179,128,74,26,137,181,212,115,45,221,76,252,61,105,255,208,121,161,228,19,99,71,186,140,173,159,55,210,163,156,147,134,187,71,187,228,152,35,86,169,243,131,54,24,39,135,84,42,130,168,153,178,139,90,212,127,183,218,215,213,239,197,80,11,235,19,57,177,243,134,226,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("857989eb-d198-4858-9f7a-b2ad3d351897"));
		}

		#endregion

	}

	#endregion

}

