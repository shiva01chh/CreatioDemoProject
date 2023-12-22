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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,205,74,197,48,16,133,215,45,244,29,6,238,190,221,123,69,144,46,196,93,81,113,63,38,211,58,208,166,37,147,92,40,23,223,221,36,253,161,10,42,102,53,115,102,206,153,143,24,28,72,38,84,4,47,100,45,202,216,186,178,30,77,203,157,183,232,120,52,69,126,45,242,204,11,155,14,158,103,113,52,156,139,60,40,39,75,93,24,67,221,163,200,13,220,43,199,23,118,115,141,66,175,216,123,106,144,109,90,172,170,10,110,197,15,3,218,249,110,237,159,104,178,36,100,156,128,123,39,184,68,3,76,193,1,99,11,42,68,0,26,13,184,102,150,91,74,117,136,153,252,91,207,10,132,176,39,13,42,82,252,4,145,93,19,200,142,220,216,113,34,235,152,2,119,147,98,150,249,119,210,36,108,153,192,58,240,114,203,100,203,125,249,8,180,17,61,120,214,187,235,81,67,252,190,44,235,200,157,83,33,107,241,241,203,205,200,255,191,123,209,241,231,173,19,25,189,124,65,234,23,245,171,24,180,227,251,4,56,144,245,33,30,2,0,0 };
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

