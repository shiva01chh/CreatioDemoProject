namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportColumnProcessErrorSchema

	/// <exclude/>
	public class IFileImportColumnProcessErrorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportColumnProcessErrorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportColumnProcessErrorSchema(IFileImportColumnProcessErrorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27561062-e504-4d29-b9de-042dd1879b77");
			Name = "IFileImportColumnProcessError";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,13,228,14,57,65,47,160,8,82,42,118,39,212,11,196,56,13,129,100,166,204,36,130,20,239,110,90,23,10,14,159,89,252,63,111,62,218,4,50,91,7,230,10,204,86,104,202,109,71,56,5,95,216,230,64,216,158,66,132,33,205,196,89,171,69,171,166,72,64,111,198,167,100,72,59,173,170,51,151,91,12,206,4,204,192,211,250,106,248,50,29,197,146,240,194,228,64,164,103,38,174,192,98,54,174,129,7,96,54,253,186,207,22,239,17,120,255,127,191,197,71,246,114,48,191,246,167,250,165,85,213,58,111,196,235,77,51,201,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27561062-e504-4d29-b9de-042dd1879b77"));
		}

		#endregion

	}

	#endregion

}

