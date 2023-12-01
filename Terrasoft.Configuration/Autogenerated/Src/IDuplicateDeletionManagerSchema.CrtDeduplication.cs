namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicateDeletionManagerSchema

	/// <exclude/>
	public class IDuplicateDeletionManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicateDeletionManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicateDeletionManagerSchema(IDuplicateDeletionManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2");
			Name = "IDuplicateDeletionManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,77,75,195,64,16,61,55,144,255,48,196,139,130,36,247,54,230,98,68,114,168,72,213,147,120,216,102,39,113,161,187,27,247,163,16,138,255,221,237,36,141,109,16,247,180,243,102,222,155,199,27,197,36,218,142,213,8,175,104,12,179,186,113,233,189,86,141,104,189,97,78,104,149,150,200,125,183,19,53,85,113,116,136,163,133,183,66,181,240,210,91,135,114,21,71,1,185,50,216,134,54,84,202,161,105,130,220,18,170,114,164,97,137,59,60,146,215,76,177,22,13,17,178,44,131,220,122,41,153,233,139,177,158,8,192,71,70,122,154,204,206,70,59,191,13,99,32,78,171,254,219,180,56,208,182,201,223,26,221,167,230,118,9,207,36,50,52,231,94,8,216,160,212,123,180,96,176,214,134,91,104,140,150,193,215,89,22,192,153,99,233,36,144,205,21,242,142,25,38,65,133,132,239,18,84,78,184,254,41,252,147,226,129,254,212,72,243,140,166,254,38,121,37,190,60,110,200,65,197,109,82,188,17,48,122,2,22,14,214,95,40,236,181,224,64,33,224,181,117,230,120,165,223,197,183,240,232,5,127,255,128,153,236,205,106,204,8,21,31,98,162,250,123,56,236,5,24,176,240,126,0,101,93,57,90,52,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1767778-661d-431a-a382-dbbf65e7e3a2"));
		}

		#endregion

	}

	#endregion

}

