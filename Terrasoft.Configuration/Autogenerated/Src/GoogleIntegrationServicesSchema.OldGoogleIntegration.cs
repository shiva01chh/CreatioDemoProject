﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GoogleIntegrationServicesSchema

	/// <exclude/>
	public class GoogleIntegrationServicesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GoogleIntegrationServicesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GoogleIntegrationServicesSchema(GoogleIntegrationServicesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9442e89-69f7-4922-a4df-5ef096a3aa03");
			Name = "GoogleIntegrationServices";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2e3e95a4-2024-4552-b820-30e9633c8933");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,86,205,110,219,56,16,62,171,64,223,129,112,47,18,96,240,1,146,186,128,55,77,83,47,144,212,136,82,244,16,244,64,75,19,133,187,146,168,37,41,53,110,225,119,239,80,148,100,234,207,222,118,47,155,67,32,14,135,243,247,125,51,158,156,101,160,10,22,1,121,0,41,153,18,79,154,94,137,252,137,39,165,100,154,139,252,245,171,31,175,95,121,165,226,121,66,194,189,210,144,93,14,206,244,190,204,53,207,128,134,32,57,75,249,247,250,221,72,11,111,43,30,193,173,136,33,61,121,73,215,145,230,213,121,35,244,11,236,142,10,110,248,89,230,62,117,111,36,204,201,233,7,22,105,33,57,168,41,13,116,69,63,106,93,208,245,78,105,137,154,24,156,163,120,45,165,144,155,252,73,144,213,208,172,27,49,22,182,126,76,59,125,52,129,70,222,72,72,208,32,185,74,153,82,23,228,70,136,36,133,77,174,33,177,24,52,54,106,221,199,230,208,218,250,106,100,107,85,220,129,198,196,11,212,223,241,148,235,253,61,252,83,114,9,25,228,90,249,238,193,68,130,97,158,121,98,180,104,35,136,3,227,164,40,119,41,143,72,100,98,60,17,162,247,163,14,179,203,233,61,164,144,48,13,152,215,86,26,88,109,26,94,97,15,36,110,238,73,37,120,76,174,95,32,42,181,107,248,22,244,179,136,125,177,251,11,34,77,42,150,150,16,92,54,46,32,143,173,151,190,203,173,20,5,72,205,107,159,117,212,141,75,155,65,197,165,46,89,74,62,43,144,88,197,28,106,52,135,71,195,122,207,75,64,55,95,158,4,93,202,156,248,125,189,192,176,194,96,1,47,8,120,41,37,22,15,49,87,10,239,30,23,125,221,197,215,203,218,212,193,252,63,244,98,66,82,213,60,194,70,210,251,48,122,134,140,221,97,103,30,163,176,47,85,243,113,152,76,104,4,202,71,72,177,16,100,44,153,75,174,38,160,109,132,61,189,1,253,118,198,228,59,63,135,111,4,51,195,184,75,163,189,150,73,105,120,227,47,202,126,202,203,65,93,131,165,117,232,205,26,128,65,13,208,196,176,44,65,208,47,164,231,157,162,131,101,208,28,255,70,25,222,227,60,196,184,96,130,139,159,48,245,250,195,159,227,41,225,67,201,146,184,212,197,198,203,203,52,13,154,186,107,185,111,17,24,61,244,59,174,59,0,153,170,205,71,220,152,242,194,50,138,144,130,232,12,171,11,86,120,104,74,70,34,166,163,103,130,25,68,80,212,76,135,96,192,130,127,231,228,104,96,69,6,62,28,138,158,7,197,105,208,199,174,192,238,116,243,30,113,250,110,242,74,252,13,126,83,229,21,89,108,63,133,15,134,93,146,63,64,86,164,6,74,148,134,154,73,61,138,29,245,254,16,241,62,212,251,212,104,161,185,91,44,15,75,160,147,210,47,146,21,5,196,150,157,102,238,129,210,31,132,204,152,238,61,176,34,250,167,18,249,146,180,37,57,173,23,216,28,108,109,47,72,163,176,101,18,137,172,65,250,117,159,99,232,19,181,94,216,183,77,155,207,67,50,157,181,223,12,149,97,67,181,112,143,134,205,106,164,106,241,108,104,113,170,31,10,147,14,89,189,107,217,49,154,24,116,38,198,182,147,3,119,174,253,119,30,124,46,98,252,178,238,66,17,225,90,178,142,34,129,123,202,255,128,10,103,225,156,13,222,191,41,241,55,82,185,162,77,220,194,249,27,40,85,76,118,99,201,152,166,200,74,5,86,141,62,136,176,230,143,223,78,91,143,63,17,59,148,232,70,221,9,125,157,21,122,143,183,221,68,24,131,110,51,217,74,168,184,40,213,84,70,189,33,119,176,92,88,142,82,188,156,159,40,86,58,16,158,91,168,218,82,219,141,234,61,211,204,37,218,233,77,167,131,233,130,244,22,229,102,3,58,154,30,110,66,147,35,175,241,37,42,220,26,57,46,102,199,77,50,4,221,29,166,166,181,1,15,156,189,115,199,148,217,54,157,71,109,93,107,205,151,200,244,55,97,19,25,117,198,173,122,103,212,174,169,87,118,95,68,3,180,83,52,50,135,32,189,49,1,206,110,251,43,160,161,12,255,126,2,3,217,205,228,144,12,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9442e89-69f7-4922-a4df-5ef096a3aa03"));
		}

		#endregion

	}

	#endregion

}

