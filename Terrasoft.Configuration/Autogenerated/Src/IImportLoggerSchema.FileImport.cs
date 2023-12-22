namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportLoggerSchema

	/// <exclude/>
	public class IImportLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportLoggerSchema(IImportLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b874d1d-c36b-481a-b709-ada9ef850f84");
			Name = "IImportLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,81,75,195,48,16,126,94,161,255,225,216,94,38,72,251,174,115,32,163,98,193,193,64,255,64,214,94,99,164,201,149,75,90,28,226,127,55,77,237,212,57,65,17,22,242,146,187,239,190,239,190,203,25,161,209,54,162,64,120,64,102,97,169,114,201,138,76,165,100,203,194,41,50,201,141,170,49,215,13,177,139,163,151,56,154,52,237,182,86,5,40,227,144,171,190,48,31,178,119,36,37,178,7,244,160,201,140,81,250,106,88,163,123,164,210,94,192,38,148,197,81,159,76,211,20,22,182,213,90,240,110,57,6,110,133,41,107,180,224,219,32,78,246,176,244,16,183,104,4,11,13,198,55,126,53,181,104,74,228,233,114,145,134,232,113,16,118,104,220,53,75,251,21,215,145,42,223,85,179,94,115,78,219,39,44,28,12,156,231,176,162,186,213,102,195,84,160,181,1,145,141,68,176,167,60,187,252,141,165,231,2,155,48,204,19,219,26,117,15,173,13,63,150,25,167,220,238,94,116,248,47,119,202,84,196,58,44,11,248,101,178,66,226,137,125,230,190,131,245,160,252,205,233,71,234,175,254,250,193,88,168,73,254,224,38,52,208,131,252,230,207,71,166,153,215,29,86,63,188,95,227,200,223,207,231,13,145,2,155,42,113,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b874d1d-c36b-481a-b709-ada9ef850f84"));
		}

		#endregion

	}

	#endregion

}

