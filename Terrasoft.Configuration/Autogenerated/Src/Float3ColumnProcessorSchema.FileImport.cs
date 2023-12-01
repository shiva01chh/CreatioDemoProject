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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,224,77,219,130,86,42,189,136,160,245,34,30,182,155,73,29,72,118,227,236,174,80,196,119,119,178,105,180,137,85,48,151,236,14,255,252,51,243,101,98,84,137,174,82,26,225,1,153,149,179,185,79,230,214,228,180,9,172,60,89,147,44,168,192,101,89,89,246,199,71,239,199,71,131,224,200,108,224,126,235,60,150,23,95,247,253,108,198,223,226,201,66,105,111,153,208,137,66,52,39,140,27,169,1,243,66,57,119,14,139,194,42,127,54,183,69,40,205,29,91,141,206,89,142,194,52,77,97,66,230,5,153,124,102,53,104,198,124,58,140,250,158,124,152,206,90,189,11,101,169,120,219,222,47,13,144,113,94,25,25,214,230,224,95,200,129,174,11,131,28,88,40,88,227,104,93,32,228,150,161,106,252,234,17,154,174,64,199,58,240,166,138,128,46,105,107,164,123,69,158,174,49,87,161,240,87,100,50,73,28,249,109,133,54,31,45,123,29,142,79,225,86,168,195,20,140,188,68,112,112,236,241,248,89,44,171,176,46,72,239,218,60,168,131,29,182,31,212,6,239,145,220,55,99,25,207,115,168,249,11,234,187,104,220,40,254,11,247,7,221,24,152,51,42,143,174,203,88,8,136,18,113,223,179,63,129,152,38,95,174,105,223,118,82,41,86,101,68,53,29,6,135,44,115,24,212,245,106,14,103,43,185,203,135,105,3,201,36,141,234,152,188,67,119,176,228,104,213,49,130,174,239,88,152,174,149,195,81,63,92,175,255,224,99,135,21,77,214,144,237,98,150,26,21,178,151,21,63,175,207,94,114,49,251,139,243,149,84,250,7,230,107,229,85,179,132,13,221,96,232,85,206,148,161,241,148,19,242,47,44,171,182,23,176,111,242,79,138,30,110,2,101,209,239,177,182,123,16,183,213,50,131,233,172,27,75,26,130,125,221,197,65,12,13,156,110,80,98,242,124,2,57,53,154,106,105,4,0,0 };
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

