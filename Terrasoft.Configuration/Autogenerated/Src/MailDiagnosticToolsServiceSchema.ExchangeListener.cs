﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailDiagnosticToolsServiceSchema

	/// <exclude/>
	public class MailDiagnosticToolsServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailDiagnosticToolsServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailDiagnosticToolsServiceSchema(MailDiagnosticToolsServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d1cb398f-7abf-4e91-a9e3-b37e95c1622c");
			Name = "MailDiagnosticToolsService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77f98e1e-7e9a-4332-9f7c-7c7343eb8d36");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,221,89,89,111,219,70,16,126,102,128,254,135,173,210,7,186,112,233,244,161,69,97,75,10,20,31,169,218,56,14,34,37,121,48,130,96,69,174,100,54,60,148,221,165,109,213,240,127,239,204,30,188,73,201,65,144,160,241,131,37,46,231,218,153,111,142,93,37,52,102,98,77,125,70,230,140,115,42,210,165,244,142,211,100,25,174,50,78,101,152,38,63,60,186,251,225,145,147,137,48,89,145,217,70,72,22,31,213,158,129,62,138,152,143,196,194,123,206,18,198,67,191,65,243,34,76,62,53,22,167,23,141,165,151,76,54,214,94,103,137,12,99,230,205,64,50,141,194,127,149,93,13,42,120,123,29,250,236,60,13,88,212,251,210,155,128,173,215,219,133,120,239,216,162,32,40,187,135,51,239,140,250,50,229,33,19,237,20,113,92,22,94,127,227,253,37,218,95,131,198,6,243,52,145,108,165,99,49,89,135,30,62,242,37,4,76,116,146,156,211,48,90,164,183,39,105,76,195,228,225,12,53,15,158,194,98,4,144,144,28,182,236,157,204,75,49,123,70,5,123,13,240,129,192,51,50,34,202,49,101,15,230,92,101,194,146,100,206,83,62,77,150,105,47,111,78,5,140,192,250,152,179,21,152,77,142,35,42,196,33,65,211,79,66,186,74,82,33,67,127,158,166,145,48,82,20,245,165,121,176,210,222,227,218,68,172,1,102,224,231,53,120,96,17,70,161,220,188,102,159,178,144,179,152,37,82,184,229,7,180,5,204,219,194,130,84,158,89,8,246,80,201,58,91,68,161,79,124,180,178,199,72,114,168,156,152,155,236,220,41,179,243,93,158,133,44,10,96,155,175,56,34,86,239,201,57,56,56,32,67,145,197,49,229,155,113,177,192,24,241,57,91,142,6,83,19,79,35,117,112,48,38,97,188,142,148,169,42,230,36,76,132,164,137,207,188,156,251,160,44,111,173,181,17,206,104,144,38,209,134,212,36,146,15,113,229,249,104,71,187,78,111,253,43,154,172,216,139,16,146,13,234,196,57,77,232,138,241,47,97,96,135,104,242,129,181,191,216,213,228,63,165,92,67,86,98,108,153,144,58,235,55,95,194,224,86,193,228,3,175,60,27,43,31,179,36,208,128,168,162,3,80,45,36,207,144,20,49,162,32,215,179,47,164,235,178,79,195,181,27,168,238,30,64,117,1,80,133,47,216,16,28,167,134,1,50,82,171,142,202,75,99,62,116,3,57,172,97,103,236,38,236,166,108,249,132,175,50,244,163,59,200,252,193,62,121,35,24,135,183,137,110,40,123,123,71,90,89,71,24,33,53,65,71,71,240,93,203,92,117,42,86,155,134,145,173,225,24,27,9,247,253,97,56,103,242,42,221,45,75,143,1,0,146,137,50,196,250,146,98,55,80,117,130,191,207,53,38,138,215,148,147,88,175,245,185,167,198,94,243,143,195,153,204,120,82,19,228,245,168,175,69,185,236,229,86,191,129,40,98,240,6,222,155,6,162,195,37,106,101,77,57,141,73,2,147,205,104,144,51,13,198,104,3,73,151,133,28,111,120,160,72,11,78,189,15,49,62,207,85,133,1,80,217,229,178,211,159,103,97,112,249,30,13,51,196,96,148,139,42,134,230,121,92,40,178,206,206,221,100,13,152,49,28,156,220,91,50,26,147,91,111,26,236,121,243,116,2,195,192,102,136,226,107,240,235,116,140,200,22,194,231,225,130,113,65,150,60,141,73,221,235,125,206,178,123,155,149,132,132,216,147,219,37,181,59,227,36,84,113,4,193,67,72,107,232,237,251,68,127,142,209,192,146,232,26,238,172,151,71,245,142,130,216,153,68,81,30,7,11,52,100,51,219,93,171,129,115,38,81,255,168,179,206,123,133,254,130,33,19,32,177,26,185,34,86,93,154,204,160,130,213,171,103,187,214,208,34,198,103,41,63,165,254,149,27,99,144,245,230,157,112,73,220,230,54,112,240,150,48,129,137,191,217,198,141,17,14,214,91,142,211,48,197,155,4,129,139,3,107,18,48,174,102,52,88,224,76,136,253,22,7,93,162,180,247,198,52,196,19,254,175,230,110,67,193,86,232,213,177,1,62,64,215,18,83,109,119,1,93,79,25,212,113,178,67,99,165,26,182,99,176,95,64,91,45,180,20,202,92,32,204,34,153,227,83,199,147,8,13,199,55,60,132,208,215,249,39,249,153,71,234,175,111,120,84,171,108,251,157,76,167,183,176,32,76,12,138,206,99,189,135,144,174,182,45,79,247,14,183,48,41,15,160,246,55,162,7,250,232,124,179,198,132,24,208,245,26,90,186,154,78,14,254,193,243,6,1,67,184,96,114,148,201,229,47,127,12,170,204,115,56,96,165,25,170,253,141,252,76,126,127,2,255,126,125,242,228,73,201,60,227,199,155,210,247,81,30,107,112,129,93,181,25,160,103,124,119,38,193,236,152,4,84,82,243,117,84,150,81,230,212,239,221,2,245,122,225,53,204,76,128,46,174,63,116,6,150,223,184,133,108,139,112,131,105,60,102,121,39,76,152,115,35,27,246,99,100,236,106,29,30,202,157,167,167,73,224,218,106,112,255,160,49,96,219,32,246,22,172,9,212,28,96,202,4,224,76,74,112,215,206,109,77,52,210,126,48,214,165,128,48,92,36,84,175,54,91,92,93,202,28,194,119,14,148,80,44,181,8,34,17,126,74,138,32,52,138,210,27,22,144,101,154,151,235,238,174,169,78,106,36,214,194,8,212,184,16,250,173,239,103,92,212,82,246,242,98,205,244,233,179,124,46,115,46,1,103,211,228,58,253,200,92,237,75,132,241,171,139,217,28,198,66,59,152,165,60,166,136,82,32,53,86,235,37,117,164,222,39,207,210,96,51,147,155,136,85,72,242,85,239,29,135,180,96,129,145,182,175,98,107,195,223,47,91,157,234,236,156,92,57,248,218,104,154,110,226,230,165,163,89,153,23,48,81,147,154,215,65,225,146,70,130,149,59,35,47,50,12,209,94,81,103,115,35,243,225,72,143,173,19,230,104,166,119,226,148,79,212,200,152,63,187,123,26,198,26,205,18,166,60,35,198,24,157,3,177,181,19,27,162,103,155,102,183,113,219,182,169,246,99,62,108,74,90,244,204,84,99,79,111,20,7,202,115,107,254,232,98,152,109,18,255,138,167,137,185,255,113,113,219,150,22,74,99,0,165,15,178,92,152,104,0,133,242,195,117,245,113,148,163,216,70,173,117,20,213,29,250,199,42,179,55,213,194,139,166,108,195,228,21,193,80,123,62,170,191,207,227,224,21,65,175,9,55,47,170,45,154,64,253,246,175,136,11,117,139,169,206,76,114,152,108,83,222,171,155,213,212,181,16,67,105,244,63,206,57,222,12,34,125,241,88,42,136,182,206,242,210,213,78,239,200,112,124,197,252,143,130,200,43,200,179,230,248,96,14,146,20,61,67,23,81,215,177,167,58,65,248,227,57,0,97,120,224,143,177,226,216,41,144,68,70,170,104,17,75,46,228,21,227,55,161,192,243,184,18,67,64,140,114,30,202,249,18,197,234,193,21,69,85,6,72,181,169,104,12,12,214,110,183,118,140,232,27,121,167,246,220,94,226,254,22,209,41,230,187,226,90,97,135,153,238,235,248,188,105,146,142,192,164,152,156,192,125,97,84,113,126,75,121,110,145,243,101,139,116,75,170,247,7,191,125,7,71,219,139,138,78,246,41,84,67,94,188,126,250,148,52,10,197,103,20,157,159,6,119,170,155,224,128,234,238,221,31,146,187,188,12,221,15,190,114,33,194,99,115,215,249,5,79,191,223,43,184,219,7,224,111,10,110,212,89,7,179,54,171,253,114,175,245,212,86,135,143,94,135,118,157,169,219,133,45,135,118,219,207,239,200,64,75,7,151,183,155,100,127,162,48,6,222,239,23,156,111,161,217,128,252,110,86,67,64,238,77,139,223,33,29,255,143,61,190,61,181,106,183,75,223,107,126,149,174,186,52,232,77,36,43,197,92,249,179,63,183,218,147,203,169,193,186,126,183,182,59,176,36,76,210,55,202,6,216,233,25,5,161,57,213,176,105,213,216,53,250,183,24,237,212,96,106,205,238,174,10,5,171,211,130,220,156,223,233,68,170,165,48,73,229,228,25,137,23,250,58,241,142,241,199,57,245,43,104,66,35,204,95,232,109,168,255,1,71,123,243,99,99,115,235,61,121,144,123,71,166,136,98,4,100,7,234,47,79,168,164,21,172,86,126,61,108,113,248,97,219,145,176,97,133,90,41,223,235,114,5,31,175,160,174,152,161,237,56,103,49,208,186,47,105,172,110,145,52,203,64,67,191,192,126,103,41,173,32,212,4,119,165,127,211,135,63,97,191,61,192,233,253,119,54,159,113,63,217,83,127,236,93,162,118,252,150,27,197,94,175,155,105,249,38,229,31,141,222,78,183,27,167,154,107,131,106,131,217,226,193,45,218,175,117,199,217,81,179,237,79,159,21,53,189,90,94,132,21,248,251,15,7,73,149,192,96,34,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d1cb398f-7abf-4e91-a9e3-b37e95c1622c"));
		}

		#endregion

	}

	#endregion

}
