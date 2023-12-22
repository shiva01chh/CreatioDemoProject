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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,141,65,10,131,48,16,69,215,10,222,33,208,189,7,176,187,6,186,234,170,246,2,99,28,37,52,153,177,153,100,33,210,187,55,42,72,41,157,221,60,222,227,19,120,148,9,12,170,7,134,0,194,67,172,53,211,96,199,20,32,90,166,186,101,99,193,85,229,82,149,69,18,75,163,186,102,189,99,126,158,15,210,206,18,209,215,55,75,175,12,51,62,5,28,115,172,180,3,145,230,40,52,123,15,212,223,81,146,139,155,56,165,206,89,163,204,234,253,215,84,163,46,32,248,147,22,203,150,191,247,53,164,126,31,92,223,204,190,239,3,139,209,71,44,226,0,0,0 };
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

