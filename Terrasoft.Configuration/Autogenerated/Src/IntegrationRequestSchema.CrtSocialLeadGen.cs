namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationRequestSchema

	/// <exclude/>
	public class IntegrationRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationRequestSchema(IntegrationRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0");
			Name = "IntegrationRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,79,193,106,195,48,12,61,47,144,127,16,236,158,220,219,177,75,10,101,48,88,233,250,3,90,162,100,134,196,202,100,121,99,148,253,251,28,187,13,238,152,47,150,158,158,158,222,179,56,145,155,177,37,56,145,8,58,238,181,106,216,246,102,240,130,106,216,86,175,220,26,28,159,9,187,61,217,178,56,151,69,89,220,221,11,13,97,8,205,136,206,109,224,201,42,13,137,127,164,15,79,78,35,171,174,107,120,112,126,154,80,190,31,47,125,51,178,239,64,18,11,118,167,23,248,50,250,14,198,246,44,83,84,0,238,67,187,10,86,87,161,58,83,154,253,219,104,90,104,151,243,255,92,135,13,220,216,62,6,236,32,252,105,58,146,80,207,108,29,5,149,148,101,13,19,24,51,137,26,10,137,14,241,64,154,255,141,17,129,61,169,3,22,112,203,159,217,133,209,56,173,214,181,220,244,213,117,230,55,175,119,168,8,103,24,72,183,139,234,22,126,46,246,200,118,201,97,236,19,122,11,70,108,121,191,119,28,246,1,207,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f58b6f1c-5c09-4a6d-a367-9cc43d2b20d0"));
		}

		#endregion

	}

	#endregion

}

