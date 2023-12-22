﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseTaskQueueManagerSchema

	/// <exclude/>
	public class BaseTaskQueueManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseTaskQueueManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseTaskQueueManagerSchema(BaseTaskQueueManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1a08287d-cbd2-47c4-9848-cd0c2db13d7e");
			Name = "BaseTaskQueueManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,26,89,115,219,54,250,217,153,201,127,192,170,251,64,207,186,116,250,234,67,59,190,146,106,198,141,179,22,179,121,134,72,72,66,205,67,6,64,59,106,198,255,125,63,92,36,0,146,18,157,100,186,157,116,28,131,31,190,251,70,74,92,16,190,193,41,65,9,97,12,243,106,41,226,171,170,92,210,85,205,176,160,85,249,246,205,183,183,111,14,106,78,203,21,154,111,185,32,197,105,240,59,192,231,57,73,37,48,143,63,144,146,48,154,118,96,110,105,249,216,30,186,180,138,162,42,251,191,48,50,116,30,95,95,182,159,86,121,181,192,249,201,137,70,21,223,86,171,21,28,203,239,240,231,23,70,86,192,24,186,202,49,231,39,232,18,115,146,96,254,240,159,154,212,228,15,92,226,21,97,111,223,0,220,241,241,49,58,227,117,81,96,182,157,154,223,65,15,2,211,146,163,130,136,117,149,113,36,42,244,92,177,7,244,76,197,26,61,74,20,177,1,189,219,16,80,23,225,250,211,25,39,4,165,140,44,207,39,146,160,38,70,56,7,106,147,227,169,189,115,118,236,208,219,212,139,156,166,8,47,184,96,56,21,40,149,252,246,178,123,150,76,209,243,154,48,176,24,10,5,210,52,0,221,55,37,84,43,61,152,70,176,58,21,21,3,37,124,82,180,52,68,40,183,21,220,130,163,37,252,223,43,143,230,198,200,211,21,72,159,108,48,195,5,42,193,201,206,39,53,39,12,48,151,218,85,38,211,179,99,245,85,1,27,241,251,228,141,62,123,247,144,143,230,16,73,247,60,56,8,128,206,3,48,233,13,7,47,70,41,164,204,180,94,124,37,125,98,21,88,81,80,34,85,196,42,1,55,73,166,65,54,246,87,20,208,9,126,253,134,86,68,156,162,151,29,186,157,167,107,82,96,165,18,84,45,181,23,33,82,10,42,182,3,138,108,137,55,222,1,63,164,231,43,53,105,132,31,37,190,215,147,175,148,223,2,235,56,255,9,172,220,109,6,153,25,165,244,125,126,57,3,183,196,101,170,56,119,124,114,6,33,15,126,136,114,136,124,194,134,88,15,2,76,94,66,183,234,134,101,149,239,83,158,18,18,178,129,138,50,180,97,180,98,160,43,180,216,162,140,44,113,157,139,189,106,123,162,76,212,160,107,90,10,116,173,239,152,160,253,100,177,157,79,209,187,211,221,74,187,121,2,43,141,83,216,83,245,32,205,131,151,2,228,196,229,214,213,91,34,149,182,198,28,45,8,41,81,81,61,1,131,192,88,133,196,154,120,158,33,240,34,39,187,245,74,36,75,154,177,223,113,153,229,58,79,221,149,70,186,107,162,188,43,219,35,216,31,58,209,202,248,163,79,144,79,109,244,169,95,32,223,125,32,34,169,54,6,103,180,168,42,208,36,191,107,57,5,3,177,237,17,154,221,148,117,1,135,192,245,25,8,52,181,38,75,182,27,194,109,198,120,194,12,18,186,69,6,25,195,216,48,74,14,79,27,0,115,113,78,100,129,3,24,143,1,125,26,245,113,224,17,212,232,60,84,241,124,67,82,186,220,126,172,110,171,244,225,119,96,146,71,189,112,55,95,73,90,11,114,79,112,6,169,48,195,2,235,191,74,55,209,114,40,62,105,38,5,104,190,66,25,22,80,149,235,162,252,47,206,107,114,246,161,166,217,52,154,204,178,137,33,162,46,253,201,85,166,28,190,166,99,27,46,218,226,229,222,102,4,190,66,197,219,133,64,42,31,110,227,175,247,0,188,189,170,234,82,52,56,60,221,95,49,2,22,182,134,165,217,145,98,238,200,18,49,119,94,204,79,56,173,89,233,88,207,77,239,161,183,56,198,177,248,71,251,71,209,48,232,123,94,215,228,39,8,10,38,233,53,60,93,162,168,65,228,186,153,165,100,229,9,29,240,197,245,135,216,211,226,175,191,118,112,251,0,232,236,28,189,107,8,92,131,51,53,234,189,220,206,178,230,210,12,84,61,36,141,181,212,14,34,14,141,33,41,140,24,47,136,228,156,88,224,207,155,172,181,119,139,208,99,171,151,164,167,26,67,177,24,118,130,167,10,34,99,136,152,140,10,36,125,77,102,227,194,163,226,248,64,173,110,131,11,148,228,217,160,10,90,146,163,110,245,59,212,98,198,115,34,66,255,63,66,58,66,226,79,178,251,1,179,176,200,167,109,239,126,145,77,158,14,218,120,198,111,30,161,110,68,157,171,52,3,55,130,20,174,25,211,202,209,28,199,95,160,21,213,153,69,114,126,95,61,219,84,19,29,30,122,128,38,199,152,4,212,167,193,174,255,40,221,25,197,75,99,13,228,98,87,145,188,237,13,84,60,181,218,234,137,39,39,7,103,138,184,49,128,230,36,48,128,213,216,123,86,21,17,239,24,97,148,34,27,89,172,114,52,217,17,202,129,174,4,58,24,163,156,164,186,219,36,50,177,68,137,85,143,171,3,170,96,181,252,179,18,232,130,188,222,125,37,124,66,138,77,46,253,108,79,100,130,119,169,195,70,10,30,65,97,55,68,154,0,178,105,72,157,238,150,39,65,150,41,83,176,191,39,85,134,9,64,79,105,145,50,229,66,147,135,153,226,60,232,157,227,155,146,215,140,92,95,182,71,81,155,33,219,139,241,92,96,38,18,134,75,142,13,148,201,51,97,178,238,73,252,61,217,57,76,207,101,157,231,109,78,123,77,1,88,98,72,112,189,21,96,15,17,87,58,57,196,210,94,241,154,116,39,47,219,179,23,243,115,192,7,125,15,248,158,58,160,132,242,51,249,56,118,117,107,29,95,147,69,189,138,254,57,249,102,8,189,128,123,232,86,48,158,120,185,252,61,101,164,211,46,170,126,50,144,226,135,106,217,254,138,161,53,57,50,62,71,100,61,63,226,95,17,233,126,216,206,74,42,40,206,233,95,196,9,118,95,40,13,57,102,210,117,218,108,111,204,237,157,33,238,21,118,110,210,247,107,6,215,206,6,160,43,228,100,250,62,199,43,185,88,161,101,70,83,105,128,206,224,1,163,188,180,174,187,46,80,152,181,216,124,234,140,180,0,100,79,253,185,203,76,169,126,213,25,180,30,244,214,221,99,165,234,127,119,75,189,58,63,9,103,241,211,17,26,117,71,88,101,59,57,143,61,74,90,72,24,191,144,154,33,229,163,59,119,254,127,149,61,204,243,160,238,237,204,235,70,214,143,68,212,247,244,17,54,117,66,7,161,137,15,116,16,16,243,85,79,7,161,218,56,232,31,142,20,6,191,230,218,15,144,149,143,208,68,246,69,147,67,239,158,158,109,178,187,114,224,186,247,93,99,185,134,131,132,22,36,192,20,54,146,125,216,58,48,26,163,76,102,114,93,23,32,52,115,221,0,170,246,171,70,2,184,231,144,129,18,242,85,4,136,236,246,98,0,147,251,121,4,63,178,118,238,230,201,66,132,200,220,236,215,27,123,239,105,158,115,244,36,167,83,174,118,155,58,222,54,77,82,213,27,92,19,115,153,179,236,177,123,170,209,241,167,195,99,71,196,244,5,119,39,240,92,148,6,104,50,29,88,132,169,133,142,229,184,69,238,33,237,198,165,106,98,7,90,73,19,179,182,163,236,237,105,29,221,157,27,200,182,175,230,58,254,90,24,185,34,184,220,170,104,213,29,185,218,20,192,205,182,138,239,186,210,6,75,123,211,70,75,252,89,164,31,171,231,93,215,131,85,68,135,184,247,125,39,34,187,17,233,160,72,170,185,42,54,182,58,247,223,111,34,162,139,0,160,236,215,221,56,220,88,232,69,227,0,68,251,67,163,167,44,233,37,148,231,176,43,34,228,226,165,113,51,90,182,47,33,127,127,89,234,137,14,213,120,79,166,23,121,94,61,59,1,44,228,177,36,178,32,136,43,177,160,5,29,83,230,2,29,236,45,115,102,87,216,183,41,252,241,133,229,247,206,208,220,46,48,101,78,53,220,4,21,16,28,119,19,253,102,210,241,65,172,7,228,72,170,182,90,70,222,195,76,44,135,228,49,112,70,250,145,192,125,75,144,221,87,108,152,28,238,89,0,220,177,140,176,203,237,53,225,233,72,68,230,198,197,208,133,38,13,233,237,139,214,104,103,37,167,204,231,238,252,66,59,119,86,128,220,65,228,237,184,244,7,179,202,216,165,108,73,243,240,16,26,153,206,138,131,251,227,111,200,248,152,212,64,247,215,157,209,121,32,155,76,63,151,20,98,10,209,76,142,17,75,10,227,226,206,0,151,43,225,201,116,78,152,30,132,178,113,69,211,172,144,39,211,123,179,176,78,165,131,141,10,125,79,174,161,184,111,94,148,146,96,139,221,172,23,205,240,161,55,218,114,215,232,108,181,7,85,110,94,81,16,140,107,14,71,157,9,89,114,168,222,94,198,234,61,232,33,120,175,45,33,77,130,128,41,128,142,233,29,118,140,238,189,13,195,218,136,118,222,251,62,100,66,200,2,253,35,216,150,152,243,88,61,109,145,72,172,41,15,55,93,47,251,220,249,182,90,241,176,243,66,122,127,241,106,53,142,208,15,144,187,209,196,186,250,24,92,147,216,14,212,174,73,70,143,244,251,222,4,47,178,12,58,95,40,3,20,134,76,174,31,252,116,5,71,95,42,246,0,131,254,182,76,215,172,42,171,154,231,163,71,123,195,183,44,188,40,167,92,12,120,85,95,71,234,69,223,5,88,187,88,72,191,95,26,6,197,26,11,112,153,76,191,82,54,106,9,194,81,191,66,186,207,171,86,229,110,206,77,154,112,110,170,170,147,174,121,60,227,31,193,215,238,216,77,177,145,205,87,152,157,223,185,137,249,39,173,115,221,5,155,126,86,227,80,41,0,165,33,6,51,10,193,233,90,239,79,157,166,43,148,227,117,203,224,3,67,230,95,77,199,238,239,133,149,99,90,13,246,68,151,213,136,70,179,183,126,36,42,241,74,251,127,213,185,114,73,25,248,136,21,103,9,101,219,44,148,150,52,7,214,33,130,22,91,132,77,11,167,90,183,87,58,162,237,2,27,103,236,244,129,154,82,163,199,97,151,116,135,45,187,188,108,208,193,4,41,211,147,180,72,138,117,50,37,210,121,144,245,243,29,94,154,160,87,109,217,221,179,248,106,77,210,135,11,182,130,107,165,144,78,27,249,146,119,223,30,245,189,25,31,240,237,118,171,236,25,56,124,15,232,110,183,127,138,221,119,89,247,111,180,131,90,253,133,34,15,55,111,253,255,154,65,43,196,63,84,103,238,127,255,3,137,35,46,130,120,39,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1a08287d-cbd2-47c4-9848-cd0c2db13d7e"));
		}

		#endregion

	}

	#endregion

}

