namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportLookupChunksDataProviderSchema

	/// <exclude/>
	public class IImportLookupChunksDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportLookupChunksDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportLookupChunksDataProviderSchema(IImportLookupChunksDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("425cd682-be37-44b5-8c48-07738afab1de");
			Name = "IImportLookupChunksDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("28117f91-27b8-43f6-8b95-0e32534298ab");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,193,10,131,48,16,68,207,21,252,135,197,222,205,189,88,47,150,130,208,67,15,253,129,84,55,54,168,73,88,147,66,41,253,247,70,163,34,189,52,183,204,204,62,134,81,188,199,193,240,10,225,134,68,124,208,194,166,133,86,66,54,142,184,149,90,165,103,217,97,217,27,77,22,222,113,20,71,187,61,97,227,13,40,149,69,18,254,244,0,101,8,92,180,110,157,41,30,78,181,195,137,91,126,37,253,148,53,210,116,198,24,131,108,112,125,207,233,149,207,255,153,91,251,44,152,57,12,66,147,15,34,66,69,40,142,201,6,58,50,19,96,121,186,224,216,134,103,220,189,147,21,200,165,213,191,82,176,214,94,217,139,149,5,125,148,38,47,251,233,144,231,227,20,187,79,152,3,85,29,22,137,35,175,140,239,11,142,224,71,116,85,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("425cd682-be37-44b5-8c48-07738afab1de"));
		}

		#endregion

	}

	#endregion

}

