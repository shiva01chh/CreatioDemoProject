﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FillProcessElementNotificationsSchema

	/// <exclude/>
	public class FillProcessElementNotificationsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FillProcessElementNotificationsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FillProcessElementNotificationsSchema(FillProcessElementNotificationsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7f2c4c16-49bf-4f25-85c4-70e5cdc70cfa");
			Name = "FillProcessElementNotifications";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,89,73,115,219,54,20,62,171,51,253,15,168,122,33,167,26,58,109,47,29,111,29,175,169,102,156,196,19,59,205,33,205,100,32,242,73,66,67,17,42,0,218,81,29,255,247,62,108,36,184,73,202,161,58,200,34,248,214,239,45,120,128,11,186,2,185,166,41,144,123,16,130,74,62,87,201,5,47,230,108,81,10,170,24,47,190,255,238,233,251,239,70,165,100,197,130,220,109,164,130,213,81,235,25,233,243,28,82,77,44,147,151,80,128,96,233,86,154,55,179,191,241,231,43,158,65,222,161,187,164,138,118,22,111,88,241,79,103,241,45,204,157,196,206,171,123,248,162,234,197,208,177,213,42,36,15,223,8,24,90,79,46,207,7,95,221,10,158,130,148,248,30,41,126,20,176,64,115,200,69,78,165,60,36,215,44,207,221,251,171,28,86,80,168,215,92,177,57,75,13,174,210,176,28,28,28,144,99,89,174,86,84,108,78,221,51,242,60,176,12,36,89,129,90,242,140,40,78,180,96,244,76,144,34,144,64,224,1,101,18,62,39,106,9,100,109,53,17,176,170,36,121,92,178,116,73,168,0,82,0,100,144,145,71,166,150,164,148,40,133,21,40,139,26,236,18,111,196,65,96,197,135,55,51,201,115,80,16,141,127,75,94,144,175,214,35,194,164,214,143,220,90,10,161,133,22,153,231,100,6,104,223,138,63,160,10,253,106,157,242,149,70,74,160,37,84,130,28,199,31,81,228,186,156,229,44,37,169,17,180,19,153,209,147,65,167,70,20,87,21,69,175,14,17,29,246,64,21,216,247,107,251,64,82,253,158,72,37,180,226,91,173,74,46,67,145,175,12,146,175,49,215,201,9,25,247,16,140,143,6,197,77,11,166,24,205,217,191,112,157,243,71,103,47,90,191,6,161,24,200,166,232,29,196,86,141,241,12,138,204,58,215,244,244,154,65,158,13,185,41,128,102,188,200,55,228,29,70,17,49,41,108,254,147,79,101,227,249,168,151,7,139,232,51,100,55,152,71,199,214,179,83,242,9,107,95,210,5,166,218,9,38,201,99,15,73,20,247,11,59,51,138,28,213,132,188,178,114,238,55,107,64,169,143,130,41,184,225,11,148,26,57,13,19,178,170,73,98,114,114,74,158,200,115,191,232,115,86,100,40,244,58,167,11,73,62,205,236,19,138,10,215,147,169,201,7,236,90,95,155,235,175,121,97,162,155,30,57,88,7,96,54,9,37,202,84,113,161,193,54,44,150,162,93,145,102,225,2,173,83,8,19,53,48,49,175,220,84,148,92,67,138,121,132,217,111,106,43,173,194,144,84,226,14,218,242,142,215,84,208,21,41,48,107,78,198,205,224,141,79,223,181,196,28,31,24,234,126,102,143,245,248,244,18,235,109,161,145,196,126,97,86,73,142,33,96,197,156,139,21,237,8,114,245,184,163,18,163,86,162,53,77,157,108,77,3,111,89,76,244,6,50,26,53,121,147,139,37,164,159,207,196,162,52,74,203,60,143,218,64,216,212,27,181,146,27,51,161,39,219,71,108,78,162,42,239,126,192,116,70,137,94,243,40,204,72,255,211,178,61,235,239,231,237,185,82,151,239,64,89,218,22,48,69,164,201,167,245,80,243,57,26,224,24,236,86,206,248,5,40,239,134,246,113,88,1,57,105,121,61,218,70,75,94,130,26,84,237,170,222,193,51,26,9,80,165,40,118,57,215,0,179,15,27,182,189,57,14,33,180,163,167,14,224,180,67,89,15,90,59,57,52,102,123,237,6,67,248,237,3,192,94,41,105,213,236,145,143,219,163,236,124,215,245,74,148,254,58,49,127,248,60,114,61,65,215,247,3,83,27,231,143,243,67,211,224,160,167,156,21,145,111,210,177,245,54,121,191,4,1,145,155,94,116,171,119,8,59,118,251,34,177,91,230,201,246,237,218,227,24,39,215,76,72,229,128,29,206,177,253,35,180,211,119,28,22,215,188,64,222,59,80,206,255,7,42,112,160,178,45,75,51,250,125,243,195,71,239,99,83,68,96,64,60,105,16,204,56,207,45,92,118,23,28,5,62,120,224,106,134,26,236,104,239,105,100,82,237,157,19,147,232,147,166,229,118,177,25,215,85,93,203,45,132,31,56,203,200,187,117,134,191,155,187,133,30,215,123,188,245,211,104,8,192,83,5,225,186,33,66,79,9,237,116,235,178,91,67,155,156,201,123,221,203,107,231,181,49,247,252,242,60,106,109,25,189,73,99,92,170,209,108,186,181,197,37,239,14,121,234,164,132,79,7,110,206,55,117,82,52,57,39,4,7,15,8,99,191,35,166,56,236,60,240,207,16,181,156,127,243,136,39,173,58,170,178,215,75,55,195,98,254,92,125,73,97,109,139,203,108,210,81,181,64,192,59,227,242,0,80,35,202,174,9,92,175,36,191,227,43,199,78,14,59,100,254,213,32,218,103,89,118,37,4,23,58,203,61,194,30,214,9,217,9,249,132,244,152,236,28,116,211,37,6,192,46,36,215,102,234,137,108,0,198,62,4,132,101,135,228,233,197,243,164,58,46,233,41,10,151,126,14,150,220,9,10,105,201,211,47,61,235,154,133,60,253,250,60,158,52,194,155,188,155,102,173,21,83,135,125,57,208,165,245,47,52,139,171,74,231,26,180,2,103,247,161,78,56,61,151,71,226,39,60,141,144,251,165,224,143,178,22,113,136,107,63,117,36,186,57,203,31,6,18,140,211,13,197,102,235,22,134,203,167,167,117,71,206,106,231,22,250,233,35,53,245,37,86,44,88,81,157,87,221,211,73,251,12,147,52,201,173,137,173,156,65,174,134,20,220,35,138,204,209,156,111,80,117,84,91,97,171,46,174,135,197,74,134,203,237,175,95,189,176,228,78,81,85,74,61,69,58,97,118,33,121,91,22,133,222,230,124,93,219,114,9,118,109,211,13,100,186,132,21,213,93,237,28,143,191,94,130,89,140,43,13,230,209,114,234,173,128,164,180,192,81,219,228,190,7,164,193,249,138,22,24,9,161,55,130,139,22,105,187,219,77,156,5,206,87,28,255,129,166,75,18,213,55,48,199,221,82,59,109,213,154,212,71,121,111,109,64,39,147,63,105,94,130,172,48,168,196,239,44,223,64,162,23,86,15,95,65,68,124,37,236,27,133,209,8,207,74,138,21,165,31,22,252,212,213,39,116,42,157,176,128,189,47,139,187,229,154,220,243,59,147,218,81,236,167,187,97,205,118,7,32,114,137,96,124,129,180,212,50,111,171,74,179,150,253,208,210,113,47,54,122,90,179,109,127,99,96,142,198,119,109,9,227,9,225,101,143,228,120,79,60,218,137,22,176,41,177,169,31,70,131,91,99,107,31,172,176,120,174,212,83,165,19,162,167,89,235,79,99,19,168,154,127,187,211,67,45,183,227,78,165,201,255,109,24,62,56,78,246,111,163,141,57,8,63,131,67,206,128,219,222,134,173,78,127,171,207,207,225,233,161,239,84,53,189,42,112,211,23,116,150,195,241,203,146,101,167,196,166,142,150,55,197,137,60,156,78,132,173,23,91,61,211,172,167,213,54,58,173,127,242,179,152,229,251,208,91,131,31,131,177,88,147,131,115,169,26,140,239,64,183,156,206,60,230,206,9,216,145,202,85,129,73,126,123,131,105,61,158,102,99,255,230,90,240,21,174,111,124,181,234,11,142,56,57,147,150,54,78,222,51,181,252,131,97,7,137,204,119,242,154,223,240,244,115,243,252,17,138,197,186,191,250,167,164,185,94,188,108,233,58,43,178,138,214,131,20,112,88,35,147,91,125,115,2,10,68,212,194,51,14,206,6,178,50,88,167,140,117,222,207,241,145,125,140,119,194,18,226,210,178,181,11,140,214,83,33,115,185,11,153,0,26,35,25,157,194,204,115,238,154,59,152,138,80,163,18,39,87,95,152,68,81,173,224,6,30,175,171,156,235,94,33,154,196,244,71,97,123,123,30,93,158,219,174,197,5,201,102,213,207,110,74,94,21,178,20,112,121,94,47,69,117,135,115,178,166,218,249,183,64,51,16,230,246,16,180,160,190,16,36,86,17,88,218,168,86,28,52,205,199,37,203,129,68,86,78,162,41,163,176,165,106,95,106,103,81,143,35,212,251,177,137,150,233,215,206,101,19,177,170,163,212,16,85,131,85,181,180,165,226,253,48,94,179,135,99,216,238,139,129,93,87,154,111,221,191,20,228,255,243,63,133,158,139,79,119,229,104,38,71,108,32,85,147,234,54,179,189,179,42,232,252,13,158,86,55,12,71,180,45,141,186,115,150,216,54,103,215,151,138,245,29,119,112,255,153,188,167,194,140,41,161,238,106,88,106,165,19,11,195,220,54,135,101,245,156,219,24,67,156,29,225,238,87,219,212,60,6,141,253,228,252,215,24,79,63,127,141,177,248,89,22,55,13,158,214,55,197,85,90,246,141,70,44,107,221,110,109,219,250,190,13,210,111,195,212,235,159,179,130,230,249,166,49,75,214,135,153,11,94,98,66,227,20,249,34,40,103,211,172,103,126,147,50,54,158,151,44,215,221,161,46,220,42,90,206,137,180,20,186,93,250,99,24,6,173,210,18,14,56,114,150,156,173,215,88,159,81,147,33,152,104,42,146,27,61,191,247,140,80,129,249,57,208,208,168,32,194,179,32,23,182,226,52,60,79,180,218,136,93,109,46,154,181,240,243,31,107,101,142,247,50,30,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7f2c4c16-49bf-4f25-85c4-70e5cdc70cfa"));
		}

		#endregion

	}

	#endregion

}

