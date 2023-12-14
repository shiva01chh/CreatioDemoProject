namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignConfigurationServiceResponseSchema

	/// <exclude/>
	public class CampaignConfigurationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignConfigurationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignConfigurationServiceResponseSchema(CampaignConfigurationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fd1fe187-de0b-4898-b834-f29572b7524b");
			Name = "CampaignConfigurationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,83,61,111,194,48,16,157,131,196,127,56,193,66,150,176,67,219,5,58,116,0,33,168,212,161,98,56,204,37,117,149,216,145,237,148,82,212,255,222,203,23,4,212,162,8,213,147,253,228,119,239,189,243,89,97,66,54,69,65,240,76,198,160,213,161,11,38,90,133,50,202,12,58,169,85,183,115,232,118,188,204,74,21,193,106,111,29,37,227,227,249,68,153,103,50,88,145,249,144,130,102,122,75,113,48,69,135,92,199,25,20,110,124,81,32,88,102,202,201,132,114,134,196,88,126,21,66,124,139,239,245,13,69,124,128,73,140,214,142,96,130,73,138,50,82,103,150,42,161,37,27,215,202,82,193,27,14,135,112,103,179,36,65,179,127,168,206,181,62,132,218,128,168,42,129,45,217,96,42,122,80,179,135,13,250,107,211,255,154,129,52,219,196,82,128,200,109,181,114,5,35,184,110,218,59,20,198,79,137,25,118,38,19,78,27,14,190,40,244,202,27,151,217,10,96,74,33,102,177,3,113,162,129,211,32,12,161,35,144,12,162,226,148,58,108,229,54,56,234,52,187,80,167,110,83,97,224,67,62,40,158,247,130,70,241,91,63,169,80,195,61,40,218,65,3,25,248,249,48,120,223,87,130,77,110,75,0,59,233,222,128,7,146,251,32,115,237,13,90,218,2,55,150,62,5,165,57,227,31,66,62,214,181,128,124,126,225,92,99,64,55,36,239,147,218,150,239,126,62,4,11,163,83,50,78,82,155,17,168,170,131,222,188,147,112,127,164,43,38,121,70,201,134,204,96,206,159,157,157,245,118,39,91,61,127,221,232,65,51,65,115,95,230,139,168,248,202,158,103,171,205,239,97,74,244,28,44,176,124,253,0,209,56,220,141,112,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fd1fe187-de0b-4898-b834-f29572b7524b"));
		}

		#endregion

	}

	#endregion

}

