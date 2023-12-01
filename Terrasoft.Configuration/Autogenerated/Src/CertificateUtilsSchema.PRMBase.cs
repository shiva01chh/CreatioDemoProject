﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CertificateUtilsSchema

	/// <exclude/>
	public class CertificateUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CertificateUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CertificateUtilsSchema(CertificateUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("512c91b2-be3a-4baf-aefe-b8099c862a69");
			Name = "CertificateUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad40b837-06de-4802-b0a3-084f3cf30f81");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,87,89,111,219,56,16,126,118,129,254,7,194,251,34,1,129,210,125,221,196,1,108,231,128,139,230,216,58,217,125,102,168,177,77,64,162,84,30,78,188,69,254,251,14,15,157,182,19,55,65,243,16,75,228,204,55,215,55,67,74,208,28,84,73,25,144,123,144,146,170,98,161,147,105,33,22,124,105,36,213,188,16,159,63,253,252,252,105,96,20,23,75,50,223,40,13,249,73,239,61,57,167,154,54,139,211,34,207,11,209,126,151,208,125,75,206,39,189,133,11,161,185,230,160,112,25,55,254,144,176,68,203,100,154,81,165,200,95,100,10,82,243,5,103,84,195,131,230,153,114,66,199,199,199,228,84,153,60,167,114,115,22,222,199,100,5,89,9,146,48,167,185,40,36,41,240,213,197,161,200,19,215,43,194,26,44,149,84,48,199,45,156,210,60,102,156,17,165,81,139,5,160,109,7,6,63,157,19,181,171,151,28,178,212,250,122,39,249,26,197,252,110,233,95,42,48,9,52,45,68,182,33,127,27,144,155,105,145,153,92,92,60,151,18,148,178,24,240,204,149,86,183,2,48,255,168,33,52,25,17,47,148,184,149,232,207,248,36,88,5,145,122,195,93,47,174,65,175,138,55,221,152,67,6,76,147,43,208,33,46,72,17,95,83,166,149,115,44,122,80,32,113,69,160,148,69,53,157,215,152,88,62,12,6,107,42,201,15,43,142,94,10,120,10,168,81,79,216,137,14,18,31,70,52,12,118,134,71,100,56,102,172,48,66,207,210,97,79,232,210,8,134,207,184,23,109,101,36,142,147,177,178,48,184,91,235,93,202,34,111,160,227,228,223,21,72,136,170,221,11,135,17,237,119,177,178,187,109,172,66,110,170,95,217,28,4,35,157,61,12,42,56,97,131,74,102,234,226,135,161,89,39,232,38,218,65,50,22,233,150,254,76,41,3,231,206,16,234,127,67,98,220,74,143,18,136,112,71,37,54,172,6,25,89,169,123,158,67,242,160,217,77,241,20,191,138,139,44,227,178,1,190,66,38,34,198,225,216,85,50,175,100,97,202,201,102,95,33,79,156,152,4,109,164,8,228,160,42,164,221,237,189,188,69,72,139,164,46,11,137,190,104,1,82,173,120,89,187,165,14,39,38,219,73,108,100,234,126,210,247,192,78,222,79,242,178,236,150,186,71,108,154,129,98,16,133,114,133,220,207,11,35,25,84,8,140,122,50,57,150,31,117,37,253,40,248,18,191,210,10,173,228,13,189,84,137,43,181,208,215,130,139,200,254,187,223,148,144,124,131,133,190,53,152,94,180,184,43,235,21,66,217,48,247,182,14,178,165,208,229,188,51,184,139,240,29,61,103,100,138,76,88,22,114,211,18,29,212,64,91,212,188,251,126,61,161,170,238,81,149,220,152,252,17,169,188,168,203,138,92,199,71,85,193,198,175,216,239,4,106,179,241,78,31,166,70,74,16,186,143,234,17,247,57,240,97,171,183,120,80,45,221,217,214,67,139,223,172,244,238,254,240,149,70,242,117,43,29,74,217,234,243,166,206,158,169,219,179,60,140,199,154,6,106,140,173,178,134,150,106,135,206,90,26,168,189,110,165,105,38,244,63,52,51,94,239,166,208,94,53,120,183,179,159,126,161,161,182,59,234,247,206,175,215,199,215,17,185,50,60,37,101,187,163,218,35,13,111,9,38,211,193,212,232,128,97,185,123,72,249,228,182,186,115,63,225,186,174,196,189,84,84,105,106,251,245,74,142,214,5,6,135,36,64,75,252,63,71,218,183,210,17,66,117,101,168,18,225,238,137,155,57,91,65,78,137,242,63,163,158,102,210,22,186,166,130,46,65,38,152,174,153,235,27,6,147,205,13,6,24,237,25,118,39,45,59,4,252,207,40,152,74,166,238,220,244,155,251,15,12,230,18,105,141,160,102,67,97,47,224,47,189,209,249,228,226,25,152,209,120,67,77,31,235,199,29,161,40,131,231,246,164,89,138,226,42,23,21,212,204,94,191,191,227,213,18,239,189,169,197,112,25,75,60,40,248,141,168,49,210,232,15,158,86,60,3,18,165,50,177,82,45,100,31,7,22,108,132,136,137,163,154,13,201,197,113,106,105,122,22,13,155,243,62,136,175,237,238,78,13,46,244,89,125,82,213,58,124,65,34,159,224,228,18,52,91,217,179,235,124,18,241,180,237,199,32,72,204,59,136,81,147,226,35,111,183,129,173,53,232,26,47,129,245,242,75,120,8,191,254,231,165,197,215,3,238,212,238,203,192,239,246,191,62,252,231,71,160,55,40,226,230,33,41,22,205,164,197,37,63,106,221,103,9,205,50,66,221,72,108,119,188,251,34,217,254,36,241,43,165,37,41,17,24,243,104,216,165,201,240,204,182,146,53,80,241,230,244,216,73,59,229,238,7,77,167,15,97,156,101,135,95,170,212,187,103,143,175,66,183,251,251,237,238,209,227,246,8,249,72,146,31,55,100,137,217,21,237,244,254,142,236,110,41,119,166,230,240,172,149,31,108,40,203,77,244,83,30,92,160,143,157,25,7,87,108,171,26,61,200,222,232,255,229,74,246,154,203,175,118,23,113,13,255,254,7,109,129,214,113,143,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("512c91b2-be3a-4baf-aefe-b8099c862a69"));
		}

		#endregion

	}

	#endregion

}
