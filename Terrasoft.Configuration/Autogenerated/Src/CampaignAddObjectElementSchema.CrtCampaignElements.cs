﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CampaignAddObjectElementSchema

	/// <exclude/>
	public class CampaignAddObjectElementSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CampaignAddObjectElementSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CampaignAddObjectElementSchema(CampaignAddObjectElementSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("71cf88a2-35ae-46c5-bcf6-531c7f489e13");
			Name = "CampaignAddObjectElement";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0bba11f-3986-4819-81ab-1d3ddbfc1f48");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,86,205,111,218,48,20,63,83,105,255,195,19,61,12,164,10,238,45,32,117,180,171,42,181,43,90,217,14,187,25,231,5,188,37,118,102,59,237,88,213,255,125,254,136,67,18,8,165,83,15,211,56,160,248,249,249,125,254,222,207,230,36,69,149,17,138,48,71,41,137,18,177,30,76,5,143,217,50,151,68,51,193,223,29,61,189,59,234,228,138,241,37,220,175,149,198,244,172,177,54,250,73,130,212,42,171,193,21,114,148,140,110,233,220,48,254,115,35,172,250,146,216,38,31,204,164,160,168,148,217,55,26,199,18,151,198,5,76,19,162,212,41,76,73,154,17,182,228,231,81,116,183,248,110,220,95,38,152,34,215,78,119,56,28,194,72,229,105,74,228,122,82,172,195,1,80,116,133,41,1,244,250,160,5,80,137,68,35,112,124,4,225,108,21,71,98,33,65,161,205,13,35,48,186,76,175,195,105,110,234,6,143,76,175,32,147,24,97,204,184,81,161,34,201,83,14,15,36,201,81,13,66,28,195,74,32,89,190,72,24,5,106,115,104,77,1,54,217,125,32,10,167,50,111,166,216,121,114,105,110,106,98,74,175,101,78,181,144,166,52,51,231,196,107,52,43,225,4,23,24,147,60,209,38,222,242,152,203,117,164,16,109,49,226,113,183,45,182,238,112,50,40,237,86,51,11,169,181,29,236,245,193,2,169,243,188,39,174,233,91,198,227,36,25,145,36,117,205,26,119,149,200,37,197,238,228,218,56,33,220,32,94,196,135,122,24,13,157,161,131,242,108,237,170,247,223,183,54,58,157,83,208,43,166,122,94,118,2,60,79,18,255,255,191,148,105,203,110,196,168,158,139,207,184,96,60,234,78,46,152,35,12,19,133,29,64,233,164,141,201,84,239,129,69,106,191,81,243,109,52,239,221,185,238,100,230,86,64,235,147,254,150,221,59,129,77,224,163,171,156,69,39,96,255,39,80,205,238,196,183,216,81,88,176,87,126,248,88,161,26,120,223,12,252,194,12,122,137,134,154,177,134,106,21,29,199,200,35,207,0,117,58,48,188,153,161,212,12,45,25,72,161,29,129,237,1,212,117,100,201,45,102,40,109,179,3,49,18,151,104,219,180,7,179,32,30,12,105,179,8,93,33,224,220,29,242,81,118,150,168,139,175,142,68,157,75,94,214,221,65,88,149,69,185,17,203,249,58,195,178,232,103,238,208,243,1,169,222,162,94,137,232,16,210,155,58,146,87,64,28,207,179,128,110,189,34,26,152,21,211,68,112,135,118,189,50,96,207,165,195,82,208,219,55,61,62,55,53,153,90,3,209,198,116,97,234,150,200,31,168,205,245,118,153,18,150,20,120,50,160,12,199,42,176,44,107,233,175,33,112,22,3,115,134,26,218,240,91,241,107,89,165,127,246,34,131,188,88,11,145,173,255,166,20,255,222,192,215,59,36,50,246,198,29,50,133,234,29,194,9,240,10,58,120,93,187,247,242,197,193,80,80,25,82,67,1,20,138,71,215,199,68,60,6,238,123,109,231,115,133,210,76,56,247,143,194,214,171,228,75,93,109,215,5,18,58,208,98,97,59,86,111,101,95,227,118,228,231,107,176,189,209,171,71,8,245,188,66,159,30,136,4,252,133,52,215,100,145,96,176,57,222,221,184,170,219,130,26,27,78,198,13,55,197,109,114,233,158,159,159,236,179,115,12,155,69,121,215,216,151,231,87,247,240,52,251,213,101,161,49,103,41,126,51,108,114,23,199,10,109,120,179,10,76,6,245,93,207,190,158,132,175,57,211,140,36,236,55,134,92,118,212,105,43,125,143,187,0,225,173,237,42,42,27,204,238,165,117,161,145,153,223,31,73,220,249,156,171,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("71cf88a2-35ae-46c5-bcf6-531c7f489e13"));
		}

		#endregion

	}

	#endregion

}
