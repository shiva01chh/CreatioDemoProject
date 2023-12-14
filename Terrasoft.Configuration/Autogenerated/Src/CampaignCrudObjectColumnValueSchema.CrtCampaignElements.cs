namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignCrudObjectColumnValueSchema

	/// <exclude/>
	public class CampaignCrudObjectColumnValueSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignCrudObjectColumnValueSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignCrudObjectColumnValueSchema(CampaignCrudObjectColumnValueSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("64496986-5fe2-4f0f-beca-e34f759c7102");
			Name = "CampaignCrudObjectColumnValue";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,79,195,48,12,134,207,155,180,255,96,105,247,245,206,16,151,34,24,135,9,4,140,187,155,184,109,80,62,70,156,32,77,19,255,157,52,233,166,129,196,88,15,81,227,216,239,251,216,182,104,136,183,40,8,94,201,123,100,215,134,69,237,108,171,186,232,49,40,103,103,211,253,108,58,137,172,108,7,47,59,14,100,150,179,105,138,204,61,117,233,25,106,141,204,87,80,163,217,162,234,108,237,163,124,108,222,73,132,218,233,104,236,27,234,72,185,160,170,42,184,230,104,12,250,221,205,120,47,57,240,57,36,129,113,146,52,132,30,3,40,134,200,36,161,217,129,24,133,161,126,222,220,130,203,210,64,154,12,217,192,139,131,110,117,34,188,141,141,86,2,196,0,246,31,215,100,159,217,142,221,172,41,244,78,166,126,158,178,72,121,252,77,158,3,27,171,62,18,180,146,137,67,181,138,60,184,22,134,255,144,152,179,197,226,88,123,74,119,192,187,143,74,142,253,111,30,36,236,161,163,176,4,30,142,175,51,182,153,123,176,226,52,3,17,210,140,46,49,27,199,86,138,47,181,186,211,216,65,112,160,172,84,2,3,149,213,148,93,245,200,96,80,120,199,231,141,27,231,52,172,144,215,57,247,79,255,57,89,89,54,144,239,37,250,51,152,99,195,247,13,74,89,138,77,178,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("64496986-5fe2-4f0f-beca-e34f759c7102"));
		}

		#endregion

	}

	#endregion

}

