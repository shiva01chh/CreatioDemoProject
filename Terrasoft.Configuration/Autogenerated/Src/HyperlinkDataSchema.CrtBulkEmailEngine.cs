namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HyperlinkDataSchema

	/// <exclude/>
	public class HyperlinkDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HyperlinkDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HyperlinkDataSchema(HyperlinkDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d");
			Name = "HyperlinkData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,209,106,194,48,20,125,86,232,63,92,240,101,3,105,223,167,8,163,130,123,216,131,184,249,1,215,246,90,179,165,73,201,77,132,34,251,247,221,180,90,68,198,216,12,129,228,158,156,115,207,33,137,193,154,184,193,130,224,157,156,67,182,123,159,230,214,236,85,21,28,122,101,77,50,62,37,227,81,96,101,42,120,107,217,83,61,187,169,133,175,53,21,145,204,233,138,12,57,85,68,142,204,137,163,74,96,200,53,50,63,193,75,219,144,211,202,124,46,209,99,50,22,66,150,101,48,231,80,215,232,218,197,185,222,80,227,136,201,120,134,195,69,0,165,40,192,91,96,60,18,40,35,187,136,236,144,41,189,180,201,174,250,52,97,167,85,1,69,244,189,181,29,157,58,235,33,220,218,89,57,247,138,36,225,186,211,245,231,183,217,58,96,69,18,203,58,224,184,250,3,193,118,243,154,14,236,235,8,151,12,236,93,188,171,173,211,112,130,138,252,44,106,103,240,245,31,147,32,226,2,155,120,197,127,50,203,123,238,253,134,88,150,42,118,64,241,181,58,212,134,161,84,221,19,139,12,30,122,12,140,124,158,41,28,81,7,122,252,61,215,114,16,207,251,136,83,176,187,15,249,52,11,120,30,172,242,179,211,15,169,39,100,202,254,185,186,186,71,175,65,65,226,248,6,79,76,221,233,207,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("09dcd3e4-968e-49ba-9925-0e06455c854d"));
		}

		#endregion

	}

	#endregion

}

