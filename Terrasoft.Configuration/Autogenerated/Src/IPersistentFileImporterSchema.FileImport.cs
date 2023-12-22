namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentFileImporterSchema

	/// <exclude/>
	public class IPersistentFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentFileImporterSchema(IPersistentFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ad942417-9bd3-4771-a7af-0535dd659ac6");
			Name = "IPersistentFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,77,79,195,48,12,134,207,155,180,255,96,109,23,144,80,123,103,165,7,198,135,122,64,66,218,196,61,107,220,45,90,155,84,249,64,76,19,255,29,55,233,186,14,202,14,72,244,210,250,141,253,198,79,220,72,86,161,169,89,142,176,66,173,153,81,133,141,22,74,22,98,227,52,179,66,201,232,73,148,152,85,181,210,22,14,147,241,200,25,33,55,176,220,27,139,213,252,91,28,173,182,26,25,39,129,86,104,109,166,113,67,22,144,73,139,186,160,77,110,33,123,69,109,4,37,75,123,50,70,237,211,71,181,91,151,34,7,113,76,255,45,27,200,231,158,25,60,211,14,193,163,219,244,5,237,86,113,211,170,113,28,67,98,92,85,49,189,79,59,229,1,75,180,8,5,249,64,161,85,5,34,128,214,76,211,185,144,171,137,78,213,241,143,242,196,231,129,164,220,187,105,209,53,179,68,99,168,131,140,79,211,246,224,76,80,64,240,40,137,125,81,48,121,87,130,183,77,52,44,87,207,142,226,1,163,235,249,69,140,55,86,10,206,8,196,213,165,98,28,131,71,4,255,218,187,55,209,104,157,150,38,77,226,227,215,137,107,177,197,124,151,153,6,204,55,120,145,142,138,46,0,62,126,96,238,136,175,29,207,122,255,167,9,153,30,27,63,114,13,64,245,107,172,218,161,156,166,171,230,5,133,210,144,51,153,99,217,118,50,48,205,192,22,88,187,13,111,96,225,203,74,127,165,130,153,119,238,163,207,80,242,240,239,54,225,103,152,248,153,56,25,123,181,255,124,1,54,21,252,31,192,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ad942417-9bd3-4771-a7af-0535dd659ac6"));
		}

		#endregion

	}

	#endregion

}

