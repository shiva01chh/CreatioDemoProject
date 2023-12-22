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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,141,65,10,194,48,16,69,215,13,228,14,57,65,47,160,8,82,42,118,39,232,5,98,157,132,64,50,83,102,18,65,138,119,55,173,11,11,14,159,89,252,63,111,62,218,4,50,217,17,204,13,152,173,144,203,109,71,232,130,47,108,115,32,108,79,33,194,144,38,226,172,213,172,85,83,36,160,55,215,151,100,72,59,173,170,51,149,123,12,163,9,152,129,221,242,106,248,49,29,197,146,240,194,52,130,72,207,76,92,129,217,172,92,3,79,192,108,250,101,159,45,62,34,240,254,255,126,141,143,236,229,96,182,246,183,250,173,85,213,118,62,202,163,165,105,209,0,0,0 };
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

