﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TransferChatToQueueProviderSchema

	/// <exclude/>
	public class TransferChatToQueueProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TransferChatToQueueProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TransferChatToQueueProviderSchema(TransferChatToQueueProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("983c67e6-7fe0-424f-a4a4-af3c39d1f289");
			Name = "TransferChatToQueueProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,86,219,110,219,70,16,125,86,128,252,195,148,45,16,26,16,40,244,213,177,5,56,180,107,24,176,29,59,114,154,199,96,69,142,164,109,201,93,117,119,105,73,17,244,239,153,189,73,36,45,187,209,131,64,238,220,207,204,156,165,96,53,234,37,43,16,158,80,41,166,229,204,100,185,20,51,62,111,20,51,92,138,247,239,182,239,223,13,26,205,197,28,38,27,109,176,254,216,123,39,253,170,194,194,42,235,236,26,5,42,94,28,116,218,110,235,90,138,227,146,86,192,236,115,45,120,177,96,66,96,149,221,161,214,108,78,218,199,205,20,210,57,73,70,163,17,156,233,166,174,153,218,140,195,251,23,92,42,212,40,140,134,89,35,92,122,172,226,102,3,114,6,70,49,161,103,228,200,58,164,88,6,140,132,255,26,108,48,139,222,70,45,119,203,102,90,241,2,138,138,105,13,79,193,54,39,179,39,249,104,141,30,148,124,230,37,42,56,133,79,76,163,147,4,173,40,34,47,219,193,192,37,59,248,93,225,156,178,129,59,52,11,89,234,83,120,80,252,153,25,244,210,165,127,1,109,92,118,215,104,110,139,31,79,184,54,30,11,76,175,27,94,186,164,111,202,33,184,23,129,171,220,189,159,128,109,214,96,144,6,99,185,68,2,85,170,123,234,242,48,122,116,117,218,147,19,56,135,22,216,214,69,76,151,250,104,62,7,227,11,81,62,70,147,79,27,31,40,141,241,15,161,63,186,200,10,77,163,68,8,149,253,37,85,205,76,74,74,112,43,11,130,255,7,155,86,56,113,194,244,171,38,16,37,69,118,189,201,190,73,245,175,155,196,236,11,106,217,168,130,244,164,162,130,135,144,180,17,157,160,122,230,5,38,67,23,111,144,188,112,172,179,182,186,194,50,251,155,85,13,38,39,195,30,30,7,32,92,238,187,208,29,20,165,111,80,183,91,148,42,85,213,20,100,110,91,230,70,194,107,244,167,207,29,220,8,110,184,77,12,181,5,9,56,89,51,65,123,70,227,119,166,17,161,80,56,59,79,222,152,166,100,180,119,214,153,70,127,178,100,138,213,32,40,251,243,164,233,32,153,140,45,178,80,28,160,61,27,57,237,227,198,181,31,171,100,28,230,11,104,165,151,149,157,64,218,137,41,130,27,126,189,32,24,219,110,194,74,188,145,126,175,191,208,77,114,8,251,213,142,113,67,34,39,180,69,83,218,162,180,111,176,151,111,127,161,91,135,221,250,191,70,197,18,244,75,34,248,21,236,157,242,77,153,140,111,74,226,26,62,227,4,61,181,216,251,120,1,188,95,15,61,166,17,111,42,99,21,125,208,54,31,49,225,54,218,75,248,222,43,57,139,214,173,6,164,83,41,43,79,3,39,251,82,60,69,132,204,34,39,240,25,164,191,217,62,185,46,17,59,74,205,105,150,55,217,141,118,39,87,107,174,141,78,163,85,52,27,220,202,121,118,165,148,84,233,31,73,206,196,7,3,26,141,119,14,51,169,124,154,43,110,22,148,235,249,214,147,193,46,3,231,19,182,193,221,14,74,137,218,26,163,13,147,4,182,136,116,145,206,88,165,209,151,145,93,213,75,179,9,10,59,247,223,37,57,98,45,251,208,170,32,87,72,243,154,47,120,85,90,73,154,31,200,9,46,185,167,126,181,57,243,164,68,44,48,253,135,102,106,28,11,220,66,242,24,154,56,140,160,193,110,184,23,126,21,75,37,11,26,62,44,239,244,60,151,141,48,164,248,103,91,101,98,152,105,180,115,208,34,212,253,132,59,234,208,217,55,70,148,32,230,68,138,15,222,161,237,182,175,112,23,234,181,77,106,21,122,222,70,36,230,219,195,172,207,192,222,161,81,155,168,31,104,63,172,15,161,247,242,74,201,95,97,243,193,51,83,160,221,45,127,215,54,159,180,143,210,184,152,193,166,215,156,139,178,140,138,29,79,212,135,198,192,247,104,117,199,4,29,42,171,222,245,222,49,122,37,70,94,73,141,79,173,37,234,143,65,183,170,9,26,127,217,225,51,199,213,1,240,3,199,180,194,184,217,184,228,22,197,105,67,209,178,253,51,238,151,37,168,223,203,176,170,247,184,234,20,225,4,155,254,141,151,55,116,59,9,99,79,51,27,60,38,113,237,211,123,11,134,216,107,40,152,41,22,144,94,173,11,92,58,154,197,245,209,205,189,32,137,125,4,89,20,54,108,9,43,90,23,236,50,143,141,10,113,133,45,19,246,150,56,3,231,14,182,184,14,95,102,184,123,109,149,143,143,165,77,233,18,167,205,220,146,9,137,79,15,225,86,76,31,178,161,252,142,132,79,186,31,25,41,93,199,47,35,29,191,24,220,169,251,163,223,79,140,113,200,95,245,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("983c67e6-7fe0-424f-a4a4-af3c39d1f289"));
		}

		#endregion

	}

	#endregion

}

