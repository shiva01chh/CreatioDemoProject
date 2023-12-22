namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignInfoSchema

	/// <exclude/>
	public class CampaignInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignInfoSchema(CampaignInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42");
			Name = "CampaignInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,219,74,3,65,12,134,175,45,244,29,2,189,239,222,91,241,166,168,244,174,80,251,0,211,157,236,108,112,231,224,36,131,148,226,187,59,59,219,195,42,34,86,151,101,32,167,63,31,73,156,178,200,65,213,8,207,24,163,98,223,200,124,233,93,67,38,69,37,228,221,116,114,152,78,110,18,147,51,176,217,179,160,93,100,59,255,179,136,38,199,97,217,41,230,91,88,42,27,20,25,183,114,141,159,78,114,188,170,42,184,227,100,173,138,251,251,163,93,114,65,90,37,16,49,68,100,116,194,208,145,105,229,13,251,23,234,163,12,176,40,65,160,172,6,214,107,236,230,39,201,106,164,25,210,174,163,26,234,34,251,153,224,230,80,40,206,152,235,232,3,70,33,204,172,235,82,54,196,191,98,22,199,214,209,107,202,221,117,230,163,134,48,130,111,46,104,189,83,246,243,115,245,152,232,132,244,148,72,95,136,52,28,192,160,44,128,251,231,253,207,157,251,161,36,190,162,243,166,20,92,209,255,177,83,102,88,16,57,77,117,222,1,95,218,135,232,77,94,26,15,203,249,25,99,231,125,7,43,183,62,149,252,107,0,210,34,4,21,169,166,160,156,228,131,113,47,168,143,123,0,174,91,180,234,23,67,121,40,249,155,146,190,253,126,38,51,116,122,56,152,98,15,222,177,51,95,126,113,142,191,15,204,250,116,40,68,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d788e01e-bff4-487a-85dc-ee3d99dc9d42"));
		}

		#endregion

	}

	#endregion

}

