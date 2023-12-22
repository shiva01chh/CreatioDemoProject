﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailQueueMessageSchema

	/// <exclude/>
	public class BulkEmailQueueMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailQueueMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailQueueMessageSchema(BulkEmailQueueMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fddc12ac-6807-462c-a9b6-c0bf3edce34d");
			Name = "BulkEmailQueueMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,75,115,219,56,18,62,123,170,230,63,160,180,135,149,170,178,116,118,102,51,135,196,214,150,95,147,241,84,236,100,34,215,94,182,246,64,147,45,9,27,62,20,0,140,173,157,202,127,159,110,128,160,64,17,36,101,89,126,100,107,124,176,45,2,232,119,127,221,104,49,11,83,144,139,48,2,118,5,66,132,50,159,170,224,36,207,166,124,86,136,80,241,60,251,254,187,223,191,255,110,175,144,60,155,177,201,82,42,72,223,172,125,198,253,73,2,17,109,150,193,91,200,64,240,168,177,231,29,207,62,175,30,94,194,141,194,221,196,236,87,153,103,171,5,87,136,52,237,90,177,7,113,195,95,4,204,144,57,59,203,138,244,53,251,80,92,39,60,210,11,251,251,251,236,64,22,105,26,138,229,184,252,124,10,83,158,129,100,55,243,80,49,184,13,35,149,44,89,148,103,42,228,153,100,159,11,40,128,161,73,100,56,131,192,146,216,119,104,44,52,121,6,200,139,29,23,201,167,179,52,228,201,111,116,236,194,156,186,90,46,0,247,145,213,246,142,226,248,168,136,57,100,17,28,47,223,113,169,216,33,123,249,162,177,242,115,158,196,32,206,99,92,253,187,94,253,8,105,254,5,142,146,196,238,193,149,31,220,149,117,162,63,234,197,9,100,241,149,224,179,25,8,45,22,46,252,195,195,141,39,10,4,174,189,242,82,172,150,127,194,213,175,198,192,72,215,216,184,102,239,147,36,148,242,181,223,10,173,246,63,14,37,176,211,171,247,108,154,11,92,4,96,145,128,233,225,160,78,101,176,63,238,178,126,68,156,253,140,217,107,205,162,46,11,121,131,116,173,36,199,224,83,162,136,84,46,100,45,98,26,34,235,7,206,246,110,177,75,134,165,244,77,241,205,147,69,40,194,148,101,152,121,135,131,107,123,254,60,30,140,15,246,245,146,222,89,106,234,165,63,124,91,240,152,57,71,71,168,245,53,106,61,28,49,29,119,123,199,171,53,244,164,179,147,18,170,244,234,186,91,43,235,124,16,249,2,132,226,176,137,109,144,65,62,101,2,146,80,129,145,137,1,177,106,49,64,169,150,86,192,21,242,119,54,3,245,134,73,250,245,181,151,157,50,65,110,56,225,33,41,81,238,22,142,255,38,160,40,85,90,14,49,253,195,34,81,255,10,147,2,126,9,179,56,33,108,57,100,190,199,193,249,44,203,5,140,254,179,46,183,155,98,19,195,251,14,26,216,56,85,136,19,44,190,27,26,181,27,180,21,138,152,254,229,10,215,41,221,71,80,133,64,214,104,128,79,232,79,1,81,46,98,148,40,41,210,76,135,108,183,24,82,97,209,160,63,130,236,250,81,159,190,196,83,236,112,172,79,231,211,161,227,245,209,155,238,64,188,0,53,207,227,141,50,84,0,198,159,180,182,98,104,61,21,18,110,78,69,158,178,95,39,239,47,219,19,178,150,143,37,1,202,70,235,40,30,67,166,248,148,131,8,220,4,109,164,242,127,49,206,6,227,137,81,93,192,66,128,196,131,186,136,82,204,90,55,118,210,16,128,199,65,158,228,69,166,6,227,203,34,189,198,40,215,249,165,159,51,149,179,133,200,35,36,229,168,202,34,194,84,220,21,97,133,156,51,4,40,172,149,185,71,90,97,156,59,62,183,214,193,51,27,96,153,129,91,36,103,207,87,4,225,54,130,133,86,208,80,56,18,179,34,69,165,47,139,36,121,143,9,178,80,203,51,187,101,128,108,43,73,129,150,140,95,14,246,43,42,158,72,242,99,188,113,183,129,193,202,99,47,108,216,145,35,94,160,93,20,115,205,105,161,145,86,131,147,57,68,159,60,210,14,203,32,165,77,163,145,6,203,189,47,161,64,66,18,225,1,129,130,192,36,56,69,207,10,30,38,252,127,112,224,21,112,60,52,50,100,112,163,79,76,236,118,49,1,165,80,70,89,10,179,71,217,73,9,226,96,209,250,163,0,251,0,189,249,107,41,144,17,38,208,208,94,105,95,91,186,8,111,49,145,197,82,43,142,187,92,59,216,141,228,202,82,47,183,40,104,191,242,108,142,18,171,56,143,216,190,235,20,108,20,132,192,124,208,198,125,11,202,193,25,44,61,152,227,67,92,24,209,199,55,29,201,106,91,176,133,224,57,114,89,234,208,45,132,64,87,84,89,98,97,18,161,145,171,57,155,243,217,28,176,211,169,142,220,240,36,97,215,96,179,1,161,106,202,133,84,93,101,119,61,122,95,189,100,127,27,91,48,47,75,201,58,214,254,240,138,246,28,87,85,205,3,198,46,217,22,51,125,40,165,54,54,242,150,143,224,92,94,230,202,196,224,136,253,147,132,123,141,220,253,0,185,73,87,230,105,249,54,234,207,54,105,205,24,199,150,222,56,70,87,177,62,12,161,128,8,60,2,109,212,229,245,40,194,90,27,208,135,107,250,122,68,218,182,253,115,194,172,200,56,22,255,141,75,15,200,207,21,196,32,161,213,255,12,87,168,104,76,77,83,111,202,185,12,60,141,102,143,78,141,150,179,66,219,26,239,170,17,173,53,167,6,235,116,35,114,216,222,169,248,34,196,128,213,153,203,2,73,212,88,238,188,163,117,88,157,77,126,11,40,16,76,59,70,229,138,41,234,212,162,48,35,240,137,87,117,32,102,161,92,81,172,34,101,117,107,189,44,120,128,148,191,240,8,46,242,24,146,224,52,84,33,145,22,216,244,225,10,221,160,209,34,98,217,30,61,59,237,100,75,239,213,77,235,233,97,239,13,61,250,110,251,156,160,167,188,108,111,1,62,13,85,158,30,124,26,34,61,62,248,76,173,65,199,70,154,158,243,94,188,105,168,225,193,27,253,196,50,219,33,208,148,20,13,212,56,163,152,169,187,176,75,128,169,0,197,112,64,67,177,186,139,73,211,64,247,2,143,4,6,218,180,149,234,15,128,2,52,166,122,70,24,64,226,220,61,255,215,149,192,16,60,153,23,217,167,240,58,129,167,133,129,117,201,30,31,4,100,94,136,8,206,112,175,50,214,29,175,166,194,212,223,155,117,219,128,252,21,233,246,119,33,235,90,121,48,225,156,102,190,32,200,3,7,180,58,102,235,130,140,204,61,171,137,22,47,154,91,183,194,15,58,185,9,68,108,62,204,248,57,36,135,47,241,174,65,39,130,106,184,65,183,201,180,118,45,114,39,104,152,222,44,161,105,240,202,218,228,58,194,164,42,22,206,167,216,191,0,203,170,185,66,185,113,229,101,201,184,100,51,205,80,80,175,147,185,49,87,218,96,229,217,119,60,229,148,72,104,203,69,194,149,164,11,15,54,155,112,99,25,90,113,183,138,198,214,209,226,198,145,184,146,116,48,126,87,218,70,27,101,89,83,25,101,230,233,34,23,170,140,253,208,78,221,105,122,212,62,70,169,71,248,93,114,211,123,107,44,39,30,110,72,119,18,26,215,198,32,110,100,155,144,239,206,141,149,240,116,41,213,39,252,203,134,88,48,33,7,191,207,52,224,201,161,63,18,70,118,175,238,102,135,134,158,62,161,231,127,24,190,221,249,237,201,78,125,218,38,38,221,4,20,79,41,28,62,230,55,210,78,55,156,157,129,126,54,44,5,249,106,5,186,202,143,176,15,199,155,245,246,247,233,198,87,50,79,91,206,26,226,108,84,206,58,149,120,138,102,182,83,160,7,175,98,165,109,58,133,104,255,174,101,155,206,179,193,234,126,149,195,153,211,117,4,76,64,147,58,119,34,56,232,30,234,185,91,205,200,234,199,123,231,205,179,26,69,249,101,186,75,6,61,179,129,84,191,84,223,214,76,170,65,44,46,176,252,68,8,252,228,191,193,88,231,89,203,151,23,214,10,167,181,35,186,232,182,101,254,253,231,94,101,201,237,22,130,213,180,216,5,142,108,57,45,219,171,139,117,88,23,236,207,129,218,131,14,212,188,38,170,222,243,168,60,161,225,236,49,228,238,137,217,250,167,254,209,192,255,71,213,234,187,215,223,187,98,153,168,175,6,65,252,182,250,178,93,226,99,234,107,87,95,245,246,87,165,110,113,239,88,145,194,76,145,215,68,174,48,131,32,238,122,149,33,188,117,238,146,206,141,138,64,18,227,44,166,47,167,243,172,239,21,6,29,206,38,50,77,96,90,214,100,32,188,180,145,135,253,23,14,122,97,234,37,254,244,188,71,208,94,104,75,43,118,219,111,183,115,7,139,241,147,181,3,213,69,102,245,104,231,72,188,237,29,152,230,147,89,145,180,189,212,179,83,60,106,154,182,97,169,221,12,40,125,175,210,61,175,190,116,227,49,101,159,42,79,58,169,236,19,174,196,245,111,110,86,217,167,215,179,25,87,250,4,253,115,98,249,173,79,44,133,246,234,26,90,111,49,172,220,32,61,55,158,87,246,209,250,22,71,150,189,105,254,104,83,203,206,23,54,83,236,197,232,53,175,101,217,62,18,8,219,87,4,203,62,146,10,110,71,84,91,23,95,212,41,205,252,222,127,216,254,123,253,77,246,167,173,203,235,210,108,84,147,187,84,120,138,25,81,151,60,15,93,130,75,195,116,137,176,219,57,235,58,167,142,114,231,11,71,253,204,253,249,3,210,21,255,206,39,51,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fddc12ac-6807-462c-a9b6-c0bf3edce34d"));
		}

		#endregion

	}

	#endregion

}

