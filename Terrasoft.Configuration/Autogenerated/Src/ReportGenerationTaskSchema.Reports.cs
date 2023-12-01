namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationTaskSchema

	/// <exclude/>
	public class ReportGenerationTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationTaskSchema(ReportGenerationTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("68544e27-681d-4cfb-9b4f-a820834261f0");
			Name = "ReportGenerationTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,80,177,106,195,48,20,156,109,240,63,60,200,210,66,137,247,186,237,146,193,116,41,33,241,86,58,40,246,179,17,181,37,243,36,13,169,201,191,247,89,86,18,39,164,45,213,34,113,186,119,247,238,148,232,208,244,162,68,40,144,72,24,93,219,229,74,171,90,54,142,132,149,90,37,241,144,196,145,51,82,53,176,221,27,139,93,150,196,140,44,8,27,254,134,85,43,140,121,132,13,246,154,108,142,10,167,177,66,152,79,207,123,223,34,73,209,202,47,177,107,241,131,129,222,237,90,89,66,57,206,253,48,22,13,126,244,236,161,149,177,228,74,171,137,173,214,94,96,98,4,177,91,50,119,247,48,110,30,29,254,102,230,78,86,96,249,245,90,61,0,59,141,89,201,19,223,184,158,160,19,21,158,0,207,129,153,121,112,115,162,241,199,121,38,155,57,47,80,85,83,144,203,84,107,210,61,146,149,120,149,41,77,83,120,50,174,235,4,237,95,142,64,142,214,128,38,48,227,45,160,153,2,96,176,132,158,116,137,220,231,184,26,200,10,149,149,181,68,90,158,244,210,185,96,232,194,199,14,169,6,150,180,217,40,159,193,225,255,123,84,199,69,20,135,255,221,53,244,59,43,238,134,247,85,103,19,122,9,122,140,207,55,141,131,182,189,194,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68544e27-681d-4cfb-9b4f-a820834261f0"));
		}

		#endregion

	}

	#endregion

}

