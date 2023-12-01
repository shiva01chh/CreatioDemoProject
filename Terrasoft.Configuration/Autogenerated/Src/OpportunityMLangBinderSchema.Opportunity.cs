namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: OpportunityMLangBinderSchema

	/// <exclude/>
	public class OpportunityMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public OpportunityMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public OpportunityMLangBinderSchema(OpportunityMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349");
			Name = "OpportunityMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0e987dc8-e3a7-4136-b3d3-af8a5676bbce");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,77,107,195,48,12,61,167,208,255,32,186,75,7,35,185,183,165,176,150,13,10,41,29,108,176,179,147,168,153,33,182,131,45,135,133,178,255,62,213,78,70,58,234,139,177,222,135,244,100,45,20,186,86,148,8,31,104,173,112,230,76,233,222,232,179,172,189,21,36,141,158,207,46,243,89,226,157,212,245,13,197,98,250,42,74,50,86,162,91,223,97,124,98,193,44,165,140,102,148,241,7,139,53,219,193,190,17,206,173,224,212,182,198,146,215,146,250,99,46,116,189,147,186,66,27,152,89,150,193,198,121,165,132,237,183,195,123,66,7,229,27,146,13,107,188,168,17,202,171,31,20,65,158,142,234,108,34,111,125,209,200,114,224,221,111,11,43,120,110,219,151,14,53,229,210,17,106,180,59,225,144,197,151,48,209,223,240,71,164,47,83,241,248,111,193,52,130,67,3,211,113,118,89,33,116,70,86,112,210,236,248,78,194,210,114,180,230,181,18,126,19,148,241,126,132,235,98,147,164,224,78,233,132,62,194,235,128,134,117,197,69,247,233,117,218,205,33,31,162,31,8,249,139,140,125,154,166,250,15,110,151,139,9,186,136,174,63,67,42,212,85,12,22,222,177,122,91,228,26,159,95,147,161,118,183,37,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c44c1193-13fd-4b69-b47e-53e7dc114349"));
		}

		#endregion

	}

	#endregion

}

