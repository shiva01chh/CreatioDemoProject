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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,32,241,14,86,119,97,151,230,206,128,195,24,135,221,38,141,23,112,83,183,88,107,147,42,73,197,24,218,187,207,77,3,99,92,88,111,254,101,255,254,252,167,6,91,242,29,106,130,29,57,135,222,86,33,223,88,83,113,221,59,12,108,77,190,193,182,67,174,205,182,161,150,76,240,179,233,105,54,157,244,158,77,13,239,71,31,168,125,154,77,69,121,112,84,75,63,108,26,244,126,1,55,99,207,206,126,144,121,193,128,219,79,77,221,224,28,167,148,82,176,244,125,219,162,59,174,83,125,233,0,54,37,107,12,84,66,17,231,193,58,209,180,53,158,101,177,9,80,138,161,40,160,211,54,160,113,93,126,182,86,87,222,93,95,52,172,65,15,128,255,224,131,5,92,177,78,78,145,247,247,76,129,8,174,215,193,58,185,246,45,90,143,29,183,39,69,225,213,112,96,108,248,139,60,32,24,58,8,181,15,104,36,120,91,65,216,147,140,16,129,118,84,173,178,251,108,153,90,167,59,14,28,246,112,222,130,224,59,210,92,177,36,38,207,41,105,201,235,122,172,41,191,128,169,91,178,101,135,14,91,48,242,35,172,178,212,158,173,119,66,148,10,161,67,73,154,188,118,92,8,254,0,27,205,243,165,138,179,209,42,133,123,31,125,46,177,13,255,78,114,127,148,152,11,244,52,191,212,39,248,78,81,147,41,199,180,99,61,170,127,69,209,134,239,7,227,237,117,127,198,2,0,0 };
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

