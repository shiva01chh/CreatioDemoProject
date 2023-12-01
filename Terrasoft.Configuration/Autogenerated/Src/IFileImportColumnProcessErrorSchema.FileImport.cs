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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,13,228,14,57,65,47,160,8,82,42,118,39,212,11,196,56,45,129,100,38,204,36,130,20,239,110,90,23,10,14,159,89,252,63,111,62,218,8,146,172,3,115,5,102,43,52,229,182,35,156,252,92,216,102,79,216,158,124,128,33,38,226,172,213,162,85,83,196,227,108,198,167,100,136,59,173,170,147,202,45,120,103,60,102,224,105,125,53,124,153,142,66,137,120,97,114,32,210,51,19,87,96,49,27,215,192,3,48,155,126,221,103,139,247,0,188,255,191,223,226,35,207,114,48,191,246,167,250,165,85,85,157,55,65,81,156,65,200,0,0,0 };
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

