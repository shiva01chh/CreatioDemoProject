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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,193,106,195,48,16,68,207,49,248,31,22,122,183,239,77,232,197,165,161,16,104,72,82,122,150,172,181,187,96,75,206,174,68,9,166,255,94,89,118,66,218,75,117,144,216,209,236,240,198,170,30,101,80,53,194,9,153,149,184,198,23,149,179,13,181,129,149,39,103,139,163,171,73,117,59,84,102,139,54,207,198,60,91,5,33,219,194,241,34,30,251,117,158,69,229,129,177,141,102,168,58,37,242,8,59,101,77,180,188,91,9,90,106,38,141,7,20,127,192,115,136,79,90,40,203,18,54,18,250,94,241,229,105,153,171,206,5,3,60,187,224,249,244,6,95,228,63,129,108,227,184,79,48,160,180,11,30,186,57,190,184,230,148,119,65,67,208,29,213,80,79,32,255,113,172,198,196,114,163,223,179,27,144,61,97,172,176,79,57,243,255,95,216,36,44,217,64,166,184,121,238,65,174,36,219,64,6,42,198,169,192,7,234,151,216,229,213,192,8,45,250,53,200,116,125,47,20,104,205,12,146,230,89,253,45,38,45,158,31,78,202,239,53,182,1,0,0 };
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

