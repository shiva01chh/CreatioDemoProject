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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,77,111,194,48,12,134,207,32,241,31,44,184,108,210,212,222,71,215,195,216,135,122,152,52,9,180,123,104,28,136,104,147,42,31,211,16,218,127,159,155,148,2,27,227,48,105,189,180,126,99,191,241,19,55,138,213,104,27,86,34,44,208,24,102,181,112,201,76,43,33,87,222,48,39,181,74,158,100,133,69,221,104,227,96,55,26,14,188,149,106,5,243,173,117,88,79,191,197,201,98,109,144,113,18,104,133,214,38,6,87,100,1,133,114,104,4,109,114,11,197,43,26,43,41,89,185,131,49,154,144,62,104,252,178,146,37,200,125,250,111,217,64,62,247,204,226,137,182,139,30,253,166,47,232,214,154,219,78,77,211,20,50,235,235,154,153,109,222,43,15,88,161,67,16,228,3,194,232,26,100,4,109,152,161,115,33,87,155,28,170,211,31,229,89,200,3,69,185,119,99,209,55,51,71,107,169,131,130,143,243,238,224,108,84,64,242,36,75,67,81,52,121,215,146,119,77,180,44,87,207,158,226,51,70,215,211,139,24,111,172,146,156,17,136,111,42,205,56,70,143,4,254,181,247,96,98,208,121,163,108,158,165,251,175,3,215,108,141,229,166,176,45,88,104,240,34,29,21,93,0,124,252,192,210,19,95,55,158,229,246,79,19,178,71,108,124,207,117,6,234,184,198,233,13,170,113,190,104,95,32,180,129,146,169,18,171,174,147,51,211,140,108,145,181,223,240,6,102,161,172,10,87,42,154,5,231,99,244,9,42,30,255,221,54,252,140,19,63,17,71,195,160,182,207,23,117,243,73,249,184,3,0,0 };
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

