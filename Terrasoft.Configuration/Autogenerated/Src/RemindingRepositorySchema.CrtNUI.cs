﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RemindingRepositorySchema

	/// <exclude/>
	public class RemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RemindingRepositorySchema(RemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d71d1132-e027-4565-9928-12b084b56c8f");
			Name = "RemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,75,111,227,54,16,62,123,129,253,15,172,247,34,163,174,140,30,122,73,28,23,73,54,9,180,216,164,65,30,237,113,161,72,116,194,86,34,93,146,114,106,20,251,223,59,124,72,34,41,201,150,155,139,195,225,204,240,155,55,41,154,150,88,108,210,12,163,39,204,121,42,216,90,198,151,140,174,201,107,197,83,73,24,253,248,225,223,143,31,38,149,32,244,21,61,238,132,196,229,105,176,142,63,167,50,237,16,47,89,81,224,76,105,16,241,13,166,152,147,172,229,113,207,226,120,136,30,127,190,24,220,186,78,51,201,56,193,162,159,163,44,25,133,29,216,251,196,241,43,128,64,151,69,42,196,9,122,192,37,161,57,176,63,224,13,19,4,116,236,52,219,98,177,64,75,81,149,101,202,119,43,187,190,231,108,75,114,44,80,138,74,44,223,88,142,214,140,35,142,51,76,182,234,64,174,117,97,46,226,90,193,194,209,176,169,94,10,146,161,76,157,219,119,44,58,65,73,47,154,137,114,120,139,27,28,40,83,42,1,251,61,39,219,84,98,141,119,178,49,11,148,169,125,36,36,87,136,26,125,79,233,75,129,239,32,182,232,12,77,27,234,244,180,43,73,168,68,9,149,152,111,211,34,161,183,132,86,18,139,107,198,175,65,164,17,4,45,191,24,119,78,62,97,154,27,104,106,229,34,189,38,184,200,135,96,114,156,230,140,22,59,244,44,48,7,155,168,201,13,244,173,242,214,167,189,50,201,29,147,100,77,50,157,144,143,88,74,128,36,28,79,126,163,123,247,123,144,119,60,204,43,149,79,10,189,14,155,5,111,66,216,19,165,40,48,195,183,98,134,116,8,39,62,53,190,124,195,217,95,231,252,181,42,49,149,119,85,81,68,20,34,196,214,81,32,61,211,94,152,4,174,129,24,244,248,106,114,192,118,144,210,153,111,234,101,7,165,40,151,251,189,185,138,180,222,9,197,239,174,107,106,220,209,212,71,49,157,135,49,180,248,191,239,247,250,173,174,168,161,116,81,89,9,80,15,38,102,84,187,122,155,114,37,228,115,131,241,99,148,64,199,170,221,240,123,90,84,56,178,1,80,58,27,239,50,250,133,189,212,170,140,226,187,222,189,33,109,28,203,138,211,30,144,171,161,67,126,69,38,18,93,145,19,187,51,32,248,99,247,20,55,36,199,58,185,107,145,117,186,53,73,55,100,111,104,196,142,136,65,58,81,153,103,164,131,116,153,163,233,65,4,144,100,7,121,154,172,51,93,41,48,114,108,172,142,177,108,159,73,253,231,129,29,63,15,224,124,196,106,92,42,168,173,223,53,169,193,100,57,132,249,57,67,170,64,45,75,88,129,38,227,206,243,28,166,112,85,82,17,25,33,75,255,194,8,213,3,34,160,3,255,53,41,0,105,64,55,139,248,154,179,50,234,78,24,63,189,13,111,95,182,37,87,20,26,8,87,98,75,175,161,39,116,205,86,232,234,31,156,65,88,173,65,158,173,110,141,115,44,170,162,182,254,43,17,178,71,87,228,227,182,154,31,96,154,96,30,113,253,131,206,86,86,233,196,104,140,193,248,200,205,19,171,204,242,215,61,249,187,111,173,145,237,179,214,14,100,208,248,152,189,225,50,85,158,138,18,243,255,109,74,211,87,192,80,154,223,57,186,169,72,142,8,220,154,158,73,238,26,43,26,81,48,216,104,140,175,202,141,220,157,6,44,176,109,149,197,170,38,18,80,117,177,123,78,242,168,86,106,4,200,26,69,86,224,7,240,32,76,160,250,180,137,127,148,94,196,106,101,205,246,66,220,176,30,217,231,153,132,112,224,188,118,148,93,162,45,225,178,130,174,165,189,160,28,182,19,73,9,182,68,154,0,35,135,200,157,113,28,88,20,20,232,129,233,23,135,17,213,122,3,149,115,219,76,155,212,214,83,79,196,174,224,211,110,131,155,253,36,239,212,112,104,203,150,1,116,167,254,122,243,217,172,204,225,177,225,236,169,47,213,31,243,233,44,62,23,145,254,103,4,63,24,32,97,222,55,98,206,122,132,180,33,62,145,18,91,113,151,48,66,254,158,109,170,205,19,145,69,45,239,18,70,200,63,86,47,127,98,7,189,179,30,35,189,19,87,78,124,91,45,93,250,120,44,151,233,70,223,117,60,64,13,113,132,158,175,76,117,145,6,76,187,28,131,1,83,87,182,93,250,178,202,194,243,28,228,159,41,145,83,55,107,220,13,69,28,149,188,206,144,56,156,188,9,76,30,174,36,2,20,179,248,183,17,41,154,136,171,191,225,220,174,5,14,211,216,130,171,7,88,47,102,120,168,98,149,198,40,171,56,135,46,0,231,108,129,57,45,52,241,12,213,251,241,179,204,238,216,187,109,154,84,254,239,155,101,61,137,154,131,141,113,222,161,125,88,212,52,178,42,163,159,58,135,251,227,237,143,55,204,113,95,145,66,88,196,5,150,239,24,211,200,228,72,124,159,114,112,63,168,139,66,32,51,72,21,154,119,249,250,208,205,234,204,83,18,211,176,77,122,33,237,232,59,166,201,54,118,232,115,18,113,135,113,254,196,84,254,119,79,208,234,34,120,171,224,217,193,92,233,220,24,80,223,224,79,212,103,13,115,105,64,121,243,175,55,158,253,150,2,163,4,194,217,178,170,225,99,208,233,75,226,82,141,179,85,111,35,106,199,121,161,27,195,72,77,109,23,105,21,184,179,205,78,115,255,14,18,92,21,99,23,203,109,125,33,233,90,214,193,120,196,17,151,5,49,41,36,131,99,26,107,173,118,115,15,82,51,90,59,192,189,11,12,34,178,23,1,117,29,236,132,213,222,109,110,177,16,181,206,131,78,85,238,156,27,57,61,178,246,202,152,59,217,202,31,113,86,250,130,229,187,113,194,225,60,177,10,140,189,35,147,170,157,145,115,247,54,99,123,204,176,124,221,153,86,126,7,177,74,220,134,60,50,183,189,73,227,89,226,101,76,152,167,150,211,164,180,229,9,19,205,242,36,77,130,216,84,177,244,27,206,170,77,247,155,151,185,192,142,154,31,207,27,176,176,109,65,34,129,167,30,149,145,251,114,209,134,218,47,127,154,197,187,176,87,90,129,125,157,24,109,221,183,97,207,19,202,246,83,184,192,6,125,110,142,188,254,182,78,11,209,182,95,211,249,135,111,140,73,183,239,139,200,131,110,107,200,192,174,31,74,209,145,223,111,156,15,102,225,87,84,77,120,208,21,42,28,167,197,13,239,34,100,94,154,122,22,171,246,251,49,98,107,36,223,176,43,191,92,212,108,206,103,186,3,15,76,247,101,45,6,31,213,125,239,111,227,164,3,234,105,64,81,87,4,255,77,235,189,169,235,182,21,74,185,174,239,245,38,228,136,235,74,68,4,128,167,114,159,75,55,42,250,72,125,107,60,155,186,225,159,238,115,50,34,185,170,209,53,129,98,95,46,180,10,215,217,186,94,30,93,151,30,85,44,46,109,248,187,104,95,174,14,212,168,199,58,148,191,150,230,146,128,226,254,253,7,173,150,66,209,15,25,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d71d1132-e027-4565-9928-12b084b56c8f"));
		}

		#endregion

	}

	#endregion

}

