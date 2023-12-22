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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,74,195,64,16,134,207,21,124,135,161,94,90,144,4,60,106,91,208,74,165,23,17,180,94,196,195,118,51,169,11,201,110,156,157,21,138,248,238,78,54,141,54,177,10,230,146,221,225,159,127,102,190,76,172,42,209,87,74,35,60,32,145,242,46,231,100,238,108,110,54,129,20,27,103,147,133,41,112,89,86,142,248,248,232,253,248,104,16,188,177,27,184,223,122,198,242,226,235,190,159,77,248,91,60,89,40,205,142,12,122,81,136,230,132,112,35,53,96,94,40,239,207,97,81,56,197,103,115,87,132,210,222,145,211,232,189,163,40,76,211,20,38,198,190,32,25,206,156,6,77,152,79,135,81,223,147,15,211,89,171,247,161,44,21,109,219,251,165,5,99,61,43,43,195,186,28,248,197,120,208,117,97,144,3,9,5,103,189,89,23,8,185,35,168,26,191,122,132,166,43,208,177,14,188,169,34,160,79,218,26,233,94,145,167,107,204,85,40,248,202,216,76,18,71,188,173,208,229,163,101,175,195,241,41,220,10,117,152,130,149,151,8,14,142,61,30,63,139,101,21,214,133,209,187,54,15,234,96,135,237,7,181,193,123,36,247,205,88,198,99,10,53,127,65,125,23,141,27,197,127,225,254,160,27,3,115,66,197,232,187,140,133,128,40,17,247,61,251,19,136,105,242,229,154,246,109,39,149,34,85,70,84,211,97,240,72,50,135,69,93,175,230,112,182,146,187,124,152,54,144,76,210,168,142,201,59,116,7,75,142,86,29,35,232,250,142,133,233,90,121,28,245,195,245,250,15,62,118,88,209,102,13,217,46,102,169,81,33,177,172,248,121,125,102,201,197,236,47,206,87,82,233,31,152,175,21,171,102,9,27,186,193,154,87,57,155,12,45,155,220,32,253,194,178,106,123,1,247,38,255,164,232,225,38,152,44,250,61,214,118,15,226,182,90,102,48,157,117,99,73,67,176,175,187,56,136,161,129,211,13,74,108,255,249,4,203,120,144,57,114,4,0,0 };
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

