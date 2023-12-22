namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadMLangBinderSchema

	/// <exclude/>
	public class LeadMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadMLangBinderSchema(LeadMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545");
			Name = "LeadMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("df5a8bee-e0f6-4225-b7c8-127f6fd1b1ca");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,193,106,195,48,12,61,167,208,127,16,221,165,131,145,220,219,82,104,203,6,133,148,13,54,216,217,137,213,204,16,219,193,86,194,74,217,191,79,177,147,145,150,249,98,252,222,211,147,158,108,132,70,223,136,18,225,3,157,19,222,158,41,61,88,115,86,85,235,4,41,107,230,179,235,124,150,180,94,153,234,70,226,48,125,17,37,89,167,208,175,255,81,124,98,193,42,173,173,97,150,249,7,135,21,219,193,161,22,222,175,32,71,33,79,185,48,213,94,25,137,46,72,178,44,131,141,111,181,22,238,178,29,222,189,14,116,91,147,170,89,220,138,10,161,236,29,160,8,117,233,88,150,77,234,154,182,168,85,57,232,238,26,193,10,118,77,243,220,161,161,92,121,66,131,110,47,60,114,213,53,204,240,55,231,9,233,203,74,158,244,45,184,69,114,112,182,29,199,84,18,161,179,74,194,171,97,199,119,18,142,150,163,53,111,144,240,155,160,140,247,35,244,59,76,146,130,59,165,19,249,72,175,3,27,54,19,119,122,73,251,105,55,199,124,200,124,36,228,223,176,238,41,196,185,71,183,203,69,15,47,162,207,207,144,3,141,140,81,194,59,162,183,32,99,211,243,11,122,171,69,230,11,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f319c644-f47a-4da7-b6eb-96ccd3799545"));
		}

		#endregion

	}

	#endregion

}

