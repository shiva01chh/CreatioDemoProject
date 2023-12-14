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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,65,106,195,48,16,60,43,144,63,44,206,37,1,227,7,164,244,210,66,192,5,55,33,14,205,33,228,160,88,107,87,212,150,92,73,14,152,210,191,119,109,217,73,11,197,186,8,141,102,118,102,119,21,175,208,214,60,67,56,160,49,220,234,220,69,207,90,229,178,104,12,119,82,171,104,35,75,140,171,90,27,55,159,125,205,103,172,177,82,21,144,182,214,97,21,165,104,174,50,195,68,11,44,31,166,62,163,35,94,136,64,148,133,193,130,234,66,172,28,154,156,156,215,16,223,61,222,120,41,69,111,60,168,123,205,105,120,80,50,103,120,230,150,175,20,27,30,33,152,16,6,171,51,41,235,230,82,202,12,228,104,54,233,5,36,232,90,188,101,76,208,189,107,97,215,176,235,203,244,89,216,105,91,163,159,205,24,231,220,195,212,97,172,174,250,3,151,94,214,229,219,109,211,67,16,194,30,63,27,180,110,163,77,197,29,225,68,77,208,90,94,160,135,162,23,171,85,8,79,90,180,169,107,75,252,67,185,161,209,209,240,186,70,17,118,118,140,237,105,113,90,89,156,174,218,79,129,253,215,244,168,135,1,194,229,157,53,12,100,200,13,198,223,43,191,65,182,64,37,252,132,232,245,237,183,250,11,34,164,59,63,102,94,215,94,91,2,0,0 };
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

