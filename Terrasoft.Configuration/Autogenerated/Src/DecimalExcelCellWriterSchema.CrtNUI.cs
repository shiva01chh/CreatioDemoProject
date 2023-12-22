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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,203,78,195,64,12,60,7,137,127,176,224,82,46,201,157,2,7,202,67,28,120,72,173,128,235,54,113,202,162,125,68,222,77,41,32,254,29,103,55,141,66,66,33,82,164,216,235,177,103,102,29,35,52,186,74,228,8,11,36,18,206,150,62,157,89,83,202,85,77,194,75,107,210,203,77,101,201,47,236,229,38,71,181,191,247,185,191,151,212,78,154,21,204,223,157,71,61,29,196,233,181,178,75,161,228,71,64,243,41,159,31,18,174,56,128,153,18,206,29,195,5,230,82,11,21,26,206,80,169,43,75,90,120,143,20,138,179,44,131,19,87,107,45,232,253,172,141,91,4,96,3,1,126,21,188,145,100,68,186,5,100,61,68,85,47,149,204,33,111,166,141,134,61,5,28,28,195,185,112,56,200,50,182,145,215,241,125,32,91,33,121,137,76,154,191,61,230,30,139,64,114,196,178,73,36,247,21,26,216,104,5,174,226,169,37,115,48,181,94,242,180,50,40,4,105,74,155,118,232,62,229,164,218,182,135,187,0,137,158,220,48,0,154,174,207,90,141,242,159,176,66,63,133,175,72,232,16,77,17,105,183,241,111,26,130,49,157,128,19,105,94,144,133,23,54,135,44,178,136,206,217,53,239,130,44,16,6,87,52,138,79,207,134,169,180,245,123,250,55,43,94,49,231,169,206,189,165,1,175,150,194,239,215,54,57,130,112,65,201,46,79,78,193,224,219,216,194,8,74,98,190,109,61,199,74,240,138,91,98,208,65,122,16,42,190,154,109,78,254,113,244,22,253,139,45,250,43,1,127,89,218,21,117,174,178,242,230,127,137,252,30,133,170,113,98,151,175,92,4,235,38,216,106,92,11,130,34,114,13,69,204,147,109,227,38,62,93,216,86,196,36,34,2,237,132,208,215,100,126,96,184,114,30,166,77,118,56,118,180,75,113,155,235,167,56,211,127,190,1,136,125,95,47,59,4,0,0 };
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

