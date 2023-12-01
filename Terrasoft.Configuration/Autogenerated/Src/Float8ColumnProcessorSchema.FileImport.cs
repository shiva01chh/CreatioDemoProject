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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,42,218,22,180,82,233,69,4,173,23,241,176,221,76,234,64,178,27,103,119,133,34,190,187,147,77,163,77,172,130,185,100,119,248,231,159,153,47,19,163,74,116,149,210,8,15,200,172,156,205,125,50,183,38,167,77,96,229,201,154,100,65,5,46,203,202,178,63,62,122,63,62,26,4,71,102,3,247,91,231,177,188,248,186,239,103,51,254,22,79,22,74,123,203,132,78,20,162,57,97,220,72,13,152,23,202,185,115,88,20,86,249,179,185,45,66,105,238,216,106,116,206,114,20,166,105,10,19,50,47,200,228,51,171,65,51,230,211,97,212,247,228,195,116,214,234,93,40,75,197,219,246,126,105,128,140,243,202,200,176,54,7,255,66,14,116,93,24,228,192,66,193,26,71,235,2,33,183,12,85,227,87,143,208,116,5,58,214,129,55,85,4,116,73,91,35,221,43,242,116,141,185,10,133,191,34,147,73,226,200,111,43,180,249,104,217,235,112,124,10,183,66,29,166,96,228,37,130,131,99,143,199,207,98,89,133,117,65,122,215,230,65,29,236,176,253,160,54,120,143,228,190,25,203,120,158,67,205,95,80,223,69,227,70,241,95,184,63,232,198,192,156,81,121,116,93,198,66,64,148,136,251,158,253,9,196,52,249,114,77,251,182,147,74,177,42,35,170,233,48,56,100,153,195,160,174,87,115,56,91,201,93,62,76,27,72,38,105,84,199,228,29,186,131,37,71,171,142,17,116,125,199,194,116,173,28,142,250,225,122,253,7,31,59,172,104,178,134,108,23,179,212,168,144,189,172,248,121,125,246,146,139,217,95,156,175,164,210,63,48,95,43,175,154,37,108,232,6,67,175,114,166,12,141,167,156,144,127,97,89,181,189,128,125,147,127,82,244,112,19,40,139,126,143,181,221,131,184,173,150,25,76,103,221,88,210,16,236,235,46,14,98,104,224,116,131,18,147,231,19,175,243,122,231,105,4,0,0 };
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

