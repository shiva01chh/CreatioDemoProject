namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float8ColumnProcessorSchema

	/// <exclude/>
	public class Float8ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float8ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float8ColumnProcessorSchema(Float8ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("841cbf68-2096-4585-a283-015e96ff338e");
			Name = "Float8ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,42,218,22,180,82,233,69,4,173,23,241,176,221,76,234,66,178,27,103,103,133,34,190,187,147,77,163,77,172,130,185,100,119,248,231,159,153,47,19,171,74,244,149,210,8,15,72,164,188,203,57,153,59,155,155,77,32,197,198,217,100,97,10,92,150,149,35,62,62,122,63,62,26,4,111,236,6,238,183,158,177,188,248,186,239,103,19,254,22,79,22,74,179,35,131,94,20,162,57,33,220,72,13,152,23,202,251,115,88,20,78,241,217,220,21,161,180,119,228,52,122,239,40,10,211,52,133,137,177,47,72,134,51,167,65,19,230,211,97,212,247,228,195,116,214,234,125,40,75,69,219,246,126,105,193,88,207,202,202,176,46,7,126,49,30,116,93,24,228,64,66,193,89,111,214,5,66,238,8,170,198,175,30,161,233,10,116,172,3,111,170,8,232,147,182,70,186,87,228,233,26,115,21,10,190,50,54,147,196,17,111,43,116,249,104,217,235,112,124,10,183,66,29,166,96,229,37,130,131,99,143,199,207,98,89,133,117,97,244,174,205,131,58,216,97,251,65,109,240,30,201,125,51,150,241,152,66,205,95,80,223,69,227,70,241,95,184,63,232,198,192,156,80,49,250,46,99,33,32,74,196,125,207,254,4,98,154,124,185,166,125,219,73,165,72,149,17,213,116,24,60,146,204,97,81,215,171,57,156,173,228,46,31,166,13,36,147,52,170,99,242,14,221,193,146,163,85,199,8,186,190,99,97,186,86,30,71,253,112,189,254,131,143,29,86,180,89,67,182,139,89,106,84,72,44,43,126,94,159,89,114,49,251,139,243,149,84,250,7,230,107,197,170,89,194,134,110,176,230,85,206,38,67,203,38,55,72,191,176,172,218,94,192,189,201,63,41,122,184,9,38,139,126,143,181,221,131,184,173,150,25,76,103,221,88,210,16,236,235,46,14,98,104,224,116,131,18,219,127,62,1,156,120,12,220,114,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("841cbf68-2096-4585-a283-015e96ff338e"));
		}

		#endregion

	}

	#endregion

}

