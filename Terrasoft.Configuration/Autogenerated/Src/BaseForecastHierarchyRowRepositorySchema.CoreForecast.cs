﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseForecastHierarchyRowRepositorySchema

	/// <exclude/>
	public class BaseForecastHierarchyRowRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseForecastHierarchyRowRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseForecastHierarchyRowRepositorySchema(BaseForecastHierarchyRowRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("59408977-7b8f-e84f-c228-9beedffa7732");
			Name = "BaseForecastHierarchyRowRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,26,219,114,219,54,246,89,157,233,63,32,234,182,67,205,104,233,102,31,215,182,18,95,228,172,182,110,156,181,157,246,33,147,201,208,36,100,113,74,145,42,64,58,81,51,254,247,61,192,1,64,0,4,36,175,183,211,60,40,38,1,156,251,29,36,117,182,166,124,147,229,148,220,82,198,50,222,44,219,244,172,169,151,229,125,199,178,182,108,234,244,162,97,52,207,120,251,203,63,190,253,230,235,183,223,140,58,94,214,247,228,102,203,91,186,62,244,158,225,104,85,209,92,156,227,233,27,90,83,86,230,131,61,151,101,253,123,255,210,70,187,94,55,117,120,133,209,216,251,244,252,52,186,52,175,219,178,45,41,143,110,184,200,242,182,97,184,3,246,124,199,232,61,144,78,206,170,140,243,127,146,27,42,120,249,79,71,217,22,69,34,55,29,28,28,144,35,222,173,215,25,219,206,212,51,46,147,142,211,130,180,13,217,192,113,82,100,109,38,30,222,208,214,2,244,107,217,174,174,54,82,64,201,0,62,201,229,127,19,178,166,237,170,41,52,178,3,11,219,166,187,171,202,156,228,130,194,16,129,35,161,34,189,11,215,245,127,114,101,116,79,219,67,194,225,71,60,61,218,155,87,148,182,234,119,207,214,119,217,61,205,238,42,170,168,246,30,195,135,173,227,139,121,221,173,41,19,71,142,254,85,194,31,44,95,109,111,104,219,130,134,22,96,33,51,98,222,198,129,225,239,119,180,46,80,105,33,5,158,102,156,106,243,53,32,175,155,207,215,116,211,240,18,52,191,141,106,84,28,85,82,94,54,140,128,157,116,89,69,178,186,32,171,146,11,155,201,225,113,101,200,100,205,103,84,56,211,160,193,168,210,29,10,204,238,120,203,0,170,194,241,20,74,81,181,134,69,176,160,54,171,91,96,243,29,107,90,80,48,45,148,148,245,163,48,39,222,18,64,36,76,95,131,151,78,177,61,169,202,140,147,99,50,190,152,143,15,159,112,10,104,233,143,92,239,60,114,153,255,177,40,32,16,116,235,250,45,68,23,113,226,154,230,13,43,22,197,206,115,254,161,61,219,45,202,110,242,21,93,103,250,156,181,240,36,0,243,26,228,177,168,207,104,85,89,82,89,156,141,49,40,248,54,102,52,112,81,210,170,144,226,47,31,178,150,106,225,203,7,178,176,201,107,88,123,3,218,110,233,253,150,124,90,134,23,14,131,167,79,138,2,246,161,92,184,116,244,211,174,172,10,202,200,167,44,182,180,135,108,176,150,13,101,34,44,6,44,7,209,191,231,148,129,125,213,24,201,201,167,206,121,62,244,205,204,219,238,61,26,15,38,199,179,0,40,88,227,38,226,140,30,178,170,163,233,217,138,230,191,157,176,123,136,18,117,251,182,171,170,68,164,169,102,153,184,160,39,19,60,63,242,160,130,2,37,28,92,125,180,3,144,161,57,170,159,216,251,158,13,69,42,163,109,199,234,168,62,201,171,87,184,111,148,68,183,28,99,160,194,44,180,133,132,217,30,197,232,154,37,154,219,61,252,196,45,38,190,18,229,45,106,99,54,119,241,77,187,248,139,82,51,75,20,228,81,77,63,99,152,99,157,0,160,13,34,25,187,234,30,79,137,111,23,1,81,197,220,193,66,32,28,66,70,103,220,225,167,5,157,233,245,118,153,24,142,56,133,60,193,232,242,216,142,59,54,63,227,3,115,216,73,4,248,102,147,177,108,77,132,121,31,251,108,205,142,14,228,234,204,74,157,251,243,132,231,35,196,5,58,81,26,118,223,198,29,174,11,58,220,123,223,221,2,94,189,71,236,63,203,10,103,87,242,10,86,9,192,234,236,89,21,21,178,141,185,15,211,5,161,246,195,177,103,67,169,189,245,231,172,134,18,135,9,3,94,200,172,155,211,211,237,251,69,145,32,244,84,22,77,169,155,96,97,89,73,235,33,99,80,17,58,37,210,177,162,43,117,75,167,126,127,69,31,104,5,219,220,115,169,145,195,165,88,239,183,231,232,70,112,0,72,52,155,148,115,37,54,163,83,141,217,236,154,164,191,174,40,163,73,46,226,115,158,254,68,183,228,232,24,9,176,24,224,88,67,26,194,81,210,184,30,117,229,20,86,212,235,219,6,79,36,8,104,170,73,158,18,225,229,81,8,239,132,3,112,29,150,180,132,141,206,28,206,112,15,162,113,139,156,64,233,131,241,97,98,24,0,1,23,37,26,81,79,161,52,29,220,82,46,73,242,194,211,198,226,190,6,192,215,229,253,170,229,218,194,164,48,228,27,11,162,109,38,83,162,225,219,196,219,1,75,226,66,3,152,145,31,109,192,168,51,161,216,0,177,82,118,1,93,42,85,78,163,182,4,146,231,198,88,123,10,94,96,153,148,46,184,8,8,87,108,190,222,180,219,196,3,2,181,143,136,103,23,101,213,82,246,139,72,186,19,67,176,227,108,75,71,5,207,118,58,81,227,57,246,156,138,55,186,14,64,97,164,182,58,147,139,174,206,211,247,27,40,121,146,128,25,76,131,132,105,182,206,75,190,169,50,229,71,136,105,170,147,211,101,115,47,122,128,43,0,140,125,242,73,93,76,212,34,200,236,178,252,141,38,234,160,52,98,10,2,74,254,54,254,254,235,94,9,166,183,13,210,59,121,252,126,60,25,232,197,59,47,253,166,171,91,97,43,228,135,31,124,45,11,229,94,45,151,162,196,154,29,91,214,100,252,25,196,171,131,144,231,161,46,36,135,14,144,240,21,3,247,212,113,55,108,224,126,12,169,236,164,133,178,145,1,5,45,247,162,100,188,181,45,247,120,24,133,168,176,65,41,36,164,92,218,164,1,41,23,146,0,150,84,174,4,61,78,64,101,148,119,149,146,5,232,161,162,133,227,27,137,195,207,212,34,66,193,80,213,18,130,113,250,93,147,204,30,74,38,27,72,213,138,187,1,71,189,212,104,246,37,49,36,25,27,42,30,75,37,169,110,185,120,31,191,204,33,207,167,123,151,85,156,40,63,194,88,162,68,40,11,159,228,229,100,2,135,231,191,3,47,131,5,146,233,137,132,109,42,130,218,165,52,110,164,72,80,220,19,114,219,92,66,59,157,40,65,222,53,77,37,216,105,179,178,230,115,91,215,14,4,112,181,109,82,22,194,82,196,47,232,173,43,139,84,238,183,162,245,16,142,97,211,133,118,77,215,205,3,77,6,64,122,250,203,194,88,171,18,141,74,85,31,94,126,236,17,186,80,65,196,77,235,203,55,20,160,52,240,41,25,132,148,43,6,210,174,7,97,132,187,168,134,33,98,7,235,207,161,64,26,75,226,96,113,12,229,73,38,47,124,203,13,181,42,218,96,51,238,134,97,17,106,167,106,22,197,197,239,142,2,14,59,119,147,81,44,60,194,121,241,125,130,64,84,187,137,24,135,167,213,0,97,184,32,67,127,31,47,92,90,81,118,82,202,10,128,68,38,242,22,110,184,166,75,240,35,72,95,184,211,111,98,95,165,30,4,68,228,4,5,0,42,202,36,37,50,15,64,122,193,154,117,50,20,224,36,61,225,161,156,167,178,84,250,239,166,172,19,241,115,187,221,80,176,179,154,178,105,68,42,30,40,119,94,50,73,175,234,112,110,21,35,28,141,77,71,141,24,20,63,19,123,66,153,136,252,186,227,240,88,26,75,0,159,19,165,80,51,80,236,12,130,213,255,96,208,142,13,134,205,237,57,150,139,116,63,167,11,225,129,246,3,97,247,77,136,226,111,136,56,204,171,206,62,24,33,4,151,94,81,235,39,173,189,197,158,157,189,56,205,59,6,43,243,250,190,172,233,176,12,60,63,189,113,118,88,169,218,165,66,6,100,123,167,16,142,10,139,167,91,73,114,79,177,240,32,119,77,149,47,161,130,85,185,114,176,58,148,209,105,120,228,166,233,88,78,117,207,241,90,69,90,124,59,255,178,129,242,128,203,58,81,26,44,30,151,84,4,208,198,152,66,37,244,91,147,40,125,186,80,53,161,92,12,99,196,149,135,123,185,99,159,179,80,244,9,224,154,102,133,2,165,42,85,103,72,27,196,47,74,74,127,111,162,9,18,170,94,20,67,157,159,117,12,130,100,43,222,130,131,246,155,207,105,189,181,153,143,33,13,108,117,122,60,93,164,185,6,20,241,244,6,234,138,112,191,229,153,189,61,164,128,154,85,134,171,119,89,201,142,202,90,20,194,50,211,204,102,166,217,149,148,216,103,68,209,49,235,239,17,84,43,166,12,210,84,198,13,155,103,249,10,107,99,101,171,50,205,203,50,121,112,60,149,253,64,50,33,127,39,47,77,222,87,252,171,70,233,81,79,91,25,78,74,65,168,62,144,121,69,197,48,232,164,69,52,186,197,146,238,27,52,116,85,18,9,237,159,98,2,128,118,103,229,22,226,95,37,172,71,17,166,95,165,150,191,28,246,76,89,192,177,134,10,87,170,58,139,231,193,43,3,51,22,233,227,196,235,80,229,99,33,155,90,160,2,133,144,232,238,52,104,65,38,14,170,23,124,64,215,200,32,245,10,39,144,58,161,21,167,225,157,129,100,245,128,237,180,57,109,171,78,89,245,192,114,251,98,203,107,234,60,187,245,174,236,188,86,79,145,40,248,124,83,53,119,89,117,178,217,168,251,57,46,28,13,27,202,11,218,230,43,0,4,111,13,251,90,202,214,142,64,195,170,58,210,193,72,66,247,178,154,103,229,179,175,121,176,171,48,226,51,197,185,103,138,31,126,252,216,103,142,162,100,102,92,233,202,230,92,175,96,11,122,56,68,160,187,16,53,17,145,58,87,183,32,161,150,252,82,220,150,43,251,136,26,240,83,232,121,75,191,40,114,70,3,90,98,56,125,41,53,42,199,97,5,233,98,210,237,123,13,20,70,149,49,237,69,167,244,162,64,186,174,228,105,3,231,122,178,140,232,199,31,99,116,49,67,235,120,234,201,88,91,187,178,214,141,67,173,165,224,219,70,51,146,40,98,220,40,239,30,132,237,155,216,216,36,226,71,58,3,88,181,221,160,0,234,107,60,221,179,43,247,250,255,75,157,96,53,101,46,58,159,91,43,202,60,28,188,54,181,134,33,22,182,191,174,204,10,18,181,183,196,242,239,166,255,172,162,42,44,162,191,166,160,178,47,193,255,252,138,201,112,180,183,92,146,3,141,144,41,188,128,64,2,225,98,16,241,101,255,40,91,202,176,248,236,14,82,43,204,233,28,141,22,29,25,88,35,213,125,253,227,24,32,136,202,226,208,37,204,137,82,33,150,118,102,251,240,109,171,14,15,131,73,127,60,40,120,45,18,141,180,70,195,6,39,208,123,189,222,113,133,32,7,125,30,144,152,206,28,209,120,135,246,75,69,162,242,108,82,196,27,126,65,51,136,194,116,94,139,120,91,36,227,65,16,29,79,236,91,141,29,49,86,9,82,209,251,36,149,56,115,233,144,58,140,240,160,68,87,3,230,231,215,59,145,219,250,20,0,84,91,241,70,83,98,176,138,240,24,57,229,94,118,141,144,120,53,78,210,247,14,202,233,221,139,64,162,38,229,170,66,180,107,117,107,116,233,87,71,122,118,217,23,109,66,116,80,187,243,220,140,4,119,127,115,176,235,134,54,52,72,247,28,194,40,64,119,74,246,104,221,25,118,171,249,188,144,157,152,23,187,216,116,129,173,184,152,127,129,56,223,82,17,103,161,228,96,242,63,171,113,18,29,151,28,27,19,92,18,38,107,205,154,176,35,11,116,46,146,208,71,43,190,40,146,117,255,20,134,166,58,192,40,60,3,77,216,94,89,132,26,10,141,160,151,205,176,137,179,155,55,37,39,91,68,73,15,77,95,11,192,174,82,231,140,145,174,41,37,42,5,220,148,224,66,246,34,82,36,54,18,109,23,79,191,1,81,226,138,92,218,12,186,185,39,132,75,117,102,77,57,135,90,71,155,71,3,33,171,252,67,22,127,114,221,143,80,215,20,155,190,155,182,97,112,76,137,64,125,238,16,250,180,226,60,107,179,254,243,138,9,228,153,1,14,158,6,120,194,75,167,177,85,90,81,107,176,233,93,94,11,187,193,191,112,249,20,130,65,11,29,127,159,7,221,49,37,54,34,64,238,58,107,19,37,129,169,131,32,61,203,54,125,205,62,244,221,243,82,202,3,234,15,103,86,17,252,128,32,170,138,225,64,35,252,61,167,49,29,219,173,251,143,22,132,226,34,244,36,86,90,123,97,192,68,47,176,68,126,207,242,21,73,66,116,136,47,72,205,223,101,221,83,165,35,95,146,137,64,145,165,50,168,90,46,168,40,253,160,7,50,63,209,45,199,41,203,71,89,87,26,168,42,182,10,221,57,78,218,183,99,155,192,205,178,115,239,48,152,161,13,182,106,145,236,166,42,134,200,177,35,117,52,246,193,78,240,35,91,249,78,252,251,47,31,114,206,202,60,46,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("59408977-7b8f-e84f-c228-9beedffa7732"));
		}

		#endregion

	}

	#endregion

}

