namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseMessageNotifierSchema

	/// <exclude/>
	public class BaseMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseMessageNotifierSchema(BaseMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dc1877d9-eed2-4af1-98c3-84cf7a260a2d");
			Name = "BaseMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,77,107,195,48,12,61,167,208,255,32,216,37,187,228,7,52,219,96,43,108,20,214,81,214,245,60,28,91,73,13,169,29,44,39,163,148,253,247,217,249,106,218,181,91,105,78,146,252,242,158,244,44,151,36,85,6,203,45,89,220,68,83,157,231,200,173,212,138,162,23,84,104,36,143,199,163,241,72,177,13,82,193,56,194,7,26,195,72,167,214,97,85,42,179,210,48,15,31,143,118,30,23,220,24,204,92,10,211,156,17,77,224,137,17,206,145,136,88,134,111,218,202,84,162,169,113,69,153,228,146,3,75,200,26,198,45,112,143,239,225,3,52,76,96,118,84,114,191,55,98,189,218,179,196,92,56,185,133,145,21,179,216,28,22,77,2,6,153,208,42,223,194,171,36,123,215,145,249,196,15,248,0,159,121,27,82,220,178,162,18,13,241,161,202,194,232,2,141,149,232,149,234,254,91,161,102,150,150,120,166,82,125,16,239,60,38,32,180,113,29,100,109,240,253,183,152,115,215,89,83,114,171,141,159,75,91,119,45,40,186,201,218,244,148,97,225,109,171,184,159,11,238,65,225,215,153,249,195,219,75,218,153,163,93,107,113,122,240,74,75,1,203,50,33,110,100,130,225,177,2,116,125,252,110,44,122,20,34,236,143,135,125,12,169,87,138,174,34,127,199,141,174,240,127,254,218,185,109,239,91,170,221,198,240,53,132,21,219,211,131,84,131,69,233,160,65,87,137,86,133,112,187,22,218,181,164,70,199,11,157,115,181,169,30,21,59,167,103,202,162,73,221,83,59,181,248,251,151,35,59,216,153,231,17,4,215,237,227,197,151,25,15,240,151,221,208,240,143,206,243,248,140,29,174,230,190,31,250,28,79,134,156,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dc1877d9-eed2-4af1-98c3-84cf7a260a2d"));
		}

		#endregion

	}

	#endregion

}

