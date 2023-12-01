﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseTimeZoneProviderSchema

	/// <exclude/>
	public class CaseTimeZoneProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseTimeZoneProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseTimeZoneProviderSchema(CaseTimeZoneProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d8a258bc-8f8e-4aec-99f6-b3dbe4216021");
			Name = "CaseTimeZoneProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,87,75,143,219,54,16,62,59,64,254,3,161,94,100,192,144,239,137,237,32,113,55,129,129,38,109,177,110,15,189,20,140,52,242,18,176,40,135,164,220,58,65,254,123,134,47,45,41,201,146,131,13,146,67,176,164,231,249,205,55,51,20,167,21,200,19,205,129,236,65,8,42,235,82,101,219,154,151,236,208,8,170,88,205,159,63,251,242,252,217,172,145,140,31,200,253,69,42,168,94,182,231,45,61,2,47,168,144,193,85,45,32,62,101,119,92,49,197,32,16,178,118,238,65,41,60,73,178,182,114,145,219,12,101,188,0,42,162,234,47,2,14,248,3,217,30,169,148,47,208,183,132,61,171,224,159,154,195,31,162,62,179,2,132,145,91,46,151,100,37,155,170,162,226,178,113,103,45,76,20,74,147,207,40,78,78,78,158,176,234,116,132,10,184,178,62,189,246,50,80,63,53,31,143,44,39,185,246,58,232,148,188,32,187,238,221,74,11,106,237,47,38,164,199,216,107,46,21,229,10,227,71,81,5,185,130,194,74,116,163,54,23,251,7,32,244,200,168,36,101,45,136,4,113,102,88,40,134,216,145,220,65,79,242,250,216,84,38,244,126,236,179,147,119,130,98,232,153,72,37,12,254,214,210,14,13,249,18,110,141,153,15,200,6,44,71,50,32,144,188,116,169,224,201,102,19,167,134,249,156,64,232,58,247,114,59,9,118,166,10,108,21,254,85,14,171,251,186,17,185,225,202,112,242,230,119,29,109,174,213,64,147,232,50,153,166,113,177,143,60,16,205,223,217,236,0,202,253,53,19,160,26,193,187,145,144,87,175,72,218,189,91,147,119,160,98,123,233,124,110,130,158,125,213,255,127,29,41,223,95,88,49,13,60,199,216,28,189,70,131,215,242,219,86,188,123,108,211,176,222,61,168,210,93,140,5,50,4,37,17,144,215,162,32,72,87,60,151,12,68,54,25,224,187,134,89,136,119,197,141,225,92,99,139,105,4,209,228,170,22,154,47,166,199,70,18,216,113,156,32,216,9,159,65,18,74,56,252,71,152,105,36,172,80,93,162,56,0,201,5,148,235,100,168,65,147,229,38,35,195,169,153,155,19,21,180,34,28,169,191,78,154,8,243,100,211,45,225,106,105,164,135,149,115,131,76,178,185,17,238,208,150,155,50,67,225,167,29,30,196,33,46,108,81,172,235,185,171,74,71,99,221,209,177,21,115,117,92,59,221,91,170,246,30,212,67,93,220,56,188,176,113,100,48,115,165,105,158,43,20,51,55,182,45,229,32,124,8,150,255,57,166,228,153,9,213,208,163,109,252,129,94,117,136,156,113,82,130,252,132,217,106,242,152,141,116,185,207,31,160,162,127,54,32,46,29,140,179,80,224,61,229,244,0,98,65,12,185,18,215,252,175,139,194,199,105,71,167,76,209,190,251,209,13,24,188,200,48,36,107,172,227,98,225,250,104,78,168,93,43,147,77,140,30,165,69,209,96,99,157,18,85,147,3,59,3,247,52,147,38,102,242,73,103,53,6,118,200,91,140,51,217,220,13,232,71,12,237,65,126,174,145,120,3,56,244,208,213,64,248,66,104,76,80,199,202,166,225,162,201,252,166,201,176,135,230,153,91,69,163,171,106,18,51,195,193,2,74,218,28,85,192,197,94,47,146,82,212,21,145,230,89,162,71,152,126,118,220,66,213,253,117,147,87,25,107,250,21,3,251,213,134,229,9,187,43,90,178,58,250,196,175,36,205,164,191,233,177,129,1,34,121,92,112,38,202,172,99,119,91,23,176,240,24,164,218,185,219,95,99,184,189,101,92,147,205,226,241,136,219,199,11,62,62,36,114,175,24,109,228,144,91,42,8,35,9,240,50,54,122,211,180,135,235,85,20,91,216,120,89,155,112,223,92,180,139,212,189,112,66,183,30,214,72,69,133,135,117,100,46,211,230,44,248,254,250,205,5,203,19,217,140,26,61,52,54,137,237,86,0,46,74,189,199,242,7,202,184,94,96,33,51,49,126,56,223,72,191,173,54,48,61,26,181,212,239,229,150,137,188,169,236,214,148,171,48,225,141,139,201,8,70,35,211,70,104,135,230,180,153,212,161,98,180,116,151,255,70,37,82,14,212,91,236,46,215,200,158,172,11,107,59,251,80,251,70,104,223,85,195,234,237,231,64,12,189,17,158,158,157,10,139,121,82,118,92,66,56,10,76,227,183,143,105,172,133,127,101,235,63,111,127,129,62,133,189,195,0,197,117,112,151,102,95,199,43,78,207,133,253,229,4,110,164,154,17,177,210,109,190,73,71,103,167,131,241,7,45,70,247,141,16,24,13,187,37,250,184,232,108,0,159,77,102,38,132,157,251,214,138,219,72,109,113,214,19,11,245,17,164,43,97,152,183,142,219,49,67,168,217,217,177,73,135,67,143,121,23,140,156,254,92,248,30,42,246,183,211,83,119,209,247,177,174,237,171,136,112,69,119,57,217,47,161,129,157,245,3,105,228,205,122,26,13,204,242,49,38,93,35,144,123,25,77,209,167,151,242,117,22,185,81,240,51,56,52,253,20,159,250,118,138,223,225,79,98,146,253,72,233,210,200,159,7,55,71,180,89,250,147,59,187,251,31,242,70,65,58,150,180,189,141,47,241,14,255,125,3,229,35,144,95,190,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d8a258bc-8f8e-4aec-99f6-b3dbe4216021"));
		}

		#endregion

	}

	#endregion

}

