namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateGroupContractSchema

	/// <exclude/>
	public class DCTemplateGroupContractSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateGroupContractSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateGroupContractSchema(DCTemplateGroupContractSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d");
			Name = "DCTemplateGroupContract";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e81fdc99-2bd3-4785-b2cd-a2accfc6f9a3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,193,110,226,48,16,61,83,169,255,48,165,23,144,170,228,14,13,61,128,84,113,96,183,106,187,167,85,15,38,158,16,175,18,39,181,199,165,44,234,191,239,216,33,144,34,208,146,67,28,143,103,222,188,55,126,209,162,68,91,139,20,225,21,141,17,182,202,40,154,86,58,83,43,103,4,169,74,71,179,141,22,165,74,57,72,168,41,154,9,18,254,219,136,148,174,175,182,215,87,61,103,149,94,193,203,198,18,150,227,163,125,244,236,52,169,18,163,23,52,74,20,234,111,192,60,100,93,216,116,81,73,44,44,151,113,225,173,193,21,167,192,180,16,214,142,96,54,125,197,178,46,4,225,163,169,92,125,160,198,169,113,28,195,189,117,101,41,204,102,178,219,135,50,160,10,12,214,6,45,163,131,100,73,144,238,10,33,171,12,23,33,66,106,48,75,250,71,248,253,120,2,92,163,104,19,181,13,226,78,135,223,221,241,188,113,160,118,203,66,165,144,134,174,103,185,246,182,129,239,94,219,147,169,106,52,164,144,5,62,5,132,230,252,88,80,8,252,210,234,221,33,40,233,121,101,10,77,180,79,237,82,107,184,45,176,92,162,241,204,90,106,143,78,73,152,75,216,194,10,105,12,214,191,190,46,104,167,37,126,194,90,81,174,52,80,142,64,59,105,255,239,62,152,219,103,124,119,202,160,132,4,200,56,28,118,9,41,190,146,121,64,63,65,233,22,181,108,134,244,125,98,11,164,188,146,151,140,235,231,7,123,142,135,101,1,63,107,78,85,228,239,254,195,143,155,13,201,198,56,127,249,193,134,222,1,180,169,15,58,167,77,181,5,237,138,194,3,248,245,204,20,66,164,22,70,148,192,6,199,164,223,218,174,63,105,59,29,156,88,45,255,32,47,235,92,165,121,203,17,101,116,31,7,128,73,103,100,150,248,183,73,15,130,188,123,4,177,145,79,9,24,156,177,225,190,241,16,146,0,222,219,51,185,73,130,168,16,236,61,128,198,245,73,100,216,54,25,189,185,191,216,182,58,242,187,4,36,102,194,21,52,240,126,27,194,67,240,93,244,3,215,126,29,12,97,212,205,191,107,113,130,13,186,80,62,208,28,126,53,203,40,48,27,159,116,71,227,153,239,65,142,241,243,15,215,100,13,94,247,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2a052ae9-b9e1-450f-b270-7e2a8392c61d"));
		}

		#endregion

	}

	#endregion

}

