namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringEnumSchema

	/// <exclude/>
	public class StringEnumSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringEnumSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringEnumSchema(StringEnumSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3d732c7c-0f8d-47a1-85af-96c11b6df501");
			Name = "StringEnum";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b6327e89-1dee-4b6f-a695-226c016beae1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,111,219,48,12,134,207,14,144,255,64,100,151,244,80,251,190,37,1,182,162,5,122,40,80,108,185,23,154,77,39,2,44,201,160,232,12,89,177,255,62,90,242,103,209,164,151,230,18,88,124,69,190,124,72,89,101,208,215,42,71,216,35,145,242,174,228,244,206,217,82,31,26,82,172,157,77,239,141,210,213,147,182,218,30,150,139,215,229,98,185,72,190,16,30,36,4,119,149,242,254,43,252,98,146,224,189,109,76,136,102,89,6,27,223,24,163,232,188,235,190,127,40,143,144,183,114,40,29,129,15,55,128,207,53,222,122,85,226,45,202,101,168,21,51,146,141,58,244,105,159,43,155,36,171,155,223,149,206,187,84,211,194,73,180,54,120,123,208,88,21,98,238,153,244,73,49,198,224,91,107,225,96,127,68,56,169,170,193,116,144,76,43,38,117,204,0,132,170,112,182,58,247,238,95,194,165,111,93,89,180,69,172,60,183,33,44,69,222,228,236,40,152,113,140,57,99,113,197,206,163,213,172,85,165,255,162,7,5,22,255,128,150,20,202,202,136,92,9,44,102,55,30,5,38,97,185,93,141,4,86,217,46,82,185,208,69,56,169,21,41,3,86,102,190,93,5,247,171,221,216,253,38,11,225,174,231,206,232,132,241,186,235,59,168,111,224,181,213,37,17,2,108,161,135,145,36,255,174,19,121,66,62,186,48,153,48,202,43,36,158,145,100,89,140,96,176,160,77,45,98,205,144,59,123,66,242,109,166,146,156,185,12,131,221,44,118,246,140,38,141,18,9,127,10,165,160,38,228,134,172,159,173,19,161,111,42,238,231,53,90,158,84,157,94,235,150,90,166,204,242,55,180,234,106,148,55,56,60,151,245,216,223,124,6,49,85,231,111,239,162,108,125,51,29,198,187,124,127,70,11,178,101,23,65,65,11,242,168,88,58,170,165,41,180,236,229,91,251,97,39,175,113,124,75,230,251,231,212,121,135,156,19,190,164,11,236,159,230,8,97,142,232,229,163,45,141,167,243,195,112,214,254,254,3,137,67,91,215,44,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3d732c7c-0f8d-47a1-85af-96c11b6df501"));
		}

		#endregion

	}

	#endregion

}

