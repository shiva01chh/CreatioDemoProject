namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoSchema

	/// <exclude/>
	public class ISysCultureInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoSchema(ISysCultureInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8");
			Name = "ISysCultureInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,61,107,195,48,16,157,109,240,127,56,200,110,239,73,233,226,161,104,41,129,134,238,170,117,82,5,214,201,156,36,104,8,253,239,149,229,38,184,148,16,172,73,122,247,62,116,119,36,29,134,73,14,8,39,100,150,193,235,216,246,158,180,53,137,101,180,158,218,19,75,10,99,185,55,245,165,169,171,20,44,25,120,59,135,136,238,208,212,25,217,49,154,92,6,65,17,89,103,179,61,136,92,239,211,24,19,163,32,237,11,109,74,31,163,29,192,94,89,255,73,213,165,16,111,134,71,246,19,114,180,24,246,112,44,234,165,222,117,29,60,133,228,156,228,243,243,21,88,126,4,195,98,8,86,33,69,171,45,114,123,147,116,107,205,75,178,10,132,130,185,167,170,50,24,15,243,229,123,67,2,41,252,186,99,158,155,204,227,200,245,13,246,171,73,195,224,199,228,8,40,175,231,78,66,136,60,239,97,37,234,139,230,53,75,54,132,190,35,231,33,13,27,83,215,170,71,177,191,18,17,250,79,73,6,213,35,254,14,73,45,251,47,239,5,253,11,22,108,62,63,55,80,97,36,191,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8"));
		}

		#endregion

	}

	#endregion

}

