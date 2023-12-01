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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,193,78,195,48,12,61,183,210,254,33,210,238,124,0,59,65,209,16,18,133,73,29,39,196,33,77,220,98,41,77,42,199,61,140,137,127,39,77,202,96,32,68,219,147,251,226,231,247,236,56,86,118,224,123,169,64,236,129,72,122,215,240,69,225,108,131,237,64,146,209,217,85,126,92,229,171,60,27,60,218,86,84,7,207,208,109,34,178,38,104,67,130,40,140,244,254,82,148,146,213,43,248,173,27,172,142,231,207,21,16,74,131,111,178,54,240,18,128,126,168,13,42,161,198,252,31,233,89,18,57,213,220,145,235,129,24,33,20,222,69,90,58,159,74,220,14,168,197,157,62,142,80,214,2,111,98,224,167,224,253,44,247,70,50,236,177,3,81,16,132,80,63,218,89,180,40,49,81,174,15,51,181,60,211,56,165,19,237,33,76,119,153,201,210,105,108,112,153,203,79,206,82,155,95,188,217,62,209,242,120,55,10,188,191,199,176,10,22,200,255,77,204,178,223,162,149,83,97,41,174,148,10,23,207,243,123,76,180,18,52,202,101,77,126,35,206,238,178,118,206,136,10,120,235,40,188,5,150,106,158,209,73,49,237,107,152,82,131,6,158,200,44,119,251,95,135,107,176,58,61,148,248,159,208,115,48,98,225,251,0,201,54,10,149,224,3,0,0 };
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

