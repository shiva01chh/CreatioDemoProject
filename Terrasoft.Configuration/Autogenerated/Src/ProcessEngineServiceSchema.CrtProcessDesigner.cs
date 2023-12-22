﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessEngineServiceSchema

	/// <exclude/>
	public class ProcessEngineServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessEngineServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessEngineServiceSchema(ProcessEngineServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7f14723-039c-438b-b43a-9b369264a887");
			Name = "ProcessEngineService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("96d1b784-3b9b-4dbf-9322-c475322e3eef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,88,91,111,219,54,20,126,118,129,254,7,206,27,90,25,240,148,237,53,137,3,196,137,51,120,104,210,32,151,229,33,8,6,90,58,182,181,232,86,146,114,234,5,249,239,59,188,136,18,105,217,105,183,1,197,214,135,212,34,15,207,229,59,87,50,167,25,240,146,70,64,110,128,49,202,139,185,8,79,138,124,158,44,42,70,69,82,228,111,223,60,191,125,211,171,120,146,47,200,245,154,11,200,14,188,111,164,79,83,136,36,49,15,127,129,28,88,18,109,208,156,82,65,55,22,175,170,92,36,25,132,215,120,132,166,201,159,74,224,6,21,238,174,146,8,206,139,24,210,157,155,225,29,204,118,19,28,163,150,43,79,202,34,45,102,52,221,223,63,41,178,172,200,195,15,197,98,129,203,205,126,27,23,73,209,189,195,96,219,122,120,58,222,186,117,201,138,8,56,239,218,191,168,18,87,119,137,32,122,70,48,26,137,174,3,104,124,163,33,238,127,207,96,129,134,146,147,148,114,190,79,140,168,73,142,214,129,97,172,232,246,246,246,200,33,175,178,140,178,245,145,249,190,89,2,121,130,25,225,154,142,136,37,21,164,100,197,42,137,129,19,26,73,78,68,20,184,14,120,22,128,68,12,230,163,190,35,163,79,246,142,72,6,98,89,196,60,172,229,236,181,4,221,27,45,106,163,30,228,218,49,47,47,64,160,29,37,186,105,150,164,137,88,95,193,167,42,97,144,65,46,120,208,254,144,184,144,17,121,229,136,164,10,205,66,60,144,66,202,106,150,38,17,137,36,48,157,184,144,125,50,166,188,65,169,247,172,144,178,144,158,107,171,36,168,50,156,52,142,189,82,127,16,46,80,143,136,48,160,113,145,167,107,50,197,144,34,191,167,248,103,68,240,231,57,205,233,2,24,102,138,144,177,6,44,168,113,235,15,14,58,57,157,38,42,185,16,182,67,46,24,122,125,72,138,217,31,152,113,71,4,153,92,71,75,200,232,37,101,152,201,2,216,111,52,173,128,7,183,232,58,4,54,215,121,73,42,231,115,40,133,244,122,210,70,35,90,51,153,164,10,50,50,147,198,183,87,134,100,58,201,171,12,24,157,165,112,40,161,78,81,150,149,121,68,34,127,137,15,200,179,146,178,162,140,240,46,21,17,141,28,158,118,24,23,72,56,28,14,181,126,35,18,76,141,226,141,64,116,10,157,230,243,98,176,161,189,102,227,88,106,143,53,181,203,149,209,240,69,105,206,78,120,86,176,8,16,248,134,164,214,116,142,57,77,163,37,9,54,16,34,165,253,149,228,59,208,218,162,165,242,223,13,229,143,205,202,104,155,190,225,89,146,199,227,245,5,126,6,86,106,248,8,107,163,100,47,153,147,160,131,31,186,163,74,83,171,72,47,194,180,76,242,10,204,169,23,253,159,116,70,140,149,168,173,136,116,99,243,93,159,87,94,198,221,70,135,149,92,49,220,12,87,191,84,34,103,117,238,102,93,130,146,211,124,141,54,65,112,233,91,230,185,39,19,78,144,16,110,176,213,184,2,222,189,115,109,9,141,206,62,20,157,68,164,47,137,250,46,60,58,116,27,155,107,90,151,3,6,143,218,8,188,180,124,205,194,218,131,157,249,116,191,121,88,198,192,67,219,5,138,82,51,209,10,51,16,21,203,187,19,84,209,189,152,202,7,121,172,139,223,182,74,168,106,170,222,244,59,138,90,184,82,146,56,134,63,102,73,166,122,176,110,43,12,74,6,92,86,106,66,177,225,8,82,204,85,95,41,117,38,16,220,97,107,82,22,9,82,132,150,253,158,207,255,80,25,73,114,180,96,212,199,51,216,5,116,18,221,78,227,254,209,109,158,124,66,71,96,251,194,157,121,130,97,106,164,104,74,3,64,120,184,167,184,236,98,42,185,77,183,176,113,206,223,127,44,65,143,80,237,6,215,187,199,62,61,205,87,197,35,4,26,60,25,73,151,31,175,111,250,67,50,46,226,245,181,88,167,50,98,144,236,28,205,199,86,97,87,195,59,70,203,18,226,33,145,237,12,184,56,83,72,58,196,122,41,252,149,215,85,254,10,199,59,28,204,96,55,173,234,139,117,99,252,144,112,113,168,207,69,48,145,240,95,42,244,85,187,177,253,210,46,203,16,13,116,237,38,30,240,67,226,172,79,227,58,167,60,186,240,100,9,209,227,49,91,84,178,150,93,96,94,125,100,147,172,20,235,96,195,149,38,7,106,134,175,158,108,142,236,108,137,8,140,187,223,244,30,102,16,52,149,110,43,58,237,126,5,118,253,26,100,127,33,35,157,185,129,254,28,72,70,250,167,87,3,6,166,228,200,161,186,202,242,160,143,99,108,13,185,174,244,18,110,105,148,38,12,207,88,145,5,253,70,15,187,113,183,4,6,106,199,197,47,156,242,201,167,138,166,129,150,16,218,172,15,164,82,191,84,73,28,120,152,15,6,53,207,227,60,174,57,126,21,171,13,30,83,174,70,113,216,197,67,176,10,6,6,211,169,51,166,213,181,193,124,141,60,95,134,46,181,230,160,199,229,224,116,60,249,12,81,37,10,108,99,51,251,115,131,195,36,231,21,131,211,113,179,20,12,108,63,48,172,166,210,19,87,56,229,1,83,195,158,234,133,190,227,67,45,3,52,93,208,200,108,216,245,78,199,178,184,163,168,21,48,217,65,227,153,251,189,161,157,119,192,116,133,222,211,50,193,210,17,104,93,66,41,177,165,116,175,39,253,65,64,7,209,84,150,29,79,14,178,213,157,166,80,158,211,108,238,127,122,168,187,142,153,196,186,226,209,164,70,103,172,250,1,110,185,201,70,253,93,39,187,240,12,68,180,148,145,125,58,14,172,198,109,91,252,233,196,54,96,99,102,195,86,89,218,45,229,186,69,100,249,152,21,219,126,70,110,176,169,233,202,208,140,215,152,28,65,91,84,120,83,92,171,130,23,12,134,68,197,175,99,173,229,233,15,24,187,236,145,160,155,131,42,103,100,187,194,1,248,210,93,26,24,18,165,223,89,90,60,25,67,181,142,13,134,150,255,214,225,223,31,181,61,217,161,189,114,24,146,160,225,89,87,202,240,56,142,85,9,232,40,147,141,201,137,244,140,213,172,13,93,131,10,45,77,113,118,71,240,19,189,110,177,178,42,188,180,167,49,103,196,169,117,107,79,53,157,131,74,61,187,227,228,161,82,85,202,247,71,18,163,198,23,78,35,242,216,36,221,61,135,248,172,119,78,34,118,158,227,253,163,214,224,255,255,152,62,48,72,172,15,38,181,7,2,149,213,22,200,161,238,194,29,23,209,6,154,58,187,254,78,219,255,186,118,211,209,109,228,200,250,252,202,45,123,75,162,153,58,179,145,102,214,248,58,216,119,60,11,200,48,177,183,236,173,111,4,254,237,131,187,87,254,22,148,7,206,229,244,20,120,196,146,82,245,208,230,167,111,128,231,67,76,236,150,251,26,5,107,222,38,77,27,134,225,29,77,228,177,91,115,173,225,39,69,85,223,229,95,72,68,177,67,4,254,219,92,56,21,144,93,20,24,154,85,30,79,62,71,160,202,132,173,179,242,17,6,217,178,60,248,161,127,44,144,180,20,242,21,171,190,142,119,37,34,121,74,196,146,96,19,121,255,108,213,127,121,63,36,179,74,232,235,139,165,163,156,228,133,32,115,41,58,236,123,102,253,248,115,235,214,181,171,250,152,113,129,127,203,122,243,223,173,29,171,2,171,132,129,208,109,248,94,1,249,166,197,193,205,147,78,117,117,219,246,82,254,149,187,120,251,129,216,221,49,79,192,29,221,88,211,221,183,143,182,241,212,79,164,29,231,136,121,17,181,34,80,125,12,26,145,128,247,22,160,121,159,67,54,3,246,160,173,215,172,205,197,16,157,242,76,22,32,14,228,213,255,128,188,124,217,169,122,46,232,58,234,195,243,10,106,6,155,141,86,242,69,200,108,190,243,253,91,184,60,194,250,171,128,49,15,79,234,137,237,31,193,226,126,107,42,119,81,173,181,255,253,5,170,120,234,127,68,26,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7f14723-039c-438b-b43a-9b369264a887"));
		}

		#endregion

	}

	#endregion

}

