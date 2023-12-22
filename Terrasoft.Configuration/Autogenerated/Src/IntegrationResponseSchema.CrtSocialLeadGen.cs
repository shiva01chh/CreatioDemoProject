namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationResponseSchema

	/// <exclude/>
	public class IntegrationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationResponseSchema(IntegrationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34726720-1e07-4f00-be95-bf2446ea34bc");
			Name = "IntegrationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,65,79,131,64,16,133,207,37,225,63,76,234,69,47,112,47,234,133,38,141,73,213,166,237,205,120,216,194,128,155,176,187,100,118,208,84,226,127,119,89,160,110,229,178,204,219,55,111,230,3,45,20,218,86,20,8,71,36,18,214,84,156,228,70,87,178,238,72,176,52,58,57,152,66,138,102,139,162,220,160,142,163,62,142,22,157,149,186,134,195,217,50,170,100,223,105,150,10,147,3,146,243,201,111,223,149,197,145,243,221,16,214,174,128,188,17,214,174,224,73,51,214,99,234,86,90,222,187,193,70,91,244,214,52,77,225,222,118,74,9,58,63,78,117,222,152,174,4,154,108,176,62,190,194,151,228,15,144,186,50,164,124,14,152,202,149,151,216,100,78,74,131,168,183,181,96,225,152,152,68,193,239,78,104,187,83,35,11,40,134,173,194,165,230,133,96,5,87,208,78,231,29,153,79,89,34,253,45,189,232,253,226,23,72,231,104,145,88,162,35,221,249,9,227,253,127,50,47,108,144,45,24,2,59,156,1,0,52,238,195,36,151,182,16,99,228,120,70,117,66,186,125,113,191,13,30,96,25,180,14,183,203,187,129,111,6,12,208,194,247,193,8,61,212,200,217,48,63,131,159,9,4,117,57,178,248,122,84,175,69,175,133,207,47,141,254,41,130,63,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34726720-1e07-4f00-be95-bf2446ea34bc"));
		}

		#endregion

	}

	#endregion

}

