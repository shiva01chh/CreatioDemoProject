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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,9,244,63,12,217,75,2,197,62,116,79,109,18,104,83,178,228,82,10,109,122,41,123,80,228,113,42,176,37,239,140,84,8,101,255,251,142,229,56,141,221,116,33,190,88,26,158,222,211,124,30,91,85,34,87,74,35,60,35,145,98,151,251,100,225,108,110,182,129,148,55,206,38,75,83,224,170,172,28,249,139,225,199,197,112,16,216,216,45,60,237,216,99,121,115,216,31,159,38,252,174,158,44,149,246,142,12,178,40,68,243,131,112,43,25,176,40,20,243,53,44,11,167,252,213,194,21,161,180,143,228,52,50,59,138,194,52,77,97,106,236,27,146,241,153,211,160,9,243,217,40,234,123,242,81,58,111,245,28,202,82,209,174,221,223,90,48,150,189,178,210,172,203,193,191,25,6,93,7,131,44,72,40,56,203,102,83,32,228,142,160,106,252,234,22,154,91,129,142,57,240,174,138,128,156,180,25,233,81,200,235,61,230,42,20,254,206,216,76,14,142,253,174,66,151,143,87,189,27,78,46,225,65,168,195,12,172,188,68,16,3,126,246,85,147,223,98,89,133,77,97,244,254,154,39,117,176,199,246,133,218,224,35,146,251,100,44,237,121,10,53,127,65,253,24,141,27,197,185,112,191,208,141,133,5,161,242,200,93,198,66,64,148,136,199,158,253,14,196,52,57,184,166,125,219,105,165,72,149,17,213,108,20,24,73,250,176,168,235,209,28,205,215,178,151,15,211,22,146,105,26,213,241,240,30,221,201,200,241,186,99,4,93,223,137,48,221,40,198,113,191,92,143,255,224,239,30,43,218,172,33,219,197,44,25,21,146,151,17,191,174,215,94,206,98,246,63,206,119,146,116,6,230,123,229,85,51,132,13,221,96,205,31,89,155,12,173,55,185,65,250,134,101,213,222,5,220,187,252,147,162,135,95,193,100,209,239,165,182,123,22,183,245,42,131,217,188,91,75,26,130,125,221,205,73,12,13,156,110,81,106,199,207,63,91,114,205,92,114,4,0,0 };
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

