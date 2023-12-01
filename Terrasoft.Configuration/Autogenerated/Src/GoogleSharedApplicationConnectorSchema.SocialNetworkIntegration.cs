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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,207,9,228,29,4,187,180,151,228,222,102,133,181,135,178,195,96,172,123,1,213,81,82,67,98,7,217,238,24,101,239,62,215,78,178,46,43,204,55,75,255,247,235,183,172,176,35,211,163,32,120,39,102,52,186,182,249,78,171,90,54,142,209,74,173,242,131,22,18,219,44,189,100,105,226,140,84,205,141,114,175,117,211,210,129,248,76,236,41,69,194,106,94,103,169,151,62,48,53,30,7,209,162,49,43,24,148,39,100,170,158,250,190,149,34,184,79,80,96,122,119,244,141,136,252,75,192,10,182,104,230,195,189,203,37,120,77,1,94,200,158,116,229,35,188,6,247,216,44,138,2,74,227,186,14,249,115,51,22,222,200,58,86,6,132,86,190,69,12,82,213,154,187,48,22,240,168,157,133,38,132,2,19,82,1,254,196,202,39,215,98,110,91,114,244,221,236,238,248,230,101,49,182,175,250,97,3,241,237,163,254,217,203,97,79,246,246,190,88,194,245,67,146,228,140,60,164,154,109,2,30,65,209,7,220,253,162,197,114,29,224,56,250,62,159,255,153,24,152,175,97,187,164,170,184,224,112,143,213,223,69,95,243,231,27,158,150,137,158,97,2,0,0 };
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

