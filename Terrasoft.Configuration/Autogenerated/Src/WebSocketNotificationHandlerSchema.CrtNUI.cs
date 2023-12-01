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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,85,81,111,211,48,16,126,78,165,253,135,163,123,73,165,42,18,60,128,180,110,123,216,86,70,17,235,166,181,192,195,132,38,55,185,118,134,196,142,108,167,83,24,252,119,46,177,67,147,180,233,38,68,31,218,218,119,254,190,187,239,206,103,193,18,212,41,11,17,230,168,20,211,114,105,130,115,41,150,124,149,41,102,184,20,7,189,167,131,158,151,105,46,86,48,203,181,193,100,212,90,147,127,28,99,88,56,235,224,18,5,42,30,110,124,166,248,104,200,80,224,126,212,82,108,12,117,62,133,180,79,150,67,133,43,130,129,243,152,105,125,4,95,113,49,147,225,15,52,83,105,248,146,135,101,64,31,152,136,98,84,165,255,221,245,66,203,24,13,250,253,119,193,235,183,193,27,248,101,207,2,215,32,157,109,8,153,238,76,47,216,201,49,67,17,161,2,46,40,63,22,5,253,193,55,34,75,179,69,204,67,8,75,252,125,161,193,17,156,49,141,117,203,68,44,165,179,14,97,178,51,29,175,208,121,163,0,105,102,152,48,164,194,141,226,107,102,176,76,216,75,237,2,194,194,14,218,168,178,14,227,233,197,248,22,78,160,223,230,236,91,93,189,67,74,200,34,187,181,163,121,207,49,142,186,56,246,73,115,255,216,109,124,134,179,76,77,101,218,72,85,48,151,170,58,98,171,240,62,109,253,207,26,21,33,8,219,112,69,105,107,203,65,129,226,29,129,121,224,218,111,154,134,32,178,56,30,64,169,242,239,255,196,55,44,249,38,23,188,92,49,149,31,219,138,12,169,249,190,147,203,41,164,76,209,13,51,168,116,21,219,130,90,99,43,182,154,155,141,208,219,39,48,85,90,224,227,190,250,108,17,156,201,40,159,231,41,78,137,102,48,170,105,208,85,165,27,37,83,84,134,99,87,119,184,222,187,95,212,144,71,149,139,52,68,140,81,229,84,103,119,249,173,208,184,127,30,95,130,223,128,129,147,147,122,181,232,99,229,132,166,147,67,15,198,73,106,242,145,243,44,193,54,114,194,171,54,148,87,179,6,115,149,95,162,249,194,226,140,70,136,33,228,155,202,214,167,26,102,77,198,65,197,225,164,43,176,90,17,249,54,164,1,180,84,105,156,82,104,50,37,182,148,179,46,207,22,230,10,205,131,180,119,214,169,220,22,93,174,105,214,241,8,97,45,121,4,182,145,139,97,224,87,34,196,212,53,164,82,241,131,234,175,50,214,209,191,23,173,25,50,248,151,216,182,111,117,45,24,127,50,22,89,130,138,45,98,60,158,180,103,214,41,212,35,120,209,133,8,28,110,243,96,87,155,187,189,86,18,173,183,167,29,213,45,61,147,4,106,47,193,93,241,148,93,151,61,233,95,97,178,64,53,163,87,143,197,252,167,125,84,174,83,51,17,219,143,70,55,166,29,254,37,172,187,120,185,223,63,151,153,40,186,212,62,63,21,212,174,105,195,5,141,154,202,29,158,128,46,215,8,116,241,229,210,111,33,215,3,105,195,239,47,77,227,228,11,152,62,49,109,110,49,225,34,154,243,4,155,84,23,52,70,138,93,104,58,237,64,221,46,24,237,244,122,127,0,216,94,202,206,189,8,0,0 };
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
