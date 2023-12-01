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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,146,207,74,195,64,16,198,207,45,244,29,134,122,81,144,228,110,107,65,84,164,160,40,85,31,96,155,76,210,197,100,55,204,206,34,165,248,238,78,254,108,108,74,43,222,204,33,48,223,206,124,243,155,221,49,170,68,87,169,4,225,13,137,148,179,25,71,183,214,100,58,247,164,88,91,51,25,239,38,227,145,119,218,228,240,186,117,140,229,172,143,111,45,225,48,138,238,13,107,214,232,68,150,131,51,194,92,60,96,105,24,41,147,46,87,176,20,119,70,195,175,44,233,77,82,28,199,48,119,190,44,21,109,23,93,188,194,138,208,73,154,3,87,39,66,102,9,74,95,176,46,148,201,189,202,17,146,214,39,10,14,241,158,69,229,215,133,78,64,135,182,135,93,71,187,166,115,207,247,66,182,66,170,185,175,224,165,169,109,207,15,209,26,225,14,197,181,212,6,29,124,110,144,55,72,192,22,88,125,96,221,208,130,74,18,235,13,3,233,124,35,252,162,56,44,48,97,72,21,171,168,183,221,231,29,173,173,45,224,221,225,77,42,198,171,182,112,7,57,242,76,138,229,247,213,241,162,73,91,228,33,255,147,96,216,244,47,240,43,100,79,198,133,219,3,172,223,107,123,130,170,81,42,69,170,4,35,123,114,61,109,179,151,233,116,241,44,211,105,163,138,206,160,247,211,105,45,100,26,41,154,199,77,233,113,167,240,140,181,215,99,120,210,223,138,169,5,95,60,29,91,130,48,198,60,14,105,117,221,125,139,246,128,124,254,224,117,10,129,254,18,154,240,7,225,98,246,135,27,75,49,83,210,251,95,110,46,76,117,119,156,225,212,216,93,250,112,250,48,236,193,46,181,27,54,20,69,147,239,27,66,51,114,248,35,4,0,0 };
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

