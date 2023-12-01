namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetXmlSchemaFilesContentResponseSchema

	/// <exclude/>
	public class GetXmlSchemaFilesContentResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetXmlSchemaFilesContentResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetXmlSchemaFilesContentResponseSchema(GetXmlSchemaFilesContentResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90c4c327-4a7f-a0dd-f8fb-e87a2ae11e91");
			Name = "GetXmlSchemaFilesContentResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0cd720a-279e-436c-a704-8c755267ad15");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,205,110,194,48,16,132,207,65,226,29,44,122,105,165,42,15,64,127,14,37,42,39,42,4,61,84,66,28,140,153,164,43,57,78,180,118,42,81,212,119,239,218,33,165,237,5,159,214,235,217,217,207,227,116,13,223,106,3,245,10,102,237,155,50,228,179,198,149,84,117,172,3,53,46,95,131,63,200,160,128,167,202,129,199,163,227,120,148,117,158,92,165,214,7,31,80,139,222,90,152,40,246,249,28,162,33,115,247,95,179,234,92,160,26,209,141,180,165,207,228,125,86,253,94,206,24,118,46,154,61,172,208,4,214,38,136,88,228,87,140,74,38,213,204,106,239,167,106,142,240,86,219,181,121,71,173,159,201,194,71,53,92,88,201,167,4,7,105,102,83,232,160,7,155,173,52,218,110,103,201,40,19,61,46,90,168,169,122,210,30,103,199,236,152,92,127,80,150,220,180,224,64,16,158,101,114,238,223,211,218,5,234,29,248,250,69,98,86,15,106,82,198,5,147,155,8,49,80,20,148,162,211,124,184,247,129,37,140,91,69,46,108,182,143,42,209,168,24,119,150,85,136,1,72,225,79,197,215,9,2,110,223,115,164,123,223,253,219,76,61,57,223,98,135,244,64,235,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90c4c327-4a7f-a0dd-f8fb-e87a2ae11e91"));
		}

		#endregion

	}

	#endregion

}

