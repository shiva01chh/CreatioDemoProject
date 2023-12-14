namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MatchesFoundUtilitiesSchema

	/// <exclude/>
	public class MatchesFoundUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MatchesFoundUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MatchesFoundUtilitiesSchema(MatchesFoundUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1");
			Name = "MatchesFoundUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,193,78,195,48,12,61,183,210,254,33,210,238,124,0,59,65,209,16,18,133,73,29,39,196,33,77,220,98,41,77,170,216,61,140,137,127,39,77,202,96,32,68,219,147,251,226,231,247,236,56,86,118,64,189,84,32,246,224,189,36,215,240,69,225,108,131,237,224,37,163,179,171,252,184,202,87,121,54,16,218,86,84,7,98,232,54,17,89,123,104,67,130,40,140,36,186,20,165,100,245,10,180,117,131,213,241,252,185,2,143,210,224,155,172,13,188,4,160,31,106,131,74,168,49,255,71,122,150,68,78,53,119,222,245,224,25,33,20,222,69,90,58,159,74,220,14,168,197,157,62,142,80,214,2,111,98,64,83,240,126,150,123,35,25,246,216,129,40,60,132,80,63,218,89,180,40,49,81,174,15,51,181,136,253,56,165,19,237,33,76,119,153,201,210,105,108,112,153,203,79,206,82,155,95,188,217,62,209,242,120,55,10,136,238,49,172,130,5,79,127,19,179,236,183,104,229,84,88,138,43,165,194,197,243,252,30,19,173,4,141,114,89,147,223,136,179,187,172,157,51,162,2,222,58,31,222,2,75,53,207,232,164,152,246,53,76,169,65,3,79,222,44,119,251,95,135,107,176,58,61,148,248,159,208,115,48,98,227,247,1,177,118,250,208,225,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e78d9172-c1ff-4b6b-b8de-32a4d56c58f1"));
		}

		#endregion

	}

	#endregion

}

