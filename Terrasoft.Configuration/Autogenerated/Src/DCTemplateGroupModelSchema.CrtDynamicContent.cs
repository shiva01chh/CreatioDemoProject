namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupModelSchema

	/// <exclude/>
	public class DCTemplateGroupModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupModelSchema(DCTemplateGroupModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7");
			Name = "DCTemplateGroupModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("748ec229-6875-456a-9dfd-63087e63e63a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,77,79,227,48,16,61,7,137,255,48,91,46,32,173,146,59,37,229,208,74,168,7,118,145,150,253,1,198,158,52,70,137,237,181,39,148,168,226,191,175,63,154,180,84,45,219,205,33,142,39,243,230,189,241,60,43,214,162,51,140,35,60,163,181,204,233,138,242,185,86,149,92,117,150,145,212,42,95,244,138,181,146,251,32,161,162,252,81,11,108,220,229,197,230,242,34,235,156,84,43,248,213,59,194,118,58,238,207,44,180,96,196,194,183,101,156,60,216,195,175,44,174,124,34,204,27,230,220,45,44,230,207,216,154,134,17,62,88,221,153,72,28,243,138,162,128,59,215,181,45,179,253,108,187,143,24,32,13,22,141,69,231,9,64,120,2,104,3,10,42,109,61,2,17,184,197,170,156,28,84,158,20,51,240,0,73,125,62,84,47,246,202,155,238,165,145,28,120,100,56,46,42,219,68,97,99,7,79,86,27,180,36,209,183,241,20,225,233,255,161,242,24,248,173,228,159,14,65,138,160,161,146,104,243,49,117,95,198,160,227,161,147,2,150,2,54,176,66,154,130,11,175,15,40,99,60,255,129,235,176,94,223,76,255,135,16,116,5,180,109,107,239,36,254,161,97,119,20,135,106,206,224,86,2,223,97,45,169,150,10,168,198,145,254,107,94,233,199,186,140,208,35,124,87,168,68,58,255,207,195,120,68,170,181,56,103,18,63,223,188,117,253,177,56,192,119,227,83,37,1,215,234,45,76,210,251,218,155,235,180,135,6,39,7,47,81,111,118,125,204,83,1,7,170,107,154,80,35,172,39,186,140,17,195,44,107,193,95,21,44,39,209,189,147,217,192,180,117,179,126,121,69,78,176,174,37,175,7,129,40,242,187,34,66,247,207,203,145,191,122,124,215,77,112,37,35,127,25,78,168,191,62,102,239,196,122,3,101,172,156,37,13,223,202,216,72,140,100,247,160,112,125,170,38,108,82,82,230,93,82,166,90,249,82,124,31,130,113,154,99,60,236,210,159,143,180,220,70,154,233,209,9,167,185,127,14,198,88,120,254,2,115,215,59,49,217,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a31f9786-6cb9-4933-9916-2eea05b45be7"));
		}

		#endregion

	}

	#endregion

}

