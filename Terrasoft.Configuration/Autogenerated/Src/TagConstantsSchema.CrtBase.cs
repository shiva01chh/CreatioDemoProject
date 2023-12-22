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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,79,77,107,132,48,16,61,175,224,127,8,235,165,61,76,215,213,36,70,150,30,52,31,165,183,66,237,15,72,53,43,130,107,196,104,139,148,254,247,186,246,210,30,164,29,134,25,152,55,51,239,189,201,53,93,141,158,103,55,154,203,201,247,124,175,211,23,227,122,93,26,84,152,97,208,206,158,199,59,110,187,115,83,79,131,30,27,219,249,222,135,239,237,250,233,181,109,74,228,198,101,86,162,178,213,206,161,66,215,203,166,27,221,130,95,119,118,135,67,16,4,40,184,22,88,219,26,87,228,247,249,96,116,101,187,118,70,15,83,83,161,167,21,91,158,21,115,111,94,30,43,116,143,58,243,190,98,55,123,65,85,142,133,164,16,178,48,5,124,84,18,50,134,21,80,17,97,194,115,78,84,28,237,111,79,219,236,255,81,192,237,208,219,197,173,217,16,65,68,146,202,56,141,65,49,25,2,102,113,8,89,66,115,80,49,79,114,46,73,148,74,177,45,226,79,255,67,243,182,205,205,68,162,168,160,28,48,207,8,224,28,199,144,11,145,66,70,100,120,204,8,139,34,26,126,115,127,250,222,146,63,226,11,76,5,230,208,236,1,0,0 };
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

