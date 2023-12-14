namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportCreateColumnsSchema

	/// <exclude/>
	public class IFileImportCreateColumnsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportCreateColumnsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportCreateColumnsSchema(IFileImportCreateColumnsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("23856807-8b4a-4f1f-8589-38bbae2e4f42");
			Name = "IFileImportCreateColumns";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,205,10,194,64,12,132,207,93,216,119,216,163,66,233,11,120,44,10,61,43,189,199,37,173,129,253,41,217,236,65,196,119,119,91,11,173,24,114,24,102,38,31,9,224,49,77,96,209,220,144,25,82,28,164,105,99,24,104,204,12,66,49,52,23,114,216,249,41,178,104,245,210,170,202,137,194,248,211,102,108,206,65,72,8,211,73,171,82,153,242,221,145,53,20,4,121,152,217,221,6,105,25,65,176,141,46,251,144,74,119,70,86,107,180,152,102,223,56,44,224,231,213,62,208,131,225,24,229,43,107,179,15,214,67,252,179,106,179,39,247,224,50,26,187,233,99,121,183,122,107,85,118,158,15,14,39,117,145,12,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("23856807-8b4a-4f1f-8589-38bbae2e4f42"));
		}

		#endregion

	}

	#endregion

}

