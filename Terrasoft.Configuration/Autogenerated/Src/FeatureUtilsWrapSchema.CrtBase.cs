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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,79,107,2,49,16,197,207,43,248,29,6,189,184,32,238,221,254,1,107,171,120,40,20,90,233,161,244,16,147,89,13,196,100,73,38,135,69,250,221,155,236,90,177,110,165,69,109,110,153,188,247,203,188,12,209,108,141,174,96,28,225,5,173,101,206,228,52,24,27,157,203,165,183,140,164,209,237,214,166,221,74,188,147,122,9,207,165,35,92,95,237,246,251,22,139,199,234,131,9,227,100,172,68,23,20,65,211,181,184,12,96,24,43,230,220,16,38,200,200,91,156,147,84,238,213,178,162,210,188,221,99,206,188,162,59,169,69,32,246,168,44,208,228,189,217,158,88,82,32,166,233,123,80,23,126,161,36,7,30,129,13,30,12,161,97,11,158,77,117,207,174,153,71,164,149,17,161,157,167,138,85,31,102,89,6,215,82,175,208,74,18,38,92,96,49,191,233,52,104,131,41,210,204,109,171,15,154,45,20,138,222,220,161,13,15,169,145,199,87,236,131,35,27,130,164,157,236,54,146,183,29,47,140,81,240,187,27,60,255,2,0,55,2,83,136,51,73,18,139,193,19,79,127,236,160,82,198,161,36,31,255,21,167,15,83,47,197,101,66,213,44,112,165,27,137,181,212,115,45,105,38,254,158,180,127,232,188,80,242,137,177,35,93,198,214,207,27,233,81,206,73,195,221,163,93,114,204,17,171,212,249,65,27,140,147,67,42,21,65,174,153,178,139,90,212,127,183,218,215,213,239,197,80,139,235,19,42,125,84,109,227,4,0,0 };
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

