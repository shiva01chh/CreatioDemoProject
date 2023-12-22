namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleSharedApplicationConnectorSchema

	/// <exclude/>
	public class GoogleSharedApplicationConnectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleSharedApplicationConnectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleSharedApplicationConnectorSchema(GoogleSharedApplicationConnectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("052166b4-a428-48fe-9cd6-6ad37cc6b8ec");
			Name = "GoogleSharedApplicationConnector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,110,131,48,12,134,207,32,241,14,150,118,105,47,112,111,89,165,181,135,106,135,73,211,186,23,112,131,161,145,32,65,78,232,52,85,123,247,165,9,48,198,144,150,91,236,255,251,253,199,81,216,144,105,81,16,188,19,51,26,93,218,244,160,85,41,171,142,209,74,173,210,147,22,18,235,36,190,37,113,212,25,169,170,137,242,168,117,85,211,137,248,74,236,40,69,194,106,222,38,177,147,62,48,85,14,7,81,163,49,27,232,149,23,100,42,158,218,182,150,194,187,143,144,103,218,238,236,26,1,249,151,128,13,236,209,204,135,59,151,155,247,26,3,188,144,189,232,194,69,120,245,238,161,153,101,25,228,166,107,26,228,207,221,80,120,35,219,177,50,32,180,114,45,98,144,170,212,220,248,177,128,103,221,89,168,124,40,48,62,21,224,79,172,116,116,205,230,182,57,7,223,221,97,193,55,205,179,161,125,215,247,27,8,111,31,244,207,78,14,71,178,211,251,106,13,247,15,137,162,43,114,159,106,182,9,120,4,69,31,176,248,69,171,245,214,195,97,244,50,159,254,153,232,153,175,126,187,164,138,176,96,127,15,213,223,69,87,155,158,111,159,126,246,4,106,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("052166b4-a428-48fe-9cd6-6ad37cc6b8ec"));
		}

		#endregion

	}

	#endregion

}

