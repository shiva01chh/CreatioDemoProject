namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float2ColumnProcessorSchema

	/// <exclude/>
	public class Float2ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float2ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float2ColumnProcessorSchema(Float2ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("66ad8406-fee7-4774-941e-8dbeb16b8a1a");
			Name = "Float2ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,4,60,106,91,208,74,165,23,17,180,94,196,195,118,51,169,3,201,110,156,221,21,138,248,238,78,54,141,54,177,10,230,146,221,225,159,127,102,190,76,140,42,209,85,74,35,60,32,179,114,54,247,201,220,154,156,54,129,149,39,107,146,5,21,184,44,43,203,254,248,232,253,248,104,16,28,153,13,220,111,157,199,242,226,235,190,159,205,248,91,60,89,40,237,45,19,58,81,136,230,132,113,35,53,96,94,40,231,206,97,81,88,229,207,230,182,8,165,185,99,171,209,57,203,81,152,166,41,76,200,188,32,147,207,172,6,205,152,79,135,81,223,147,15,211,89,171,119,161,44,21,111,219,251,165,1,50,206,43,35,195,218,28,252,11,57,208,117,97,144,3,11,5,107,28,173,11,132,220,50,84,141,95,61,66,211,21,232,88,7,222,84,17,208,37,109,141,116,175,200,211,53,230,42,20,254,138,76,38,137,35,191,173,208,230,163,101,175,195,241,41,220,10,117,152,130,145,151,8,14,142,61,30,63,139,101,21,214,5,233,93,155,7,117,176,195,246,131,218,224,61,146,251,102,44,227,121,14,53,127,65,125,23,141,27,197,127,225,254,160,27,3,115,70,229,209,117,25,11,1,81,34,238,123,246,39,16,211,228,203,53,237,219,78,42,197,170,140,168,166,195,224,144,101,14,131,186,94,205,225,108,37,119,249,48,109,32,153,164,81,29,147,119,232,14,150,28,173,58,70,208,245,29,11,211,181,114,56,234,135,235,245,31,124,236,176,162,201,26,178,93,204,82,163,66,246,178,226,231,245,217,75,46,102,127,113,190,146,74,255,192,124,173,188,106,150,176,161,27,12,189,202,153,50,52,158,114,66,254,133,101,213,246,2,246,77,254,73,209,195,77,160,44,250,61,214,118,15,226,182,90,102,48,157,117,99,73,67,176,175,187,56,136,161,129,211,13,74,76,158,79,187,204,72,124,105,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("66ad8406-fee7-4774-941e-8dbeb16b8a1a"));
		}

		#endregion

	}

	#endregion

}

