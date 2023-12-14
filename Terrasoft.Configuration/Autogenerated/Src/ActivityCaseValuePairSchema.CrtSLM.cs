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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,79,75,196,48,16,197,207,45,244,59,12,236,189,189,187,34,72,15,226,173,168,236,125,108,166,117,160,77,74,38,89,40,203,126,119,147,244,15,171,160,98,78,51,111,230,189,249,17,141,35,201,132,45,193,27,89,139,98,58,87,214,70,119,220,123,139,142,141,46,242,75,145,103,94,88,247,240,58,139,163,241,88,228,65,57,88,234,195,24,234,1,69,238,224,177,117,124,102,55,215,40,116,194,193,83,131,108,211,98,85,85,112,47,126,28,209,206,15,107,255,66,147,37,33,237,4,220,7,193,57,26,96,10,14,48,29,180,33,2,80,43,192,53,179,220,82,170,155,152,201,191,15,220,130,16,14,164,160,141,20,63,65,100,151,4,178,35,55,214,76,100,29,83,224,110,82,204,50,255,78,154,132,45,19,88,5,94,238,152,108,185,47,223,2,109,68,79,158,213,238,122,86,16,191,47,203,122,114,199,84,200,90,92,127,185,25,249,255,119,47,58,254,188,117,32,173,150,47,72,253,162,126,21,131,22,223,39,57,22,185,213,22,2,0,0 };
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

