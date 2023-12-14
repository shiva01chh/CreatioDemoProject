namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandResultSchema

	/// <exclude/>
	public class FacebookCommandResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandResultSchema(FacebookCommandResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fbe4dcf3-dfa9-4277-a9bc-ff9fbac967cf");
			Name = "FacebookCommandResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,141,49,10,195,48,12,69,231,4,114,7,67,119,31,32,221,26,232,212,169,233,5,20,71,49,166,182,148,90,246,80,66,239,94,39,129,12,165,218,244,120,143,79,16,80,102,48,168,30,24,35,8,79,73,119,76,147,179,57,66,114,76,186,103,227,192,55,245,210,212,85,22,71,86,93,139,62,48,63,207,7,233,223,146,48,232,155,163,87,129,5,159,34,218,18,171,206,131,72,123,20,29,135,0,52,222,81,178,79,155,56,231,193,59,163,204,234,253,215,84,171,46,32,248,147,86,203,150,127,246,53,164,113,31,92,223,194,214,251,2,179,24,131,127,218,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fbe4dcf3-dfa9-4277-a9bc-ff9fbac967cf"));
		}

		#endregion

	}

	#endregion

}

