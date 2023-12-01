﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendMessageDataSchema

	/// <exclude/>
	public class SendMessageDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendMessageDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendMessageDataSchema(SendMessageDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c3037c35-6d4c-4cfc-93be-deef2d9553d9");
			Name = "SendMessageData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("27091b53-7f92-431b-845e-5f00397c8b24");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,75,111,219,48,12,62,167,192,254,131,134,93,210,174,75,208,235,18,231,176,172,107,3,180,67,183,100,231,65,181,25,71,168,45,7,146,220,34,40,250,223,71,73,126,191,26,103,238,37,146,73,126,34,41,234,35,203,105,8,114,79,93,32,27,16,130,202,104,171,38,203,136,111,153,31,11,170,88,196,63,156,189,126,56,27,197,146,113,191,77,101,178,188,94,223,71,30,4,114,150,169,174,15,82,65,88,221,163,93,16,128,171,141,228,228,6,56,8,230,206,26,225,5,224,119,148,124,18,224,163,54,89,6,84,202,175,100,13,220,187,7,41,169,15,223,169,162,70,101,58,157,146,185,140,195,144,138,195,34,217,27,117,178,141,4,217,83,129,33,42,16,146,68,91,242,72,149,187,35,42,34,18,129,38,169,241,180,96,189,143,31,3,230,18,215,0,212,142,27,189,154,35,51,183,126,48,8,60,244,235,65,176,103,170,192,10,247,118,67,238,152,84,115,22,162,241,130,252,53,191,114,150,152,35,174,69,40,195,61,136,104,15,66,49,208,144,198,17,43,175,134,104,62,220,128,194,152,4,134,130,191,106,7,184,144,82,163,48,15,184,98,91,6,98,146,25,79,171,214,243,103,26,196,144,109,55,239,217,231,234,73,134,110,98,230,97,130,140,201,202,35,186,74,70,35,31,212,204,44,100,178,120,235,19,64,44,65,16,55,226,220,150,72,63,239,219,141,107,174,255,65,213,101,166,89,221,14,17,201,99,28,60,17,8,41,11,136,206,165,58,244,139,37,55,239,10,227,27,106,93,155,51,242,213,169,206,87,156,102,92,129,143,249,60,181,148,142,133,170,197,132,218,121,52,191,139,117,149,172,70,2,84,44,120,174,244,43,6,113,184,133,0,31,14,82,138,42,26,143,179,205,100,229,93,86,238,249,220,102,232,237,127,238,86,42,42,20,241,240,177,159,156,158,70,136,90,90,144,125,96,195,66,200,195,94,107,59,253,121,144,122,21,224,178,61,195,11,146,9,69,158,124,241,237,214,205,119,173,245,7,162,15,155,208,208,242,117,63,183,219,76,107,62,155,220,39,45,161,188,25,46,2,36,49,69,93,133,191,105,179,60,37,152,78,148,122,129,49,163,130,200,115,77,236,151,250,114,22,54,192,165,5,202,91,247,32,161,218,126,216,47,176,154,77,45,140,98,203,93,25,237,58,129,176,45,25,39,237,152,56,14,225,113,16,156,167,178,81,38,32,28,94,138,112,227,132,47,44,97,100,52,148,247,245,76,36,243,163,114,52,227,233,169,140,195,113,130,209,211,139,94,227,20,181,15,122,19,206,59,8,181,60,74,37,236,68,102,85,127,106,243,33,110,61,0,238,171,93,234,137,33,139,126,129,116,3,180,83,204,157,181,27,34,6,253,38,116,114,44,115,43,100,101,92,133,251,126,113,84,64,58,139,90,7,113,111,245,13,235,111,214,239,196,209,54,94,222,131,218,69,222,49,179,229,50,136,56,232,112,153,196,227,209,73,238,118,86,156,125,13,114,49,159,166,171,130,255,149,41,218,130,143,211,55,87,149,186,90,154,188,191,138,44,125,131,70,101,82,25,219,156,74,127,47,170,230,99,170,147,143,172,69,133,134,182,234,52,244,218,146,73,210,185,156,180,135,21,133,165,135,227,148,222,81,13,35,41,77,167,88,168,69,165,202,213,59,149,90,176,170,154,212,90,216,250,99,133,227,44,106,139,178,205,123,99,55,104,193,47,206,81,198,141,132,119,155,143,93,181,209,171,21,148,192,18,138,53,134,199,79,177,65,244,130,255,244,185,79,186,39,131,215,61,8,116,150,173,126,118,136,122,23,189,60,88,184,107,68,203,202,54,113,110,156,150,193,23,114,117,78,46,74,100,243,153,92,29,239,246,142,249,187,65,253,190,69,192,14,199,83,191,47,106,101,215,64,34,201,183,50,175,152,111,248,247,15,131,145,203,98,67,16,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c3037c35-6d4c-4cfc-93be-deef2d9553d9"));
		}

		#endregion

	}

	#endregion

}

