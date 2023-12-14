﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookRepositorySchema

	/// <exclude/>
	public class WebhookRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookRepositorySchema(WebhookRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dab2516e-9a4a-47d8-9a1e-c28570275417");
			Name = "WebhookRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c57d96f3-f6a9-41c3-a651-44ed58ea0c9a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,77,111,219,48,12,61,167,64,255,131,224,93,18,192,112,238,253,2,214,174,235,138,161,67,215,180,235,97,216,65,181,153,68,152,45,121,146,156,193,27,250,223,71,217,178,45,127,213,205,134,5,185,88,124,143,164,248,40,74,156,38,160,82,26,2,185,7,41,169,18,107,29,92,8,190,102,155,76,82,205,4,63,60,248,125,120,48,203,20,227,27,178,202,149,134,228,184,243,141,248,56,134,208,128,85,176,74,33,100,52,102,191,32,106,112,174,107,9,99,235,193,37,215,76,51,80,8,64,200,114,185,36,39,42,75,18,42,243,51,251,125,7,169,4,5,92,43,162,183,64,24,215,32,215,38,249,181,144,228,39,60,109,133,248,78,20,221,161,243,160,114,177,116,124,164,217,83,204,66,135,119,253,88,146,208,177,80,76,11,153,35,202,108,184,23,190,88,184,144,64,53,212,145,192,36,156,7,53,124,217,197,159,164,84,210,132,112,44,242,169,103,89,183,102,9,48,1,229,157,217,232,36,173,215,72,88,23,51,56,89,22,235,141,55,9,58,147,92,213,180,50,62,97,17,66,43,155,1,95,101,44,34,43,186,3,11,156,127,66,239,95,104,156,65,35,21,233,165,179,48,194,60,143,214,190,10,42,225,71,6,74,19,45,58,117,32,52,162,41,58,34,47,84,62,140,169,82,164,87,116,114,52,170,132,217,207,27,9,27,147,242,123,6,113,164,142,200,173,100,59,212,161,52,166,229,7,230,69,35,193,227,156,60,40,144,216,194,220,238,179,253,121,108,61,2,143,74,167,237,8,8,84,90,102,33,198,55,113,138,164,75,196,112,63,52,240,87,54,65,214,202,198,59,187,70,7,148,99,39,138,117,39,83,87,125,91,189,94,137,230,157,189,182,189,47,72,209,201,179,14,232,180,3,51,178,91,221,71,235,114,3,122,43,70,75,127,89,234,127,158,177,56,218,175,229,108,134,59,90,31,223,85,184,133,132,98,146,237,172,203,225,144,151,214,27,202,233,6,100,112,5,186,170,223,121,110,2,206,61,27,222,43,154,185,229,24,93,182,66,4,229,97,46,253,118,10,105,217,43,208,214,95,177,19,53,183,14,252,145,195,51,155,149,167,176,50,187,149,29,236,31,12,224,158,253,157,137,210,63,88,251,205,23,175,51,30,122,83,228,95,102,82,171,41,173,250,59,97,166,77,183,84,182,39,234,138,237,221,15,52,101,31,33,111,84,107,80,95,189,183,133,205,251,214,136,28,10,156,233,92,223,231,41,12,83,46,26,128,203,219,226,212,48,91,28,228,124,40,141,46,30,103,159,204,27,204,48,239,115,27,228,242,237,244,60,23,209,200,214,34,170,169,75,80,34,147,33,60,200,120,24,190,170,204,46,167,234,243,194,54,204,123,116,33,21,215,226,2,20,243,29,172,81,168,44,225,86,206,69,15,225,152,231,149,32,190,85,109,2,237,106,225,187,210,77,240,42,61,252,74,182,9,124,87,7,191,43,223,4,255,174,17,11,185,142,116,19,188,70,20,191,209,111,130,211,22,196,111,107,184,216,111,70,79,94,91,67,207,152,255,244,138,121,253,35,166,253,134,177,87,222,95,62,101,250,247,10,30,131,214,253,52,54,193,107,125,48,230,124,112,170,7,120,7,154,250,56,242,189,32,15,174,226,31,127,127,0,35,54,224,37,106,11,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dab2516e-9a4a-47d8-9a1e-c28570275417"));
		}

		#endregion

	}

	#endregion

}

