namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float3ColumnProcessorSchema

	/// <exclude/>
	public class Float3ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float3ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float3ColumnProcessorSchema(Float3ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ac9f761-d47f-4b4c-a8e7-4a1491cda0d9");
			Name = "Float3ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,224,77,219,130,86,42,189,136,160,245,34,30,182,155,73,93,72,118,227,236,172,80,196,119,119,178,105,180,137,85,48,151,236,14,255,252,51,243,101,98,85,137,190,82,26,225,1,137,148,119,57,39,115,103,115,179,9,164,216,56,155,44,76,129,203,178,114,196,199,71,239,199,71,131,224,141,221,192,253,214,51,150,23,95,247,253,108,194,223,226,201,66,105,118,100,208,139,66,52,39,132,27,169,1,243,66,121,127,14,139,194,41,62,155,187,34,148,246,142,156,70,239,29,69,97,154,166,48,49,246,5,201,112,230,52,104,194,124,58,140,250,158,124,152,206,90,189,15,101,169,104,219,222,47,45,24,235,89,89,25,214,229,192,47,198,131,174,11,131,28,72,40,56,235,205,186,64,200,29,65,213,248,213,35,52,93,129,142,117,224,77,21,1,125,210,214,72,247,138,60,93,99,174,66,193,87,198,102,146,56,226,109,133,46,31,45,123,29,142,79,225,86,168,195,20,172,188,68,112,112,236,241,248,89,44,171,176,46,140,222,181,121,80,7,59,108,63,168,13,222,35,185,111,198,50,30,83,168,249,11,234,187,104,220,40,254,11,247,7,221,24,152,19,42,70,223,101,44,4,68,137,184,239,217,159,64,76,147,47,215,180,111,59,169,20,169,50,162,154,14,131,71,146,57,44,234,122,53,135,179,149,220,229,195,180,129,100,146,70,117,76,222,161,59,88,114,180,234,24,65,215,119,44,76,215,202,227,168,31,174,215,127,240,177,195,138,54,107,200,118,49,75,141,10,137,101,197,207,235,51,75,46,102,127,113,190,146,74,255,192,124,173,88,53,75,216,208,13,214,188,202,217,100,104,217,228,6,233,23,150,85,219,11,184,55,249,39,69,15,55,193,100,209,239,177,182,123,16,183,213,50,131,233,172,27,75,26,130,125,221,197,65,12,13,156,110,80,98,251,207,39,137,172,196,120,114,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ac9f761-d47f-4b4c-a8e7-4a1491cda0d9"));
		}

		#endregion

	}

	#endregion

}

