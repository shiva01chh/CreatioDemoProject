﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarEditPageChangesStoreSchema

	/// <exclude/>
	public class CalendarEditPageChangesStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarEditPageChangesStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarEditPageChangesStoreSchema(CalendarEditPageChangesStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("91248fd0-2062-41d4-80a9-84ae90d77069");
			Name = "CalendarEditPageChangesStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,90,221,111,219,54,16,127,118,129,254,15,92,10,20,10,96,40,91,247,150,196,30,218,52,13,12,52,77,55,119,235,195,176,7,70,98,28,173,178,156,82,84,186,172,233,255,190,227,151,68,82,164,36,59,110,26,172,121,136,37,234,120,188,207,31,143,39,85,101,86,44,208,252,166,100,100,121,240,248,81,101,220,198,71,171,60,39,9,203,86,69,25,159,144,130,208,44,113,73,94,103,197,199,122,236,29,161,20,151,171,11,6,51,41,9,12,199,199,5,203,88,70,74,120,254,248,81,129,151,164,188,194,9,177,168,138,139,108,81,81,204,87,126,252,232,51,167,27,61,161,100,1,183,232,40,199,101,185,143,142,112,78,138,20,211,227,52,99,111,241,130,28,93,226,98,65,202,57,131,21,4,253,222,222,30,58,44,171,229,18,211,155,169,186,127,162,255,60,87,205,144,115,27,107,102,123,6,183,63,231,96,12,156,103,255,226,243,156,252,5,3,87,213,121,158,37,40,225,210,245,8,55,2,133,70,181,62,199,69,181,4,117,4,69,58,103,152,85,165,144,191,165,64,64,3,228,83,70,8,221,150,186,45,182,150,155,128,20,174,16,35,41,232,232,140,102,139,172,192,57,154,160,31,199,98,228,13,249,4,55,63,201,27,53,11,6,158,201,129,151,36,39,76,12,252,204,239,191,72,117,158,128,69,164,202,234,222,246,231,11,92,42,51,165,103,231,127,67,208,245,27,65,254,142,131,142,211,151,104,168,151,215,49,24,62,47,25,197,9,83,30,247,136,175,205,87,43,10,89,196,104,149,64,16,236,163,183,116,197,128,138,164,82,205,209,149,190,111,115,138,118,145,100,52,178,252,3,230,181,238,99,237,166,3,65,172,172,222,50,123,45,14,72,112,69,40,207,67,144,70,232,164,8,90,38,15,165,78,115,29,55,19,45,235,105,99,217,130,219,119,159,209,130,176,3,84,242,127,189,66,159,18,118,185,74,203,46,251,213,142,153,9,156,185,145,70,68,39,132,153,247,209,238,65,120,38,252,112,216,170,167,204,147,75,178,196,111,0,169,154,105,3,68,220,200,168,118,112,219,89,222,152,217,245,66,7,39,43,244,235,155,125,131,193,94,251,42,232,80,49,116,133,41,94,34,142,220,147,157,170,36,20,34,187,144,219,196,206,244,112,79,60,181,220,127,189,202,82,52,199,215,36,250,221,162,70,246,228,58,206,109,207,17,243,102,226,117,36,159,164,156,86,214,190,50,105,29,15,10,250,79,25,75,46,81,100,69,99,45,194,40,129,52,116,18,76,225,218,126,77,51,186,198,20,145,242,35,172,84,0,34,154,75,253,90,17,122,19,217,250,197,38,193,41,46,96,99,160,99,67,96,45,217,104,4,60,227,231,105,250,60,207,37,49,236,195,213,178,40,163,134,66,178,82,182,129,245,249,140,90,91,103,221,177,101,194,120,150,54,108,178,11,20,41,30,63,128,18,85,158,55,22,0,49,196,19,165,183,177,248,23,117,161,127,71,231,148,224,15,7,97,203,193,126,97,88,205,149,189,223,74,92,181,25,160,39,46,18,242,226,70,184,209,48,91,45,111,124,4,114,48,226,53,130,97,92,169,213,156,176,151,228,66,90,246,15,156,87,196,52,175,101,176,87,89,158,43,158,114,124,55,22,193,92,147,15,182,131,186,251,222,34,104,168,29,187,3,235,75,112,95,27,90,99,188,196,55,179,66,215,102,107,21,27,193,34,3,213,224,236,1,227,173,21,27,178,198,8,139,143,188,245,83,119,1,98,238,78,106,153,240,2,145,245,72,45,154,154,99,99,103,91,79,188,176,234,86,48,22,149,242,179,181,20,208,88,203,220,99,113,211,218,58,29,255,117,212,59,62,107,217,106,249,170,158,30,217,28,137,80,191,24,39,21,236,187,50,227,102,169,118,1,172,11,171,83,194,42,90,216,66,65,94,11,97,134,24,120,64,33,182,186,134,3,93,150,146,190,66,76,11,230,19,201,118,183,135,119,87,169,230,48,222,177,56,239,132,35,105,40,156,188,203,150,100,86,48,66,175,113,190,69,52,105,13,125,45,60,9,202,191,37,56,9,242,143,222,175,232,7,112,155,73,160,86,254,212,126,50,70,62,236,216,28,95,60,139,3,165,103,225,111,135,53,126,7,119,100,122,216,160,62,109,31,8,248,120,68,123,24,16,228,17,108,171,64,228,225,127,39,56,106,18,209,9,65,125,252,238,104,71,213,210,1,58,150,170,12,125,157,149,236,48,92,12,76,117,197,166,133,183,230,5,179,94,79,235,209,38,148,78,3,219,97,158,146,44,128,142,202,56,125,202,34,97,24,149,50,87,52,187,134,19,134,149,58,235,9,230,14,14,16,46,108,81,212,120,160,67,192,144,165,141,4,18,147,84,204,40,14,226,208,254,27,89,66,132,171,69,133,145,212,122,81,71,49,10,5,155,14,170,154,62,150,156,224,60,18,101,104,50,69,89,236,203,126,139,41,160,198,68,84,127,177,70,17,43,126,180,156,51,222,64,37,148,111,113,135,158,186,107,202,83,178,81,160,140,4,46,37,245,26,90,210,166,250,40,227,247,151,4,18,35,229,114,166,182,76,177,45,92,195,6,61,125,170,182,169,40,141,157,93,200,109,212,241,238,233,237,45,234,165,83,119,187,250,128,11,71,86,222,141,247,10,54,40,181,188,173,169,33,225,235,59,229,116,199,111,171,79,4,126,220,153,54,115,205,54,145,217,37,130,51,43,152,7,84,11,157,56,12,184,10,197,31,249,7,178,70,120,27,112,73,56,116,14,129,150,147,51,10,7,126,92,229,181,5,235,221,73,197,89,125,174,21,135,218,134,139,123,176,21,60,101,64,27,100,187,53,132,107,18,80,38,226,184,216,113,174,130,101,199,237,240,216,181,220,185,57,242,221,197,77,131,124,213,36,86,159,191,120,163,35,113,170,51,111,184,31,124,115,247,186,98,54,164,67,50,91,37,235,47,225,71,251,93,138,111,61,184,236,66,121,163,192,218,122,92,245,133,149,84,127,72,88,125,203,56,9,111,142,45,191,117,123,213,89,104,64,148,53,61,54,185,111,185,45,178,187,33,144,106,116,175,31,44,119,125,61,217,10,155,76,151,199,211,0,251,238,125,68,123,164,227,192,169,87,208,22,13,31,138,149,131,140,51,99,83,221,184,145,165,106,28,51,178,178,230,136,211,14,175,154,169,27,99,110,1,229,78,176,112,161,33,214,126,15,31,193,179,250,116,189,213,221,103,219,46,247,66,81,143,227,149,66,27,56,127,205,77,234,129,197,74,96,223,170,171,235,123,216,188,238,33,92,183,181,159,125,229,152,93,47,100,213,134,247,221,224,149,143,215,118,182,189,109,96,224,198,251,95,232,106,172,194,171,110,252,134,226,206,106,184,161,117,66,144,191,37,73,101,252,141,13,70,238,190,108,94,155,241,216,226,87,174,42,154,16,211,118,101,19,221,62,29,91,220,164,139,74,3,198,195,83,53,173,145,26,230,185,62,152,14,83,56,211,210,69,35,162,60,221,11,91,200,111,145,6,114,241,104,171,99,77,180,96,214,155,202,167,64,186,121,158,196,239,86,252,97,243,25,73,95,131,39,177,247,50,72,11,55,207,100,179,98,237,166,10,100,181,41,140,99,42,110,198,246,226,179,212,232,169,27,96,34,219,18,14,134,40,174,1,243,24,253,32,198,231,121,150,226,159,1,50,156,21,101,36,222,56,247,240,227,32,202,89,68,214,94,24,48,211,240,157,240,246,182,159,92,247,105,28,67,120,124,161,149,80,205,166,128,46,155,162,14,90,15,108,252,215,67,241,166,105,125,25,155,222,216,250,198,168,141,61,157,136,3,65,233,64,204,26,144,210,11,33,222,214,160,0,143,247,132,124,240,117,6,199,253,243,185,200,22,78,4,169,20,36,240,75,39,237,194,243,146,166,107,169,211,222,233,101,26,109,76,183,105,201,136,248,199,163,149,255,242,32,139,79,51,249,165,203,224,204,135,69,206,46,184,125,172,204,151,103,105,183,23,169,9,21,79,173,180,145,232,169,145,232,38,231,38,209,109,70,46,167,58,197,13,57,236,132,210,164,119,219,183,229,245,255,38,141,58,169,47,232,106,201,227,67,207,240,190,174,24,187,163,157,44,217,202,96,184,33,191,175,146,232,122,208,159,236,173,76,8,230,242,184,206,40,164,205,103,12,73,245,31,56,42,76,39,181,232,252,205,133,249,232,112,162,85,232,64,9,173,173,33,14,35,125,16,193,200,80,108,0,94,54,40,40,225,238,5,18,116,160,58,95,91,120,209,64,223,117,165,123,71,29,28,224,214,27,227,18,164,79,248,23,140,226,164,194,213,6,32,141,122,95,102,245,84,50,250,224,227,184,206,251,254,109,13,92,117,32,114,40,54,186,159,22,187,214,211,127,161,115,53,255,184,80,189,234,30,246,225,177,176,215,171,21,61,198,201,165,214,93,124,161,232,144,187,175,191,215,152,35,150,56,202,9,166,173,151,232,214,176,231,77,158,26,51,135,96,196,252,251,15,140,175,66,100,203,51,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("91248fd0-2062-41d4-80a9-84ae90d77069"));
		}

		#endregion

	}

	#endregion

}

