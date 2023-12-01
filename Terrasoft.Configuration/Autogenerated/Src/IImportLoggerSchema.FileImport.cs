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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,81,75,195,48,16,126,94,161,255,225,216,94,38,72,251,174,117,32,163,98,193,193,64,255,64,214,94,99,164,201,149,75,90,28,226,127,55,77,237,196,169,160,8,11,121,201,221,119,223,119,223,229,140,208,104,91,81,34,60,32,179,176,84,187,100,77,166,86,178,99,225,20,153,228,70,53,88,232,150,216,197,209,75,28,205,218,110,215,168,18,148,113,200,245,80,88,140,217,59,146,18,217,3,6,208,108,193,40,125,53,108,208,61,82,101,47,96,27,202,226,104,72,166,105,10,153,237,180,22,188,95,77,129,91,97,170,6,45,248,54,136,147,3,44,61,198,101,173,96,161,193,248,198,175,230,22,77,133,60,95,101,105,136,126,15,194,30,141,187,102,105,63,227,122,82,213,187,106,62,104,46,105,247,132,165,131,145,243,28,214,212,116,218,108,153,74,180,54,32,242,137,8,14,148,103,151,191,177,244,92,98,27,134,121,98,91,147,238,177,181,241,199,114,227,148,219,223,139,30,255,229,78,153,154,88,135,101,1,191,76,86,72,60,177,207,194,119,176,25,149,191,56,253,72,253,213,223,48,24,11,13,201,31,220,132,6,6,144,223,252,229,196,180,240,186,227,234,135,247,107,28,249,235,207,27,165,206,112,161,104,3,0,0 };
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

