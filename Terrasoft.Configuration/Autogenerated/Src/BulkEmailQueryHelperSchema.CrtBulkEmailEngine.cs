﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailQueryHelperSchema

	/// <exclude/>
	public class BulkEmailQueryHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailQueryHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailQueryHelperSchema(BulkEmailQueryHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ccd4ed58-7208-492c-b4ca-974036b08cbf");
			Name = "BulkEmailQueryHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd52e867-4cdd-49ef-ae6f-89b6a324e270");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,237,90,91,83,220,54,20,126,166,51,253,15,138,251,226,157,217,49,36,121,72,91,96,59,97,119,67,182,13,9,236,46,205,67,38,15,198,214,130,27,175,237,72,50,129,166,252,247,30,73,182,44,223,189,23,104,232,164,147,14,32,75,159,206,229,59,231,232,200,14,236,37,166,145,237,96,52,199,132,216,52,92,48,107,24,6,11,239,50,38,54,243,194,0,125,253,241,135,157,152,122,193,37,154,221,82,134,151,251,133,191,173,145,205,236,210,224,48,244,125,236,112,0,106,29,227,0,19,207,41,205,121,227,5,159,179,193,179,216,38,236,111,235,156,121,126,54,88,35,148,53,28,207,78,66,23,251,180,122,42,193,117,227,214,232,8,30,193,195,159,8,190,228,234,13,125,155,210,95,209,81,236,127,26,47,109,207,63,139,49,185,125,141,253,8,19,49,47,138,47,124,207,65,14,159,86,57,139,27,8,230,41,192,19,204,174,66,23,32,79,137,119,109,51,204,159,241,255,35,249,39,154,97,110,24,116,140,25,71,155,226,8,224,109,58,195,129,139,137,192,150,19,204,201,56,136,151,152,216,23,62,62,56,142,61,119,128,46,210,221,39,46,237,163,115,138,9,24,37,144,86,70,113,238,207,158,112,219,206,206,181,77,16,145,91,148,118,64,135,40,192,95,18,121,204,194,122,177,122,135,187,49,94,6,102,0,44,9,23,166,82,63,145,250,53,182,1,146,246,250,168,121,130,165,237,221,107,129,174,0,179,78,73,120,237,1,192,91,120,160,214,191,34,225,178,77,176,116,238,4,244,34,191,135,158,218,110,52,76,102,170,41,239,54,215,82,129,78,220,108,103,58,254,28,219,126,121,95,133,166,134,44,125,89,89,224,57,94,70,62,16,168,66,226,70,212,108,101,147,88,10,93,67,72,199,26,5,203,28,87,37,87,35,236,20,59,33,113,235,165,106,228,132,182,236,253,21,38,120,213,69,147,192,148,12,180,78,109,2,243,24,120,208,212,35,172,215,67,54,77,162,99,95,44,34,152,197,36,168,141,39,49,233,78,38,131,234,96,23,147,239,51,212,213,178,77,130,221,208,22,27,197,103,122,40,26,185,80,52,148,134,70,179,99,132,23,54,176,127,189,146,205,30,40,219,157,219,90,55,117,71,75,39,114,228,33,105,130,201,173,252,225,227,87,29,22,221,245,139,72,157,37,165,15,74,145,22,158,230,183,172,82,169,173,224,180,86,189,206,91,208,216,103,10,182,94,41,235,60,128,149,102,157,72,245,49,158,225,235,190,218,221,221,69,7,52,94,46,109,114,59,72,7,166,98,13,69,159,249,161,0,45,66,130,166,224,244,112,33,196,66,88,112,94,45,222,45,174,62,136,56,255,69,174,58,52,52,245,141,1,136,14,144,200,43,98,29,236,138,37,213,8,121,147,1,8,252,141,156,140,25,94,64,153,29,56,184,140,34,85,167,131,179,6,53,14,118,211,89,58,115,1,145,193,25,169,34,217,1,194,86,98,173,115,238,130,13,59,166,37,131,207,84,37,167,152,139,116,34,150,50,209,106,100,0,235,16,134,92,110,168,205,56,193,117,27,84,249,228,129,232,80,171,200,170,172,152,113,32,104,27,112,226,82,47,96,72,215,242,158,184,161,182,237,202,144,105,71,138,76,55,230,136,19,198,96,3,176,42,197,240,19,90,50,106,95,98,250,200,249,210,73,169,149,185,3,88,39,18,106,200,241,31,148,66,175,226,192,177,196,182,50,125,228,121,116,98,7,46,241,124,104,11,28,47,242,64,206,82,198,225,5,143,149,41,5,251,81,102,50,18,103,135,251,151,129,171,17,243,63,32,34,73,149,160,224,115,62,33,222,52,125,125,19,37,109,5,253,58,50,83,121,155,78,130,51,14,163,211,114,205,170,199,143,56,78,6,179,194,225,189,145,161,197,147,248,220,38,151,152,21,250,168,140,117,235,23,200,157,215,16,143,84,222,143,88,179,8,44,180,184,125,27,190,9,157,79,226,129,169,233,214,71,130,247,185,211,151,246,120,189,122,203,226,77,115,231,55,65,214,74,77,214,40,182,0,242,176,167,48,185,167,58,138,213,212,217,173,29,196,218,141,192,219,213,135,53,193,10,13,242,61,157,68,65,182,107,76,32,191,137,19,27,11,81,28,120,55,136,121,80,136,153,189,140,186,134,4,95,61,135,69,198,96,36,112,224,87,14,230,72,244,122,26,159,231,119,107,164,45,175,222,137,184,163,100,187,121,56,79,215,154,233,24,74,101,41,56,197,156,4,236,249,179,158,153,62,182,102,241,5,35,118,210,141,167,171,205,167,191,188,216,235,163,167,240,175,215,235,89,243,144,217,112,154,0,61,92,170,219,242,39,232,17,229,85,110,221,189,174,184,17,238,144,146,30,117,23,216,218,251,201,123,113,205,129,133,190,111,147,218,71,171,46,36,178,94,50,7,90,121,71,144,16,67,226,88,227,27,236,196,208,109,56,182,111,147,3,144,117,96,246,58,23,150,71,222,190,205,58,54,109,141,238,84,157,211,186,231,236,90,167,22,91,193,60,118,237,253,15,77,151,1,92,165,147,211,160,79,61,157,50,162,33,203,40,204,238,220,168,233,112,120,237,126,116,68,25,118,210,101,37,214,20,90,181,237,147,167,186,23,236,192,161,45,230,135,255,103,199,52,92,187,79,170,162,68,117,143,180,189,238,168,173,13,235,92,48,52,216,205,88,225,185,32,138,183,240,192,238,57,107,37,103,250,199,68,133,73,139,42,77,254,23,30,46,119,35,91,63,27,228,154,156,205,142,7,226,237,202,10,158,230,102,126,188,113,190,137,115,41,35,252,3,139,98,159,181,117,231,106,205,219,102,174,149,2,175,226,92,105,11,89,20,221,162,141,30,147,159,199,169,34,186,139,133,78,117,46,46,249,86,123,121,182,153,139,57,140,158,186,27,223,2,182,185,57,3,219,142,179,233,22,189,77,13,45,190,202,247,56,247,92,192,211,15,176,248,190,236,10,107,234,181,113,224,195,187,11,26,250,24,142,251,198,11,235,233,207,214,115,244,15,247,111,241,213,244,123,143,93,233,223,3,80,33,22,182,93,163,247,81,163,210,27,143,178,212,27,181,111,152,183,243,130,59,183,149,124,135,171,217,65,222,162,234,115,76,189,165,16,194,208,26,98,86,212,150,186,247,211,242,179,51,115,116,36,249,8,231,103,247,66,253,122,88,88,99,141,3,26,19,60,58,202,134,204,94,170,78,10,53,225,159,216,77,197,87,70,160,149,248,113,152,151,55,229,190,156,100,102,27,102,88,59,95,174,60,31,35,83,2,88,124,166,182,19,143,168,188,185,172,151,174,155,78,230,182,16,22,51,247,122,137,150,34,164,178,31,119,122,84,22,161,90,35,16,240,169,224,104,90,76,249,239,81,66,173,181,210,236,28,0,52,154,103,199,177,213,226,142,195,196,249,216,171,15,185,185,38,180,192,235,88,61,245,24,218,74,241,236,124,73,185,198,215,60,27,92,86,230,107,243,111,223,243,245,218,249,26,125,129,212,219,133,107,34,217,165,94,214,210,217,160,53,151,183,37,100,73,138,238,89,121,30,71,0,36,157,220,79,200,63,24,32,198,135,171,115,116,245,138,52,101,215,107,214,148,247,171,22,124,47,2,89,17,40,184,67,212,0,110,188,74,95,148,171,67,254,211,193,126,138,186,83,158,152,207,60,141,69,133,251,229,146,132,113,132,221,156,83,139,178,30,243,57,71,183,230,13,58,28,160,27,107,194,240,242,89,130,187,8,65,2,231,10,153,10,139,95,102,148,64,149,33,42,107,33,183,67,5,127,148,241,116,149,64,60,129,110,253,129,111,83,51,232,68,82,207,19,70,105,50,63,237,89,35,160,170,23,192,48,127,75,193,121,107,38,57,248,46,209,103,179,106,123,30,241,235,96,250,237,118,50,172,50,83,234,48,145,250,102,212,24,128,137,255,180,253,24,159,218,158,40,1,144,22,35,76,152,7,26,50,15,197,66,89,100,7,46,79,170,48,227,154,207,165,57,248,124,97,190,14,65,37,105,35,85,4,87,45,203,210,231,98,7,138,116,1,85,12,133,23,127,193,212,193,135,143,40,211,37,229,159,183,64,230,147,108,216,122,25,220,106,81,42,221,190,95,136,144,68,79,153,235,164,244,133,226,223,71,122,81,47,4,70,147,140,153,132,60,106,202,226,138,253,241,77,4,68,164,176,143,58,12,128,48,106,178,37,208,249,129,64,188,222,150,231,134,177,90,147,132,63,87,188,10,232,9,168,21,251,126,150,168,164,182,16,61,204,204,182,224,177,86,37,71,154,92,238,16,246,161,139,105,199,40,157,106,10,106,168,116,165,167,41,229,128,4,119,189,227,146,244,220,190,134,152,102,245,14,7,163,52,176,149,155,65,147,229,50,12,198,132,132,68,222,232,138,131,195,94,26,4,171,134,189,120,51,33,95,76,172,17,235,147,228,16,196,151,31,80,140,145,67,240,226,208,200,7,146,177,59,104,139,205,41,166,90,23,41,244,226,31,143,111,240,118,65,45,59,95,49,138,18,42,9,18,25,69,99,27,21,76,218,235,169,53,235,126,100,168,83,164,32,120,53,87,244,55,218,201,152,62,36,70,224,191,127,1,166,209,252,204,11,54,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ccd4ed58-7208-492c-b4ca-974036b08cbf"));
		}

		#endregion

	}

	#endregion

}
