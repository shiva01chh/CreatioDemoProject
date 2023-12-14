namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: Float1ColumnProcessorSchema

	/// <exclude/>
	public class Float1ColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public Float1ColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public Float1ColumnProcessorSchema(Float1ColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c");
			Name = "Float1ColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aaf0cd3b-b0e9-4378-a805-7163759e3c5e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,21,252,14,67,223,165,5,73,240,170,109,65,43,149,94,68,208,190,139,188,195,116,51,169,11,201,110,152,221,21,138,248,221,157,108,26,109,210,60,193,92,178,59,252,231,63,51,191,76,12,150,228,42,84,4,207,196,140,206,230,62,89,90,147,235,93,96,244,218,154,100,165,11,90,151,149,101,127,126,246,126,126,54,10,78,155,29,60,237,157,167,242,250,235,126,156,205,244,191,120,178,66,229,45,107,114,162,16,205,31,166,157,212,128,101,129,206,93,193,170,176,232,47,151,182,8,165,121,100,171,200,57,203,81,152,166,41,204,180,121,37,214,62,179,10,20,83,62,31,71,125,79,62,78,23,173,222,133,178,68,222,183,247,27,3,218,56,143,70,134,181,57,248,87,237,64,213,133,65,14,44,20,172,113,122,91,16,228,150,161,106,252,234,17,154,174,64,197,58,240,134,69,32,151,180,53,210,163,34,47,119,148,99,40,252,173,54,153,36,78,252,190,34,155,79,214,189,14,167,23,240,32,212,97,14,70,94,34,24,28,123,58,253,39,150,85,216,22,90,29,218,28,212,193,1,219,9,181,209,123,36,247,205,88,198,243,28,106,254,130,250,49,26,55,138,223,194,61,161,27,3,75,38,244,228,186,140,133,128,40,137,142,61,251,19,136,105,242,229,154,246,109,103,21,50,150,17,213,124,28,28,177,204,97,72,213,171,57,94,108,228,46,31,166,13,36,179,52,170,99,242,1,221,96,201,201,166,99,4,93,223,169,48,221,162,163,73,63,92,175,255,232,227,128,149,76,214,144,237,98,150,26,21,177,151,21,191,170,207,94,114,41,251,137,243,173,84,26,198,92,181,233,96,223,228,55,210,25,193,125,208,25,220,161,199,191,245,26,62,11,222,205,58,131,249,162,27,75,154,161,251,186,235,193,206,155,121,186,65,137,213,207,39,137,36,58,219,29,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f839451-e4a5-40f4-bb65-4692bb45345c"));
		}

		#endregion

	}

	#endregion

}

