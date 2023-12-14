﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormSubmitPreProcessHandlerSchema

	/// <exclude/>
	public class WebFormSubmitPreProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormSubmitPreProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormSubmitPreProcessHandlerSchema(WebFormSubmitPreProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a07ceba0-f001-4b60-8b92-88109299f9c4");
			Name = "WebFormSubmitPreProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8fa2fedf-477a-49c5-b16a-2ddd6c5f7040");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,85,219,78,219,64,16,125,118,165,254,195,52,149,42,71,66,206,59,196,32,218,146,18,137,182,136,164,237,99,181,216,227,100,37,223,186,187,78,65,136,127,239,236,205,183,4,16,42,146,137,61,59,115,246,204,153,217,157,146,21,40,107,150,32,172,81,8,38,171,76,69,159,170,50,227,155,70,48,197,171,242,237,155,135,183,111,130,70,242,114,3,171,123,169,176,56,25,125,147,127,158,99,162,157,101,244,5,75,20,60,217,243,185,226,229,159,206,216,223,75,96,103,55,209,76,97,250,11,111,23,149,40,86,40,118,60,193,167,2,163,5,75,84,37,56,74,242,32,159,247,2,55,196,2,62,229,76,202,99,240,32,205,109,193,213,181,192,107,81,37,40,229,37,43,211,28,133,137,152,205,102,48,151,77,81,48,113,127,234,190,237,186,132,90,32,61,38,4,182,218,166,9,100,149,208,79,1,210,160,130,100,59,50,71,30,106,54,194,154,75,68,150,203,10,18,129,89,60,121,66,227,104,57,78,124,143,237,4,102,26,179,110,110,115,158,64,162,19,124,33,63,56,134,151,97,9,242,193,8,209,106,71,235,53,10,69,154,30,235,119,69,133,197,212,186,212,254,19,126,72,20,148,65,105,171,62,254,124,128,13,170,19,144,250,223,227,56,84,211,248,204,20,235,94,14,186,243,29,209,134,229,186,106,146,237,170,106,4,53,232,111,105,126,47,49,39,130,39,198,205,170,49,240,90,245,156,64,183,110,16,16,60,196,167,195,120,56,59,131,112,104,137,141,115,96,154,199,54,214,61,181,179,154,247,225,79,195,18,255,2,229,42,149,104,180,203,185,216,52,5,150,42,156,52,3,17,38,71,35,85,166,211,169,225,28,200,67,108,98,216,177,188,49,141,30,56,13,222,99,153,218,154,12,11,244,21,213,182,74,77,117,140,72,67,197,118,21,79,225,60,77,181,186,11,142,121,250,83,227,134,68,215,116,175,182,124,163,35,127,4,206,98,182,157,58,161,118,76,88,23,105,10,19,183,53,138,50,15,103,86,162,117,117,197,165,10,93,70,38,204,59,80,84,7,17,45,184,144,234,187,248,140,25,107,114,21,102,58,243,44,42,137,65,116,241,167,161,147,17,182,148,188,62,60,131,176,135,22,67,217,228,57,124,248,0,239,44,229,104,41,191,145,229,187,248,181,229,10,87,250,238,10,109,22,62,141,160,71,128,164,48,37,91,12,18,8,91,215,64,115,241,156,141,50,206,110,32,125,93,172,237,209,49,12,158,144,101,152,250,186,58,167,195,126,239,69,122,124,93,105,159,56,120,166,188,23,41,87,158,66,155,201,126,205,39,238,208,47,83,106,198,150,50,117,116,107,15,167,196,114,101,84,13,167,189,98,222,214,197,37,221,87,207,52,192,138,66,114,236,10,123,167,11,123,23,89,49,99,152,124,180,8,147,233,89,212,53,182,199,190,249,95,232,155,61,100,221,52,45,235,174,101,252,102,214,210,22,93,160,106,68,217,171,203,33,245,174,232,134,36,42,215,108,131,63,110,174,72,66,135,239,116,58,16,65,91,209,253,78,119,245,145,219,120,250,186,243,108,110,51,187,56,158,75,198,112,113,135,73,163,104,50,169,45,154,167,55,161,252,108,146,53,38,156,186,48,133,220,242,135,154,18,136,90,204,217,24,116,94,51,193,10,208,242,198,227,59,236,116,77,155,104,27,36,173,49,154,207,76,196,97,128,204,21,213,134,154,65,153,234,162,62,27,100,222,165,155,85,149,176,177,198,136,10,133,164,241,224,86,246,97,108,37,101,107,112,211,141,210,239,246,238,114,239,123,187,217,209,78,33,39,110,56,154,101,67,69,186,115,4,62,83,119,95,44,253,161,42,234,74,168,235,97,70,48,202,208,55,226,104,175,120,180,155,109,180,118,199,184,221,211,46,12,175,1,107,179,25,182,44,159,233,63,107,29,26,141,141,254,254,1,11,3,196,235,21,10,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a07ceba0-f001-4b60-8b92-88109299f9c4"));
		}

		#endregion

	}

	#endregion

}

