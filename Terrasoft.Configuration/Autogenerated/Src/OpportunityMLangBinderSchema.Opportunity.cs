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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,75,107,195,48,12,62,183,208,255,32,186,75,7,35,185,183,165,176,150,13,10,41,29,108,176,179,147,168,153,33,126,96,203,97,161,236,191,79,113,146,145,142,250,98,172,239,33,125,178,22,10,189,21,5,194,7,58,39,188,185,80,114,48,250,34,171,224,4,73,163,23,243,235,98,62,11,94,234,234,134,226,48,121,21,5,25,39,209,111,238,48,62,49,103,150,82,70,51,202,248,131,195,138,237,224,80,11,239,215,112,182,214,56,10,90,82,123,202,132,174,246,82,151,232,34,51,77,83,216,250,160,148,112,237,110,120,79,232,160,66,77,178,102,77,16,21,66,209,249,65,30,229,201,168,78,39,114,27,242,90,22,3,239,126,91,88,195,179,181,47,13,106,202,164,39,212,232,246,194,35,139,175,113,162,191,225,79,72,95,166,228,241,223,162,105,15,14,13,76,195,217,101,137,208,24,89,194,89,179,227,59,9,71,171,209,154,215,74,248,77,80,244,247,35,116,139,157,205,114,238,148,76,232,35,188,137,104,92,87,191,232,54,233,166,221,30,179,33,250,145,144,191,200,184,167,105,170,255,224,110,181,156,160,203,222,245,103,72,133,186,236,131,197,119,95,189,45,114,173,59,191,204,178,102,91,38,2,0,0 };
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

