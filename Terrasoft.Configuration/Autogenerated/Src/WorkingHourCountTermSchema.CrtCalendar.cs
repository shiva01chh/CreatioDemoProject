namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkingHourCountTermSchema

	/// <exclude/>
	public class WorkingHourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkingHourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkingHourCountTermSchema(WorkingHourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02");
			Name = "WorkingHourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,84,77,107,219,64,16,61,203,144,255,48,184,151,186,20,169,167,30,26,71,80,156,146,248,16,40,212,37,231,181,52,182,151,104,119,205,126,36,136,208,255,222,153,93,73,113,28,219,33,135,64,110,218,217,247,118,222,204,155,145,22,10,221,86,84,8,11,180,86,56,179,242,249,204,232,149,92,7,43,188,52,58,159,137,6,117,45,172,59,27,61,158,141,178,224,164,94,195,159,214,121,84,231,123,103,98,54,13,86,76,115,249,21,106,180,178,34,12,161,62,89,92,83,20,102,141,112,14,126,192,173,177,119,196,187,54,193,206,76,208,158,146,171,8,44,138,2,166,46,40,37,108,91,118,231,136,0,79,16,88,182,240,144,168,176,33,174,203,123,74,177,195,217,134,101,35,43,168,98,174,67,153,158,4,220,72,29,60,238,72,200,30,163,140,65,240,13,250,141,169,89,242,111,107,60,213,134,117,2,236,11,141,129,43,244,14,252,6,193,75,133,16,180,244,81,225,75,137,41,178,21,86,40,208,100,193,197,184,22,173,27,151,125,179,129,143,249,180,136,136,195,4,194,141,203,5,229,162,143,151,72,139,62,88,237,202,197,32,4,42,174,146,144,253,21,99,183,125,81,96,238,201,127,89,35,72,234,53,213,193,196,191,204,251,60,255,165,131,66,43,150,13,78,231,189,192,75,209,150,81,228,87,184,20,30,99,26,186,152,0,207,72,150,165,28,176,20,14,243,103,143,37,74,68,146,177,221,99,52,112,142,58,149,204,112,115,205,102,241,108,101,255,58,51,8,149,252,56,106,78,180,252,132,51,148,170,10,13,41,37,209,157,92,154,165,170,19,240,110,38,197,33,29,151,92,16,13,134,225,132,73,198,113,199,134,215,121,134,246,237,74,147,61,120,53,180,126,40,239,85,183,216,222,168,234,144,85,79,207,36,112,4,194,151,147,70,77,118,157,58,182,21,67,167,225,1,241,206,129,80,105,167,13,172,249,55,193,13,249,64,22,252,76,234,204,42,169,125,197,132,110,97,110,25,26,255,36,111,247,128,3,42,53,21,46,134,174,127,255,118,126,104,153,118,18,165,231,58,230,228,196,202,164,232,243,32,197,70,163,255,140,44,153,9,0,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5cacbc39-30b4-4a81-96b8-4533327f7a02"));
		}

		#endregion

	}

	#endregion

}

