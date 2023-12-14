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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,77,75,195,64,16,61,55,144,255,48,196,139,130,36,247,54,230,98,68,114,168,72,213,147,120,216,118,39,113,161,187,27,247,163,16,138,255,221,205,36,141,109,16,247,180,243,102,222,155,199,27,197,36,218,150,237,16,94,209,24,102,117,237,210,123,173,106,209,120,195,156,208,42,45,145,251,118,47,118,84,197,209,49,142,22,222,10,213,192,75,103,29,202,85,28,5,228,202,96,19,218,80,41,135,166,14,114,75,168,202,145,134,37,238,177,39,175,153,98,13,26,34,100,89,6,185,245,82,50,211,21,99,61,17,128,143,140,244,52,153,157,141,182,126,27,198,64,156,86,253,183,105,113,164,109,147,191,53,186,79,205,237,18,158,73,100,104,206,189,16,176,65,169,15,104,193,224,78,27,110,161,54,90,6,95,103,89,0,103,142,165,147,64,54,87,200,91,102,152,4,21,18,190,75,80,57,225,186,167,240,79,138,7,250,83,35,205,51,154,250,155,228,149,248,242,184,33,7,21,183,73,241,70,192,232,9,88,56,88,119,161,112,208,130,3,133,128,215,214,153,254,74,191,139,111,225,209,11,254,254,1,51,217,155,213,152,17,42,62,196,68,245,247,112,216,11,48,96,253,251,1,25,170,85,15,53,2,0,0 };
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

