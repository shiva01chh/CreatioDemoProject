namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingUnsubscribeRestRequestSchema

	/// <exclude/>
	public class LandingUnsubscribeRestRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingUnsubscribeRestRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingUnsubscribeRestRequestSchema(LandingUnsubscribeRestRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd");
			Name = "LandingUnsubscribeRestRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,193,106,195,48,16,68,207,49,248,31,22,122,183,239,77,233,197,165,161,16,104,72,82,122,150,172,181,187,96,75,238,174,68,9,166,255,94,89,118,130,219,75,117,144,216,209,236,240,198,170,30,101,80,53,194,25,153,149,184,198,23,149,179,13,181,129,149,39,103,139,147,171,73,117,123,84,102,135,54,207,198,60,219,4,33,219,194,233,34,30,251,109,158,69,229,142,177,141,102,168,58,37,114,15,123,101,77,180,188,89,9,90,106,38,141,71,20,127,196,207,16,159,180,80,150,37,60,72,232,123,197,151,199,101,174,58,23,12,240,236,130,167,243,43,124,145,255,0,178,141,227,62,193,128,210,46,120,232,230,248,226,154,83,174,130,134,160,59,170,161,158,64,254,227,216,140,137,229,70,127,96,55,32,123,194,88,225,144,114,230,255,191,176,73,88,178,129,76,113,243,172,65,174,36,187,64,6,42,198,169,192,59,234,231,216,229,197,192,8,45,250,45,200,116,125,47,20,104,205,12,146,230,89,253,45,38,109,125,126,0,221,65,197,137,191,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d75d98-819a-c4f5-150a-b26f00c1ebdd"));
		}

		#endregion

	}

	#endregion

}

