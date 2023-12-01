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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,147,77,111,219,48,12,134,207,14,144,255,64,100,151,244,80,251,190,37,1,218,162,5,122,40,80,108,185,23,154,77,39,2,44,201,160,232,20,105,177,255,62,70,242,103,209,164,151,230,18,88,124,69,190,124,72,89,101,208,215,42,71,216,34,145,242,174,228,244,206,217,82,239,26,82,172,157,77,239,141,210,213,147,182,218,238,230,179,247,249,108,62,75,126,16,238,36,4,119,149,242,254,39,252,97,146,224,189,109,76,136,102,89,6,43,223,24,163,232,184,105,191,111,149,71,200,79,114,40,29,129,15,55,128,143,53,94,123,85,226,53,202,101,168,21,51,146,141,58,244,105,151,43,27,37,171,155,191,149,206,219,84,227,194,73,180,214,123,123,208,88,21,98,238,153,244,65,49,198,224,71,107,225,96,187,71,56,168,170,193,180,151,140,43,38,117,204,0,132,170,112,182,58,118,238,95,194,165,95,109,89,180,69,172,60,181,33,44,69,222,228,236,40,152,113,140,57,99,113,193,206,163,213,172,85,165,223,208,131,2,139,175,160,37,133,178,50,34,87,2,139,217,149,71,129,73,88,174,23,3,129,69,182,137,84,206,116,17,78,106,69,202,128,149,153,175,23,193,253,98,51,116,191,202,66,184,237,185,53,58,98,188,108,251,14,234,43,120,63,233,146,8,1,214,208,193,72,146,127,151,137,60,33,239,93,152,76,24,229,5,18,207,72,178,44,70,48,88,208,166,22,177,102,200,157,61,32,249,83,166,146,156,57,15,131,221,36,118,244,140,38,141,18,9,127,11,165,160,38,228,134,172,159,172,19,161,111,42,238,230,53,88,30,85,29,95,107,151,90,166,204,242,215,183,234,106,148,55,216,63,151,229,208,223,116,6,49,85,235,111,235,162,108,121,53,30,198,167,124,127,71,11,178,101,103,65,193,9,228,94,177,116,84,75,83,104,217,203,183,246,253,78,94,226,248,145,204,205,247,212,249,132,156,19,190,164,11,236,158,230,0,97,138,232,229,171,45,141,167,211,195,112,38,191,255,205,23,251,89,43,5,0,0 };
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

