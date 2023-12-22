namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailRequestSchema

	/// <exclude/>
	public class CheckedEmailRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailRequestSchema(CheckedEmailRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("942945d7-ac66-48ca-b114-0dbc0d994415");
			Name = "CheckedEmailRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,65,79,27,49,16,133,207,69,226,63,140,210,75,185,236,222,73,224,208,16,161,30,168,80,194,173,234,193,241,190,13,22,94,123,59,227,141,68,35,254,59,99,111,72,67,168,196,30,188,154,241,155,207,126,79,14,166,131,244,198,130,30,192,108,36,182,169,154,199,208,186,205,192,38,185,24,170,249,98,117,23,27,120,57,63,219,157,159,125,25,196,133,13,173,158,37,161,83,165,247,176,89,38,213,45,2,216,217,233,169,102,57,132,228,58,84,43,221,53,222,253,45,84,85,169,238,43,99,163,5,205,189,17,185,164,249,35,236,19,154,69,103,156,95,226,207,0,73,69,86,215,53,205,100,232,58,195,207,215,251,122,137,158,33,8,73,136,71,41,165,72,54,19,8,25,32,185,94,131,182,122,108,235,208,144,158,211,115,220,186,6,76,162,107,245,70,174,79,208,51,1,140,23,165,49,218,171,201,167,185,84,223,141,64,221,109,157,197,254,218,19,170,51,237,215,141,73,70,167,18,27,155,126,107,163,31,214,222,89,178,217,239,255,236,210,37,125,132,233,220,174,228,112,200,235,158,99,15,78,14,26,218,125,65,142,251,167,65,149,198,45,52,163,168,158,243,63,61,130,188,211,131,98,123,20,83,137,173,58,16,234,83,196,108,107,252,128,67,249,160,144,113,248,104,230,159,164,184,190,67,183,6,127,251,169,207,139,174,104,50,202,39,23,57,132,183,20,126,44,194,208,129,205,218,99,38,137,245,201,92,211,98,188,211,142,54,72,211,124,229,41,189,236,189,35,52,163,253,82,143,221,247,205,210,59,254,94,1,198,122,147,80,221,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("942945d7-ac66-48ca-b114-0dbc0d994415"));
		}

		#endregion

	}

	#endregion

}

