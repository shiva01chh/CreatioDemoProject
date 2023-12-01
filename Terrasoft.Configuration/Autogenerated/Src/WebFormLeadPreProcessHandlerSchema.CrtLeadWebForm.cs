﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormLeadPreProcessHandlerSchema

	/// <exclude/>
	public class WebFormLeadPreProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormLeadPreProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormLeadPreProcessHandlerSchema(WebFormLeadPreProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5131dc53-4fdc-4167-9a9a-5dfd90a5a90d");
			Name = "WebFormLeadPreProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc0e3e3b-059a-41c0-ac9d-be82e0250c11");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,75,111,219,48,12,62,39,64,255,131,150,93,82,160,176,239,109,210,75,250,10,182,14,5,250,216,89,149,105,71,128,45,25,146,28,172,40,250,223,71,61,236,218,138,235,12,59,24,16,41,242,35,63,146,162,5,173,64,215,148,1,121,2,165,168,150,185,73,54,82,228,188,104,20,53,92,138,147,249,251,201,124,214,104,46,10,114,11,2,80,11,217,111,120,189,145,170,122,4,181,231,12,46,58,131,141,84,145,148,220,80,102,164,226,160,81,143,55,223,21,20,136,74,54,37,213,250,156,4,160,159,64,179,7,5,15,74,50,208,250,142,138,172,4,229,236,211,52,37,43,221,84,21,85,111,151,65,246,247,154,212,10,240,115,46,100,103,117,54,104,46,21,41,17,142,104,186,71,57,105,49,210,8,100,165,1,104,169,37,97,10,242,245,226,11,246,201,54,230,124,144,230,130,164,22,179,110,94,75,206,8,179,188,38,105,157,147,227,152,136,247,238,232,119,245,194,251,26,148,193,58,158,219,179,1,134,238,222,164,110,69,242,172,65,97,250,2,37,235,19,137,182,143,179,89,1,230,194,29,116,56,124,132,64,32,50,31,107,24,248,30,204,78,102,83,81,247,146,103,228,17,204,115,29,232,220,211,26,115,93,110,131,184,173,106,169,204,3,85,180,210,129,57,246,168,30,202,167,33,189,72,157,92,65,78,155,210,188,208,178,129,123,42,104,1,138,172,253,244,248,201,122,75,110,193,172,108,165,71,76,47,151,167,125,142,81,206,215,25,55,54,193,43,106,232,178,61,216,1,114,135,54,35,148,129,178,29,113,22,55,28,202,76,119,118,61,145,139,206,51,25,94,181,64,51,124,15,10,195,255,194,39,231,146,92,70,118,23,3,179,91,144,133,162,245,142,51,90,110,100,217,84,66,143,59,124,124,205,112,2,106,146,77,155,50,207,201,242,91,104,227,29,148,216,213,100,171,15,209,162,188,18,129,12,79,59,218,10,76,163,68,47,215,217,158,42,194,156,39,246,114,8,143,205,236,227,63,11,110,190,142,113,70,124,132,232,106,111,139,219,222,13,31,65,40,217,8,22,102,226,83,74,126,192,219,168,149,131,253,52,115,45,156,152,174,131,110,255,83,197,109,105,0,231,18,178,77,91,160,14,33,32,74,87,165,35,195,20,234,51,70,97,178,6,253,216,71,43,49,48,62,168,199,241,141,226,86,166,191,140,247,188,83,92,255,1,214,24,220,244,102,7,238,235,109,252,118,215,235,26,24,207,57,86,189,196,221,105,181,53,190,252,164,195,76,99,208,149,91,49,196,242,93,47,154,193,116,44,46,159,48,136,213,97,147,91,101,178,74,157,199,56,64,251,230,189,171,149,72,102,75,52,233,20,45,57,239,235,148,96,64,105,82,116,235,239,0,198,63,38,221,41,194,127,3,233,127,198,254,228,222,183,14,63,168,110,207,133,226,46,163,191,196,176,34,103,228,96,47,182,15,235,191,214,123,20,108,29,133,243,211,54,242,47,137,225,188,225,96,129,119,123,219,223,121,234,93,214,19,131,233,181,67,165,211,205,231,127,1,24,177,250,235,30,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5131dc53-4fdc-4167-9a9a-5dfd90a5a90d"));
		}

		#endregion

	}

	#endregion

}

