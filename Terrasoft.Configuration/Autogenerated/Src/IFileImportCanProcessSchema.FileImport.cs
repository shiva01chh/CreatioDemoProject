namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportCanProcessSchema

	/// <exclude/>
	public class IFileImportCanProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportCanProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportCanProcessSchema(IFileImportCanProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ebbb19c-387f-4ea6-9d4f-066fbfef8b64");
			Name = "IFileImportCanProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,143,193,10,131,48,16,68,207,6,242,15,57,182,23,127,160,71,219,130,183,66,253,129,152,174,118,33,217,149,108,114,40,197,127,175,90,193,22,247,52,12,51,111,88,178,1,100,176,14,76,3,49,90,225,46,149,21,83,135,125,142,54,33,83,121,69,15,117,24,56,38,173,222,90,21,89,144,250,191,116,132,242,66,9,19,130,156,180,154,34,67,110,61,58,131,148,32,118,51,187,222,32,149,165,91,100,7,34,83,112,230,21,45,179,55,155,125,88,88,175,187,123,66,176,21,251,28,200,192,206,58,126,151,118,229,117,100,201,156,65,18,210,242,133,121,108,122,173,142,90,141,179,248,189,15,110,21,229,11,14,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ebbb19c-387f-4ea6-9d4f-066fbfef8b64"));
		}

		#endregion

	}

	#endregion

}

