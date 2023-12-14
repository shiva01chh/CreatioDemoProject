﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualizeCertificatesEventListenerSchema

	/// <exclude/>
	public class ActualizeCertificatesEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualizeCertificatesEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualizeCertificatesEventListenerSchema(ActualizeCertificatesEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("164c6445-d998-48c4-bc13-fe0265326980");
			Name = "ActualizeCertificatesEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,91,111,218,48,20,126,166,82,255,195,25,123,73,167,42,236,97,79,3,58,81,74,17,211,214,118,13,221,52,77,19,114,195,129,122,10,78,100,59,172,221,212,255,190,99,199,129,56,16,170,241,0,216,231,246,157,187,5,91,161,202,88,140,48,69,41,153,74,23,58,28,166,98,193,151,185,100,154,167,226,248,232,239,241,209,241,81,43,87,92,44,33,122,82,26,87,221,205,185,42,36,177,233,62,140,226,7,156,231,9,202,125,28,223,240,158,184,86,171,84,108,169,95,114,38,245,159,112,178,202,146,112,42,249,114,137,82,213,169,93,139,43,203,239,19,30,67,156,48,165,96,16,235,156,37,252,15,14,81,106,190,224,49,211,168,70,107,20,250,19,39,224,2,37,188,135,65,150,121,87,231,76,33,41,34,55,91,173,215,18,151,228,52,80,8,148,102,66,171,247,112,35,249,154,212,88,99,173,172,56,64,108,232,160,180,52,112,62,94,159,207,198,183,215,119,55,208,135,246,199,244,126,44,211,60,107,119,27,249,167,183,147,241,120,116,107,184,157,111,7,152,47,70,151,179,225,237,245,213,172,34,245,22,222,194,59,248,0,111,224,205,1,201,225,167,65,20,205,174,6,159,71,70,166,26,145,50,76,54,193,7,52,68,223,163,89,52,154,78,39,87,227,29,12,123,67,125,254,52,148,169,168,56,101,99,138,98,94,132,213,157,93,140,47,57,38,243,166,0,59,4,179,216,232,179,234,60,152,119,10,37,229,72,96,108,92,128,89,238,157,95,48,124,35,211,204,128,70,107,60,213,36,132,243,210,188,59,214,45,212,142,182,88,90,75,212,238,95,75,162,206,229,62,32,68,123,182,223,106,203,204,23,65,141,17,250,125,16,121,146,156,148,44,173,29,6,88,179,36,199,66,163,83,105,191,159,15,59,251,25,245,67,218,24,230,117,202,231,48,17,92,115,155,203,11,166,89,80,246,7,25,215,248,168,77,73,152,223,18,90,132,218,15,70,80,50,116,75,122,165,8,130,226,246,121,143,217,93,69,47,88,94,51,9,44,203,136,186,137,137,227,8,73,50,49,37,72,183,63,218,3,203,227,152,218,63,129,41,240,174,10,156,119,245,248,86,85,135,197,160,187,219,205,102,131,39,158,203,14,111,165,120,73,125,109,36,122,67,214,152,35,37,154,74,94,133,99,212,95,77,170,123,69,15,156,5,62,138,211,162,2,154,122,243,116,103,98,84,50,176,167,195,200,26,245,64,140,74,149,147,235,138,86,194,198,7,87,215,145,101,54,160,41,200,193,118,178,156,110,135,223,222,68,239,24,113,49,250,63,27,187,142,188,88,239,52,231,111,236,102,40,168,157,78,7,122,42,95,173,152,124,58,43,47,134,18,205,208,2,38,230,160,220,134,162,19,252,74,239,97,145,74,136,43,147,13,88,117,102,134,27,157,157,186,210,94,198,36,91,129,32,7,251,109,87,158,237,179,209,35,198,185,173,179,178,98,123,29,203,104,229,220,14,75,215,84,34,124,238,138,234,90,80,209,70,154,54,221,75,125,81,235,95,191,29,93,6,50,63,199,84,143,77,137,223,39,230,178,230,73,121,153,44,132,38,164,233,2,53,227,137,141,97,223,180,221,102,245,135,69,184,135,102,81,19,95,175,113,33,17,241,204,75,127,13,187,107,0,191,43,74,4,37,82,189,65,44,240,55,84,186,211,60,41,2,223,173,93,11,213,189,227,52,243,5,4,175,60,127,46,82,52,18,163,71,122,71,28,194,123,178,25,234,158,248,196,190,48,226,237,227,136,248,3,10,219,105,137,253,164,11,229,148,111,174,123,186,117,157,125,124,100,62,255,0,251,212,152,3,208,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("164c6445-d998-48c4-bc13-fe0265326980"));
		}

		#endregion

	}

	#endregion

}

