﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EntityUtilsHelperSchema

	/// <exclude/>
	public class EntityUtilsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EntityUtilsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EntityUtilsHelperSchema(EntityUtilsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("012573d5-4a1d-467e-84b4-9ca561534f11");
			Name = "EntityUtilsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1b48d10c-73f9-465d-8c06-a582b79b2f43");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,109,111,227,184,17,254,236,3,238,63,112,125,192,65,6,188,74,14,215,235,46,186,137,1,199,142,183,70,247,246,182,155,164,253,80,20,7,90,162,99,54,178,164,35,169,228,220,187,252,247,14,95,36,145,20,229,216,221,11,90,180,155,15,235,21,69,206,12,159,121,227,140,152,227,45,225,37,78,8,186,38,140,97,94,172,69,60,43,242,53,189,173,24,22,180,200,191,252,226,151,47,191,24,84,156,230,183,232,106,199,5,217,190,241,158,97,126,150,145,68,78,230,241,91,146,19,70,147,206,156,229,15,237,144,205,105,187,45,242,240,27,70,250,198,227,203,92,80,65,9,15,77,88,208,44,184,80,142,199,211,21,23,12,107,81,97,18,76,251,138,145,91,120,66,179,12,115,254,7,164,40,239,110,4,205,248,31,73,86,18,166,38,157,156,156,160,51,94,109,183,152,237,38,230,89,191,70,137,92,135,214,5,67,15,5,187,147,44,31,168,216,32,162,232,196,245,218,19,107,113,89,173,50,154,152,133,1,126,131,95,20,207,70,178,5,37,89,10,162,125,96,244,30,11,162,95,150,250,1,49,130,211,34,207,118,232,134,19,6,122,203,181,30,208,143,149,243,252,166,103,213,219,138,166,232,199,53,64,115,149,108,200,22,223,192,227,185,26,141,63,96,198,73,52,60,125,253,234,219,111,103,191,255,238,229,119,175,46,47,94,254,238,245,116,246,242,245,55,175,78,95,78,47,23,223,204,78,231,167,23,243,197,124,56,50,244,191,34,121,170,165,118,183,0,130,0,238,85,34,10,38,55,162,0,208,51,28,100,151,57,104,21,103,244,159,132,35,140,114,242,128,40,172,195,57,24,103,177,70,98,67,12,104,103,156,192,127,25,89,159,15,59,248,13,79,38,227,154,176,54,1,185,142,151,36,161,107,74,82,36,113,65,73,3,76,236,168,70,139,83,98,134,183,40,7,199,56,31,186,48,14,39,22,107,23,113,224,219,72,11,68,21,13,69,210,168,187,35,104,228,105,204,229,52,66,210,235,6,3,79,143,160,156,142,98,7,131,71,163,221,62,78,134,216,227,126,37,125,79,196,166,232,53,180,57,85,252,0,168,51,80,37,224,58,70,197,234,31,32,196,4,189,37,2,34,64,181,205,255,130,179,138,240,72,11,128,120,81,177,132,232,135,177,145,74,91,153,158,13,90,144,63,99,164,233,129,81,174,245,139,247,128,124,51,186,197,16,62,152,189,90,191,86,150,203,64,171,37,5,95,211,239,151,105,13,219,61,102,240,146,87,153,0,196,164,33,245,139,31,141,20,134,131,57,22,88,109,224,122,87,18,148,58,79,231,70,214,216,153,164,215,209,53,138,156,217,241,146,191,43,138,187,170,172,133,25,104,78,134,134,154,247,198,121,145,82,94,102,120,55,235,188,55,24,88,11,229,230,91,113,102,238,11,119,85,151,170,187,120,30,124,111,104,200,93,153,121,122,213,185,171,159,102,111,3,163,109,29,240,128,186,103,177,177,173,186,239,113,142,111,85,140,83,127,144,44,196,210,248,204,197,78,146,141,194,234,30,197,51,8,89,194,24,83,228,177,48,10,28,12,76,208,93,16,145,108,22,172,216,206,47,162,174,133,212,147,45,80,65,106,179,212,53,229,200,140,106,65,98,240,11,25,40,102,45,44,13,177,46,214,199,209,116,116,225,144,126,68,36,227,164,65,219,149,218,118,49,159,143,103,52,251,69,221,71,40,108,71,141,124,250,71,59,91,60,77,83,159,241,216,54,223,122,149,53,61,76,126,28,48,223,118,177,168,88,110,252,91,143,105,41,28,119,113,141,189,53,109,227,115,247,7,67,104,237,86,122,197,11,223,217,47,168,12,43,141,67,180,158,163,36,120,225,177,48,122,7,78,142,57,41,227,31,181,94,213,193,83,131,114,111,227,240,104,109,189,139,201,225,209,190,16,0,8,73,3,9,185,30,208,222,199,85,84,148,136,154,211,158,58,246,36,69,185,3,212,227,102,241,254,132,106,131,177,76,135,147,107,153,157,213,24,162,233,24,61,108,104,178,81,52,53,51,202,81,70,243,59,72,220,242,88,229,36,214,14,233,22,40,77,86,63,171,151,74,82,73,168,57,160,233,149,16,211,2,114,181,129,7,178,186,181,177,61,188,123,150,43,57,148,0,230,0,99,194,36,87,83,198,104,13,81,202,236,89,109,247,129,102,25,90,73,209,33,104,165,221,237,106,53,243,73,231,4,212,30,193,189,131,72,189,66,231,114,163,106,116,79,153,168,112,134,252,197,50,151,95,89,91,105,223,68,42,225,186,218,107,146,180,101,162,78,10,10,163,98,39,105,61,227,207,21,97,59,147,169,237,217,106,220,15,247,161,140,50,238,99,165,93,197,226,34,93,106,154,101,246,65,132,71,129,105,80,46,64,34,226,202,3,237,113,237,10,250,237,95,193,144,62,72,5,17,57,53,210,131,80,210,128,210,40,47,114,21,31,46,127,2,156,199,1,132,28,36,71,70,2,227,198,54,67,208,72,71,23,193,4,248,248,217,129,255,251,29,216,102,73,115,216,16,89,166,124,56,1,43,163,234,124,154,161,181,178,34,4,202,41,117,130,168,83,216,255,102,48,24,163,229,101,94,109,9,195,171,140,156,213,37,69,3,205,231,88,209,27,43,158,81,130,33,56,182,225,221,106,226,185,67,20,206,178,64,105,31,95,225,123,18,173,138,2,196,146,255,142,164,73,111,213,225,69,197,4,63,12,104,255,116,221,126,111,60,51,11,186,94,212,91,209,27,231,3,146,119,188,25,184,252,25,208,148,254,155,146,18,142,92,36,79,118,8,118,84,36,170,137,102,9,99,47,236,250,224,125,1,142,37,183,108,74,29,167,186,170,157,129,88,200,60,13,44,40,26,128,213,70,197,235,48,38,189,199,132,178,213,78,31,43,185,14,102,162,141,231,251,66,236,17,8,59,203,84,64,37,166,41,96,69,79,19,235,141,36,199,132,81,216,74,136,182,40,62,153,114,167,120,212,28,154,97,43,225,57,193,223,36,60,81,60,69,222,42,168,135,147,143,100,77,24,145,205,46,43,239,237,167,64,194,233,170,213,173,78,83,109,6,245,53,218,221,33,168,213,233,94,133,45,84,218,84,227,242,7,117,126,80,163,166,190,222,141,155,45,194,221,32,127,195,181,71,52,196,227,43,34,230,245,82,35,149,9,92,176,127,130,65,85,145,204,37,6,98,154,7,171,51,19,235,157,154,238,133,73,195,75,174,200,206,178,34,39,50,103,141,172,218,28,136,228,77,243,198,84,198,255,110,95,233,160,98,51,180,41,93,211,211,188,211,151,115,213,82,119,223,60,160,125,132,199,129,38,91,203,222,5,190,167,253,16,255,137,236,156,46,64,236,148,243,53,80,94,167,227,160,98,254,211,202,121,125,172,88,237,4,153,50,134,229,161,66,147,193,92,13,254,237,239,245,52,169,138,118,26,148,244,121,149,101,125,40,92,192,68,238,115,28,183,108,218,125,187,27,118,169,92,9,80,236,182,75,166,145,80,79,232,128,216,246,4,254,159,115,66,74,120,34,63,248,124,78,9,207,154,18,142,77,5,75,169,19,84,43,231,57,18,193,39,4,249,79,11,212,61,217,1,253,250,43,122,42,134,135,243,198,127,56,178,215,74,146,177,104,42,0,244,85,37,142,137,234,221,64,212,218,141,60,199,203,61,44,185,228,16,213,245,97,176,65,180,213,69,219,97,31,22,100,92,92,154,255,191,105,72,80,65,182,176,222,80,130,90,41,79,151,48,100,190,56,216,108,229,114,135,160,156,119,102,51,154,104,178,224,225,160,219,72,81,54,233,0,125,253,181,226,20,127,36,56,131,58,11,96,149,171,111,150,41,168,252,125,33,46,183,37,156,231,71,206,153,34,60,95,126,108,113,191,201,218,125,97,85,125,9,230,155,75,239,38,37,121,32,218,195,235,136,61,59,141,230,53,134,212,213,150,30,200,252,185,221,230,102,180,211,115,110,190,0,215,83,188,44,101,15,207,100,88,230,8,231,169,138,162,166,137,5,177,220,253,176,107,194,219,33,225,204,79,106,158,24,123,50,156,142,134,222,252,147,176,220,207,210,53,235,101,240,91,38,166,94,38,199,52,232,14,7,181,13,73,220,205,53,189,114,116,147,92,93,100,152,78,157,129,86,218,76,131,192,33,132,251,196,154,188,163,92,72,194,221,36,202,143,104,2,246,242,197,66,64,172,223,74,191,76,45,110,237,48,168,79,178,6,75,103,28,44,23,11,196,55,69,149,165,199,177,145,119,62,160,58,162,57,4,131,105,67,27,24,46,50,124,171,201,130,26,19,240,54,112,47,101,141,234,150,72,106,150,88,242,240,62,118,117,139,81,27,159,250,2,15,27,169,123,204,118,11,178,94,102,174,45,4,190,208,235,223,137,140,0,187,112,203,177,231,0,241,84,43,178,155,10,37,226,103,53,191,30,43,48,179,234,30,165,163,51,164,147,128,97,163,18,92,15,216,48,83,5,79,55,201,149,37,112,54,116,194,215,21,140,112,145,245,41,178,143,3,100,34,71,56,153,128,64,184,31,152,159,131,76,48,111,217,219,145,94,223,158,81,199,143,116,117,249,51,73,42,81,132,243,48,175,24,153,95,180,67,22,7,193,118,237,145,162,161,18,95,9,204,196,53,195,57,199,102,69,93,199,56,199,158,176,34,252,3,157,165,34,171,38,235,116,179,237,37,237,112,205,119,31,160,22,213,65,152,138,188,52,213,219,44,247,141,182,99,149,62,93,219,48,29,69,54,40,117,106,199,223,88,46,244,148,96,150,36,54,128,97,41,224,168,93,65,8,131,99,205,169,13,165,119,238,181,72,169,83,155,58,28,234,13,212,7,197,39,68,233,181,29,223,98,90,209,108,121,172,8,35,15,97,110,209,224,124,173,183,239,232,12,234,219,70,38,8,45,155,27,116,202,219,218,89,18,159,183,89,177,194,217,180,44,225,84,13,123,191,229,241,130,96,240,65,114,195,101,151,158,76,75,170,206,145,106,191,182,108,138,135,60,19,190,147,29,101,229,135,237,7,144,69,59,222,131,209,184,217,87,139,214,96,160,203,177,181,134,217,119,107,128,93,129,110,49,181,215,6,246,251,158,60,200,223,200,158,166,139,151,210,22,241,104,209,45,86,93,233,107,226,129,29,52,31,63,100,221,226,136,96,147,233,169,95,253,146,74,175,15,212,76,174,223,116,234,82,139,147,68,50,86,185,172,38,103,189,237,56,116,125,177,202,99,120,220,13,171,224,29,171,30,55,58,236,142,213,161,136,121,98,63,5,92,75,125,176,15,66,235,203,136,71,175,223,54,189,137,123,61,185,137,64,131,54,39,90,31,213,160,150,187,46,174,84,34,142,70,142,97,90,227,221,208,88,255,90,9,80,94,124,166,193,12,248,136,192,68,33,136,5,178,230,71,8,91,43,156,220,5,19,167,216,176,226,161,255,102,144,151,227,195,183,131,244,168,59,168,198,224,239,95,224,212,146,12,41,46,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("012573d5-4a1d-467e-84b4-9ca561534f11"));
		}

		#endregion

	}

	#endregion

}

