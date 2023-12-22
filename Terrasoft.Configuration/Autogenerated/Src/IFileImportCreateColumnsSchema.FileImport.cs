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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,205,10,194,64,12,132,207,93,216,119,216,163,66,233,11,120,44,10,61,43,222,227,146,106,96,127,74,54,123,16,241,221,221,214,66,87,12,57,12,51,147,143,4,240,152,38,176,104,46,200,12,41,142,210,245,49,140,116,207,12,66,49,116,39,114,56,248,41,178,104,245,210,170,201,137,194,253,167,205,216,29,131,144,16,166,131,86,165,50,229,155,35,107,40,8,242,56,179,135,13,210,51,130,96,31,93,246,33,149,238,140,108,214,104,49,77,221,216,45,224,231,217,62,208,131,225,24,229,43,91,83,7,235,33,254,89,173,169,201,87,112,25,141,221,244,190,188,219,188,181,42,91,207,7,252,68,176,107,20,1,0,0 };
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

