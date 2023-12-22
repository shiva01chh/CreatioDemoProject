namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportFactorySchema

	/// <exclude/>
	public class IFileImportFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportFactorySchema(IFileImportFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d");
			Name = "IFileImportFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,77,107,132,48,16,61,43,248,31,6,123,233,66,209,123,107,133,101,169,197,219,30,218,31,144,213,81,2,38,145,73,82,144,210,255,222,137,110,221,117,187,185,229,49,239,99,222,104,161,208,142,162,65,248,64,34,97,77,231,178,131,209,157,236,61,9,39,141,206,42,57,96,173,70,67,46,137,191,147,24,248,121,43,117,191,33,16,190,36,113,18,71,15,132,61,147,160,214,14,169,99,217,103,168,47,2,149,104,156,161,41,76,242,108,158,231,80,88,175,148,160,169,60,255,87,30,116,134,224,228,229,208,6,43,212,78,58,137,22,156,129,139,92,246,39,146,95,169,140,254,52,200,6,228,42,116,207,63,226,69,162,127,1,102,224,29,29,140,36,3,182,216,78,208,73,221,34,101,43,37,191,229,20,163,32,161,64,115,151,175,169,183,72,220,160,198,38,212,151,150,139,53,4,24,44,58,199,251,216,172,200,103,202,125,133,198,12,94,105,123,36,211,160,181,134,210,242,176,32,240,37,6,143,54,219,208,235,227,146,246,109,14,91,205,89,195,22,119,224,199,207,77,54,216,70,125,130,250,236,179,239,123,190,163,224,174,246,173,24,185,72,184,141,180,227,115,71,63,203,201,81,183,203,213,195,151,177,235,247,11,218,243,93,50,95,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d"));
		}

		#endregion

	}

	#endregion

}

