namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchColumnSchema

	/// <exclude/>
	public class SearchColumnSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchColumnSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchColumnSchema(SearchColumnSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1e9e33bb-e2f8-4c17-b5b6-db4500bda4ab");
			Name = "SearchColumn";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,79,205,10,131,48,12,62,43,248,14,1,239,123,128,237,232,125,200,244,5,178,46,214,130,166,37,173,7,145,189,251,170,29,99,27,30,182,28,2,249,254,248,194,56,146,119,168,8,90,18,65,111,187,112,168,44,119,70,79,130,193,88,46,242,165,200,139,60,43,133,116,60,161,26,208,251,35,52,132,162,250,202,14,211,200,27,239,166,235,96,20,168,149,254,98,179,148,240,138,168,197,58,146,96,40,230,212,155,45,241,207,8,31,196,176,134,11,117,36,196,138,26,213,211,136,231,88,20,22,208,20,78,224,215,117,223,51,253,163,77,245,126,211,182,179,219,85,149,196,183,244,213,118,39,244,19,140,216,251,60,0,227,148,196,65,113,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1e9e33bb-e2f8-4c17-b5b6-db4500bda4ab"));
		}

		#endregion

	}

	#endregion

}

