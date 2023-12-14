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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,81,75,195,48,16,126,94,161,255,225,216,94,38,72,251,174,115,32,163,98,193,193,64,255,64,214,94,99,164,201,149,75,58,28,226,127,55,73,237,196,169,160,8,11,121,201,221,119,223,119,223,229,140,208,104,59,81,33,60,32,179,176,212,184,108,69,166,81,178,103,225,20,153,236,70,181,88,234,142,216,165,201,75,154,76,186,126,219,170,10,148,113,200,77,40,44,135,236,29,73,137,236,1,1,52,153,49,74,95,13,107,116,143,84,219,11,216,196,178,52,9,201,60,207,97,97,123,173,5,239,151,99,224,86,152,186,69,11,190,13,226,236,0,203,143,113,139,78,176,208,96,124,227,87,83,139,166,70,158,46,23,121,140,126,15,194,29,26,119,205,210,126,198,237,72,213,239,170,69,208,156,211,246,9,43,7,3,231,57,172,168,237,181,217,48,85,104,109,68,20,35,17,28,40,207,46,127,99,233,185,194,46,14,243,196,182,70,221,99,107,195,143,21,198,41,183,191,23,59,252,151,59,101,26,98,29,151,5,252,50,89,33,241,196,62,75,223,193,122,80,254,226,244,35,245,87,127,97,48,22,90,146,63,184,137,13,4,144,223,252,249,200,52,243,186,195,234,199,247,107,154,248,27,206,27,58,33,202,148,105,3,0,0 };
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

