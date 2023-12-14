namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApplicationServiceQueryExecutorSchema

	/// <exclude/>
	public class ApplicationServiceQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApplicationServiceQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApplicationServiceQueryExecutorSchema(ApplicationServiceQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0ae10d6-8124-4581-913a-ac8fe338fb3a");
			Name = "ApplicationServiceQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,139,219,48,16,61,123,97,255,195,224,94,108,8,246,61,217,46,100,211,109,201,33,101,219,238,246,82,122,80,236,113,34,176,37,163,143,208,176,244,191,119,36,57,196,78,226,77,15,173,33,88,26,191,121,122,243,102,20,193,26,212,45,43,16,158,81,41,166,101,101,178,133,20,21,223,88,197,12,151,226,246,230,245,246,38,178,154,139,205,0,162,112,54,18,207,230,109,91,243,194,103,235,108,190,214,70,177,194,111,70,51,30,133,225,134,227,56,224,35,49,72,53,130,248,134,106,199,11,255,141,190,190,83,184,161,195,96,81,51,173,167,208,19,211,225,190,88,84,251,199,95,88,88,162,244,41,121,158,195,157,182,77,195,212,254,190,219,123,20,96,7,131,138,126,58,228,131,46,182,216,48,13,178,2,118,100,207,14,68,121,143,233,199,7,172,152,173,205,3,23,37,137,78,204,190,69,89,37,75,95,240,126,160,36,157,192,103,106,6,188,135,248,138,230,56,253,73,212,173,93,19,8,10,87,230,181,42,97,10,15,76,99,31,229,107,24,128,238,206,29,61,44,2,218,21,244,234,13,59,154,76,93,53,202,186,230,144,215,79,94,82,64,116,242,174,8,75,94,200,84,34,17,232,39,4,236,96,59,129,37,229,175,152,96,27,84,206,235,110,153,186,3,162,41,172,169,166,228,52,165,7,3,55,186,209,239,78,50,138,50,168,30,150,240,164,100,139,202,77,223,212,173,13,241,96,25,32,167,115,17,2,92,108,81,113,83,202,2,242,99,180,223,245,168,61,240,128,220,145,169,188,164,161,49,202,77,237,87,212,52,14,161,253,193,213,208,244,251,75,93,143,103,111,75,95,161,217,202,242,255,234,14,34,59,71,175,143,8,124,66,51,72,73,82,42,206,247,43,25,32,15,61,26,14,64,118,150,30,95,202,138,211,217,191,175,116,39,121,9,43,214,206,203,146,59,45,172,94,200,218,54,66,39,161,93,128,254,53,241,197,68,203,129,160,165,193,230,47,204,209,167,57,221,136,70,129,154,224,38,156,249,157,213,22,147,248,153,254,46,226,201,121,90,182,164,107,199,68,129,153,67,56,51,198,57,220,197,127,81,252,109,154,14,20,152,46,95,152,16,29,6,125,204,61,127,0,161,46,39,142,71,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ae10d6-8124-4581-913a-ac8fe338fb3a"));
		}

		#endregion

	}

	#endregion

}

