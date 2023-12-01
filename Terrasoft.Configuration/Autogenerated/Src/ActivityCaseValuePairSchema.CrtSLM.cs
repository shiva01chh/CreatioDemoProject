namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityCaseValuePairSchema

	/// <exclude/>
	public class ActivityCaseValuePairSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityCaseValuePairSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityCaseValuePairSchema(ActivityCaseValuePairSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64d1bc1c-8aa8-4e74-bc6c-174824b86bb2");
			Name = "ActivityCaseValuePair";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,79,75,196,48,16,197,207,45,244,59,12,236,189,189,187,34,72,15,226,173,168,236,125,76,166,117,160,77,75,38,89,40,203,126,119,147,244,15,171,160,98,78,51,111,230,189,249,17,131,3,201,132,138,224,141,172,69,25,91,87,214,163,105,185,243,22,29,143,166,200,47,69,158,121,97,211,193,235,44,142,134,99,145,7,229,96,169,11,99,168,123,20,185,131,71,229,248,204,110,174,81,232,132,189,167,6,217,166,197,170,170,224,94,252,48,160,157,31,214,254,133,38,75,66,198,9,184,15,130,115,52,192,20,28,48,182,160,66,4,160,209,128,107,102,185,165,84,55,49,147,127,239,89,129,16,246,164,65,69,138,159,32,178,75,2,217,145,27,59,78,100,29,83,224,110,82,204,50,255,78,154,132,45,19,88,7,94,110,153,108,185,47,223,2,109,68,79,158,245,238,122,214,16,191,47,203,58,114,199,84,200,90,92,127,185,25,249,255,119,47,58,254,188,117,32,163,151,47,72,253,162,126,21,131,22,222,39,14,173,61,214,21,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64d1bc1c-8aa8-4e74-bc6c-174824b86bb2"));
		}

		#endregion

	}

	#endregion

}

