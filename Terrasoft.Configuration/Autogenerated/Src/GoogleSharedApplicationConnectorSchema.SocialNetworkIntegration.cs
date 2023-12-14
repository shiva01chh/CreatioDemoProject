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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,110,131,48,12,134,207,32,241,14,150,118,105,47,112,111,89,165,181,135,106,135,73,211,186,23,112,131,161,145,32,65,78,232,52,85,123,247,133,4,88,199,144,150,91,236,255,251,253,199,81,216,144,105,81,16,188,19,51,26,93,218,244,160,85,41,171,142,209,74,173,210,147,22,18,235,36,190,37,113,212,25,169,170,59,229,81,235,170,166,19,241,149,216,81,138,132,213,188,77,98,39,125,96,170,28,14,162,70,99,54,48,40,47,200,84,60,181,109,45,133,119,159,32,207,180,221,217,53,2,242,47,1,27,216,163,153,15,119,46,55,239,53,5,120,33,123,209,133,139,240,234,221,67,51,203,50,200,77,215,52,200,159,187,177,240,70,182,99,101,64,104,229,90,196,32,85,169,185,241,99,1,207,186,179,80,249,80,96,124,42,192,159,88,233,228,154,205,109,115,14,190,187,195,130,111,154,103,99,187,215,15,27,8,111,31,245,207,78,14,71,178,247,247,213,26,250,15,137,162,43,242,144,106,182,9,120,4,69,31,176,248,69,171,245,214,195,97,244,50,159,254,153,232,153,175,97,187,164,138,176,96,127,15,213,223,69,87,235,207,55,70,49,254,37,98,2,0,0 };
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

