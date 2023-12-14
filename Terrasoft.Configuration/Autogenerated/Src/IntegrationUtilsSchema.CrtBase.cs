namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationUtilsSchema

	/// <exclude/>
	public class IntegrationUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationUtilsSchema(IntegrationUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64");
			Name = "IntegrationUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,106,195,48,16,133,215,49,248,14,34,43,7,130,46,16,186,73,220,150,64,155,66,157,180,107,85,158,184,2,91,50,35,41,197,148,220,189,250,113,210,184,212,96,47,44,70,51,223,204,147,158,172,22,178,34,69,167,13,52,171,52,177,33,220,3,34,211,234,104,232,70,33,140,108,211,124,125,205,68,158,230,204,48,183,151,38,146,53,160,91,198,97,192,200,163,168,44,50,35,148,76,147,239,52,153,181,246,163,22,156,240,154,105,77,182,210,64,21,179,7,35,106,237,242,190,230,82,164,141,75,113,114,82,162,36,239,40,12,20,157,228,175,160,109,109,178,131,6,116,237,37,112,79,19,59,8,151,228,209,58,70,7,137,125,80,10,28,36,49,244,233,3,213,66,148,177,116,67,209,31,175,4,205,81,180,126,111,225,37,5,93,179,19,195,91,209,79,170,42,248,39,52,140,220,253,81,64,239,165,17,166,139,217,103,38,89,5,72,31,132,44,183,210,157,74,114,88,119,59,119,97,217,124,216,109,190,88,141,204,113,19,254,27,76,55,8,204,64,156,150,13,53,244,189,134,24,45,192,228,112,220,168,218,54,242,141,213,22,116,54,90,120,83,53,80,26,189,223,150,243,101,127,199,211,58,228,23,11,2,121,53,100,26,28,125,15,100,180,110,26,246,114,113,54,144,87,159,167,193,247,136,10,243,223,151,224,85,223,188,139,105,135,118,246,56,206,47,123,209,0,61,24,190,83,95,35,44,59,65,239,198,217,253,206,179,52,113,171,255,126,0,70,0,55,1,180,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64"));
		}

		#endregion

	}

	#endregion

}

