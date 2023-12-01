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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,143,193,10,194,48,16,68,207,13,228,31,114,212,75,127,192,99,85,232,77,208,31,72,227,182,46,36,187,37,155,28,68,250,239,54,181,80,164,123,26,134,153,55,44,217,0,50,90,7,230,1,49,90,225,62,213,13,83,143,67,142,54,33,83,125,69,15,109,24,57,38,173,62,90,85,89,144,134,191,116,132,250,66,9,19,130,156,180,154,35,99,238,60,58,131,148,32,246,133,221,110,144,198,210,45,178,3,145,57,88,120,85,199,236,205,102,31,22,214,251,238,94,16,108,195,62,7,50,176,179,142,191,165,93,121,29,89,50,103,144,132,180,124,97,158,155,94,171,147,86,83,17,243,125,1,104,106,82,182,5,1,0,0 };
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

