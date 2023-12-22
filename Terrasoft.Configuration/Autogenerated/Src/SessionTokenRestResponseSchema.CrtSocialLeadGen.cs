namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SessionTokenRestResponseSchema

	/// <exclude/>
	public class SessionTokenRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SessionTokenRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SessionTokenRestResponseSchema(SessionTokenRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff");
			Name = "SessionTokenRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,143,193,74,196,64,12,134,207,91,232,59,4,188,183,119,21,47,21,188,8,187,216,190,192,108,155,214,193,118,82,146,140,34,139,239,238,116,166,171,221,21,7,50,144,63,225,207,247,59,51,161,204,166,69,104,144,217,8,245,90,84,228,122,59,120,54,106,201,21,53,181,214,140,207,104,186,39,116,121,118,202,179,60,219,221,48,14,97,8,213,104,68,110,161,70,145,208,54,244,134,238,5,69,67,205,228,4,227,110,89,150,112,47,126,154,12,127,62,172,125,53,146,239,128,215,53,120,108,246,240,97,245,21,172,235,137,167,120,24,204,145,188,130,36,107,208,197,187,56,219,149,27,191,217,31,71,219,66,187,160,252,75,2,1,114,27,100,153,29,152,222,109,135,252,75,187,75,233,126,226,133,141,25,89,45,134,140,135,120,38,205,175,35,69,161,190,38,253,139,122,102,21,101,235,134,11,88,56,193,128,122,23,242,134,239,107,197,64,215,37,146,216,39,245,82,140,218,246,125,3,225,225,166,136,209,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e3a15ec-b9d8-c38d-ff2f-9dd9e4d205ff"));
		}

		#endregion

	}

	#endregion

}

