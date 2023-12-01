﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PrmCertifiedContactsActualizerEventListenerSchema

	/// <exclude/>
	public class PrmCertifiedContactsActualizerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PrmCertifiedContactsActualizerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PrmCertifiedContactsActualizerEventListenerSchema(PrmCertifiedContactsActualizerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62cc41d2-c829-47ff-91e7-ee6f8a7a627d");
			Name = "PrmCertifiedContactsActualizerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("17d20118-0995-427a-b811-b7f3235a9cbc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,75,79,27,49,16,62,47,18,255,193,221,94,146,10,109,184,244,66,30,136,134,128,168,10,165,130,170,135,170,66,198,59,73,220,238,218,43,219,155,6,16,255,189,227,181,55,89,47,9,143,38,82,162,25,207,124,254,230,105,65,115,208,5,101,64,174,65,41,170,229,212,36,99,41,166,124,86,42,106,184,20,187,59,15,187,59,81,169,185,152,145,171,59,109,32,199,243,44,3,102,15,117,114,10,2,20,103,253,149,205,183,146,42,115,223,150,147,179,188,200,146,115,106,216,28,148,222,124,122,173,248,108,22,156,54,41,41,216,166,79,78,40,51,82,113,216,232,249,3,110,209,42,207,165,216,236,191,253,4,145,175,144,110,90,102,160,182,90,4,185,66,43,180,235,245,122,100,160,203,60,167,234,110,228,229,35,102,74,154,241,123,32,5,6,140,41,35,76,10,131,188,9,3,101,248,148,51,106,64,39,181,119,175,225,94,148,183,25,103,132,101,84,107,114,169,242,177,115,128,116,236,16,244,10,91,77,22,32,204,23,142,69,178,55,28,144,163,162,8,84,159,168,6,68,124,168,104,70,239,21,204,144,52,57,225,144,165,250,0,177,249,2,89,184,195,194,9,68,1,77,165,200,238,136,54,202,134,127,243,91,222,158,42,89,22,100,72,226,75,23,139,158,243,226,25,86,159,189,71,220,127,22,216,184,242,95,96,67,190,9,219,183,205,11,232,76,73,49,89,22,10,180,182,49,227,5,251,100,159,124,36,31,240,123,248,146,175,77,253,155,121,197,85,55,52,129,235,114,88,115,88,26,114,67,67,69,191,101,140,106,225,230,172,50,93,139,129,225,119,13,170,105,89,6,114,223,215,26,68,234,202,29,214,254,82,201,194,70,1,182,254,85,163,121,202,174,233,90,216,45,209,46,134,40,154,129,33,195,81,251,94,114,120,72,58,109,221,48,140,42,113,251,36,68,237,86,193,69,26,81,29,126,180,160,89,137,131,54,7,246,231,72,205,202,28,19,118,81,102,89,39,14,29,99,239,25,61,189,181,66,112,167,143,246,247,49,8,50,204,116,40,173,67,244,100,248,20,195,10,138,65,134,67,34,144,79,183,54,137,66,136,225,147,58,39,104,144,217,137,199,227,159,113,96,29,255,34,84,135,28,124,84,143,238,79,129,41,213,198,126,240,22,175,73,92,120,229,42,111,173,176,182,165,109,91,47,157,131,153,203,173,139,100,33,121,74,234,125,58,198,105,244,115,139,147,210,169,83,119,134,194,49,24,202,51,130,107,198,181,203,106,5,39,99,28,76,3,99,59,140,104,55,120,245,32,142,58,235,9,222,91,47,176,61,178,177,241,206,60,47,226,247,17,178,16,240,151,52,24,219,199,170,211,92,87,1,104,107,211,120,84,219,54,239,130,104,142,37,216,48,38,75,220,205,155,9,118,87,29,21,56,158,9,109,168,96,235,199,201,102,16,125,246,106,198,221,255,41,89,99,246,219,239,87,165,112,201,215,132,138,148,104,127,49,74,85,157,166,82,53,159,177,244,201,27,71,125,57,170,142,79,86,119,244,218,151,12,208,145,230,68,96,30,134,49,115,195,18,143,38,75,96,101,213,146,94,149,12,122,149,225,168,49,196,114,129,239,50,79,125,159,125,21,54,101,6,105,116,218,75,215,99,212,185,173,33,55,76,73,77,192,231,179,61,197,216,24,172,177,183,163,109,189,221,223,82,7,171,171,212,248,249,7,113,186,209,77,134,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62cc41d2-c829-47ff-91e7-ee6f8a7a627d"));
		}

		#endregion

	}

	#endregion

}
