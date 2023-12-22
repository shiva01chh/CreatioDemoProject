namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EqualComparatorProviderSchema

	/// <exclude/>
	public class EqualComparatorProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EqualComparatorProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EqualComparatorProviderSchema(EqualComparatorProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc");
			Name = "EqualComparatorProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,84,201,78,195,48,16,61,183,82,255,97,16,18,74,37,148,220,105,129,67,91,33,14,44,162,136,187,155,76,90,163,196,14,94,144,194,242,239,56,182,19,76,26,56,32,65,47,145,223,204,123,111,54,149,145,18,101,69,82,132,123,20,130,72,158,171,120,193,89,78,183,90,16,69,57,139,87,76,81,85,175,107,150,238,4,103,244,197,162,147,241,235,100,60,25,143,180,164,108,11,235,90,42,44,103,22,57,20,184,53,9,176,40,136,148,39,176,122,210,164,88,240,178,34,70,142,139,91,193,159,105,134,194,166,38,73,2,115,169,203,146,136,250,204,191,125,130,132,180,227,72,200,185,128,140,230,57,10,100,10,84,93,161,140,91,126,18,8,84,122,83,208,20,210,198,250,59,103,56,129,203,111,139,26,185,174,186,38,174,80,237,120,102,218,184,181,202,46,216,47,219,2,119,168,180,96,18,176,145,14,138,183,181,75,37,204,152,226,142,156,244,217,115,225,232,103,159,69,197,243,164,5,155,44,223,90,111,13,11,94,232,146,125,146,224,2,213,218,154,245,90,140,166,240,218,200,140,156,38,100,88,224,150,40,140,248,230,17,83,5,146,107,145,226,3,41,52,30,131,199,204,22,20,101,214,199,6,90,137,86,35,10,72,112,112,10,76,23,5,28,29,237,241,194,88,64,137,109,137,50,218,179,153,58,151,209,219,155,177,112,147,187,148,215,70,224,70,172,202,74,213,145,71,167,129,216,212,138,255,148,188,111,51,179,62,239,246,243,254,219,213,102,102,136,247,180,196,127,90,238,210,216,253,229,106,151,190,157,115,79,107,223,112,10,81,23,11,7,63,235,243,2,233,97,114,223,123,54,116,84,29,117,248,174,250,97,127,49,221,129,181,241,216,93,90,243,28,56,183,129,172,175,199,215,27,193,207,165,248,240,208,89,29,34,203,220,63,138,125,59,244,43,104,177,240,247,1,103,147,26,239,153,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ebef606a-f1e5-4bdb-b9fe-2515dda709fc"));
		}

		#endregion

	}

	#endregion

}

