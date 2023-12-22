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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,77,79,227,48,16,61,7,137,255,48,91,46,32,173,146,59,37,229,208,74,168,7,118,145,22,126,128,177,39,141,81,98,103,237,9,37,170,248,239,248,163,73,67,213,66,201,33,142,39,243,230,189,241,60,43,86,163,109,24,71,120,68,99,152,213,5,165,115,173,10,185,106,13,35,169,85,186,232,20,171,37,119,65,66,69,233,189,22,88,217,243,179,205,249,89,210,90,169,86,240,175,179,132,245,116,216,159,88,104,193,136,249,111,195,56,57,176,131,95,24,92,185,68,152,87,204,218,107,88,204,31,177,110,42,70,120,103,116,219,4,226,144,151,101,25,220,216,182,174,153,233,102,219,125,192,0,105,48,216,24,180,142,0,132,35,128,218,163,160,208,198,33,16,129,27,44,242,201,94,229,73,54,3,7,144,212,165,125,245,108,84,190,105,159,43,201,129,7,134,195,162,146,77,16,54,116,240,96,116,131,134,36,186,54,30,2,60,254,223,87,30,2,79,74,254,111,17,164,240,26,10,137,38,29,82,199,50,122,29,119,173,20,176,20,176,129,21,210,20,172,127,189,67,30,226,233,31,92,251,245,242,106,250,19,66,208,5,208,182,173,209,73,124,163,97,119,20,251,106,78,224,86,2,223,96,45,169,148,10,168,196,129,254,107,94,233,198,186,12,208,3,124,23,168,68,60,255,207,195,184,71,42,181,56,101,18,127,95,157,117,221,177,88,192,183,198,165,74,2,174,213,171,159,164,243,181,51,215,113,15,245,78,246,94,162,174,217,245,49,143,5,44,168,182,170,124,13,191,30,233,50,68,26,102,88,13,238,170,96,62,9,238,157,204,122,166,173,155,245,243,11,114,130,117,41,121,217,11,68,145,222,100,1,58,62,47,75,238,234,241,93,55,222,149,140,220,101,56,162,254,242,144,189,35,235,21,228,161,114,18,53,252,202,67,35,33,146,220,130,194,245,177,154,176,137,73,137,115,73,30,107,165,75,241,187,15,134,105,14,113,191,139,127,222,227,114,29,104,166,7,39,28,231,254,57,24,98,227,231,3,238,14,238,125,225,4,0,0 };
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

