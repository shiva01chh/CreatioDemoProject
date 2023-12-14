namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DecimalExcelCellWriterSchema

	/// <exclude/>
	public class DecimalExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DecimalExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DecimalExcelCellWriterSchema(DecimalExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("11e09c36-5811-41ad-acea-44711f05f95b");
			Name = "DecimalExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,203,78,235,48,16,93,7,137,127,24,193,166,108,146,61,5,22,148,135,88,0,87,106,197,189,91,55,153,20,35,63,162,177,83,202,69,252,59,99,59,141,74,66,33,82,164,204,120,206,204,57,199,19,35,52,186,70,148,8,11,36,18,206,214,62,159,89,83,203,85,75,194,75,107,242,235,77,99,201,47,236,245,166,68,117,120,240,126,120,144,181,78,154,21,204,223,156,71,61,29,196,249,173,178,75,161,228,255,136,230,83,62,63,38,92,113,0,51,37,156,59,133,43,44,165,22,42,54,156,161,82,55,150,180,240,30,41,22,23,69,1,103,174,213,90,208,219,69,23,119,8,192,0,1,126,21,188,146,100,68,190,5,20,59,136,166,93,42,89,66,25,166,141,134,253,141,56,56,133,75,225,112,144,101,108,144,215,243,253,67,182,65,242,18,153,52,127,123,44,61,86,145,228,136,101,72,100,143,13,26,216,104,5,174,225,169,53,115,48,173,94,242,180,58,42,4,105,106,155,247,232,93,202,89,179,109,15,15,17,146,60,185,99,0,132,174,255,180,26,229,223,97,133,126,10,31,137,208,49,154,42,209,238,226,239,52,68,99,122,1,103,210,60,35,11,175,108,9,69,98,145,156,179,107,222,5,89,33,12,174,104,20,159,95,12,83,121,231,247,244,103,86,188,98,206,83,91,122,75,3,94,29,133,239,175,109,114,2,241,130,178,125,158,156,131,193,215,177,133,9,148,165,124,215,122,142,141,224,21,183,196,160,163,252,40,86,124,132,109,206,126,113,244,30,253,179,173,118,87,2,126,178,180,47,234,93,101,229,225,127,73,252,158,132,106,113,98,151,47,92,4,235,16,108,53,174,5,65,149,184,198,34,230,201,182,113,19,159,47,108,39,98,146,16,145,118,70,232,91,50,95,48,92,57,143,211,38,123,28,59,217,167,184,203,237,166,56,19,158,79,134,231,124,218,51,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("11e09c36-5811-41ad-acea-44711f05f95b"));
		}

		#endregion

	}

	#endregion

}

