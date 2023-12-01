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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,65,11,194,48,12,133,207,43,244,63,244,168,48,246,7,60,14,133,157,149,221,107,201,102,160,109,70,154,30,68,252,239,118,115,176,137,33,135,199,123,47,31,137,54,64,154,172,3,115,3,102,155,104,144,166,165,56,224,152,217,10,82,108,46,232,161,11,19,177,104,245,210,170,202,9,227,248,211,102,104,206,81,80,16,210,73,171,82,153,242,221,163,51,24,5,120,152,217,221,6,105,25,172,64,75,62,135,152,74,119,70,86,107,180,152,102,223,56,44,224,231,213,61,32,88,195,68,242,149,181,217,7,235,33,252,89,181,217,147,123,235,51,24,183,233,99,121,183,122,107,85,182,204,7,98,233,33,30,11,1,0,0 };
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

