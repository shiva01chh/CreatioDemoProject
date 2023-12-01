namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportTagManagerSchema

	/// <exclude/>
	public class IFileImportTagManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportTagManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportTagManagerSchema(IFileImportTagManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7");
			Name = "IFileImportTagManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,147,77,78,195,48,16,133,215,141,148,59,140,186,1,36,148,28,128,80,169,148,34,117,1,27,202,1,166,241,56,24,197,118,228,113,34,69,136,187,99,231,135,63,21,9,118,181,188,112,172,111,94,230,61,219,6,53,113,131,37,193,158,156,67,182,210,103,27,107,164,170,90,135,94,89,147,221,169,154,118,186,177,206,167,201,107,154,44,154,246,80,171,18,148,241,228,100,44,220,125,18,123,172,238,209,96,69,46,128,17,94,228,121,14,5,183,90,163,235,87,243,198,198,17,122,98,240,88,113,246,65,229,63,177,162,65,135,26,76,104,241,122,201,100,4,185,229,106,219,145,241,48,126,129,61,188,80,233,179,34,31,200,227,133,232,42,158,203,194,186,213,97,193,223,74,58,171,196,212,83,48,192,231,163,234,244,143,75,184,33,105,221,100,112,107,188,242,138,248,17,59,26,36,215,65,61,202,242,197,85,154,252,106,56,226,1,171,235,193,50,4,61,32,44,159,65,13,162,36,128,162,110,127,42,89,12,238,134,142,142,229,241,37,137,62,146,226,31,65,220,82,77,243,201,131,146,163,239,144,39,8,75,108,206,252,148,200,169,4,49,182,251,96,253,19,147,56,150,197,90,134,87,240,199,171,241,150,38,97,134,241,14,28,218,232,189,116,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee7c80a9-3a5c-4e84-9235-9be88e7c35d7"));
		}

		#endregion

	}

	#endregion

}

