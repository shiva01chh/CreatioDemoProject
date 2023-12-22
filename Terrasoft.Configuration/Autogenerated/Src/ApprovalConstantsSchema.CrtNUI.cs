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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,95,107,194,48,20,197,159,21,252,14,97,190,108,15,89,77,147,54,102,255,64,124,216,171,108,131,61,223,164,183,210,161,109,105,210,13,145,125,247,69,93,187,118,115,32,120,95,66,14,231,158,251,75,72,114,88,163,45,193,32,121,193,170,2,91,164,238,122,94,228,105,182,172,43,112,89,145,143,134,219,209,144,248,170,109,150,47,201,243,198,58,92,223,142,134,7,113,92,225,210,155,200,124,5,214,222,144,89,89,86,197,59,172,124,130,117,144,59,219,248,130,32,32,119,182,94,175,161,218,60,252,72,141,159,116,26,90,123,208,247,151,181,94,101,134,120,155,243,139,217,13,60,54,111,103,221,54,99,187,136,139,170,40,177,114,25,122,206,197,62,171,235,58,2,216,200,175,144,185,253,209,253,228,218,94,255,234,9,254,54,245,73,31,235,44,105,51,238,31,72,142,31,123,237,242,130,139,56,140,148,72,168,148,32,169,208,19,160,83,41,128,198,201,84,71,66,135,138,107,115,113,117,123,34,230,204,24,44,29,38,103,113,182,33,61,80,148,42,5,163,57,229,134,135,84,112,148,20,34,133,148,133,26,88,24,97,204,120,120,58,232,19,190,161,57,23,180,13,233,129,130,226,160,39,90,81,3,60,246,55,170,34,170,116,200,41,78,24,0,139,149,225,124,250,13,58,56,66,217,106,115,255,33,86,93,194,193,49,188,193,63,108,115,200,15,237,61,54,197,194,73,154,96,74,99,165,145,10,22,79,169,142,82,78,35,38,37,19,90,130,64,213,176,13,198,152,39,135,119,235,119,159,123,173,43,141,134,94,235,214,23,207,247,253,191,199,3,0,0 };
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

