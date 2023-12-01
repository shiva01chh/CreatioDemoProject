﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebFormEventTargetPostProcessHandlerSchema

	/// <exclude/>
	public class WebFormEventTargetPostProcessHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebFormEventTargetPostProcessHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebFormEventTargetPostProcessHandlerSchema(WebFormEventTargetPostProcessHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b93c4fca-ee9f-428c-9e74-1bbcd672a290");
			Name = "WebFormEventTargetPostProcessHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9892593b-d041-45d0-95a7-d3a6e875d1a5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,91,111,219,54,20,126,118,128,254,7,214,221,131,140,25,10,182,199,36,78,135,38,78,106,32,233,130,38,93,31,218,46,80,164,99,135,168,110,37,41,55,193,154,255,190,195,139,36,146,162,29,23,195,94,18,81,62,215,239,92,169,50,41,128,215,73,10,228,6,24,75,120,181,20,241,73,85,46,233,170,97,137,160,85,249,98,239,159,23,123,163,134,211,114,69,174,31,185,128,226,208,59,199,23,180,252,214,191,60,169,138,162,42,237,51,131,254,116,14,37,160,96,200,62,194,221,89,197,138,107,96,107,154,130,75,30,207,75,65,5,5,62,80,117,82,229,57,164,210,46,30,43,81,52,29,208,220,192,131,136,223,195,170,201,19,54,127,168,25,112,46,233,145,14,41,95,49,88,225,137,156,228,9,231,7,196,88,49,95,67,41,110,18,182,2,113,85,113,113,197,170,20,185,222,38,101,150,3,83,124,251,251,251,228,136,55,69,145,176,199,99,115,70,178,53,205,128,147,26,121,72,173,153,164,33,203,138,17,75,36,201,81,144,124,207,147,53,196,173,176,125,79,218,17,7,72,114,94,145,148,193,114,54,222,16,142,120,225,35,56,52,120,76,246,165,208,186,185,203,105,74,82,233,233,78,142,146,3,178,131,116,148,44,51,162,67,242,140,66,158,33,148,87,140,174,145,81,161,53,170,245,129,164,8,188,32,92,48,233,254,109,78,203,175,144,97,12,155,162,196,0,193,3,153,145,63,198,127,71,159,62,127,255,156,125,249,117,242,57,238,30,127,25,31,186,146,62,112,96,136,68,169,163,79,110,27,231,124,104,147,94,80,46,142,164,241,218,180,211,68,36,199,228,118,217,189,112,136,85,170,61,146,91,86,85,66,63,7,126,190,78,239,161,72,52,145,126,54,214,189,130,50,211,56,152,179,1,5,33,171,129,201,20,150,192,84,2,173,132,172,117,200,28,201,154,50,209,36,121,11,207,117,213,176,20,180,248,119,88,150,68,193,60,146,9,164,159,70,12,68,195,74,50,182,162,56,86,214,142,158,228,223,167,237,54,93,130,184,175,54,70,234,174,170,114,178,224,23,86,136,34,99,88,170,78,210,164,137,177,196,24,162,98,24,47,248,101,34,210,251,168,39,155,6,66,61,57,180,76,108,149,26,5,231,32,108,189,26,115,41,232,89,11,60,206,171,132,9,199,142,223,54,168,197,90,74,55,104,87,50,6,122,167,132,150,130,172,88,213,212,239,154,226,14,88,107,136,242,157,20,234,239,204,32,178,59,30,173,31,138,63,62,151,226,249,39,75,203,151,248,175,36,111,96,23,236,52,106,39,157,210,255,140,221,239,65,236,206,27,154,73,214,119,240,221,214,187,200,162,96,217,245,85,55,117,106,73,235,36,54,44,173,121,235,132,17,48,66,21,43,226,122,70,203,204,85,167,126,145,58,34,91,133,35,79,35,172,12,166,153,194,17,37,57,146,227,181,124,139,25,140,191,210,76,82,70,19,93,106,175,149,163,49,130,194,33,10,240,24,178,3,77,134,96,104,102,39,168,70,105,8,69,23,166,173,238,253,159,176,246,98,226,51,202,184,248,147,157,194,50,105,114,17,45,53,197,177,118,83,157,226,82,54,165,217,204,145,30,235,127,202,81,213,180,126,252,120,150,69,210,105,34,131,151,111,150,123,126,253,154,148,240,221,131,204,131,218,225,8,1,190,174,48,11,174,193,180,120,101,46,143,22,243,178,41,112,220,221,229,48,64,56,237,253,234,48,54,110,232,67,139,171,77,24,163,148,121,210,213,190,201,185,227,182,127,15,42,18,125,221,92,191,150,12,133,163,241,88,5,50,31,176,104,81,118,22,188,121,180,196,232,146,182,217,98,77,219,74,165,75,18,133,164,206,72,217,228,121,235,108,11,184,97,122,210,255,58,92,173,100,112,132,77,3,6,79,109,136,141,21,79,193,150,227,198,206,214,17,8,203,150,122,112,181,123,37,104,27,99,156,13,67,130,221,226,162,170,190,54,245,205,99,221,145,250,93,198,108,79,111,33,199,53,0,55,85,177,192,205,20,211,147,85,197,41,85,27,11,110,126,33,225,239,97,9,12,202,118,15,80,181,50,53,208,219,169,166,187,208,212,223,131,236,104,190,52,230,196,243,111,184,101,240,72,117,170,121,81,99,234,246,225,116,51,2,196,166,8,182,168,25,153,19,39,1,158,8,228,188,221,87,126,90,228,192,171,201,112,167,9,173,99,38,182,225,172,15,12,112,103,149,227,58,249,141,205,67,177,253,69,195,200,224,24,85,205,100,90,30,119,26,144,33,138,101,39,31,20,222,68,246,48,151,194,107,155,54,177,93,2,59,236,114,207,44,151,166,68,206,219,242,81,105,208,245,203,32,42,196,173,249,238,165,121,64,95,220,69,56,208,147,44,176,24,96,224,140,238,112,182,26,8,157,188,57,3,92,136,84,185,188,233,198,47,194,232,42,57,80,118,186,45,163,243,223,52,141,15,181,221,94,67,121,177,109,10,216,115,139,111,206,22,135,110,167,78,108,33,104,80,232,187,141,219,122,113,162,146,151,206,252,12,54,32,187,47,63,5,99,178,144,163,213,186,231,200,182,36,69,100,86,46,30,201,236,56,142,182,77,120,99,110,160,245,106,199,13,208,174,102,119,51,243,187,156,35,210,164,162,166,191,110,115,111,27,187,143,95,107,141,55,186,60,83,117,98,58,201,97,235,12,238,146,61,176,246,212,247,204,227,241,199,123,52,207,132,187,219,161,54,95,114,52,161,158,241,210,106,191,23,140,252,189,197,221,77,156,165,68,51,184,45,56,89,67,180,196,9,0,147,13,165,226,182,138,0,48,27,35,179,243,246,25,78,23,91,212,46,157,194,31,45,184,173,90,217,201,163,240,202,31,188,173,220,62,115,109,216,54,197,198,139,108,236,143,66,187,176,130,67,47,60,65,3,189,239,112,244,83,3,64,125,229,209,63,250,31,169,212,139,249,3,164,141,192,44,21,247,120,105,172,33,165,184,154,103,68,226,43,63,207,24,128,227,142,127,223,23,112,84,39,44,41,136,76,207,217,216,13,203,248,248,6,133,250,162,142,246,21,71,88,128,249,22,134,8,42,222,246,211,24,205,100,151,71,203,216,118,118,25,53,217,154,53,183,60,145,12,143,219,153,218,1,162,153,244,105,147,70,243,213,76,141,15,3,93,228,125,123,114,49,152,234,43,113,231,151,191,89,126,250,66,90,163,13,105,63,207,116,109,120,185,142,25,27,248,184,53,178,38,198,128,34,182,171,240,50,41,147,149,217,58,75,46,18,236,147,102,0,249,95,152,134,169,235,180,240,206,206,190,193,58,164,94,127,29,78,32,171,198,204,101,83,162,16,223,84,242,78,219,22,235,206,227,87,78,47,235,194,170,155,108,123,79,245,63,93,245,215,207,73,64,143,222,2,80,190,154,163,253,157,107,208,202,181,103,88,208,114,25,140,242,84,106,218,220,200,243,212,104,52,108,167,232,38,45,211,206,85,180,30,240,118,72,134,91,8,161,229,208,152,14,217,225,26,51,188,212,181,59,138,131,191,221,147,228,20,216,182,91,234,183,238,75,245,110,111,239,95,55,201,154,249,37,24,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b93c4fca-ee9f-428c-9e74-1bbcd672a290"));
		}

		#endregion

	}

	#endregion

}

