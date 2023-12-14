﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserAdministratorSchema

	/// <exclude/>
	public class SspUserAdministratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserAdministratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserAdministratorSchema(SspUserAdministratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2");
			Name = "SspUserAdministrator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,26,77,115,219,184,245,172,157,217,255,128,213,94,168,25,15,221,115,28,185,149,101,39,85,199,177,61,86,210,28,58,157,22,38,33,137,13,69,106,9,210,142,214,227,255,222,135,7,128,4,64,144,162,18,207,110,167,109,14,177,8,190,47,60,188,111,48,163,91,198,119,52,98,228,35,43,10,202,243,85,25,206,243,108,149,172,171,130,150,73,158,133,203,229,221,143,63,60,255,248,195,168,226,73,182,38,203,61,47,217,246,204,121,6,156,52,101,145,64,224,225,123,150,177,34,137,122,97,110,31,254,5,63,63,228,49,75,91,112,215,73,246,75,179,104,202,181,221,230,153,255,77,193,186,214,195,203,139,206,87,87,89,153,148,9,227,62,128,207,236,161,197,81,10,184,100,101,9,79,156,76,9,82,113,244,181,231,26,0,16,1,245,231,130,173,225,5,153,167,148,243,55,100,201,119,159,56,43,102,241,54,201,18,94,2,86,94,32,220,233,233,41,121,203,171,237,150,22,251,115,245,140,56,100,149,23,36,42,24,21,68,73,148,103,37,141,74,66,179,152,84,64,136,135,26,247,212,64,222,85,15,105,18,145,8,241,125,44,201,27,178,240,139,50,122,70,113,106,185,239,138,124,199,10,161,166,55,226,119,9,231,198,98,9,226,138,140,11,130,164,144,50,147,103,29,214,128,166,124,163,157,166,132,240,243,26,220,125,124,38,107,86,158,145,23,201,112,87,36,143,180,100,228,125,149,196,228,31,156,239,238,243,188,124,95,228,213,110,17,159,245,200,52,75,83,178,203,139,146,166,82,103,100,45,112,14,138,134,108,150,22,23,34,92,97,52,2,161,200,20,161,71,35,71,14,242,211,20,17,195,171,237,174,220,75,144,209,31,93,105,213,250,27,119,29,140,202,214,0,184,83,41,222,227,41,125,202,18,13,24,8,176,143,251,29,19,30,58,57,67,122,28,165,242,144,124,164,105,133,30,50,122,233,209,18,152,174,228,82,38,41,250,133,180,159,131,106,106,227,181,87,236,115,252,153,101,177,52,47,219,214,96,219,96,135,85,4,134,8,214,38,141,184,71,224,5,168,35,161,105,242,43,48,160,36,99,79,36,1,124,154,65,56,203,87,164,220,48,64,97,76,248,206,106,58,246,89,251,248,244,188,127,143,210,141,124,168,129,99,168,149,245,56,81,118,226,0,77,29,48,121,108,109,109,77,113,51,173,245,96,98,158,97,151,18,63,176,114,147,199,194,89,209,89,122,244,55,23,65,5,216,153,90,210,60,65,181,66,59,5,139,242,34,238,80,15,174,236,104,65,183,36,131,68,50,29,171,224,180,136,199,231,115,21,167,146,152,65,148,93,37,172,8,223,158,34,172,31,85,252,63,62,199,224,33,126,246,3,211,40,202,171,76,27,248,248,124,38,159,165,91,247,178,44,88,89,21,25,151,140,44,64,253,166,21,103,164,150,4,66,128,207,245,38,79,8,216,130,136,201,66,168,19,9,108,75,86,67,176,45,77,210,19,242,144,231,41,73,248,12,14,255,145,193,41,131,173,51,109,42,166,230,9,55,31,32,158,176,242,134,61,9,17,76,168,192,144,68,138,224,114,215,172,116,124,48,144,33,60,129,72,64,27,69,243,188,95,210,71,166,12,110,36,117,99,73,21,98,196,173,141,81,107,236,49,175,53,102,138,186,200,238,243,148,73,253,9,23,16,194,225,67,1,203,139,88,235,224,145,22,13,19,1,134,104,174,59,52,244,156,80,57,219,237,140,39,153,173,109,16,87,17,53,143,16,146,246,37,91,65,141,82,109,179,191,138,112,169,189,205,11,108,138,18,43,183,86,10,57,4,127,143,59,6,28,185,245,110,156,70,255,221,58,182,179,2,247,40,216,54,9,173,232,250,132,26,134,129,70,179,19,158,82,66,31,130,195,194,65,112,207,108,24,155,46,44,249,119,40,180,79,50,71,153,77,85,250,86,250,234,185,240,182,235,36,186,163,209,23,186,102,252,6,60,43,80,25,96,145,61,38,128,131,228,179,85,174,181,153,172,72,160,215,160,124,141,88,198,153,64,11,23,252,38,47,111,170,52,189,45,176,26,8,38,26,69,187,148,48,108,143,8,207,196,71,143,188,200,125,191,152,78,217,202,18,161,37,191,192,227,142,163,156,144,118,241,48,40,169,12,44,1,65,0,203,91,73,142,229,190,72,202,98,191,98,107,223,145,81,68,57,92,147,25,144,83,80,115,192,154,99,60,32,180,201,226,98,99,82,180,227,210,13,184,47,208,83,5,165,122,217,157,106,122,178,171,71,47,110,34,210,69,214,99,82,148,21,176,179,244,218,145,23,142,78,83,210,36,251,178,147,83,200,112,79,108,109,151,174,135,227,241,89,59,236,203,140,231,6,252,192,199,209,151,214,6,196,113,1,134,70,49,69,149,120,222,206,181,238,0,164,214,163,143,153,241,32,220,9,25,2,78,144,100,229,196,125,25,10,225,61,68,106,125,107,213,251,5,82,123,22,148,52,7,211,139,253,210,205,171,20,140,73,230,27,187,123,21,81,2,197,109,197,134,49,20,142,194,33,21,238,248,196,104,103,124,170,188,67,63,80,37,24,114,178,173,75,162,128,188,100,75,191,222,65,177,253,4,21,229,108,205,122,68,242,29,54,8,246,193,194,7,193,254,160,228,17,1,216,33,126,14,47,117,172,181,197,85,64,87,95,119,73,193,46,69,14,152,18,241,231,99,2,17,251,83,25,221,228,79,225,44,142,47,233,158,59,68,39,158,240,107,210,182,243,75,237,185,34,93,3,65,21,200,121,71,50,81,158,169,18,156,91,20,214,193,253,158,165,57,141,77,219,154,211,104,211,62,69,59,81,182,51,204,206,72,15,178,194,116,115,94,157,229,26,29,91,72,208,231,102,144,218,106,45,183,101,133,77,11,177,112,227,81,43,11,13,8,15,122,27,42,64,141,76,254,230,97,12,236,136,6,180,66,86,120,61,38,81,105,109,65,190,81,161,92,205,108,128,127,76,75,250,205,173,136,108,65,117,248,71,27,185,135,109,129,178,10,236,73,250,75,19,101,165,22,70,99,113,24,225,15,206,5,254,219,116,211,223,135,25,94,40,38,124,77,243,87,87,100,243,38,179,214,107,2,226,6,243,107,189,228,196,69,227,205,149,236,6,157,238,204,95,209,91,133,175,64,158,245,86,219,158,242,220,146,81,188,225,134,71,215,50,104,47,54,3,85,163,48,43,154,128,173,16,227,159,50,177,186,5,210,235,104,82,250,193,49,44,115,25,66,15,215,41,163,221,193,59,36,78,253,52,124,229,154,57,24,240,142,4,44,2,218,174,122,70,9,141,233,105,76,159,1,194,118,212,217,92,236,235,195,15,204,170,171,163,223,133,51,95,50,17,166,117,249,131,15,78,208,156,132,178,180,9,198,203,217,39,200,128,99,216,229,36,124,87,228,219,192,174,46,39,225,140,75,160,137,60,216,240,243,134,21,172,198,179,43,10,0,95,240,171,95,96,19,129,164,31,226,40,46,104,149,25,19,77,109,150,197,53,45,111,25,84,243,237,38,220,154,212,183,10,170,240,182,88,83,168,214,49,86,120,121,59,94,214,181,145,70,245,19,66,185,210,109,231,112,67,190,14,175,190,178,168,2,183,138,104,74,139,183,226,8,207,131,195,225,18,237,57,71,185,127,149,49,46,149,14,37,7,91,3,99,230,80,35,118,2,230,181,201,202,27,45,85,51,32,19,190,238,44,95,207,62,213,17,105,43,189,189,19,135,100,112,170,205,98,144,205,46,128,110,241,151,60,17,148,12,141,170,59,137,189,194,0,38,26,225,182,230,105,207,104,12,187,48,61,231,255,174,241,42,174,161,138,202,1,206,1,181,62,113,27,134,50,183,75,139,227,102,206,84,227,241,143,249,167,29,148,19,208,242,155,228,56,194,113,232,227,116,13,60,168,217,23,142,103,9,74,158,54,73,180,33,79,73,154,146,7,166,111,184,24,138,47,174,26,148,212,38,109,157,30,68,3,112,145,100,177,69,15,78,10,83,175,42,47,248,197,30,29,241,26,170,151,186,72,111,239,205,238,223,27,79,21,185,188,13,13,230,96,206,156,92,119,150,64,202,157,229,67,187,27,116,60,244,115,82,110,254,12,22,202,3,129,116,159,63,93,231,209,23,177,16,104,27,28,137,30,60,104,89,223,9,233,178,58,9,47,235,16,23,12,43,179,137,118,80,51,128,136,224,160,13,249,78,168,156,65,213,199,61,74,144,102,45,127,159,181,27,66,165,41,101,208,129,167,173,240,95,41,170,179,195,153,7,39,15,123,178,136,187,174,145,190,193,102,129,88,151,197,154,86,229,88,16,96,73,3,194,92,229,49,159,255,92,115,233,59,126,11,240,93,94,68,108,190,161,217,154,233,214,220,197,90,209,148,27,104,202,120,100,4,252,61,109,102,190,97,209,23,2,186,183,194,29,251,10,39,54,212,114,14,94,147,233,140,111,177,24,218,65,97,95,132,82,46,86,216,209,228,229,149,144,46,48,38,136,255,27,181,235,247,165,102,193,213,203,77,6,48,63,113,84,238,247,86,167,100,106,126,125,48,184,181,215,179,245,99,186,122,188,56,28,159,227,31,239,55,42,131,243,236,49,5,174,247,94,249,208,80,64,110,83,161,94,236,177,255,14,236,171,217,238,2,88,127,113,211,26,111,227,231,67,251,101,180,1,18,31,104,70,215,32,11,148,213,11,245,13,130,74,232,99,197,22,142,93,138,33,209,92,223,144,167,173,53,215,61,197,54,32,140,215,193,24,247,4,38,134,219,57,0,107,38,229,102,203,253,56,104,185,138,124,120,205,86,229,237,234,62,89,111,202,109,206,225,103,48,254,211,120,114,128,2,126,39,85,108,153,224,42,35,180,3,47,46,60,205,23,202,244,245,123,61,150,110,104,14,52,111,188,105,69,11,61,122,104,21,143,61,35,168,30,163,174,212,136,69,161,9,198,222,220,173,140,211,190,45,55,102,55,237,123,92,77,121,200,13,46,68,224,191,253,93,221,33,226,5,250,203,240,33,159,16,153,255,182,202,226,134,182,248,235,168,11,182,95,83,215,26,131,61,49,10,21,124,96,233,147,36,89,27,116,100,186,54,41,233,67,202,212,239,111,13,2,150,188,99,101,224,138,141,8,238,214,215,14,6,195,1,49,99,116,153,224,35,28,142,106,28,78,212,197,226,185,240,157,56,193,79,46,85,98,238,129,85,91,31,61,19,45,237,88,15,254,200,203,137,245,18,55,113,98,216,151,124,171,174,167,177,186,252,201,218,84,248,142,149,209,70,164,250,203,139,160,17,170,169,53,71,54,120,119,252,115,33,225,39,38,70,12,70,98,151,24,65,52,172,121,58,146,154,250,2,11,127,58,154,198,69,188,133,114,78,173,62,47,31,61,97,181,71,208,179,206,191,189,107,51,98,54,146,134,198,178,49,101,142,135,209,105,36,244,211,193,176,210,65,201,248,8,72,221,123,29,172,114,47,161,60,249,189,131,238,225,48,34,165,60,54,234,254,54,113,225,85,194,194,112,55,121,221,248,209,23,62,250,162,199,75,115,41,113,92,232,176,161,229,185,14,111,227,227,88,205,163,234,43,136,50,119,62,237,144,119,1,175,214,218,39,241,63,205,222,254,168,47,79,236,137,148,188,163,248,190,185,148,186,163,5,105,45,218,200,177,127,150,208,251,129,89,157,108,69,5,77,155,70,52,235,25,74,120,107,154,26,188,227,59,179,238,143,192,14,97,14,104,215,197,144,129,203,11,75,42,39,45,248,241,75,73,203,106,240,172,231,155,66,154,190,150,51,110,76,219,2,116,29,169,148,91,240,155,213,56,75,68,177,35,156,117,11,106,118,60,213,241,131,30,213,235,122,71,57,245,164,165,185,109,156,152,67,25,255,48,188,193,82,185,174,53,146,169,124,83,24,255,167,0,114,213,94,196,53,241,239,223,199,178,74,151,5,51,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("623e144d-2bff-4944-aa0a-346ec2a0efa2"));
		}

		#endregion

	}

	#endregion

}

