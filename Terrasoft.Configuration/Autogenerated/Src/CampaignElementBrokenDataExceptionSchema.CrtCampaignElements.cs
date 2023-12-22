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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,32,241,14,86,119,97,151,230,206,128,195,24,135,221,38,141,23,112,83,183,68,107,157,42,73,197,24,218,187,207,77,3,99,92,88,111,254,101,255,254,252,167,140,45,249,14,53,193,142,156,67,111,171,144,111,44,87,166,238,29,6,99,57,223,96,219,161,169,121,219,80,75,28,252,108,122,154,77,39,189,55,92,195,251,209,7,106,159,102,83,81,30,28,213,210,15,155,6,189,95,192,205,216,179,179,31,196,47,24,112,251,169,169,27,156,227,148,82,10,150,190,111,91,116,199,117,170,47,29,96,184,52,26,3,149,80,196,121,176,78,52,109,217,27,89,204,1,74,49,20,5,116,218,6,52,174,203,207,214,234,202,187,235,139,198,104,208,3,224,63,248,96,1,87,172,147,83,228,253,61,83,32,130,235,117,176,78,174,125,139,214,99,199,237,73,81,120,101,19,12,54,230,139,60,32,48,29,132,218,7,100,9,222,86,16,246,36,35,68,160,29,85,171,236,62,91,166,214,233,142,131,9,123,56,111,65,240,29,105,83,25,73,76,158,83,210,146,215,245,88,83,126,1,83,183,100,203,14,29,182,192,242,35,172,178,212,158,173,119,66,148,10,161,67,73,154,188,118,166,16,252,1,54,154,231,75,21,103,163,85,10,247,62,250,92,98,27,254,157,228,254,40,49,23,232,105,126,169,79,240,157,162,38,46,199,180,99,61,170,127,69,209,174,191,31,55,205,236,140,206,2,0,0 };
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

