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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,77,79,195,48,12,61,23,137,255,96,141,203,184,180,119,6,28,24,3,113,224,67,218,4,92,179,214,29,65,249,168,156,116,12,16,255,29,55,233,170,209,50,168,84,169,118,252,236,247,94,92,35,52,186,74,228,8,11,36,18,206,150,62,157,90,83,202,85,77,194,75,107,210,217,166,178,228,23,118,182,201,81,29,30,124,30,30,36,181,147,102,5,243,119,231,81,79,122,113,122,173,236,82,40,249,17,208,124,202,231,71,132,43,14,96,170,132,115,39,112,137,185,212,66,133,134,83,84,234,202,146,22,222,35,133,226,44,203,224,212,213,90,11,122,63,111,227,22,1,216,64,128,95,5,111,36,25,145,110,1,217,14,162,170,151,74,230,144,55,211,6,195,158,2,14,78,224,66,56,236,101,25,219,200,235,248,62,144,173,144,188,68,38,205,223,30,115,143,69,32,57,96,217,36,146,251,10,13,108,180,2,87,241,212,146,57,152,90,47,121,90,25,20,130,52,165,77,59,244,46,229,164,218,182,135,187,0,137,158,220,48,0,154,174,207,90,13,242,159,176,66,63,129,175,72,232,8,77,17,105,183,241,111,26,130,49,157,128,83,105,94,144,133,23,54,135,44,178,136,206,217,53,239,130,44,16,122,87,52,136,207,206,251,169,180,245,123,242,55,43,94,49,231,169,206,189,165,30,175,150,194,239,215,54,62,134,112,65,201,62,79,206,192,224,219,208,194,8,74,98,190,109,61,199,74,240,138,91,98,208,40,29,133,138,175,102,155,147,127,28,189,69,255,98,139,221,149,128,191,44,237,138,58,87,89,121,243,191,68,126,143,66,213,56,182,203,87,46,130,117,19,108,53,174,5,65,17,185,134,34,230,201,182,113,19,159,46,108,43,98,28,17,129,118,66,232,107,50,63,48,92,57,15,211,198,123,28,59,222,167,184,205,237,166,56,195,207,55,71,38,53,19,50,4,0,0 };
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

