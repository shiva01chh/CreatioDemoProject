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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,75,235,64,16,198,207,21,252,31,134,122,105,65,146,195,243,164,109,65,43,149,94,30,130,214,203,195,195,118,51,169,11,201,110,156,157,21,138,248,191,59,217,52,125,77,172,130,185,100,119,248,246,251,118,126,153,88,85,162,175,148,70,120,68,34,229,93,206,201,220,217,220,108,2,41,54,206,38,11,83,224,178,172,28,241,233,201,251,233,201,32,120,99,55,240,176,245,140,229,213,126,127,120,154,240,187,122,178,80,154,29,25,244,162,16,205,25,225,70,50,96,94,40,239,47,97,81,56,197,127,230,174,8,165,189,39,167,209,123,71,81,152,166,41,76,140,125,65,50,156,57,13,154,48,159,14,163,190,39,31,166,179,86,239,67,89,42,218,182,251,107,11,198,122,86,86,154,117,57,240,139,241,160,235,96,144,5,9,5,103,189,89,23,8,185,35,168,26,191,186,133,230,86,160,99,14,188,169,34,160,79,218,140,244,32,228,223,45,230,42,20,124,99,108,38,7,71,188,173,208,229,163,101,239,134,227,115,248,43,212,97,10,86,94,34,136,1,23,125,213,248,89,44,171,176,46,140,222,93,243,168,14,118,216,190,80,27,188,71,114,255,25,75,123,76,161,230,47,168,239,163,113,163,248,45,220,47,116,99,97,78,168,24,125,151,177,16,16,37,226,161,103,191,3,49,77,246,174,105,223,118,82,41,82,101,68,53,29,6,143,36,125,88,212,245,104,14,103,43,217,203,135,105,11,201,36,141,234,120,120,135,238,104,228,104,213,49,130,174,239,88,152,174,149,199,81,191,92,143,255,224,99,135,21,109,214,144,237,98,150,140,10,137,101,196,47,235,53,203,89,204,126,226,124,35,73,191,192,124,171,88,53,67,216,208,13,214,188,202,218,100,104,217,228,6,233,27,150,85,123,23,112,111,242,79,138,30,238,130,201,162,223,83,109,247,40,110,171,101,6,211,89,183,150,52,4,251,186,171,163,24,26,56,221,162,212,228,249,4,120,145,252,51,105,4,0,0 };
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

