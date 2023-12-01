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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,83,193,110,219,48,12,61,187,64,255,129,75,47,45,48,216,247,166,78,15,9,80,228,208,173,192,186,15,80,101,58,86,97,75,158,68,55,53,130,254,251,40,41,118,210,32,233,50,31,44,139,230,227,123,20,159,180,104,208,181,66,34,60,163,181,194,153,146,210,185,209,165,90,117,86,144,50,58,93,244,90,52,74,114,144,80,83,250,104,10,172,221,229,197,230,242,34,233,156,210,43,248,213,59,194,102,58,238,207,44,180,16,36,252,183,21,146,24,204,240,43,139,43,78,132,121,45,156,187,133,197,252,25,155,182,22,132,15,214,116,109,32,14,121,89,150,193,157,235,154,70,216,126,182,221,7,12,144,1,139,173,69,199,4,80,48,1,52,30,5,165,177,140,64,4,105,177,204,39,7,149,39,217,12,24,160,168,79,135,234,217,94,249,182,123,169,149,4,25,24,142,139,74,54,65,216,216,193,147,53,45,90,82,200,109,60,5,120,252,127,168,60,4,126,107,245,167,67,80,133,215,80,42,180,233,152,186,47,99,208,241,208,169,2,150,5,108,96,133,52,5,231,95,31,144,135,120,250,3,215,126,189,190,153,254,15,33,152,18,104,219,214,222,73,252,67,195,238,40,14,213,156,193,173,11,124,135,181,162,74,105,160,10,71,250,175,121,21,143,117,25,160,71,248,174,80,23,241,252,63,15,227,17,169,50,197,57,147,248,249,198,214,229,99,113,128,239,45,167,42,2,105,244,155,159,36,251,154,205,117,218,67,131,147,189,151,168,111,119,125,204,99,1,7,186,171,107,95,195,175,39,186,12,145,86,88,209,0,95,21,204,39,193,189,147,217,192,180,117,179,121,121,69,73,176,174,148,172,6,129,88,164,119,89,128,238,159,151,35,190,122,114,215,141,119,165,32,190,12,39,212,95,31,179,119,100,189,129,60,84,78,162,134,111,121,104,36,68,146,123,208,184,62,85,19,54,49,41,97,151,228,177,86,186,44,190,15,193,48,205,49,238,119,241,207,71,92,110,3,205,244,232,132,227,220,63,7,67,140,159,191,130,236,51,90,216,4,0,0 };
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

