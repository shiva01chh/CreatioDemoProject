namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ApprovalConstantsSchema

	/// <exclude/>
	public class ApprovalConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ApprovalConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ApprovalConstantsSchema(ApprovalConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("96d50106-6c2d-4bb1-9f14-582f073e5e34");
			Name = "ApprovalConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("be1f674b-cdb4-46e4-8c46-23cae20b9205");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,193,75,195,48,20,198,207,27,236,127,8,243,162,135,216,165,73,155,197,169,48,118,240,58,84,240,252,146,190,142,202,214,150,38,85,198,240,127,55,219,108,109,117,194,192,119,9,249,248,222,247,126,9,73,14,27,180,37,24,36,207,88,85,96,139,212,93,47,138,60,205,86,117,5,46,43,242,209,112,55,26,18,95,181,205,242,21,121,218,90,135,155,217,104,120,20,47,42,92,121,19,89,172,193,218,27,50,47,203,170,120,131,181,79,176,14,114,103,27,95,16,4,228,214,214,155,13,84,219,251,111,169,241,147,78,67,107,15,250,254,178,214,235,204,16,111,115,126,49,251,129,167,230,237,173,187,102,108,23,113,89,21,37,86,46,67,207,185,60,100,117,93,39,0,27,249,5,50,119,56,186,159,92,219,235,31,61,193,239,166,62,233,67,157,37,109,198,221,61,201,241,253,160,93,142,185,136,195,72,137,132,74,9,146,10,61,1,58,149,2,104,156,76,117,36,116,168,184,54,227,171,217,153,152,115,99,176,116,152,252,139,179,13,233,129,162,84,41,24,205,41,55,60,164,130,163,164,16,41,164,44,212,192,194,8,99,198,195,243,65,31,241,21,205,127,65,219,144,30,40,40,14,122,162,21,53,192,99,127,163,42,162,74,135,156,226,132,1,176,88,25,206,167,95,160,131,19,148,173,182,240,31,98,221,37,28,156,194,27,252,193,182,128,252,216,222,99,83,44,156,164,9,166,52,86,26,169,96,241,148,234,40,229,52,98,82,50,161,37,8,84,13,219,224,2,243,228,248,110,253,238,227,160,117,165,209,208,107,251,250,4,63,76,181,192,191,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("96d50106-6c2d-4bb1-9f14-582f073e5e34"));
		}

		#endregion

	}

	#endregion

}

