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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,228,224,77,219,130,86,42,189,136,160,245,34,30,166,155,73,93,72,118,227,236,174,80,196,119,119,178,105,180,137,85,48,151,236,14,255,252,51,243,101,98,176,36,87,161,34,120,32,102,116,54,247,201,220,154,92,111,2,163,215,214,36,11,93,208,178,172,44,251,227,163,247,227,163,65,112,218,108,224,126,235,60,149,23,95,247,253,108,166,223,226,201,2,149,183,172,201,137,66,52,39,76,27,169,1,243,2,157,59,135,69,97,209,159,205,109,17,74,115,199,86,145,115,150,163,48,77,83,152,104,243,66,172,125,102,21,40,166,124,58,140,250,158,124,152,206,90,189,11,101,137,188,109,239,151,6,180,113,30,141,12,107,115,240,47,218,129,170,11,131,28,88,40,88,227,244,186,32,200,45,67,213,248,213,35,52,93,129,138,117,224,13,139,64,46,105,107,164,123,69,158,174,41,199,80,248,43,109,50,73,28,249,109,69,54,31,45,123,29,142,79,225,86,168,195,20,140,188,68,112,112,236,241,248,89,44,171,176,46,180,218,181,121,80,7,59,108,63,168,13,222,35,185,111,198,50,158,231,80,243,23,212,119,209,184,81,252,23,238,15,186,49,48,103,66,79,174,203,88,8,136,146,104,223,179,63,129,152,38,95,174,105,223,118,82,33,99,25,81,77,135,193,17,203,28,134,84,189,154,195,217,74,238,242,97,218,64,50,73,163,58,38,239,208,29,44,57,90,117,140,160,235,59,22,166,107,116,52,234,135,235,245,31,124,236,176,146,201,26,178,93,204,82,163,34,246,178,226,231,245,217,75,46,101,127,113,190,146,74,255,192,124,141,30,155,37,108,232,6,163,95,229,172,51,50,94,231,154,248,23,150,85,219,11,216,55,249,39,69,15,55,65,103,209,239,177,182,123,16,183,213,50,131,233,172,27,75,26,130,125,221,197,65,12,13,156,110,80,98,245,243,9,174,20,184,109,106,4,0,0 };
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

