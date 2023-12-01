﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendToUserIncomingMessageActionSchema

	/// <exclude/>
	public class SendToUserIncomingMessageActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendToUserIncomingMessageActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendToUserIncomingMessageActionSchema(SendToUserIncomingMessageActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d95fb2c1-d588-4589-82d4-01c3afc7de75");
			Name = "SendToUserIncomingMessageAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,85,219,78,219,64,16,125,54,18,255,48,114,43,17,36,226,160,146,2,133,6,41,9,53,117,213,16,68,18,245,177,50,246,36,217,202,222,181,118,215,65,41,202,191,119,188,107,155,152,146,162,230,197,218,185,156,153,57,115,73,174,24,95,192,45,62,106,193,149,152,107,239,155,18,252,114,127,47,55,242,201,90,105,76,235,231,20,165,12,141,213,8,149,10,23,36,243,134,34,77,141,199,254,30,15,83,84,89,24,225,150,225,80,240,57,91,228,50,212,76,112,111,156,114,22,45,67,206,49,121,134,216,223,123,42,188,157,119,18,23,100,4,195,36,84,234,2,38,200,227,169,152,41,148,1,143,68,74,134,214,3,251,81,129,101,92,58,157,14,124,86,121,154,134,114,125,85,190,239,49,147,168,144,107,5,9,163,244,57,74,32,84,86,130,64,106,81,224,145,233,37,144,93,92,75,180,0,101,10,134,156,162,122,21,126,103,43,64,150,63,36,44,130,168,72,113,119,134,223,171,184,23,16,236,80,17,150,173,186,46,219,103,152,196,84,247,157,100,171,80,163,85,102,246,1,18,195,88,240,100,13,35,181,24,90,2,71,33,39,60,9,63,163,230,187,247,183,141,23,112,165,67,30,225,101,25,146,18,183,81,155,41,140,80,47,197,206,28,2,194,133,27,212,21,182,45,168,117,147,179,184,224,173,31,83,153,51,206,244,17,40,45,183,152,30,136,120,125,8,79,5,148,35,81,231,146,3,199,71,152,176,52,75,176,68,41,213,78,16,83,254,13,48,43,47,48,72,179,133,88,42,190,18,49,166,232,18,192,41,154,98,4,110,61,96,19,148,43,22,161,91,186,24,176,233,58,195,91,154,215,194,208,78,185,55,49,89,187,214,104,99,62,155,203,226,179,105,242,176,18,84,112,17,102,39,3,65,252,47,14,130,231,254,64,217,59,202,226,69,27,61,159,241,56,160,180,6,235,89,16,183,154,232,135,38,45,135,205,161,85,3,244,128,231,73,82,197,112,134,197,58,39,232,253,144,76,211,208,113,108,189,119,191,164,153,94,215,33,231,66,194,193,83,19,120,115,224,150,216,101,167,236,99,83,231,93,239,74,239,149,73,120,73,193,118,237,22,168,218,253,59,161,116,229,85,90,29,190,70,181,97,150,2,221,99,196,50,70,59,93,227,183,234,238,86,19,84,225,148,12,116,58,211,241,245,248,2,204,148,165,228,106,150,154,22,62,65,115,63,224,97,77,91,69,176,133,138,113,32,208,57,195,170,167,47,135,181,72,164,229,158,249,39,131,243,211,79,126,251,164,235,159,180,187,254,135,227,118,127,208,189,110,159,117,207,143,251,31,253,107,255,180,123,230,54,10,121,123,211,204,65,113,28,171,54,247,134,241,37,82,215,98,65,119,70,226,188,231,254,215,53,245,118,93,28,23,58,87,134,91,123,194,204,20,207,178,152,104,126,147,75,211,6,89,245,192,246,254,149,150,52,58,233,108,111,72,237,123,4,197,255,11,149,177,66,169,61,90,76,22,38,236,55,142,31,126,81,87,106,128,127,81,104,165,77,33,201,232,247,7,98,146,163,85,203,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d95fb2c1-d588-4589-82d4-01c3afc7de75"));
		}

		#endregion

	}

	#endregion

}
