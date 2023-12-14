namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MaxSizeTextColumnProcessorSchema

	/// <exclude/>
	public class MaxSizeTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MaxSizeTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MaxSizeTextColumnProcessorSchema(MaxSizeTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1");
			Name = "MaxSizeTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,110,219,48,12,134,207,41,208,119,32,178,75,2,12,246,61,77,2,172,41,58,228,176,161,64,147,93,134,30,20,153,78,9,216,146,71,73,69,179,98,239,62,74,142,187,56,139,15,245,197,18,241,243,39,249,73,50,170,70,215,40,141,176,65,102,229,108,233,179,149,53,37,237,3,43,79,214,100,247,84,225,186,110,44,251,235,171,183,235,171,81,112,100,246,240,120,112,30,235,155,247,253,105,54,227,80,60,187,87,218,91,38,116,162,16,205,39,198,189,212,128,85,165,156,155,193,55,245,250,72,191,113,131,175,126,101,171,80,155,7,182,26,157,179,156,212,121,158,195,156,204,51,50,249,194,106,208,140,229,98,124,65,61,206,151,157,220,133,186,86,124,232,246,95,12,144,113,94,25,25,216,150,224,159,201,129,142,197,65,22,44,36,172,113,180,171,16,74,203,208,180,126,113,140,147,206,64,167,98,240,162,170,128,46,235,10,229,39,149,126,222,97,169,66,229,111,201,20,146,61,241,135,6,109,57,89,159,181,57,253,12,223,5,63,44,192,200,79,4,195,243,79,167,79,226,219,132,93,69,250,216,240,176,24,102,112,17,225,232,45,97,252,71,93,134,245,28,226,137,8,252,135,100,222,42,62,72,250,63,212,41,176,98,84,30,93,31,184,144,16,37,226,209,114,120,8,113,206,222,173,243,115,239,121,163,88,213,137,219,98,28,28,178,204,98,80,199,11,59,94,110,101,47,167,212,5,178,121,158,212,41,249,136,112,184,238,100,219,115,131,190,249,84,216,238,148,195,201,121,56,190,140,209,159,35,95,52,69,139,184,207,91,106,52,200,94,110,255,44,174,189,228,98,17,5,195,200,111,165,214,7,144,223,41,175,218,139,217,146,14,134,126,201,154,10,52,158,74,66,30,64,218,116,221,128,125,145,7,43,122,248,26,168,72,126,63,162,221,70,220,182,235,2,22,203,126,44,59,1,121,46,190,185,72,163,101,212,15,74,44,126,127,1,127,67,230,39,140,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cf2e8673-fb8d-4ba0-9c62-446b24f54ef1"));
		}

		#endregion

	}

	#endregion

}

