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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,203,106,195,48,16,60,39,144,127,88,210,75,10,197,190,39,33,144,132,22,2,14,45,180,208,243,218,218,184,2,75,50,122,152,134,208,127,239,90,178,75,18,170,139,208,204,236,236,206,74,163,34,215,98,69,240,65,214,162,51,39,159,237,141,62,201,58,88,244,210,232,217,244,50,155,78,130,147,186,190,145,88,202,94,176,242,198,74,114,171,127,20,159,84,178,74,41,163,153,101,254,193,82,205,118,176,111,208,185,37,20,132,226,88,160,174,119,82,11,178,81,146,231,57,172,93,80,10,237,121,51,188,123,29,168,208,120,217,176,56,96,77,80,245,14,80,198,186,108,44,203,175,234,218,80,54,178,26,116,119,141,96,9,219,182,125,238,72,251,66,58,79,154,236,14,29,113,213,37,206,240,55,231,145,252,151,17,60,233,91,116,75,228,224,108,58,142,41,5,65,103,164,128,87,205,142,239,30,173,95,140,214,188,65,79,223,30,170,116,63,66,191,195,201,164,228,78,217,149,124,164,87,145,141,155,73,59,61,103,253,180,235,67,49,100,62,120,226,223,48,246,41,198,185,71,55,139,121,15,207,147,207,207,144,131,180,72,81,226,59,161,183,32,99,253,249,5,53,221,251,17,3,2,0,0 };
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

