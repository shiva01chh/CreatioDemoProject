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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,42,218,22,180,82,233,69,4,173,23,241,48,221,76,234,66,178,27,103,119,133,34,190,187,147,77,163,77,172,130,185,100,119,248,231,159,153,47,19,131,37,185,10,21,193,3,49,163,179,185,79,230,214,228,122,19,24,189,182,38,89,232,130,150,101,101,217,31,31,189,31,31,13,130,211,102,3,247,91,231,169,188,248,186,239,103,51,253,22,79,22,168,188,101,77,78,20,162,57,97,218,72,13,152,23,232,220,57,44,10,139,254,108,110,139,80,154,59,182,138,156,179,28,133,105,154,194,68,155,23,98,237,51,171,64,49,229,211,97,212,247,228,195,116,214,234,93,40,75,228,109,123,191,52,160,141,243,104,100,88,155,131,127,209,14,84,93,24,228,192,66,193,26,167,215,5,65,110,25,170,198,175,30,161,233,10,84,172,3,111,88,4,114,73,91,35,221,43,242,116,77,57,134,194,95,105,147,73,226,200,111,43,178,249,104,217,235,112,124,10,183,66,29,166,96,228,37,130,131,99,143,199,207,98,89,133,117,161,213,174,205,131,58,216,97,251,65,109,240,30,201,125,51,150,241,60,135,154,191,160,190,139,198,141,226,191,112,127,208,141,129,57,19,122,114,93,198,66,64,148,68,251,158,253,9,196,52,249,114,77,251,182,147,10,25,203,136,106,58,12,142,88,230,48,164,234,213,28,206,86,114,151,15,211,6,146,73,26,213,49,121,135,238,96,201,209,170,99,4,93,223,177,48,93,163,163,81,63,92,175,255,224,99,135,149,76,214,144,237,98,150,26,21,177,151,21,63,175,207,94,114,41,251,139,243,149,84,250,7,230,107,244,216,44,97,67,55,24,253,42,103,157,145,241,58,215,196,191,176,172,218,94,192,190,201,63,41,122,184,9,58,139,126,143,181,221,131,184,173,150,25,76,103,221,88,210,16,236,235,46,14,98,104,224,116,131,18,171,159,79,25,194,89,116,106,4,0,0 };
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

