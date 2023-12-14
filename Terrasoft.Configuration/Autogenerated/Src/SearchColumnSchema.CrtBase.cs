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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,79,205,10,194,48,12,62,175,176,119,8,236,238,3,232,113,119,25,110,47,16,107,214,21,182,180,164,221,65,134,239,110,183,138,160,236,160,57,4,242,253,241,133,113,162,224,81,19,116,36,130,193,245,241,80,59,238,173,153,5,163,117,92,170,165,84,165,42,42,33,147,78,168,71,12,225,8,45,161,232,161,118,227,60,241,198,251,249,58,90,13,122,165,191,216,34,39,188,35,26,113,158,36,90,74,57,205,102,203,252,43,34,68,177,108,224,66,61,9,177,166,86,15,52,225,57,21,133,5,12,197,19,132,117,61,246,76,255,104,115,189,223,180,221,221,239,170,42,226,91,254,106,187,51,250,9,38,108,157,39,3,175,169,114,105,1,0,0 };
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

