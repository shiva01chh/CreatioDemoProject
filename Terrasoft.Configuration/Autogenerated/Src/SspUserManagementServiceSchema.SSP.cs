﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserManagementServiceSchema

	/// <exclude/>
	public class SspUserManagementServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserManagementServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserManagementServiceSchema(SspUserManagementServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6e955ccc-6fa4-4733-b7fb-043d040d18f4");
			Name = "SspUserManagementService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,75,111,219,56,16,62,187,64,255,3,225,189,56,64,42,223,219,196,64,94,205,122,209,180,65,156,182,135,32,7,90,162,29,110,245,90,82,74,234,45,250,223,119,248,210,131,166,100,37,118,218,117,146,94,82,15,135,67,242,155,111,134,228,136,49,142,8,79,177,79,208,37,97,12,243,100,150,121,71,73,60,163,243,156,225,140,38,177,55,153,156,191,126,245,227,245,171,94,206,105,60,71,147,5,207,72,244,206,250,13,125,194,144,248,162,3,247,78,73,76,24,245,151,116,62,208,248,159,37,225,69,30,103,52,34,222,4,186,224,144,254,43,7,93,210,130,214,91,234,147,179,36,32,97,107,163,119,0,147,184,93,109,196,251,74,166,165,66,185,118,16,195,90,162,168,218,221,213,106,140,93,36,121,6,58,160,12,234,127,48,50,135,129,209,81,136,57,127,139,38,60,253,204,9,59,195,49,158,147,136,196,153,238,35,117,135,195,33,218,227,121,20,97,182,24,233,223,186,29,205,18,134,124,70,176,176,140,114,48,193,17,142,3,68,227,91,154,201,165,161,236,134,68,8,254,114,158,162,187,27,234,223,8,53,14,6,9,17,61,103,251,253,166,193,255,36,97,74,88,127,56,242,204,36,134,149,89,92,105,45,160,64,198,176,159,93,11,217,49,153,225,60,204,42,43,38,82,14,67,44,201,14,120,250,145,100,128,81,10,19,157,210,144,102,139,11,242,79,78,153,156,3,31,84,127,8,71,160,125,180,162,139,208,242,180,32,216,17,131,164,249,52,164,62,242,5,202,141,32,163,183,232,16,115,82,64,222,251,33,97,47,124,116,70,178,155,36,0,47,157,51,193,23,229,148,94,170,126,160,15,148,103,123,2,4,192,96,44,96,39,35,116,134,83,45,225,74,196,7,227,147,56,143,8,195,211,144,236,141,245,76,198,133,151,70,202,119,165,96,7,137,56,234,245,24,201,114,22,219,173,64,41,17,66,131,220,24,1,112,70,40,38,119,168,54,17,109,163,103,132,1,64,88,118,241,10,241,174,82,3,238,31,4,17,141,63,199,116,73,183,222,102,58,228,190,79,0,216,186,166,18,106,149,19,198,128,161,53,5,41,210,205,31,33,167,212,91,133,68,55,10,136,150,21,140,212,12,16,97,26,90,3,8,145,108,253,185,227,93,38,194,65,131,29,17,163,189,159,218,177,36,14,148,111,155,28,45,105,163,26,175,62,65,16,72,212,171,76,239,93,65,128,195,120,201,55,50,80,221,96,14,253,243,79,147,203,254,46,18,20,36,60,123,159,176,8,103,32,7,213,51,128,4,88,167,68,222,95,60,137,119,209,97,18,44,38,217,34,36,53,149,66,234,125,101,56,77,137,6,251,2,114,47,100,76,210,110,84,146,222,176,190,78,65,19,127,218,14,58,18,89,131,8,52,249,160,41,50,244,66,16,83,127,13,41,111,49,3,145,182,179,95,229,157,123,44,141,126,47,99,11,67,73,49,28,244,137,213,70,224,29,31,78,136,159,51,136,231,147,120,78,99,224,230,13,241,191,29,225,88,77,73,207,143,27,67,114,6,220,158,180,202,87,122,66,237,73,109,80,31,223,152,109,48,89,204,230,32,8,46,146,16,162,89,3,34,201,40,37,187,6,35,216,85,252,4,54,170,113,96,140,174,138,124,64,18,82,38,76,187,113,244,210,83,135,11,73,238,98,2,102,12,227,13,175,22,255,34,50,29,169,72,13,168,187,254,68,62,206,96,83,24,156,124,247,73,42,119,12,242,221,56,186,180,91,182,238,67,187,238,90,205,80,70,179,26,103,79,53,116,148,84,49,210,210,120,94,241,178,54,181,171,72,190,80,250,255,177,27,28,46,10,213,128,15,156,13,207,148,238,91,176,61,20,103,186,45,137,39,251,110,35,5,72,2,202,81,154,176,12,135,8,43,200,208,156,37,121,10,166,225,60,71,98,159,120,69,255,161,109,96,47,197,12,71,40,134,99,226,126,31,27,196,251,35,13,190,190,7,69,57,112,119,10,183,32,49,26,9,188,189,161,236,86,90,81,243,230,163,75,150,19,68,103,246,124,228,76,192,181,9,92,177,216,29,5,178,191,65,51,28,2,20,123,67,211,117,187,115,70,243,185,208,164,13,1,221,120,118,46,129,209,232,158,8,88,6,167,57,13,80,1,125,75,106,88,53,134,35,59,60,82,120,23,76,30,243,229,5,241,182,8,84,40,104,245,83,65,83,5,2,182,130,253,151,71,210,41,201,16,141,103,210,189,194,30,158,194,245,219,226,113,91,28,25,26,127,154,254,13,88,161,59,154,221,200,66,130,9,129,25,37,97,192,17,39,217,147,231,60,200,77,238,6,64,5,178,117,201,224,1,28,183,45,108,201,62,168,205,86,225,104,14,142,101,160,172,69,29,229,140,129,186,144,122,229,182,88,4,67,165,179,96,139,76,44,59,245,209,175,250,181,120,133,76,127,221,108,165,94,226,112,155,115,106,27,163,191,37,136,19,105,10,130,118,150,199,190,254,47,19,39,11,89,1,188,127,64,127,35,139,55,183,56,132,125,45,197,148,169,192,22,246,144,200,218,113,160,254,239,99,57,234,83,143,108,121,66,19,85,162,98,91,3,196,63,105,192,223,3,222,133,130,218,213,42,108,121,208,198,102,15,183,85,113,207,204,236,219,67,222,13,95,13,57,59,68,165,90,249,113,0,236,23,99,253,198,192,35,177,56,153,7,142,184,99,73,84,134,165,146,133,2,23,17,144,98,143,20,21,201,151,80,116,135,162,186,228,8,143,159,195,154,237,83,37,224,126,162,96,47,232,3,134,68,31,25,128,87,215,170,218,27,240,150,232,107,31,161,18,102,92,105,113,221,79,150,243,235,157,71,131,29,69,162,45,9,211,34,18,172,229,181,132,107,19,220,26,231,162,138,110,213,211,95,74,45,77,165,150,242,171,168,77,189,131,52,13,23,75,233,81,3,206,7,117,234,105,170,27,39,182,87,88,26,199,220,154,13,166,137,161,43,48,171,66,84,82,245,133,161,15,100,232,209,13,142,231,178,160,84,126,33,159,100,56,203,185,58,255,168,164,176,139,166,73,18,34,202,165,18,121,174,212,108,1,203,224,84,64,244,194,200,214,195,249,7,240,1,116,170,30,3,148,84,124,238,229,43,238,215,86,231,173,225,85,245,134,106,150,186,242,54,93,98,242,66,169,102,74,241,140,137,87,49,0,153,121,150,82,32,87,35,211,230,189,170,225,108,113,162,99,70,79,3,244,47,56,164,1,206,136,250,78,93,196,114,93,60,176,181,186,126,71,114,91,255,245,37,226,150,8,181,86,90,255,10,243,152,129,106,189,106,81,82,75,216,241,217,153,1,86,246,185,58,198,25,174,210,176,211,163,170,194,243,111,91,247,255,215,75,175,173,206,89,2,48,102,148,216,239,112,196,52,206,72,52,5,231,232,87,65,125,234,42,212,247,107,124,148,135,20,119,65,255,7,154,147,236,157,40,94,191,67,155,199,176,94,244,92,3,73,171,240,252,152,120,86,107,173,117,24,229,193,175,86,138,117,160,215,110,178,90,74,109,179,93,45,208,118,117,209,3,57,186,84,248,123,76,112,173,250,86,29,131,99,170,170,75,108,177,39,224,216,213,155,215,8,217,85,177,205,32,210,94,29,233,130,130,123,141,213,138,67,125,129,174,186,10,170,21,40,172,149,61,96,29,235,249,71,218,114,81,83,53,116,37,188,152,140,211,140,106,232,106,102,204,133,190,184,248,82,18,56,83,90,165,125,115,169,204,58,70,119,11,46,251,224,190,137,40,234,245,154,144,225,229,249,215,65,49,19,55,213,227,244,102,208,105,125,195,210,1,168,246,7,56,221,98,238,33,188,246,107,239,61,28,144,89,143,151,173,247,33,29,249,154,155,167,46,203,204,191,186,70,197,67,152,85,190,184,143,39,212,12,187,35,111,244,215,135,210,21,222,229,35,235,142,136,241,218,147,106,215,150,88,127,143,221,209,172,120,244,210,119,221,131,164,194,61,188,249,177,201,208,103,221,216,213,24,17,39,97,167,37,245,120,187,43,94,234,97,185,35,23,154,119,232,93,231,35,30,160,187,231,35,95,171,111,130,162,43,94,84,175,117,176,214,22,214,217,235,164,75,120,179,79,58,99,137,91,142,139,247,62,43,110,40,135,116,205,34,171,95,54,118,201,45,93,172,172,227,170,34,231,184,81,41,31,252,61,3,151,185,30,91,119,240,145,187,219,58,78,169,231,110,215,166,42,16,24,89,41,124,83,48,56,171,39,29,112,104,232,247,203,19,201,6,150,220,249,212,213,80,143,122,204,139,222,173,24,242,196,1,76,237,128,250,165,212,170,99,84,253,16,173,149,117,129,171,105,64,26,119,27,114,92,213,235,54,104,71,119,73,25,252,251,15,164,226,89,139,36,58,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6e955ccc-6fa4-4733-b7fb-043d040d18f4"));
		}

		#endregion

	}

	#endregion

}
