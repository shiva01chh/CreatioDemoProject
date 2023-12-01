namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportValidationServiceSchema

	/// <exclude/>
	public class IFileImportValidationServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportValidationServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportValidationServiceSchema(IFileImportValidationServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1");
			Name = "IFileImportValidationService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,65,106,195,48,16,60,59,144,63,44,206,197,1,227,7,164,244,210,66,192,5,55,33,14,205,33,228,160,216,107,87,212,150,84,73,14,152,210,191,119,35,217,73,11,197,186,8,141,102,118,102,119,5,107,209,40,86,32,236,81,107,102,100,101,147,103,41,42,94,119,154,89,46,69,178,230,13,166,173,146,218,206,103,95,243,89,208,25,46,106,200,123,99,177,77,114,212,23,94,96,38,75,108,30,166,62,147,3,158,137,64,148,133,198,154,234,66,42,44,234,138,156,87,144,222,61,222,88,195,75,103,60,168,157,230,56,60,40,153,213,172,176,209,43,197,134,71,8,39,132,225,242,68,74,213,157,27,94,0,31,205,38,189,128,4,215,22,111,25,51,180,239,178,52,43,216,186,50,46,75,112,220,40,244,179,25,227,156,28,76,29,166,226,34,63,48,242,178,107,190,237,38,223,135,49,236,240,179,67,99,215,82,183,204,18,78,212,12,141,97,53,122,40,121,49,82,196,240,36,203,62,183,125,131,127,40,55,52,57,104,166,20,150,241,213,46,8,118,180,56,41,12,78,87,117,83,8,254,107,122,212,195,0,97,116,103,13,3,25,114,131,246,247,210,111,48,88,160,40,253,132,232,245,237,183,250,11,34,132,206,15,84,24,205,6,90,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb43cabf-2447-44e4-b1b4-3716ee0c72e1"));
		}

		#endregion

	}

	#endregion

}

