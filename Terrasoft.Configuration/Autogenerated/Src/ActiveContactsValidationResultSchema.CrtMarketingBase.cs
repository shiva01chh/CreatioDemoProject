namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationResultSchema

	/// <exclude/>
	public class ActiveContactsValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationResultSchema(ActiveContactsValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45311f20-f594-44c6-8b97-79025c4a6695");
			Name = "ActiveContactsValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,79,75,196,48,16,197,207,45,244,59,12,236,189,209,171,171,130,22,143,194,162,226,125,76,103,75,160,77,74,102,178,32,139,223,221,52,177,251,71,196,109,14,129,60,222,123,191,100,136,197,129,120,68,77,240,70,222,35,187,173,212,141,179,91,211,5,143,98,156,173,202,125,85,86,37,196,181,242,212,69,5,154,30,153,111,224,65,139,217,81,52,11,106,225,119,236,77,155,18,47,196,161,151,57,164,148,130,91,14,195,128,254,243,254,40,61,34,19,236,14,25,240,41,84,159,100,212,121,104,12,31,189,209,160,39,246,69,116,145,238,92,20,191,224,89,56,218,129,131,214,196,92,31,188,234,212,60,35,157,101,1,99,5,94,179,29,238,224,106,189,12,16,103,234,252,210,250,167,201,28,203,175,127,202,231,121,111,188,27,201,139,161,56,244,77,10,45,131,107,215,210,255,236,137,218,68,23,236,161,35,89,3,79,219,215,178,246,248,111,24,187,11,0,22,111,108,7,207,217,251,23,102,69,182,205,239,76,231,172,158,139,73,139,235,27,128,99,197,138,172,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45311f20-f594-44c6-8b97-79025c4a6695"));
		}

		#endregion

	}

	#endregion

}

