namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float1ColumnProcessorSchema

	/// <exclude/>
	public class Float1ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float1ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float1ColumnProcessorSchema(Float1ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c");
			Name = "Float1ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,21,252,14,67,223,165,5,73,240,170,109,65,43,149,94,68,208,190,139,188,195,118,51,169,11,201,110,152,217,21,138,248,221,157,108,26,109,210,60,193,92,178,59,252,231,63,51,191,76,172,42,145,43,165,17,158,145,72,177,203,125,178,116,54,55,187,64,202,27,103,147,149,41,112,93,86,142,252,249,217,251,249,217,40,176,177,59,120,218,179,199,242,250,235,126,156,77,248,191,120,178,82,218,59,50,200,162,16,205,31,194,157,212,128,101,161,152,175,96,85,56,229,47,151,174,8,165,125,36,167,145,217,81,20,166,105,10,51,99,95,145,140,207,156,6,77,152,207,199,81,223,147,143,211,69,171,231,80,150,138,246,237,253,198,130,177,236,149,149,97,93,14,254,213,48,232,186,48,200,129,132,130,179,108,182,5,66,238,8,170,198,175,30,161,233,10,116,172,3,111,170,8,200,73,91,35,61,42,242,114,135,185,10,133,191,53,54,147,196,137,223,87,232,242,201,186,215,225,244,2,30,132,58,204,193,202,75,4,131,99,79,167,255,196,178,10,219,194,232,67,155,131,58,56,96,59,161,54,122,143,228,190,25,203,120,158,66,205,95,80,63,70,227,70,241,91,184,39,116,99,96,73,168,60,114,151,177,16,16,37,226,177,103,127,2,49,77,190,92,211,190,237,172,82,164,202,136,106,62,14,140,36,115,88,212,245,106,142,23,27,185,203,135,105,3,201,44,141,234,152,124,64,55,88,114,178,233,24,65,215,119,42,76,183,138,113,210,15,215,235,63,250,56,96,69,155,53,100,187,152,165,70,133,228,101,197,175,234,179,151,92,204,126,226,124,43,149,134,49,87,109,58,184,55,249,141,76,134,112,31,76,6,119,202,171,191,245,26,62,11,222,205,58,131,249,162,27,75,154,161,251,186,235,193,206,155,121,186,65,137,29,63,159,243,42,235,239,37,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c"));
		}

		#endregion

	}

	#endregion

}

