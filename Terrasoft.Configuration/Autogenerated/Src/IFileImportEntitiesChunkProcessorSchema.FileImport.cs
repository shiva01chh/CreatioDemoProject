namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportEntitiesChunkProcessorSchema

	/// <exclude/>
	public class IFileImportEntitiesChunkProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportEntitiesChunkProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportEntitiesChunkProcessorSchema(IFileImportEntitiesChunkProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cea1c9a4-d455-4ca6-92a0-f145d998b68e");
			Name = "IFileImportEntitiesChunkProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,106,131,64,16,134,207,17,242,14,67,114,105,47,122,79,173,80,130,165,30,10,66,250,2,27,29,205,82,221,149,153,85,42,165,239,222,117,53,166,181,37,100,47,178,255,255,207,183,59,179,42,81,35,55,34,67,120,67,34,193,186,48,254,94,171,66,150,45,9,35,181,242,159,101,133,73,221,104,50,107,239,115,237,173,90,150,170,132,67,207,6,235,135,181,103,149,45,97,105,147,0,137,50,72,133,133,237,32,185,148,197,202,72,35,145,247,167,86,189,167,164,51,100,214,228,42,155,246,88,201,12,228,185,238,150,178,213,112,137,249,204,184,67,101,24,118,144,58,212,96,225,32,141,198,139,80,121,133,20,254,32,246,7,209,97,238,220,39,42,57,130,63,222,216,212,45,152,152,72,211,21,148,243,39,220,22,85,62,222,121,218,79,13,188,162,57,233,156,47,13,12,102,16,4,16,114,91,215,130,250,232,44,196,31,152,181,6,65,186,83,0,167,249,192,177,135,70,48,99,110,63,100,159,211,206,146,253,153,18,44,49,161,75,129,178,201,199,205,200,74,231,186,77,20,6,206,119,241,78,203,28,166,209,187,103,184,75,22,121,88,2,238,255,111,247,107,252,81,126,137,78,179,235,27,221,45,247,231,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cea1c9a4-d455-4ca6-92a0-f145d998b68e"));
		}

		#endregion

	}

	#endregion

}

