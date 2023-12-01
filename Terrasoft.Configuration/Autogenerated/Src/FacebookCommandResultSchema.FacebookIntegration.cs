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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,141,49,10,195,48,12,69,231,4,114,7,67,247,28,32,221,106,232,212,169,233,5,20,71,49,166,182,148,90,246,80,66,239,94,39,129,12,165,218,244,120,143,79,16,80,102,48,168,30,24,35,8,79,169,213,76,147,179,57,66,114,76,109,207,198,129,111,234,165,169,171,44,142,172,186,22,125,96,126,158,15,210,191,37,97,104,111,142,94,5,22,124,138,104,75,172,180,7,145,238,40,52,135,0,52,222,81,178,79,155,56,231,193,59,163,204,234,253,215,84,167,46,32,248,147,86,203,150,127,246,53,164,113,31,92,223,194,202,125,1,96,120,127,230,217,0,0,0 };
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

