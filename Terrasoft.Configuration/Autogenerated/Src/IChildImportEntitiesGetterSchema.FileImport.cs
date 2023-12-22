namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IChildImportEntitiesGetterSchema

	/// <exclude/>
	public class IChildImportEntitiesGetterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IChildImportEntitiesGetterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IChildImportEntitiesGetterSchema(IChildImportEntitiesGetterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080");
			Name = "IChildImportEntitiesGetter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,144,193,110,195,32,12,64,207,141,148,127,64,61,109,23,248,128,177,92,162,174,202,109,82,247,3,148,57,29,18,56,145,13,135,168,218,191,15,146,37,205,134,56,128,253,236,135,65,19,128,71,99,65,124,0,145,225,161,143,178,29,176,119,183,68,38,186,1,229,155,243,208,133,113,160,88,87,247,186,58,36,118,120,19,151,137,35,132,140,122,15,182,112,44,207,128,64,206,190,108,204,190,35,129,60,97,116,209,1,103,32,35,99,186,122,103,133,195,8,212,23,127,215,126,57,255,185,152,86,244,12,49,167,51,93,196,7,165,148,208,156,66,48,52,53,107,32,35,44,108,41,21,240,91,37,55,88,253,167,245,104,200,4,129,121,234,215,227,124,134,44,224,99,179,120,197,35,36,181,154,47,143,82,130,152,8,185,105,255,202,180,90,19,133,236,78,152,2,144,185,122,208,243,20,83,83,158,248,180,244,127,223,218,239,76,207,229,199,190,235,42,239,253,250,1,155,19,141,164,154,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62efa7fa-c711-4c24-a8e7-b07f25c59080"));
		}

		#endregion

	}

	#endregion

}

