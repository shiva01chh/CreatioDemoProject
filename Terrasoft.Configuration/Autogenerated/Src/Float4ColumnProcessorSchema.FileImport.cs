namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float4ColumnProcessorSchema

	/// <exclude/>
	public class Float4ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float4ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float4ColumnProcessorSchema(Float4ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e45599cf-db78-4a8d-b5e2-31927002be8f");
			Name = "Float4ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,75,235,64,16,198,207,21,252,31,134,122,105,65,146,195,243,164,109,65,43,149,94,30,130,214,203,195,195,118,51,169,11,201,110,156,217,21,138,248,191,59,217,52,125,77,172,130,185,100,119,248,246,251,118,126,153,88,85,34,87,74,35,60,34,145,98,151,251,100,238,108,110,54,129,148,55,206,38,11,83,224,178,172,28,249,211,147,247,211,147,65,96,99,55,240,176,101,143,229,213,126,127,120,154,240,187,122,178,80,218,59,50,200,162,16,205,25,225,70,50,96,94,40,230,75,88,20,78,249,63,115,87,132,210,222,147,211,200,236,40,10,211,52,133,137,177,47,72,198,103,78,131,38,204,167,195,168,239,201,135,233,172,213,115,40,75,69,219,118,127,109,193,88,246,202,74,179,46,7,255,98,24,116,29,12,178,32,161,224,44,155,117,129,144,59,130,170,241,171,91,104,110,5,58,230,192,155,42,2,114,210,102,164,7,33,255,110,49,87,161,240,55,198,102,114,112,228,183,21,186,124,180,236,221,112,124,14,127,133,58,76,193,202,75,4,49,224,162,175,26,63,139,101,21,214,133,209,187,107,30,213,193,14,219,23,106,131,247,72,238,63,99,105,207,83,168,249,11,234,251,104,220,40,126,11,247,11,221,88,152,19,42,143,220,101,44,4,68,137,120,232,217,239,64,76,147,189,107,218,183,157,84,138,84,25,81,77,135,129,145,164,15,139,186,30,205,225,108,37,123,249,48,109,33,153,164,81,29,15,239,208,29,141,28,173,58,70,208,245,29,11,211,181,98,28,245,203,245,248,15,62,118,88,209,102,13,217,46,102,201,168,144,188,140,248,101,189,246,114,22,179,159,56,223,72,210,47,48,223,42,175,154,33,108,232,6,107,94,101,109,50,180,222,228,6,233,27,150,85,123,23,112,111,242,79,138,30,238,130,201,162,223,83,109,247,40,110,171,101,6,211,89,183,150,52,4,251,186,171,163,24,26,56,221,162,212,234,231,19,12,3,58,108,106,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e45599cf-db78-4a8d-b5e2-31927002be8f"));
		}

		#endregion

	}

	#endregion

}

