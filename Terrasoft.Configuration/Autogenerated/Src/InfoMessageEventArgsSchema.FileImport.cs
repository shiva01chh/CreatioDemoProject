namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InfoMessageEventArgsSchema

	/// <exclude/>
	public class InfoMessageEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InfoMessageEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InfoMessageEventArgsSchema(InfoMessageEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e");
			Name = "InfoMessageEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,81,65,10,194,48,16,60,91,232,31,22,188,251,0,61,73,169,210,131,80,208,15,196,118,27,2,109,18,118,83,81,138,127,55,105,85,170,230,100,14,33,25,102,103,50,19,45,58,100,43,42,132,19,18,9,54,141,91,101,70,55,74,246,36,156,50,122,181,83,45,22,157,53,228,210,100,72,147,69,207,74,75,56,222,216,97,183,73,19,143,44,9,165,103,2,100,173,96,94,67,78,100,232,128,204,66,98,126,65,237,182,36,121,100,218,254,220,170,10,170,192,139,211,96,13,133,110,204,239,244,34,120,191,173,74,50,22,201,41,244,118,229,40,58,234,191,12,246,189,170,97,122,244,209,43,249,137,162,134,1,36,186,13,112,216,238,31,244,252,90,161,13,97,103,167,8,123,137,186,158,252,253,109,194,230,80,164,137,120,148,239,34,98,44,223,195,191,225,217,81,248,161,167,226,31,65,70,100,190,30,204,90,102,20,37,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("581d1ca8-4c25-474e-9e2b-79fe22e7b14e"));
		}

		#endregion

	}

	#endregion

}

