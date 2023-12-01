﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitiesDataProviderSchema

	/// <exclude/>
	public class ImportEntitiesDataProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitiesDataProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitiesDataProviderSchema(ImportEntitiesDataProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429");
			Name = "ImportEntitiesDataProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,25,219,110,219,54,244,217,3,246,15,156,183,7,9,51,148,110,111,203,197,65,18,39,155,177,102,233,154,182,123,24,134,130,150,104,155,171,76,185,36,229,196,43,242,239,59,188,72,34,41,201,118,176,98,91,30,98,139,58,247,59,143,25,94,17,177,198,41,65,111,8,231,88,20,115,153,92,21,108,78,23,37,199,146,22,44,185,161,57,153,174,214,5,151,95,126,241,233,203,47,6,165,160,108,129,238,183,66,146,213,73,240,12,168,121,78,82,133,39,146,31,9,35,156,166,45,152,151,148,125,108,14,175,138,213,170,96,238,51,39,254,83,50,185,12,14,174,153,164,146,18,209,28,187,194,3,192,13,78,101,193,13,4,192,124,205,201,2,68,66,232,42,199,66,28,35,163,78,69,101,130,37,126,197,139,13,205,8,215,224,191,79,200,28,151,185,188,164,44,3,226,145,220,174,73,49,143,166,253,104,241,8,253,2,134,68,103,136,193,135,130,237,7,141,255,0,22,235,114,150,211,20,165,74,158,29,226,128,168,187,100,29,40,127,212,218,129,219,132,196,76,130,130,175,56,221,96,73,180,54,131,181,121,64,169,122,143,40,147,232,22,63,190,194,28,36,149,132,139,171,162,100,242,21,225,191,150,132,111,175,150,37,251,0,106,124,247,195,139,23,39,189,200,175,139,135,155,130,79,153,32,188,141,249,66,99,182,113,133,228,202,83,239,103,229,124,78,56,201,28,197,182,247,233,146,172,176,53,225,240,178,3,98,104,105,126,77,88,102,244,181,207,149,107,111,40,201,179,62,213,13,165,151,197,98,65,56,122,159,235,79,79,61,87,12,244,94,232,79,15,96,10,145,93,174,152,184,88,44,128,35,134,232,50,49,182,69,239,211,158,55,123,240,47,50,188,150,74,28,139,15,110,77,137,16,133,47,24,39,56,43,88,190,173,205,71,141,81,30,83,146,131,27,166,44,35,143,202,102,211,246,241,62,147,233,120,225,165,146,85,217,77,71,164,53,155,137,206,254,208,139,222,130,235,1,159,153,92,71,165,247,24,35,29,151,131,0,232,44,0,211,122,14,166,12,168,227,156,254,69,140,123,162,88,159,63,125,22,73,70,59,236,30,154,61,70,199,72,46,169,136,180,88,131,110,149,90,206,2,173,58,253,183,71,175,62,159,0,145,53,36,21,40,217,23,201,189,250,92,181,36,27,183,99,11,157,159,27,245,162,46,77,250,98,252,28,106,185,108,189,12,76,31,199,39,251,68,173,82,166,247,133,35,114,251,101,75,244,14,124,83,225,237,163,146,250,180,87,138,113,212,150,216,45,19,246,67,137,100,10,6,8,128,162,234,59,84,122,242,224,33,236,51,71,16,168,193,227,39,180,32,242,4,237,9,143,91,34,151,69,111,149,155,144,28,42,58,2,173,187,42,168,121,171,107,117,84,204,254,4,190,200,212,146,123,112,63,16,159,102,74,169,50,207,171,88,223,96,142,50,67,210,104,107,40,132,122,26,167,36,55,188,88,69,123,138,187,73,129,1,157,163,40,100,253,149,207,123,96,24,39,191,45,129,90,100,171,91,13,61,140,147,169,184,254,88,226,60,50,222,77,234,118,22,18,142,45,207,39,253,159,19,89,114,102,181,242,234,76,21,1,186,167,245,153,208,188,53,38,116,173,212,165,117,21,33,26,37,180,89,50,101,178,56,208,90,86,230,46,216,78,13,174,89,185,34,28,207,114,114,234,125,119,240,198,99,165,161,95,84,117,255,22,81,47,10,34,22,112,100,28,212,6,52,174,24,163,15,100,107,115,206,181,81,133,254,146,194,44,112,86,63,38,111,10,117,98,171,163,134,180,217,109,1,27,106,29,160,43,59,200,8,152,66,170,1,228,22,203,101,114,49,19,209,190,41,231,8,69,14,171,68,67,160,111,209,247,85,200,244,18,191,165,44,218,53,5,141,218,114,185,234,105,67,27,110,103,144,8,76,198,154,234,21,161,185,154,54,93,67,89,161,64,210,172,128,78,72,226,62,194,54,72,60,220,251,117,78,229,29,3,120,41,34,135,107,220,21,54,10,227,244,199,146,102,58,52,128,186,128,131,42,218,234,108,18,94,216,139,250,216,6,123,67,196,117,146,32,234,74,96,65,238,245,67,43,31,38,128,73,25,188,168,202,137,241,121,71,230,63,191,220,152,27,66,164,203,217,236,250,145,164,165,212,221,206,151,1,46,21,162,228,100,114,217,28,65,131,168,202,145,75,3,166,143,215,48,149,233,38,96,116,75,12,85,98,142,163,134,75,67,96,240,176,132,123,20,248,177,198,78,212,135,195,98,48,104,236,153,92,100,153,11,90,183,223,119,56,47,137,53,113,219,54,86,225,170,218,217,15,175,244,53,60,186,162,96,83,208,12,181,39,23,43,98,87,73,188,199,27,176,217,53,231,96,210,111,207,108,211,76,126,194,44,203,137,62,189,5,134,120,209,89,108,45,55,184,37,42,42,126,57,122,83,76,46,63,111,49,178,160,202,118,97,227,115,131,154,58,232,98,87,253,105,186,88,245,30,122,210,106,45,183,142,79,141,209,221,14,212,81,10,251,74,113,173,163,47,147,101,63,135,123,46,78,151,38,38,43,208,75,44,225,136,250,133,160,150,198,148,42,13,3,230,157,133,173,50,224,51,242,169,186,125,180,219,143,62,241,46,59,143,76,133,240,61,20,48,221,239,115,35,142,85,74,194,212,103,213,211,222,107,58,180,177,236,222,54,110,83,198,51,39,117,251,184,99,77,143,51,68,64,67,39,209,137,41,106,114,131,251,93,172,157,92,22,145,203,108,228,42,48,170,234,194,160,203,255,62,123,96,215,174,7,35,59,104,39,250,166,215,55,25,181,9,117,221,49,107,90,205,164,165,91,151,43,125,82,1,215,164,109,29,114,25,216,82,89,89,234,9,165,58,102,35,197,109,173,71,97,82,91,248,142,237,41,57,145,106,41,110,153,185,222,128,175,46,248,66,212,78,10,140,2,81,17,6,165,5,108,4,128,233,164,58,180,100,213,81,98,191,91,205,246,229,195,225,1,224,77,141,126,52,216,113,180,29,20,207,157,190,204,70,163,169,106,118,197,97,219,172,232,40,41,169,10,124,167,248,217,198,29,165,16,163,177,186,21,217,209,251,24,165,74,78,240,250,49,162,48,62,125,23,55,229,175,153,230,212,53,217,50,59,113,179,213,108,47,210,68,19,56,9,177,236,66,232,155,161,193,252,164,225,159,134,14,92,70,212,220,128,173,219,12,86,50,105,14,69,114,67,185,144,119,220,174,244,234,4,85,213,219,67,14,238,31,3,185,228,197,131,30,89,32,156,192,214,76,254,2,239,239,184,46,241,117,172,68,118,223,231,144,10,131,191,154,25,180,183,223,108,215,74,35,207,29,170,187,95,110,149,174,46,25,107,45,61,199,36,19,23,191,101,38,253,166,14,108,155,139,55,96,44,39,204,236,168,27,59,200,27,117,14,19,172,202,167,218,120,150,150,177,6,170,42,208,185,175,1,88,120,174,31,170,247,199,173,237,131,230,255,206,225,224,234,54,114,153,213,30,9,170,80,19,2,29,181,199,149,125,228,11,23,119,100,230,1,247,233,66,66,120,147,172,202,100,251,104,114,121,127,29,234,174,65,164,250,118,224,4,117,14,121,176,41,62,144,72,237,161,70,14,186,63,61,213,178,81,46,225,14,140,102,69,145,163,255,209,8,37,202,84,5,1,196,148,228,165,13,87,59,24,170,31,19,108,86,7,4,96,186,186,215,43,206,42,69,195,206,238,233,214,127,131,28,92,229,4,119,249,139,214,189,182,17,250,164,26,140,250,103,80,159,239,200,181,70,203,6,7,180,180,198,54,115,156,139,42,151,63,71,163,59,188,211,117,183,186,3,123,93,229,73,37,28,124,141,252,11,168,85,239,144,85,103,147,123,206,230,249,232,232,8,157,138,114,181,194,124,59,174,14,148,71,185,208,89,142,230,112,239,67,93,198,66,82,133,46,154,109,209,218,172,134,51,116,186,86,245,130,147,185,254,85,230,108,24,152,99,136,142,106,22,167,71,33,83,131,220,131,57,62,61,210,175,53,180,221,81,235,74,177,43,248,118,165,205,63,78,143,122,81,119,192,246,175,39,11,236,202,237,223,30,208,254,211,184,245,127,102,104,92,120,151,7,222,123,141,31,84,19,142,110,74,150,234,251,247,200,46,127,155,21,211,24,205,161,231,133,167,10,161,231,178,34,64,148,172,217,173,24,231,237,88,189,56,189,155,21,242,34,85,197,223,224,5,148,236,218,20,148,57,235,23,10,94,199,245,216,99,109,89,77,121,84,33,250,151,135,216,101,255,81,239,186,244,251,235,199,53,55,140,245,22,200,145,43,44,204,106,228,234,70,180,107,174,49,122,209,204,95,207,13,234,250,54,179,119,115,204,122,164,8,41,4,137,80,109,83,254,131,124,80,241,150,232,193,243,159,166,130,25,107,159,153,22,59,231,139,32,178,208,186,254,218,117,151,239,191,165,216,27,73,215,94,174,217,234,221,98,134,23,102,31,54,213,63,118,167,228,114,251,118,154,69,13,87,184,132,22,210,64,191,173,107,155,237,78,61,58,56,200,221,125,222,1,152,118,213,206,167,93,205,107,73,210,15,8,111,48,205,117,131,2,186,213,134,27,62,33,236,147,3,123,80,35,144,206,150,225,248,231,22,37,183,43,105,124,163,183,24,191,38,2,46,63,106,226,167,208,69,9,0,86,111,66,55,191,179,32,63,251,220,212,93,31,5,18,236,251,5,196,254,154,126,102,131,243,185,110,213,23,162,195,54,188,206,175,6,16,63,253,40,254,117,87,97,229,88,200,90,213,230,183,220,228,130,109,163,84,21,193,52,49,253,216,185,133,6,102,120,26,250,65,230,145,220,53,8,89,179,235,41,31,233,58,96,214,166,252,180,179,64,140,59,199,30,167,182,40,94,134,149,203,73,159,192,223,223,59,22,155,96,233,35,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3e62edd-3aed-4f53-ac07-92e86719d429"));
		}

		#endregion

	}

	#endregion

}

