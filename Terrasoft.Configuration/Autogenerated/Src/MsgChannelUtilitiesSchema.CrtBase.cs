﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MsgChannelUtilitiesSchema

	/// <exclude/>
	public class MsgChannelUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MsgChannelUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MsgChannelUtilitiesSchema(MsgChannelUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("75f1e6e1-f848-4035-bda7-522abc9b3a5e");
			Name = "MsgChannelUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ca48210-97af-47ed-9943-795346aceaf8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,85,223,111,211,48,16,126,238,164,253,15,71,64,34,149,166,136,61,32,164,85,19,98,133,65,36,54,38,202,196,3,66,200,77,174,153,53,199,174,108,103,163,42,253,223,57,199,78,154,116,165,43,18,162,15,105,108,223,143,239,190,59,127,145,172,68,51,103,25,194,23,212,154,25,53,179,201,88,201,25,47,42,205,44,87,242,240,96,121,120,112,120,48,168,12,151,5,76,22,198,98,57,106,215,99,165,113,189,186,64,99,88,65,111,20,162,44,149,92,159,20,66,77,153,56,57,241,251,201,71,85,56,179,81,29,249,169,198,130,18,193,88,48,99,78,224,194,20,227,27,38,37,138,107,203,5,183,28,77,109,54,175,166,130,103,96,44,193,202,32,115,198,219,109,7,30,240,58,174,146,228,36,45,197,190,170,99,248,227,16,47,115,167,20,85,59,152,87,90,101,84,195,59,73,232,112,130,50,71,125,73,4,193,41,68,189,163,200,35,31,124,251,52,53,74,160,197,56,122,149,28,191,76,142,225,87,155,14,184,1,169,232,79,66,101,16,152,204,225,158,11,1,83,4,141,165,186,195,188,62,154,103,170,116,169,53,10,100,6,77,52,252,190,23,186,51,150,221,126,224,198,42,189,152,16,37,187,208,110,154,54,232,159,146,139,231,168,79,216,57,71,145,59,182,52,191,35,243,64,151,95,52,252,107,100,185,146,98,1,41,245,18,126,8,122,156,2,189,94,48,201,10,212,201,123,180,174,201,168,227,232,43,78,39,42,187,69,27,13,31,73,124,129,246,70,61,150,121,170,148,128,241,13,102,183,99,38,175,148,177,126,234,48,14,44,17,217,53,13,71,13,109,166,101,102,8,75,23,112,192,103,16,63,89,207,78,131,57,53,159,43,41,201,165,177,27,184,186,146,175,76,203,115,165,75,102,227,136,82,62,183,48,167,172,80,250,180,96,21,44,95,172,96,166,85,9,203,227,21,220,223,112,129,240,32,122,51,14,218,167,136,142,124,134,65,3,23,94,191,134,232,141,16,209,81,23,240,200,91,105,180,149,150,48,99,194,160,223,90,213,207,176,111,117,229,183,87,91,25,75,9,12,140,169,99,22,55,184,242,153,90,166,74,211,150,94,251,24,94,206,69,227,67,253,149,120,15,147,238,94,220,50,149,230,116,254,190,226,121,114,137,247,238,63,30,134,10,207,84,190,160,51,138,237,129,123,252,189,208,201,7,154,38,106,128,159,97,50,246,184,70,221,26,123,14,59,138,189,83,60,135,206,88,164,210,162,150,76,196,233,186,37,144,249,255,141,17,217,155,135,13,46,131,179,243,242,144,235,177,121,139,211,170,136,159,69,77,206,101,72,154,184,198,174,252,12,205,148,134,165,247,95,57,255,19,88,210,115,21,133,56,141,71,111,202,187,88,134,127,65,196,23,69,211,213,178,241,31,10,119,185,221,237,96,36,122,143,20,186,229,46,214,34,154,97,93,123,13,125,71,229,143,235,201,67,221,255,3,75,241,53,221,71,146,112,137,153,251,250,213,106,178,94,110,209,148,53,119,129,102,252,105,123,58,179,77,170,250,81,147,113,165,53,74,235,82,39,33,230,90,2,218,43,230,47,66,247,250,63,20,153,172,191,60,125,168,67,45,179,163,182,205,205,132,214,168,194,251,233,70,168,228,156,203,60,165,111,255,217,226,58,205,119,21,144,230,161,169,174,250,110,200,39,36,32,149,16,109,61,219,46,105,199,254,168,71,114,151,221,64,1,32,169,97,79,169,83,57,83,97,178,147,86,177,67,118,167,189,51,85,209,87,216,205,162,203,211,147,237,158,30,239,221,154,78,51,86,251,76,87,24,228,127,50,67,142,203,125,7,229,207,50,176,139,226,45,183,43,236,117,183,234,29,250,253,6,40,199,63,105,74,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("75f1e6e1-f848-4035-bda7-522abc9b3a5e"));
		}

		#endregion

	}

	#endregion

}

