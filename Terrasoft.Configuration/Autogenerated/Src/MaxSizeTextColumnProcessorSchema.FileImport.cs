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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,110,219,48,12,134,207,41,208,119,32,178,75,2,12,246,61,77,2,172,41,58,228,208,162,64,147,93,134,30,20,153,78,9,216,146,71,73,69,179,98,239,62,90,142,91,59,141,15,245,197,18,241,243,39,249,73,50,170,68,87,41,141,176,65,102,229,108,238,147,149,53,57,237,3,43,79,214,36,183,84,224,186,172,44,251,203,139,183,203,139,81,112,100,246,240,120,112,30,203,171,247,125,55,155,113,40,158,220,42,237,45,19,58,81,136,230,27,227,94,106,192,170,80,206,205,224,78,189,62,210,95,220,224,171,95,217,34,148,230,129,173,70,231,44,71,117,154,166,48,39,243,140,76,62,179,26,52,99,190,24,159,81,143,211,101,43,119,161,44,21,31,218,253,15,3,100,156,87,70,6,182,57,248,103,114,160,235,226,32,11,22,18,214,56,218,21,8,185,101,168,26,191,122,140,78,103,160,99,49,120,81,69,64,151,180,133,210,78,165,223,55,152,171,80,248,107,50,153,100,79,252,161,66,155,79,214,39,109,78,191,195,189,224,135,5,24,249,137,96,120,254,233,244,73,124,171,176,43,72,31,27,30,22,195,12,206,34,28,189,69,140,31,212,101,88,207,161,62,17,129,255,16,205,27,197,23,73,127,66,29,3,43,70,229,209,245,129,11,9,81,34,30,45,135,135,16,231,228,221,58,61,245,158,87,138,85,25,185,45,198,193,33,203,44,6,117,125,97,199,203,173,236,229,148,218,64,50,79,163,58,38,31,17,14,215,157,108,123,110,208,55,159,10,219,157,114,56,57,13,215,47,99,244,239,200,23,77,214,32,238,243,150,26,21,178,151,219,63,171,215,94,114,49,171,5,195,200,175,165,214,23,144,223,40,175,154,139,217,144,14,134,254,200,154,50,52,158,114,66,30,64,90,181,221,128,125,145,7,43,122,248,25,40,139,126,191,106,187,141,184,109,215,25,44,150,253,88,210,1,121,42,190,58,75,163,97,212,15,74,172,251,253,7,93,36,198,112,148,4,0,0 };
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

