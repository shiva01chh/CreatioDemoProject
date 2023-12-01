﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadNotificationProviderSchema

	/// <exclude/>
	public class LeadNotificationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadNotificationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadNotificationProviderSchema(LeadNotificationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("331bec2a-e8d3-4fd0-a099-f1ff7e7a7355");
			Name = "LeadNotificationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d421cd45-8045-4291-a77e-0a493fa9465d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,88,221,111,219,54,16,127,86,129,254,15,156,10,20,50,22,200,235,107,156,26,112,155,52,240,150,52,65,236,108,15,109,81,48,210,57,225,38,75,30,73,101,240,138,254,239,59,126,201,164,44,201,30,48,172,15,141,73,222,239,190,239,120,84,73,215,32,54,52,3,178,4,206,169,168,86,50,125,95,149,43,246,88,115,42,89,85,190,124,241,237,229,139,168,22,172,124,12,72,56,164,231,239,38,205,209,98,43,36,172,113,191,40,32,83,56,145,94,66,9,156,101,147,30,120,27,139,107,220,121,197,225,17,209,228,125,65,133,56,37,87,64,243,143,149,100,43,150,105,109,110,121,245,204,114,224,154,118,60,30,147,51,81,175,215,148,111,167,118,173,0,164,244,16,100,99,33,169,67,140,61,200,166,126,40,88,70,50,37,173,87,24,57,37,239,168,128,174,163,19,50,239,86,47,82,94,107,172,249,192,160,200,209,156,91,206,158,169,4,173,125,180,49,11,146,161,179,36,17,146,43,95,92,222,221,220,223,126,253,56,187,190,32,111,73,236,243,142,39,189,32,71,174,12,136,141,31,163,87,80,230,70,186,93,59,199,42,32,175,51,89,113,165,144,182,223,234,99,124,209,231,133,228,94,0,71,116,105,226,75,234,96,57,82,28,162,83,242,128,142,74,90,71,68,251,226,251,113,82,206,153,6,97,124,206,140,117,39,164,122,248,29,57,77,201,134,114,204,86,9,92,4,210,188,237,64,82,159,7,80,212,6,184,100,208,178,191,157,78,122,227,146,87,245,134,148,40,32,109,104,252,4,114,246,184,240,105,114,173,69,244,8,210,254,138,56,200,154,151,94,112,117,44,149,162,141,182,157,210,155,12,60,90,129,143,72,216,43,191,91,114,159,159,174,65,62,85,38,107,43,137,1,128,220,229,173,93,146,234,25,43,26,245,35,207,21,203,201,44,207,177,252,235,117,41,146,5,168,46,64,132,254,99,163,18,153,149,81,40,53,148,73,124,7,107,86,230,168,121,124,66,226,121,30,143,210,153,72,244,143,33,66,179,88,178,53,88,128,191,49,4,196,172,148,52,147,141,160,230,208,59,24,194,159,131,200,56,219,232,122,52,28,130,157,22,84,215,163,111,151,218,232,16,225,232,84,240,44,229,146,201,98,223,22,236,148,139,236,9,214,180,69,125,81,74,38,183,230,200,108,183,128,126,169,137,5,72,137,246,8,197,4,57,206,215,244,17,118,174,119,171,137,95,180,61,33,255,185,98,229,146,62,20,112,76,200,175,96,37,111,106,172,83,133,210,182,204,114,116,237,125,201,36,202,190,25,10,213,92,92,252,89,211,162,5,10,137,172,148,57,182,29,43,65,187,181,131,243,162,214,13,37,228,236,199,170,87,97,235,252,46,158,91,225,7,97,79,235,93,216,238,251,37,116,71,201,18,71,255,82,232,80,200,125,212,253,177,193,214,245,141,178,53,195,238,120,171,126,156,134,116,150,96,226,229,67,58,43,243,150,37,190,178,203,237,6,252,128,90,131,76,42,167,183,174,219,39,126,237,10,41,210,54,143,230,124,158,143,14,25,24,220,226,243,114,85,145,75,144,119,144,85,60,111,159,36,70,175,142,123,202,252,157,146,188,57,50,58,255,74,139,26,220,229,20,93,214,232,75,102,170,108,210,236,164,75,190,69,211,240,58,235,70,127,106,10,243,11,94,136,181,116,28,172,99,109,131,47,225,47,178,167,175,19,28,233,158,130,115,66,159,4,211,115,190,156,24,234,119,85,190,29,32,246,251,158,131,88,21,17,101,181,179,251,38,221,244,129,210,80,217,219,107,166,109,145,95,70,1,118,215,218,6,84,218,235,130,78,175,107,16,194,105,118,80,1,95,184,223,110,142,193,250,244,62,31,61,22,88,237,245,111,115,9,251,73,121,248,22,62,52,170,204,54,27,208,249,174,167,5,82,173,112,72,212,215,49,89,85,156,100,28,168,106,1,158,247,20,137,124,194,234,214,218,247,140,23,122,71,143,88,154,237,219,216,50,141,167,51,84,1,64,49,94,189,141,175,152,144,103,203,41,98,1,166,241,120,234,100,167,103,99,13,246,71,149,176,173,96,107,114,99,131,102,226,170,200,50,112,217,235,248,97,119,49,243,193,100,127,219,187,13,58,78,253,25,161,227,216,222,10,239,169,189,203,251,73,122,248,7,147,128,31,218,206,104,221,233,138,21,58,0,92,55,26,252,35,234,66,30,27,135,238,28,108,133,165,191,75,197,206,195,38,252,65,156,180,44,211,82,68,200,111,33,57,54,236,41,82,187,227,174,184,186,97,216,181,208,59,109,88,215,104,127,92,203,180,252,228,129,254,21,180,164,137,143,100,249,0,76,21,106,64,205,155,68,25,64,121,217,20,162,31,134,251,102,43,205,66,172,112,9,118,152,193,78,235,103,202,201,31,160,100,162,153,63,146,248,107,140,255,239,108,216,17,109,170,13,62,78,76,27,187,85,191,207,169,164,251,215,131,118,115,120,9,40,155,246,123,121,163,109,127,171,54,99,149,215,237,180,34,248,60,100,180,96,127,195,173,213,72,107,150,46,220,118,18,222,106,198,57,233,135,138,175,169,76,226,207,241,183,159,190,127,142,79,201,183,55,223,113,118,64,211,79,90,28,143,175,62,63,181,245,108,18,171,166,8,218,144,116,60,29,40,197,238,242,48,60,176,253,49,28,73,104,153,193,129,74,177,83,20,86,138,118,30,190,73,205,78,19,21,75,0,193,169,138,97,93,20,198,73,108,69,188,39,48,249,193,156,145,215,175,189,247,114,170,59,35,234,244,11,108,147,88,132,183,212,104,136,54,175,1,179,4,59,102,147,38,122,126,9,89,160,62,137,218,30,237,184,124,106,75,177,201,26,41,110,186,180,114,245,25,3,129,110,35,0,59,177,14,181,111,63,230,176,117,213,125,199,135,136,161,23,230,32,193,17,47,203,35,159,150,123,79,147,30,156,255,26,81,56,111,61,136,59,234,41,58,44,179,185,235,28,241,57,94,192,172,84,233,231,118,62,240,106,237,131,155,131,255,229,53,247,95,62,231,162,244,183,39,224,16,70,20,1,87,56,28,222,240,158,55,134,74,210,116,89,161,130,88,177,130,22,10,149,140,70,13,75,253,146,153,139,59,163,90,239,83,101,69,11,1,45,84,219,248,249,32,135,176,154,176,26,169,176,249,239,125,208,113,13,51,172,150,163,155,161,255,217,116,104,10,113,13,205,127,105,116,247,185,249,69,89,175,129,171,47,4,103,123,79,172,169,106,123,193,43,181,233,122,238,123,89,235,92,161,68,50,234,27,155,237,158,191,165,119,240,223,63,85,186,251,184,231,22,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("331bec2a-e8d3-4fd0-a099-f1ff7e7a7355"));
		}

		#endregion

	}

	#endregion

}
