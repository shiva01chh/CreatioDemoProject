namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActivityUserTaskHelperSchema

	/// <exclude/>
	public class ActivityUserTaskHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActivityUserTaskHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActivityUserTaskHelperSchema(ActivityUserTaskHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8");
			Name = "ActivityUserTaskHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3949d191-f356-45da-a437-95abb1839b71");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,91,75,235,64,16,126,142,224,127,24,123,94,90,40,201,187,189,128,150,122,129,163,8,85,223,215,205,164,93,220,75,216,75,57,65,252,239,103,47,73,218,104,53,132,101,231,242,125,243,205,236,72,34,208,212,132,34,60,163,214,196,168,202,230,43,37,43,182,117,154,88,166,228,249,217,199,249,89,230,12,147,91,216,52,198,162,152,245,246,49,68,8,37,79,71,52,230,107,105,153,101,104,124,130,79,249,163,113,235,153,97,197,137,49,151,112,69,45,219,51,219,188,24,212,207,196,188,223,33,175,81,251,60,255,23,69,1,115,227,132,32,186,89,182,246,147,86,123,86,162,1,226,254,49,206,124,4,4,218,157,42,13,84,74,131,221,33,144,150,18,156,231,4,235,73,243,142,172,56,98,171,221,27,103,20,140,245,157,82,160,65,206,207,106,62,162,246,94,252,67,42,121,9,79,145,36,5,191,202,141,142,27,198,185,1,170,184,19,18,246,132,59,4,85,69,153,24,198,210,228,61,178,248,10,157,215,68,19,1,210,63,210,98,148,178,71,203,117,66,205,139,24,60,157,155,170,61,250,251,104,185,74,149,67,224,119,80,212,214,231,71,107,0,24,142,107,175,88,9,155,26,41,171,154,110,104,127,149,122,119,117,34,120,13,248,113,18,219,118,58,245,88,29,214,227,32,111,10,183,206,243,196,98,19,8,171,150,101,172,130,113,170,126,111,214,162,182,205,120,210,133,50,141,214,233,184,104,89,246,25,207,84,97,67,119,40,72,255,240,173,185,232,70,156,236,217,55,64,146,234,79,142,52,108,123,171,204,120,228,144,42,79,153,230,39,138,182,208,192,181,232,216,242,27,38,203,235,38,244,59,62,180,62,153,245,221,158,0,95,44,64,58,206,251,198,187,70,208,30,143,247,59,112,218,206,242,104,68,159,237,230,162,44,211,242,70,59,121,135,206,232,11,223,127,93,107,154,115,23,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64a98983-9363-4df0-9a04-3cf2dd6cddc8"));
		}

		#endregion

	}

	#endregion

}

