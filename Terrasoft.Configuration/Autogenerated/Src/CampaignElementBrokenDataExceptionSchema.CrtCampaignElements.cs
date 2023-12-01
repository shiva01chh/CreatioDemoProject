namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignElementBrokenDataExceptionSchema

	/// <exclude/>
	public class CampaignElementBrokenDataExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignElementBrokenDataExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignElementBrokenDataExceptionSchema(CampaignElementBrokenDataExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f");
			Name = "CampaignElementBrokenDataException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,32,241,14,86,119,97,151,246,206,128,195,24,135,221,38,141,23,112,83,183,88,107,146,42,73,197,24,218,187,207,77,3,99,92,88,111,254,101,255,254,252,167,6,53,249,14,21,193,142,156,67,111,235,144,111,172,169,185,233,29,6,182,38,223,160,238,144,27,179,109,73,147,9,126,54,61,205,166,147,222,179,105,224,253,232,3,233,167,217,84,148,7,71,141,244,195,166,69,239,23,112,51,246,236,236,7,153,23,12,184,253,84,212,13,206,113,170,40,10,88,250,94,107,116,199,117,170,47,29,192,166,98,133,129,42,40,227,60,88,39,154,178,198,179,44,54,1,42,49,20,5,84,218,6,52,174,203,207,214,197,149,119,215,151,45,43,80,3,224,63,248,96,1,87,172,147,83,228,253,61,83,32,130,235,85,176,78,174,125,139,214,99,199,237,73,81,120,53,28,24,91,254,34,15,8,134,14,66,237,3,26,9,222,214,16,246,36,35,68,160,28,213,171,236,62,91,86,172,211,29,7,14,123,56,111,65,240,29,41,174,89,18,147,231,148,180,228,117,61,54,148,95,192,138,91,178,101,135,14,53,24,249,17,86,89,106,207,214,59,33,74,133,208,161,36,77,94,57,46,5,127,128,141,230,249,178,136,179,209,42,133,123,31,125,46,177,13,255,78,114,127,148,152,75,244,52,191,212,39,248,78,81,147,169,198,180,99,61,170,127,69,209,228,251,1,96,40,138,16,197,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("244e9e83-75da-48e7-886d-ea2dfe372f7f"));
		}

		#endregion

	}

	#endregion

}

