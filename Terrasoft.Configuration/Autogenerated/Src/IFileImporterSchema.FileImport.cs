namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImporterSchema

	/// <exclude/>
	public class IFileImporterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImporterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImporterSchema(IFileImporterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fa525843-9e33-4417-81db-be5e451e98f6");
			Name = "IFileImporter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,107,194,64,16,61,27,200,127,24,236,165,94,18,60,148,130,90,65,197,82,15,82,169,222,74,15,107,50,137,11,201,110,152,217,88,164,237,127,239,102,83,63,170,141,52,228,176,51,111,222,155,153,183,91,178,84,41,44,119,108,48,239,251,158,239,41,145,35,23,34,66,88,33,145,96,157,152,96,162,85,34,211,146,132,145,90,5,143,50,195,89,94,104,50,190,247,225,123,173,162,92,103,50,2,169,12,82,82,17,103,199,10,36,232,193,108,44,24,79,115,150,84,17,91,97,24,194,128,203,60,23,180,27,238,19,75,177,69,144,174,18,182,34,43,145,193,104,136,215,144,104,2,70,65,209,6,80,25,105,36,242,65,36,60,87,25,20,130,68,14,213,54,15,109,119,70,219,152,219,195,65,232,162,99,33,161,41,73,177,5,246,167,10,122,125,94,179,206,44,231,182,125,31,116,239,130,46,124,194,106,131,96,101,54,58,6,201,16,99,65,24,9,131,113,208,238,188,85,156,181,214,153,27,255,69,188,215,171,78,127,230,188,173,195,197,97,14,56,142,212,113,182,183,90,55,132,169,181,23,166,91,187,29,247,96,225,108,173,49,172,114,53,242,36,84,156,33,13,78,26,236,108,79,123,139,14,30,81,202,67,184,4,251,255,21,194,41,145,166,102,173,26,111,150,27,163,189,39,252,189,190,163,29,21,155,74,154,69,71,137,117,234,170,102,67,197,149,181,85,162,231,200,44,82,252,123,89,171,48,71,74,175,73,156,57,19,95,113,45,110,150,153,232,172,204,213,130,116,100,199,57,119,255,18,220,63,23,84,113,253,98,92,252,229,123,246,183,223,55,135,97,246,105,209,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fa525843-9e33-4417-81db-be5e451e98f6"));
		}

		#endregion

	}

	#endregion

}

