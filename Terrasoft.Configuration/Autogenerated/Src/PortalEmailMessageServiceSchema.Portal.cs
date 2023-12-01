﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalEmailMessageServiceSchema

	/// <exclude/>
	public class PortalEmailMessageServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalEmailMessageServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalEmailMessageServiceSchema(PortalEmailMessageServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b2da881e-69a0-4267-8efc-c499e036bc63");
			Name = "PortalEmailMessageService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("221a1177-e530-45e1-8abc-49575f2d8a6d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,86,77,111,219,56,16,61,187,64,255,3,225,189,200,128,65,223,155,196,128,227,166,93,119,215,141,215,206,54,135,160,7,90,26,59,68,37,81,33,169,164,218,32,255,125,135,31,178,36,91,178,99,31,12,136,156,121,243,56,156,121,195,148,37,160,50,22,2,185,3,41,153,18,27,77,167,34,221,240,109,46,153,230,34,253,248,225,245,227,135,94,174,120,186,37,171,66,105,72,46,246,190,233,50,79,53,79,128,174,64,114,22,243,255,172,223,129,21,238,62,243,16,230,34,130,248,232,38,157,132,154,63,159,6,161,247,176,174,12,234,244,147,164,238,90,223,145,208,181,78,63,95,119,110,221,224,249,52,7,213,102,128,36,142,68,172,118,75,234,75,145,107,180,65,99,52,255,67,194,22,143,73,166,49,83,234,19,89,8,169,89,124,147,48,30,207,65,41,182,5,239,100,141,71,163,17,185,84,121,146,48,89,140,253,183,223,39,27,33,201,139,144,191,76,244,23,174,31,73,102,161,8,24,44,146,56,48,69,75,148,81,13,230,193,99,224,173,107,201,66,253,211,174,169,172,198,23,236,218,68,101,223,65,227,105,50,188,155,53,143,185,46,150,240,148,115,9,9,164,90,5,245,15,115,65,228,138,156,112,49,86,212,47,68,3,19,36,203,215,49,15,73,104,242,209,157,14,242,137,92,51,85,37,167,247,106,19,180,75,231,28,244,163,136,76,66,165,41,36,151,190,94,230,62,48,103,49,132,154,124,5,221,22,192,236,5,95,115,30,145,16,67,248,229,63,185,210,66,22,179,104,64,76,55,244,122,207,76,18,80,79,120,196,20,94,136,173,143,98,21,62,98,186,255,201,65,22,193,191,10,36,38,52,69,48,36,68,235,6,115,150,34,162,28,146,254,244,32,64,127,112,97,225,17,154,34,119,115,69,22,111,42,226,60,73,233,76,77,226,23,86,40,127,130,43,162,101,14,23,59,66,153,243,248,11,138,47,60,214,32,209,192,0,77,37,224,177,221,210,61,214,198,130,73,108,122,252,80,129,91,180,247,35,185,18,233,93,145,97,181,63,229,44,30,90,84,75,100,41,132,118,212,169,201,153,11,226,24,125,71,160,96,48,108,79,85,117,20,23,70,209,73,20,5,251,36,7,21,255,67,148,221,65,13,10,6,119,223,109,41,246,48,93,16,212,241,13,250,139,155,121,31,83,191,132,144,103,28,107,176,127,166,227,10,210,8,228,185,94,222,198,164,119,22,189,219,121,106,92,23,143,66,139,211,78,238,186,232,12,243,33,191,9,110,66,31,20,119,127,64,39,202,113,26,56,251,30,189,173,72,30,150,163,9,91,26,206,148,173,139,160,173,106,209,185,50,173,115,176,74,142,149,239,35,79,154,113,39,77,199,147,49,240,210,132,140,106,145,254,134,141,190,69,121,242,209,140,130,161,128,249,96,211,102,176,105,103,176,73,117,175,30,161,74,183,4,157,203,180,179,50,173,209,155,23,31,68,112,250,211,37,70,86,219,220,230,190,150,219,5,44,112,213,42,220,36,116,117,14,17,209,130,92,102,166,129,37,108,72,138,237,119,213,111,107,190,254,104,135,218,16,123,183,98,1,142,121,143,15,47,128,240,8,219,133,111,56,72,122,57,178,8,21,160,75,147,26,47,90,200,163,117,185,109,236,31,110,51,112,47,139,250,192,233,61,224,164,156,165,207,226,23,4,46,97,216,244,253,197,237,234,14,47,199,76,8,80,250,139,144,9,51,98,128,166,158,155,91,162,223,80,186,134,228,90,68,197,74,23,49,52,76,118,171,244,94,178,44,131,200,41,219,18,95,61,34,85,112,28,212,206,164,114,40,117,142,163,18,171,125,164,156,30,38,94,229,84,41,118,199,38,211,17,165,117,254,244,230,55,132,216,19,43,124,10,196,224,90,38,192,9,16,153,121,48,182,227,234,244,65,28,175,94,67,182,144,152,131,49,66,236,36,234,7,139,115,184,52,231,27,7,251,26,231,7,200,78,104,59,221,149,150,72,21,1,106,154,236,157,93,83,158,246,44,69,185,225,86,246,114,130,164,78,179,223,201,172,133,120,27,18,124,246,188,35,81,217,129,69,83,56,14,247,143,72,134,91,221,91,44,101,228,144,75,73,162,243,113,184,132,76,130,50,15,45,60,187,39,108,31,135,60,221,216,26,55,184,108,109,78,122,198,115,241,51,211,172,222,186,239,123,178,85,100,123,175,157,2,104,253,176,15,204,245,209,118,253,178,225,231,144,172,65,6,230,245,97,100,66,249,235,175,55,171,171,13,226,43,232,149,108,65,95,32,50,254,189,29,81,96,71,64,150,133,120,6,7,89,21,111,11,141,170,11,206,99,82,234,191,198,166,170,11,240,251,121,37,205,174,172,115,179,186,212,108,241,247,178,179,221,82,35,68,196,198,215,142,187,11,51,176,76,243,157,125,137,205,166,109,225,219,218,219,123,180,91,27,9,215,240,247,63,183,52,23,194,239,14,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b2da881e-69a0-4267-8efc-c499e036bc63"));
		}

		#endregion

	}

	#endregion

}

