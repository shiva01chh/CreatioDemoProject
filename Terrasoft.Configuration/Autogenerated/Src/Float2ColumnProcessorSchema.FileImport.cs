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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,4,60,106,91,208,74,165,23,17,180,94,196,195,116,51,169,11,201,110,156,221,21,138,248,238,78,54,141,54,177,10,230,146,221,225,159,127,102,190,76,12,150,228,42,84,4,15,196,140,206,230,62,153,91,147,235,77,96,244,218,154,100,161,11,90,150,149,101,127,124,244,126,124,52,8,78,155,13,220,111,157,167,242,226,235,190,159,205,244,91,60,89,160,242,150,53,57,81,136,230,132,105,35,53,96,94,160,115,231,176,40,44,250,179,185,45,66,105,238,216,42,114,206,114,20,166,105,10,19,109,94,136,181,207,172,2,197,148,79,135,81,223,147,15,211,89,171,119,161,44,145,183,237,253,210,128,54,206,163,145,97,109,14,254,69,59,80,117,97,144,3,11,5,107,156,94,23,4,185,101,168,26,191,122,132,166,43,80,177,14,188,97,17,200,37,109,141,116,175,200,211,53,229,24,10,127,165,77,38,137,35,191,173,200,230,163,101,175,195,241,41,220,10,117,152,130,145,151,8,14,142,61,30,63,139,101,21,214,133,86,187,54,15,234,96,135,237,7,181,193,123,36,247,205,88,198,243,28,106,254,130,250,46,26,55,138,255,194,253,65,55,6,230,76,232,201,117,25,11,1,81,18,237,123,246,39,16,211,228,203,53,237,219,78,42,100,44,35,170,233,48,56,98,153,195,144,170,87,115,56,91,201,93,62,76,27,72,38,105,84,199,228,29,186,131,37,71,171,142,17,116,125,199,194,116,141,142,70,253,112,189,254,131,143,29,86,50,89,67,182,139,89,106,84,196,94,86,252,188,62,123,201,165,236,47,206,87,82,233,31,152,175,209,99,179,132,13,221,96,244,171,156,117,70,198,235,92,19,255,194,178,106,123,1,251,38,255,164,232,225,38,232,44,250,61,214,118,15,226,182,90,102,48,157,117,99,73,67,176,175,187,56,136,161,129,211,13,74,172,126,62,1,91,36,24,110,106,4,0,0 };
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

