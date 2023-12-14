namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RelationshipDiagramConfigProviderSchema

	/// <exclude/>
	public class RelationshipDiagramConfigProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RelationshipDiagramConfigProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RelationshipDiagramConfigProviderSchema(RelationshipDiagramConfigProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd23d878-8d9c-8ece-5b7d-37cf027c27fd");
			Name = "RelationshipDiagramConfigProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("32e5a92e-2a79-472b-b08d-f730aa69067f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,111,155,64,16,61,59,82,254,195,138,147,45,5,7,176,113,156,90,62,216,94,28,89,138,34,43,110,123,169,122,216,192,128,87,130,93,180,31,169,172,202,255,189,203,71,18,136,105,157,134,3,176,203,123,111,230,237,204,192,72,6,50,39,33,160,175,32,4,145,60,86,195,21,103,49,77,180,32,138,114,54,124,132,180,124,145,123,154,99,144,52,97,32,46,47,126,95,94,244,180,164,44,65,187,131,84,144,205,94,215,77,29,1,195,53,9,21,23,20,164,65,24,76,174,159,82,26,162,48,37,82,34,76,73,34,72,214,138,103,48,133,246,11,48,96,138,170,67,11,129,214,84,72,117,15,207,144,86,251,168,36,244,18,80,51,36,205,173,88,29,207,104,236,32,228,44,250,128,200,241,52,237,14,189,119,89,223,105,26,161,93,184,135,140,124,219,68,231,242,147,74,20,7,135,169,204,83,114,248,78,82,13,43,158,234,140,253,133,120,74,221,100,36,249,55,167,237,131,50,5,34,46,170,190,105,149,183,89,143,173,224,207,52,42,106,93,89,235,42,22,186,3,213,218,232,15,102,175,177,126,96,136,137,78,213,146,178,200,36,217,87,135,28,120,220,63,31,113,48,248,249,254,200,207,114,208,151,255,176,82,75,127,208,81,125,162,2,148,22,12,49,248,213,77,172,80,189,147,230,156,151,148,174,30,172,25,189,183,70,153,151,157,51,220,18,33,161,111,121,62,190,89,185,139,165,237,226,192,177,199,190,227,218,203,177,227,217,142,23,56,129,191,184,241,240,36,176,6,87,232,250,154,132,33,215,76,213,122,29,141,52,71,214,131,153,116,235,170,134,52,27,198,124,91,84,252,123,158,240,77,100,85,152,99,141,61,157,148,207,59,114,39,203,96,52,241,93,123,186,14,60,123,236,250,183,246,20,99,199,94,76,157,17,30,79,166,35,140,71,149,35,19,83,153,63,199,167,29,109,247,92,53,188,148,143,99,115,24,202,30,45,174,63,188,153,5,184,2,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd23d878-8d9c-8ece-5b7d-37cf027c27fd"));
		}

		#endregion

	}

	#endregion

}

