﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ProcessEntitiesFileImportStageSchema

	/// <exclude/>
	public class ProcessEntitiesFileImportStageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ProcessEntitiesFileImportStageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ProcessEntitiesFileImportStageSchema(ProcessEntitiesFileImportStageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3097ba9e-50e7-45c0-9a7c-b463e370a647");
			Name = "ProcessEntitiesFileImportStage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,90,91,111,219,54,20,126,246,128,253,7,182,195,0,25,241,148,238,181,142,93,164,110,186,26,104,179,32,78,183,135,97,40,24,137,182,181,217,162,39,81,105,141,44,255,125,135,23,73,188,137,146,187,173,15,77,68,30,30,158,243,157,43,201,228,120,79,202,3,78,8,186,35,69,129,75,186,102,241,130,230,235,108,83,21,152,101,52,143,223,102,59,178,220,31,104,193,190,253,230,241,219,111,70,85,153,229,27,180,58,150,140,236,167,214,55,44,221,237,72,194,215,149,241,79,36,39,69,150,56,52,239,179,252,175,118,80,223,118,191,167,185,127,166,32,93,227,241,91,156,48,90,100,164,4,10,160,249,174,32,27,216,30,161,197,14,151,229,75,116,83,208,132,148,229,85,206,50,6,68,173,54,43,134,55,68,44,57,63,63,71,23,89,190,5,105,89,74,19,148,20,100,61,123,254,26,151,196,162,126,126,62,175,201,203,106,191,199,197,177,254,190,250,66,146,138,17,148,9,98,68,212,110,53,245,185,70,254,219,27,178,198,213,142,189,206,242,20,212,137,216,241,64,232,58,90,122,246,27,79,208,53,216,7,205,80,14,63,128,40,172,204,120,252,59,240,63,84,247,187,12,148,224,234,247,104,143,94,34,207,174,192,227,81,224,210,98,249,54,35,187,84,128,153,61,96,38,81,27,29,228,7,90,182,235,239,240,230,3,206,129,71,129,62,173,61,163,83,99,157,156,173,101,91,108,171,252,207,242,13,102,24,132,126,200,82,206,35,235,161,240,241,187,166,44,91,103,237,234,250,219,71,123,131,11,0,150,145,162,188,37,7,90,102,224,72,199,122,157,111,206,224,145,82,64,154,160,79,52,39,55,164,72,192,230,191,224,93,69,12,154,42,203,25,250,84,86,9,183,130,50,6,73,111,233,231,114,65,171,156,121,104,15,53,209,175,25,219,94,21,5,45,66,212,140,50,188,243,19,220,83,186,3,93,202,107,66,82,129,193,113,170,172,74,242,84,26,214,180,50,132,125,201,138,138,71,19,55,181,112,35,73,97,123,188,24,88,20,132,111,147,193,34,156,67,254,160,107,160,33,68,69,79,216,241,100,32,185,177,33,71,14,28,121,225,242,179,231,85,73,10,16,44,151,73,229,249,92,219,226,163,57,117,62,191,56,23,43,253,140,18,186,171,246,121,109,3,90,24,172,150,11,57,123,185,217,0,24,24,16,184,76,241,1,108,111,113,85,177,21,86,46,50,5,67,166,10,19,212,185,25,178,101,28,243,61,71,163,151,232,30,162,52,178,249,56,212,232,17,61,133,77,12,180,7,82,112,153,79,138,101,239,224,108,238,143,113,244,234,21,138,252,51,51,169,143,200,204,50,109,31,161,74,176,11,239,174,243,8,166,76,40,47,139,77,181,135,56,139,198,227,241,212,18,188,55,153,244,18,204,230,82,188,222,172,35,53,236,165,82,218,250,244,237,147,229,171,116,247,38,179,192,20,55,96,119,170,3,37,133,252,81,136,102,134,186,116,243,145,15,211,106,144,239,218,201,105,120,245,174,99,152,62,64,27,1,88,35,139,10,162,186,218,35,241,235,50,229,24,249,230,227,112,6,232,209,228,3,97,91,218,89,78,31,104,150,162,203,52,133,72,40,239,168,228,74,82,177,211,49,210,28,231,184,194,15,48,254,0,232,1,138,37,194,240,31,164,0,97,52,95,60,197,156,94,174,228,172,35,182,205,202,9,202,201,103,20,96,250,168,124,248,150,82,182,74,182,100,143,63,114,84,196,102,177,49,56,81,148,160,19,207,230,146,91,77,105,12,214,148,10,48,128,17,64,105,185,90,195,130,248,105,44,74,219,83,103,178,50,66,169,201,136,170,70,153,131,81,13,210,3,134,140,107,210,251,252,185,111,147,160,87,215,186,114,152,181,250,218,16,184,101,105,130,22,118,94,151,202,143,10,194,170,34,183,68,246,226,34,164,229,249,68,72,122,33,97,23,191,243,193,185,130,69,14,55,100,209,79,21,56,94,102,162,175,228,95,114,167,39,5,134,126,231,66,247,150,57,50,179,224,152,7,76,235,82,1,17,148,99,241,15,222,222,194,18,139,164,113,189,81,205,28,232,204,221,226,21,225,135,141,72,27,21,89,77,255,22,94,15,65,201,8,164,152,248,142,190,207,74,48,139,100,253,164,180,19,211,192,93,10,45,36,16,67,64,174,112,86,132,98,74,120,42,199,42,190,38,159,249,207,198,202,174,67,251,209,188,131,142,223,220,142,143,196,82,96,97,207,169,39,37,72,163,137,208,21,150,42,140,232,67,92,177,139,38,230,107,16,56,121,48,41,104,92,219,132,240,154,172,225,100,101,58,189,200,30,189,121,161,240,165,132,102,211,214,132,252,35,16,217,66,225,55,96,93,37,90,173,66,182,142,186,155,105,244,108,134,82,121,182,138,120,119,60,174,87,169,200,145,81,244,212,141,133,220,16,122,101,136,230,212,130,228,114,13,181,108,8,34,117,194,110,197,154,161,23,150,170,90,168,58,129,213,29,51,115,4,137,198,237,25,34,187,224,162,67,243,107,139,27,138,158,245,53,29,60,221,45,213,248,213,23,112,167,50,106,57,217,105,185,5,183,151,173,116,177,70,47,157,235,88,183,137,202,111,67,196,12,9,230,243,39,79,234,69,129,172,221,180,130,157,105,219,58,150,76,144,201,202,238,208,132,63,47,243,140,9,143,40,135,152,204,58,218,129,23,105,58,223,185,199,190,145,125,14,133,21,31,48,219,198,11,146,237,248,61,131,205,240,28,253,248,226,197,90,89,160,187,105,139,63,30,82,158,61,109,163,249,34,150,107,104,30,194,135,58,103,100,28,84,65,244,103,154,182,124,98,5,189,148,156,12,133,181,117,228,15,244,167,53,201,191,171,222,118,107,12,142,160,233,215,13,148,212,132,167,108,126,71,86,254,156,107,205,151,200,93,232,224,164,55,29,46,19,173,191,255,246,144,163,239,157,155,9,52,71,47,2,224,241,126,136,52,249,108,230,107,13,193,143,220,140,119,103,59,170,229,105,109,103,232,200,56,243,8,46,37,154,250,236,25,75,133,85,90,110,100,237,198,249,231,220,233,109,35,122,255,7,216,25,149,224,80,164,152,132,154,95,189,163,22,37,55,105,234,191,232,84,85,59,160,68,237,172,75,103,103,146,162,171,167,199,141,10,163,160,95,116,239,208,13,192,13,61,84,59,248,106,214,168,20,220,219,159,145,118,160,201,72,129,171,41,116,54,67,178,232,106,11,99,206,42,190,113,86,169,205,180,212,213,93,211,187,249,174,172,53,54,87,111,83,172,37,162,155,130,64,172,18,123,220,205,88,118,144,27,221,94,0,194,68,7,143,7,151,238,235,75,240,190,47,164,14,179,119,184,220,174,32,57,113,77,231,145,114,6,104,118,4,139,88,245,167,158,6,117,153,43,245,155,176,182,247,185,37,37,244,67,60,40,251,238,43,120,118,52,12,160,118,87,94,174,132,26,37,131,44,96,69,182,148,34,22,83,81,38,122,244,122,53,215,11,242,42,241,240,15,122,78,104,135,49,250,1,13,147,83,109,58,196,1,79,99,56,40,86,134,234,170,152,122,252,39,134,164,114,139,243,13,212,103,23,140,250,120,196,241,150,27,102,113,189,116,60,182,83,191,16,70,59,107,105,194,213,163,82,140,248,215,45,41,72,68,56,219,103,62,153,160,84,50,156,229,101,68,180,237,212,90,37,19,72,200,204,35,198,177,61,157,249,91,18,30,40,206,216,204,137,206,120,177,131,178,87,51,241,172,169,29,186,81,209,72,227,190,5,171,182,237,142,12,148,204,131,185,103,233,9,133,73,216,188,175,56,73,199,240,22,168,144,199,169,10,228,45,16,114,149,81,22,122,115,223,215,84,15,222,182,232,57,188,59,169,53,161,16,232,85,250,175,126,220,155,29,239,93,144,100,186,170,238,203,164,200,238,173,105,129,180,178,121,123,29,35,151,232,192,89,20,19,23,54,3,17,201,64,252,247,49,47,79,222,218,103,198,62,62,167,226,85,67,111,142,198,94,127,68,63,212,70,124,79,55,252,28,253,14,231,233,142,92,125,73,200,129,247,211,211,147,56,117,68,198,32,38,169,159,65,218,9,91,216,238,255,43,104,103,255,25,104,103,255,22,52,47,131,110,208,12,207,63,21,163,137,219,136,185,193,114,90,107,37,172,37,225,43,46,28,53,154,108,57,71,170,200,59,36,239,48,95,10,41,34,162,19,158,83,197,45,230,227,73,237,78,221,227,247,63,30,137,11,73,189,207,48,219,172,9,138,120,161,6,41,218,218,57,213,143,68,67,172,25,86,116,218,143,154,89,103,204,27,85,193,169,169,49,138,67,47,120,225,94,238,255,128,79,215,169,193,114,130,214,120,87,146,147,32,109,162,172,23,5,117,235,51,180,117,233,58,129,184,1,145,104,117,195,0,64,43,63,147,208,241,192,171,168,17,200,30,17,79,223,176,45,221,53,20,253,6,189,37,123,106,154,212,127,242,24,146,251,135,56,254,208,66,52,196,218,29,167,76,245,20,225,105,114,141,7,188,15,132,223,34,81,180,151,63,245,163,162,249,164,225,92,197,52,71,68,195,199,229,118,242,177,163,230,105,116,168,58,121,119,77,116,205,61,44,31,187,254,32,199,197,175,70,109,172,155,63,109,94,239,249,3,206,162,46,35,181,120,240,118,67,130,74,50,147,103,161,65,87,174,206,165,178,121,85,213,243,103,60,250,242,107,202,188,28,130,167,66,212,195,192,217,197,127,161,22,82,98,224,30,95,125,27,60,224,197,155,50,56,224,144,244,43,223,238,235,229,225,231,251,87,104,153,131,108,57,222,41,136,134,88,223,126,118,109,222,248,67,237,90,219,101,121,238,190,157,119,14,237,177,77,179,131,249,140,238,26,80,188,225,77,219,43,218,54,248,120,17,241,191,9,57,91,107,143,15,206,28,127,236,195,201,22,69,22,123,148,229,198,110,205,121,172,235,86,209,61,228,24,199,36,125,107,223,137,72,30,237,244,103,63,57,238,11,103,23,219,160,249,58,142,40,173,249,84,134,244,254,177,199,130,238,15,92,38,247,175,60,186,28,95,142,154,131,98,12,254,253,3,3,20,41,225,114,43,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3097ba9e-50e7-45c0-9a7c-b463e370a647"));
		}

		#endregion

	}

	#endregion

}

