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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,79,107,2,49,16,197,207,43,244,59,12,122,113,65,220,187,253,3,214,86,241,80,40,180,210,67,233,33,38,179,26,136,201,146,73,14,139,244,187,55,217,181,178,237,86,90,212,230,150,201,123,191,204,203,16,205,54,72,5,227,8,207,104,45,35,147,187,225,196,232,92,174,188,101,78,26,125,209,217,94,116,18,79,82,175,224,169,36,135,155,203,253,190,105,177,120,168,62,156,50,238,140,149,72,65,17,52,61,139,171,0,134,137,98,68,35,152,34,115,222,226,194,73,69,47,150,21,149,230,245,14,115,230,149,187,149,90,4,98,223,149,5,154,188,63,111,136,165,11,196,52,125,11,234,194,47,149,228,192,35,176,197,131,17,180,108,193,179,173,238,217,55,243,128,110,109,68,104,231,177,98,213,135,89,150,193,149,212,107,180,210,9,19,46,176,152,95,119,91,180,225,12,221,156,118,213,123,205,150,10,69,127,65,104,195,67,106,228,241,21,7,64,206,134,32,105,55,187,137,228,93,199,75,99,20,252,238,6,207,63,1,192,141,192,20,226,76,146,196,98,240,196,211,31,59,168,148,113,40,201,251,127,197,25,192,204,75,113,158,80,53,11,168,164,177,216,72,189,208,210,205,197,223,147,14,190,59,207,148,124,106,236,88,151,177,245,211,70,122,144,115,212,112,27,180,115,142,57,98,149,58,61,104,139,113,116,72,165,34,136,218,41,123,168,69,253,119,171,125,93,253,90,12,181,230,250,0,102,245,29,208,235,4,0,0 };
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

