namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TagConstantsSchema

	/// <exclude/>
	public class TagConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TagConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TagConstantsSchema(TagConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca");
			Name = "TagConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9e68a40f-2533-42d0-8fe0-88fdb6bf5704");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,79,77,107,132,48,16,61,175,224,127,8,235,165,61,76,215,213,36,42,75,15,230,171,244,182,80,251,3,82,205,138,224,170,24,109,145,210,255,222,172,61,245,32,237,48,204,192,188,153,121,239,205,182,233,106,244,178,216,201,92,79,190,231,123,157,190,26,59,232,210,160,194,140,163,182,253,101,122,224,125,119,105,234,121,212,83,211,119,190,247,233,123,187,97,126,107,155,18,217,201,205,74,84,182,218,90,84,232,218,109,218,201,58,252,182,179,59,28,130,32,64,193,173,192,218,214,184,33,191,207,71,163,171,190,107,23,244,52,55,21,58,175,152,123,86,44,131,121,125,174,208,35,234,204,199,138,221,237,5,85,12,11,73,33,76,195,12,240,81,73,200,83,172,128,138,8,19,206,56,81,113,180,191,63,109,179,255,71,1,239,199,161,119,110,205,134,8,34,146,76,198,89,12,42,149,33,224,52,14,33,79,40,3,21,243,132,113,73,162,76,138,109,17,127,250,31,155,247,109,238,84,36,138,10,202,1,243,156,0,102,56,6,38,68,6,57,145,225,49,39,105,20,209,240,135,251,203,247,92,186,248,6,222,246,85,199,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae28a44b-17af-49d1-987b-2e02f87bc1ca"));
		}

		#endregion

	}

	#endregion

}

