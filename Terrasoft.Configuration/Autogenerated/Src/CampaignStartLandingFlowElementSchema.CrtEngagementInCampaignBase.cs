namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignStartLandingFlowElementSchema

	/// <exclude/>
	public class CampaignStartLandingFlowElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignStartLandingFlowElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignStartLandingFlowElementSchema(CampaignStartLandingFlowElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0");
			Name = "CampaignStartLandingFlowElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,143,177,14,194,48,12,68,231,86,234,63,88,98,111,119,132,88,170,50,177,193,15,184,137,41,145,18,167,74,28,65,133,248,119,82,10,2,38,188,221,201,103,191,99,116,20,71,84,4,71,10,1,163,63,73,221,122,62,153,33,5,20,227,185,42,111,85,89,149,197,42,208,144,37,180,22,99,92,67,139,110,68,51,240,65,48,200,30,89,27,30,118,214,95,58,75,142,88,158,145,166,105,96,19,147,115,24,166,237,75,119,87,82,73,176,183,4,234,117,2,104,201,128,156,81,0,181,142,160,60,11,42,137,32,254,179,134,73,27,226,76,218,79,16,179,129,182,126,63,105,190,190,140,169,183,70,129,154,57,255,97,194,167,200,15,124,145,59,23,247,165,55,177,94,170,207,242,233,229,121,0,86,198,134,186,55,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("61400b6c-6c0b-7653-fe9c-14375ff174b0"));
		}

		#endregion

	}

	#endregion

}

