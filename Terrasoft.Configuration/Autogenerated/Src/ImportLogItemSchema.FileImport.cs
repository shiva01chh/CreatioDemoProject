namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportLogItemSchema

	/// <exclude/>
	public class ImportLogItemSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportLogItemSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportLogItemSchema(ImportLogItemSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("567fdcd5-bfe6-4534-8033-3043e6eaac3e");
			Name = "ImportLogItem";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,106,194,64,16,134,207,17,124,135,193,94,218,75,114,215,42,20,177,32,180,32,232,11,172,233,36,46,77,118,151,153,13,52,136,239,222,217,77,108,19,15,98,78,147,217,159,249,191,127,118,141,170,145,157,202,17,14,72,164,216,22,62,93,91,83,232,178,33,229,181,53,233,187,174,112,91,59,75,126,58,57,79,39,73,195,218,148,176,111,217,99,189,152,78,164,243,68,88,138,18,214,149,98,158,67,39,254,176,229,86,20,81,144,101,25,188,114,83,215,138,218,85,255,255,102,64,27,246,202,136,181,45,192,159,52,67,30,6,128,20,36,76,214,176,62,86,8,133,37,96,111,41,184,234,56,26,42,43,165,145,131,186,67,188,90,100,3,15,215,28,43,157,247,35,71,72,32,136,55,140,201,57,114,254,39,17,115,79,77,46,182,115,216,197,73,157,224,54,73,108,172,9,149,71,30,231,105,29,138,18,17,114,194,98,57,27,25,206,178,85,250,55,109,8,125,165,30,169,159,95,32,236,61,73,246,94,229,223,7,10,151,181,148,149,132,141,164,155,218,249,118,17,142,47,125,4,52,95,93,138,113,164,29,89,135,228,53,242,3,137,196,25,228,93,176,42,241,62,104,71,1,159,157,182,231,44,209,71,162,132,251,226,114,199,106,243,147,163,11,183,40,179,36,30,248,144,239,33,211,193,58,238,251,222,172,164,235,14,155,177,19,190,95,234,58,150,67,14,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("567fdcd5-bfe6-4534-8033-3043e6eaac3e"));
		}

		#endregion

	}

	#endregion

}

