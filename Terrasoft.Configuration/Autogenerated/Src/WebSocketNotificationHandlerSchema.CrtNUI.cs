﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebSocketNotificationHandlerSchema

	/// <exclude/>
	public class WebSocketNotificationHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebSocketNotificationHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebSocketNotificationHandlerSchema(WebSocketNotificationHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3e3b52d6-f311-4165-a4a9-925f963aa00e");
			Name = "WebSocketNotificationHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,81,79,219,48,16,126,14,18,255,225,86,94,18,169,138,180,61,108,18,5,30,128,142,117,26,5,209,110,123,64,19,114,147,107,241,150,216,145,237,128,50,182,255,190,75,236,172,73,218,20,52,173,15,109,237,59,127,223,221,119,231,179,96,41,234,140,69,8,115,84,138,105,185,52,225,153,20,75,190,202,21,51,92,138,253,189,167,253,61,47,215,92,172,96,86,104,131,233,168,179,38,255,36,193,168,116,214,225,5,10,84,60,90,251,76,241,209,144,161,196,253,168,165,88,27,154,124,10,105,159,44,7,10,87,4,3,103,9,211,250,16,190,226,98,38,163,31,104,166,210,240,37,143,170,128,62,48,17,39,168,42,255,219,171,133,150,9,26,244,7,239,194,215,111,195,55,240,203,158,5,174,65,58,219,16,114,221,155,94,184,149,99,134,34,70,5,92,80,126,44,14,7,193,55,34,203,242,69,194,35,136,42,252,93,161,193,33,156,50,141,77,203,68,44,165,179,14,97,178,53,29,175,212,121,173,0,105,102,152,48,164,194,181,226,15,204,96,149,176,151,217,5,68,165,29,180,81,85,29,198,211,243,241,13,28,195,160,203,57,176,186,122,7,148,144,69,118,107,71,243,158,99,18,247,113,236,146,230,238,177,223,248,12,103,149,154,202,181,145,170,100,174,84,117,196,86,225,93,218,250,159,53,42,66,16,182,225,202,210,54,150,65,137,226,29,130,185,231,218,111,155,134,32,242,36,9,160,82,249,247,127,226,27,86,124,147,115,94,173,152,42,142,108,69,134,212,124,223,201,229,4,50,166,232,134,25,84,186,142,109,65,173,177,17,91,195,205,70,232,237,18,152,42,45,240,113,87,125,54,8,78,101,92,204,139,12,167,68,19,140,26,26,244,85,233,90,201,12,149,225,216,215,29,174,247,238,22,13,228,81,237,34,13,17,99,92,59,53,217,93,126,43,52,238,159,199,151,224,183,96,224,248,184,89,45,250,88,57,161,237,228,208,195,113,154,153,98,228,60,43,176,181,156,240,170,11,229,53,172,225,92,21,23,104,190,176,36,167,17,98,8,249,186,182,13,168,134,121,155,49,168,57,156,116,37,86,39,34,223,134,20,64,71,149,214,41,133,38,87,98,67,57,235,242,108,97,46,209,220,75,123,103,157,202,93,209,229,3,205,58,30,35,60,72,30,131,109,228,114,24,248,181,8,9,117,13,169,84,254,160,250,171,140,117,244,239,68,103,134,4,255,18,219,230,173,110,4,227,79,198,34,79,81,177,69,130,71,147,238,204,58,129,102,4,47,186,16,161,195,109,31,236,107,115,183,215,73,162,243,246,116,163,186,161,103,146,64,237,37,184,45,159,178,171,170,39,253,75,76,23,168,102,244,234,177,132,255,180,143,202,85,102,38,98,243,209,232,199,180,195,191,130,117,23,175,240,7,103,50,23,101,151,218,231,167,134,218,54,109,184,160,81,83,187,195,19,208,229,26,129,46,191,92,250,29,228,102,32,93,248,221,165,105,157,124,1,211,39,166,205,13,166,92,196,115,158,98,155,234,156,198,72,185,11,109,167,45,168,155,5,163,157,198,231,15,131,63,80,121,198,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3e3b52d6-f311-4165-a4a9-925f963aa00e"));
		}

		#endregion

	}

	#endregion

}

