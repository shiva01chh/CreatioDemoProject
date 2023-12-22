﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChatOperatorTransferStoreSchema

	/// <exclude/>
	public class ChatOperatorTransferStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChatOperatorTransferStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChatOperatorTransferStoreSchema(ChatOperatorTransferStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4ad49e15-2a62-471e-a3e5-b685a4c96355");
			Name = "ChatOperatorTransferStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,91,111,219,54,20,126,118,129,254,7,214,5,10,7,203,228,118,143,75,108,204,115,210,194,109,218,116,113,178,61,20,69,193,74,116,66,64,18,93,146,202,234,21,254,239,59,188,73,164,36,42,78,251,80,71,228,225,119,190,115,229,165,196,5,17,91,156,18,116,77,56,199,130,109,100,178,100,229,134,222,86,28,75,202,202,228,178,40,105,122,135,203,146,228,201,123,34,4,190,165,229,237,211,39,63,158,62,25,85,2,254,68,235,157,144,164,56,105,125,3,74,158,147,84,65,136,228,13,41,9,167,105,71,230,130,150,223,58,131,87,85,41,105,65,146,53,44,193,57,253,79,211,104,164,124,158,69,17,155,225,36,54,158,156,253,25,157,90,203,96,161,33,180,38,82,194,151,64,51,164,133,66,247,128,140,19,128,133,176,116,58,157,162,83,81,21,5,230,187,185,253,214,184,2,209,114,195,120,161,215,33,182,65,108,75,0,132,113,4,163,8,92,44,145,228,184,20,27,224,4,112,137,195,154,122,96,159,106,167,124,205,201,103,24,216,86,95,115,154,162,52,199,66,160,107,187,252,210,2,195,252,15,205,169,67,74,15,172,50,2,158,222,80,194,21,155,74,16,158,212,178,190,82,167,228,77,69,51,88,132,126,160,91,34,79,144,80,255,237,7,240,29,13,148,178,82,226,84,14,163,59,233,165,17,70,238,247,80,109,203,138,115,176,167,241,170,144,88,86,98,88,105,219,99,107,189,6,217,159,64,53,132,191,95,58,89,149,11,200,243,123,98,226,191,143,102,193,153,100,65,216,61,183,60,50,208,45,95,153,56,31,20,229,131,66,97,3,125,50,228,109,27,157,18,250,199,48,152,144,42,155,209,7,16,60,4,112,123,199,36,59,8,241,163,146,60,25,244,184,173,59,191,172,108,90,16,209,235,118,171,129,148,85,17,137,182,243,181,11,58,164,197,203,99,53,80,127,190,210,159,75,168,103,113,254,61,37,36,35,25,140,254,86,19,125,206,201,173,234,0,75,21,202,223,145,18,116,42,156,74,205,251,33,171,92,30,137,71,244,143,32,139,6,52,187,190,81,115,133,46,46,113,41,129,239,71,78,239,177,52,236,70,91,243,161,210,74,72,23,152,107,143,133,195,23,75,156,222,145,119,100,7,174,24,171,45,69,41,111,123,88,140,109,134,60,39,101,102,52,135,52,94,83,146,103,109,14,189,233,116,42,8,176,226,100,51,27,175,180,106,109,216,120,58,71,180,216,230,164,128,154,48,125,152,106,195,210,38,137,175,200,22,188,11,243,2,225,237,22,188,101,228,114,114,79,114,148,42,168,88,118,90,95,112,130,51,86,230,59,228,41,70,95,60,44,61,60,84,11,30,121,229,166,191,42,82,17,231,35,160,199,4,133,63,118,218,152,54,251,7,40,13,192,161,47,105,124,242,17,108,235,222,164,172,252,89,142,1,136,97,22,12,29,200,199,59,187,40,212,143,156,221,211,140,240,159,97,21,129,66,95,88,255,132,101,104,11,238,6,54,87,168,161,210,28,136,218,159,118,159,217,15,39,191,174,65,94,165,170,80,160,4,52,240,208,238,94,82,169,119,16,104,21,37,249,183,54,88,237,2,145,144,5,77,0,156,20,241,141,30,217,98,142,11,221,254,103,227,42,48,103,60,87,230,169,150,96,7,146,211,169,150,246,123,120,84,237,164,229,155,16,251,8,233,230,59,234,148,19,180,149,80,50,89,116,11,78,45,28,72,114,192,80,142,26,168,145,73,139,141,135,25,102,108,131,20,140,71,214,71,82,200,162,68,50,175,31,171,229,189,182,87,180,208,3,121,246,158,200,59,214,233,178,174,32,46,168,144,167,237,198,61,215,217,182,200,243,176,221,79,92,184,238,177,202,7,119,31,0,86,23,12,103,181,236,196,249,161,29,212,79,131,59,201,103,192,105,64,13,4,39,178,226,101,123,120,31,154,176,38,106,18,189,33,138,177,31,35,1,97,135,32,251,172,177,103,147,158,5,165,67,57,4,87,157,14,156,161,214,65,210,163,35,117,79,170,138,114,50,182,7,160,241,49,26,175,178,241,81,178,16,147,113,235,156,167,198,227,171,212,9,171,127,157,153,137,175,212,39,169,152,82,61,89,175,94,65,38,241,183,140,122,0,118,106,148,92,194,224,122,113,243,78,65,122,140,147,149,56,255,86,225,188,99,98,16,178,142,123,250,34,23,73,190,86,54,121,225,107,206,72,166,150,250,1,92,136,108,98,244,197,60,158,44,145,232,38,231,223,73,90,73,114,5,27,8,20,43,215,63,104,54,183,228,70,116,131,236,160,74,25,19,148,191,113,94,145,83,117,250,158,131,39,89,197,83,178,200,10,90,222,64,113,41,135,161,217,76,159,205,147,243,98,43,119,206,78,99,169,170,243,149,58,104,14,131,238,68,128,120,98,17,20,155,103,181,179,146,69,185,155,48,69,150,37,10,115,102,209,143,26,149,35,79,56,203,38,202,183,109,183,54,178,35,77,204,96,28,215,131,238,196,111,187,92,235,250,215,44,30,61,108,86,79,157,52,122,70,42,253,163,8,230,204,218,197,48,53,227,161,232,58,80,213,31,233,214,10,88,203,12,135,181,191,186,142,106,61,123,247,215,190,14,142,29,50,63,251,176,108,234,48,244,149,203,87,198,114,180,18,138,229,5,45,168,116,215,145,137,159,199,200,223,189,92,128,41,92,164,5,45,170,28,142,12,132,85,26,66,213,80,248,34,162,76,212,198,181,54,109,168,239,117,123,49,20,253,75,75,93,165,43,21,29,9,128,239,170,156,163,151,129,189,61,235,140,119,94,188,8,12,73,206,40,7,50,36,211,34,75,86,129,65,191,132,18,230,194,230,205,207,123,8,244,185,53,242,104,0,206,240,247,43,51,26,186,250,15,214,246,51,212,93,95,128,26,193,186,228,172,3,34,111,16,193,117,211,120,108,143,72,46,8,82,42,106,56,107,244,129,160,245,179,70,131,118,208,58,239,65,196,229,237,97,141,220,115,97,211,207,237,173,82,16,204,211,187,88,115,127,244,217,1,139,8,137,147,58,48,77,139,91,137,15,21,52,120,174,251,238,164,137,137,207,32,114,2,242,124,16,136,55,224,255,220,17,56,246,54,237,246,217,172,117,63,72,236,211,150,26,5,129,163,228,154,41,234,14,91,247,110,227,164,22,81,235,178,94,186,17,253,182,45,37,170,253,65,28,51,242,253,114,99,113,142,209,90,43,89,178,2,142,243,84,168,183,97,158,209,18,231,171,219,18,78,238,75,44,32,177,230,232,215,87,109,134,251,7,59,214,195,103,209,135,174,59,144,58,2,229,160,212,127,98,27,120,26,57,228,94,99,236,30,207,235,152,218,36,68,91,44,37,225,225,197,70,175,54,54,138,249,69,155,200,233,212,77,121,151,160,120,21,28,144,253,178,93,40,230,148,210,83,63,102,169,9,133,86,233,247,164,121,88,70,157,171,76,112,160,13,114,186,67,32,121,205,248,57,72,76,36,243,14,58,225,94,195,130,212,123,77,185,144,151,252,140,108,48,180,93,151,131,55,246,40,51,67,82,21,132,219,7,85,158,195,122,40,143,18,114,188,57,138,128,144,237,192,179,72,15,78,153,195,232,221,67,59,134,248,153,217,255,88,153,131,79,91,239,138,141,27,7,31,137,76,228,239,25,205,12,74,120,81,234,180,177,228,138,20,236,158,76,6,187,217,209,64,41,217,55,199,96,16,198,252,127,255,3,116,174,25,203,4,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4ad49e15-2a62-471e-a3e5-b685a4c96355"));
		}

		#endregion

	}

	#endregion

}

