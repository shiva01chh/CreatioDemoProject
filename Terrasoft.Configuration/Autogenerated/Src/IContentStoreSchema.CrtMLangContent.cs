namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContentStoreSchema

	/// <exclude/>
	public class IContentStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContentStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContentStoreSchema(IContentStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3c7a9a4-e4fe-4de6-9313-1b0c8d8e8ead");
			Name = "IContentStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("16e592d3-2033-426b-b620-6aa2b1f8eec0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,207,74,195,64,16,198,207,21,124,135,65,47,10,146,220,219,90,16,91,164,160,88,170,62,192,54,153,164,139,201,110,152,157,69,74,241,221,157,252,217,216,148,42,222,204,33,48,223,206,124,243,155,221,49,170,68,87,169,4,225,21,137,148,179,25,71,247,214,100,58,247,164,88,91,115,126,182,63,63,27,121,167,77,14,47,59,199,88,78,250,248,222,18,14,163,104,97,88,179,70,39,178,28,92,18,230,226,1,75,195,72,153,116,25,195,82,220,25,13,191,176,164,55,73,113,28,195,212,249,178,84,180,155,117,241,26,43,66,39,105,14,92,157,8,153,37,40,125,193,186,80,38,247,42,71,72,90,159,40,56,196,7,22,149,223,20,58,1,29,218,30,119,29,237,155,206,61,223,138,108,133,84,115,143,97,213,212,182,231,199,104,141,48,71,113,45,181,65,7,31,91,228,45,18,176,5,86,239,88,55,180,160,146,196,122,195,64,58,223,10,191,40,14,11,76,24,82,197,42,234,109,15,121,71,27,107,11,120,115,120,151,138,241,186,45,220,67,142,60,145,98,249,125,118,188,104,210,22,121,200,255,36,24,54,253,11,252,26,217,147,113,225,246,0,235,247,218,253,64,213,40,149,34,85,130,145,61,185,189,104,179,151,233,197,236,89,166,211,70,21,157,65,239,167,211,90,200,52,82,52,141,155,210,211,78,225,25,107,175,199,240,164,191,21,83,11,62,123,58,181,4,97,140,105,28,210,234,186,69,139,246,128,124,245,224,117,10,129,254,6,154,240,27,225,122,242,135,27,75,49,83,210,251,95,110,46,76,53,63,205,240,211,216,93,250,112,250,48,236,209,46,181,27,54,20,69,59,252,190,0,62,167,188,172,44,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3c7a9a4-e4fe-4de6-9313-1b0c8d8e8ead"));
		}

		#endregion

	}

	#endregion

}

