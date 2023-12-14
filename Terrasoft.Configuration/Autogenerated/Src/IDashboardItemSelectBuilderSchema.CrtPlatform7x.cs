namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDashboardItemSelectBuilderSchema

	/// <exclude/>
	public class IDashboardItemSelectBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDashboardItemSelectBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDashboardItemSelectBuilderSchema(IDashboardItemSelectBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4e4bbf9b-4e63-40a8-8dcf-802e271ecd52");
			Name = "IDashboardItemSelectBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,61,110,195,48,12,133,231,4,200,29,56,182,64,97,31,32,65,134,216,65,145,161,83,122,1,218,166,29,21,250,113,73,9,133,97,244,238,165,101,52,237,210,106,208,240,168,247,222,71,121,116,36,35,182,4,175,196,140,18,250,88,84,193,247,102,72,140,209,4,191,219,206,187,237,38,137,241,3,92,39,137,228,116,110,45,181,203,80,138,103,242,196,166,221,223,223,84,129,169,168,79,42,168,52,166,198,154,22,140,143,196,253,82,114,169,81,110,77,64,238,46,154,116,165,37,231,148,140,237,136,245,249,156,77,155,178,44,225,32,201,57,228,233,248,45,212,38,55,170,4,31,38,222,160,13,54,57,47,48,34,235,10,154,47,197,221,91,254,54,255,24,15,18,89,17,159,32,52,111,218,123,132,179,143,38,78,213,154,244,130,35,204,48,80,220,195,231,63,28,153,86,64,50,58,188,39,82,160,62,48,116,24,17,108,192,238,15,140,117,215,213,254,240,184,126,79,238,209,107,57,95,134,102,85,179,137,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4e4bbf9b-4e63-40a8-8dcf-802e271ecd52"));
		}

		#endregion

	}

	#endregion

}

