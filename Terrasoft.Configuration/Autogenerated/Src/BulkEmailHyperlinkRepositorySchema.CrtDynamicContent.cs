﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailHyperlinkRepositorySchema

	/// <exclude/>
	public class BulkEmailHyperlinkRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailHyperlinkRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailHyperlinkRepositorySchema(BulkEmailHyperlinkRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a9f4225e-4fcb-41ae-9373-d905f499b7e8");
			Name = "BulkEmailHyperlinkRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7b5cce97-2e1e-4b17-90ca-f9813022e3eb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,88,89,115,27,55,12,126,86,102,242,31,24,101,38,179,219,122,86,153,246,45,178,148,198,71,108,77,236,196,141,228,246,193,118,51,244,46,100,177,222,203,36,87,177,26,231,191,23,36,247,224,30,58,58,153,250,197,38,9,124,0,129,143,0,214,49,141,64,164,212,7,50,3,206,169,72,230,210,59,76,226,57,187,203,56,149,44,137,159,63,251,246,252,89,47,19,44,190,35,211,149,144,16,13,27,107,148,15,67,240,149,176,240,78,32,6,206,252,150,204,25,139,31,90,155,51,120,148,222,103,184,203,66,202,143,31,83,14,66,40,16,37,55,24,24,201,115,26,7,156,133,225,20,248,146,249,80,65,28,38,188,177,242,142,14,112,3,183,94,114,184,67,28,114,24,82,33,222,144,131,44,188,63,142,40,11,79,87,41,240,144,197,247,159,33,77,4,147,9,95,105,249,193,96,64,246,69,22,69,148,175,198,249,250,130,39,75,22,128,32,17,200,69,18,8,34,19,34,232,18,200,162,0,17,100,206,147,136,224,61,210,144,74,240,10,160,129,133,148,102,183,33,243,137,175,28,217,226,71,239,155,246,165,114,30,3,33,105,44,241,2,23,156,45,209,130,57,79,205,130,248,234,156,8,201,213,245,191,72,78,253,251,73,240,123,6,124,117,65,57,38,85,2,255,136,191,200,136,244,111,211,72,159,179,160,63,92,15,193,33,69,95,233,90,136,252,124,19,196,67,77,87,96,102,225,49,189,160,18,23,49,162,252,214,119,222,190,185,126,251,116,253,138,70,233,245,240,233,149,235,56,87,127,189,186,30,142,110,126,118,71,234,207,209,203,155,159,92,119,147,137,219,86,16,103,244,54,132,220,207,24,127,37,115,167,29,105,119,152,71,23,144,78,58,192,245,104,191,103,16,6,235,66,205,129,6,73,28,174,200,165,0,142,121,137,13,217,201,151,172,182,222,98,66,39,148,103,62,166,91,25,210,204,48,18,77,254,233,141,73,204,36,163,33,251,7,57,72,73,12,95,9,211,132,192,151,154,204,137,92,0,170,0,70,135,195,124,212,223,68,173,254,96,108,8,232,149,182,6,77,99,251,169,74,154,14,223,168,95,191,85,127,60,67,91,106,79,101,34,223,244,246,7,90,67,3,228,36,223,228,131,211,136,92,221,132,75,84,137,233,245,26,241,196,124,182,2,220,235,125,223,28,229,115,243,92,215,100,114,153,176,0,203,2,80,222,246,86,56,39,25,158,150,4,155,4,133,95,75,202,73,0,33,114,90,81,12,51,113,164,23,78,195,95,87,11,247,188,247,88,22,156,77,68,45,4,255,92,0,7,167,74,222,36,232,187,222,68,28,63,100,52,116,176,168,102,81,236,149,175,201,177,29,115,117,40,122,198,41,239,248,17,252,12,253,113,237,0,21,87,102,177,36,39,32,39,177,44,161,254,160,97,6,206,17,211,94,35,13,246,205,227,218,203,31,217,152,232,119,92,44,201,67,171,34,20,129,97,115,226,188,208,199,170,103,72,138,12,253,0,43,167,67,161,208,232,113,144,25,22,131,215,230,2,223,203,248,26,91,218,51,12,178,70,184,106,227,220,24,53,188,147,55,211,71,2,28,75,115,143,36,153,36,10,14,37,244,78,30,168,220,106,177,219,21,167,13,225,192,240,105,47,68,110,139,100,156,217,220,136,168,244,23,248,76,71,68,87,60,239,220,172,29,20,219,219,92,20,247,140,198,167,212,52,207,195,36,74,89,8,65,238,117,137,93,53,88,180,145,91,243,14,169,144,251,218,212,216,177,20,176,137,102,161,44,136,186,246,82,133,202,28,27,39,245,23,196,41,141,97,148,154,86,203,236,41,161,180,209,27,46,57,243,46,99,16,62,77,225,136,74,58,213,6,28,13,225,157,240,36,75,197,213,47,55,158,73,135,55,75,206,146,175,192,39,49,66,49,108,111,133,31,117,232,130,7,187,96,255,90,96,15,11,134,169,0,92,213,220,188,65,172,58,184,205,191,156,29,70,177,139,27,186,108,76,177,251,151,111,185,85,43,246,72,121,166,28,173,198,4,155,40,25,15,209,145,242,189,95,202,232,20,66,148,195,25,40,74,150,128,107,85,59,240,210,78,169,238,93,242,208,202,174,38,19,98,84,148,204,106,231,216,167,103,102,20,48,66,237,103,159,191,237,245,19,67,29,237,179,233,250,231,84,220,111,67,92,59,64,88,136,152,200,156,198,134,135,88,238,62,102,97,248,137,31,71,169,92,89,215,62,52,130,46,121,171,163,246,134,180,142,42,80,44,59,192,11,202,79,244,98,93,109,70,239,147,157,106,243,20,100,189,50,239,145,205,21,217,214,203,61,236,210,201,3,80,151,199,28,119,201,170,212,214,253,169,229,163,211,165,154,68,75,59,231,198,26,205,252,180,232,46,168,244,46,8,152,46,32,161,145,23,142,137,245,158,149,142,150,140,91,20,105,37,185,185,57,77,65,85,24,69,43,243,151,230,206,251,4,19,151,174,154,141,89,36,25,247,225,192,126,114,122,95,82,126,7,242,160,187,109,11,99,192,80,195,216,88,71,13,227,125,187,239,182,241,93,239,157,104,180,237,58,70,73,128,230,190,74,116,115,175,145,212,142,227,34,107,205,163,83,42,22,253,255,121,234,104,69,29,91,57,21,121,40,77,162,77,140,189,105,10,62,155,175,62,98,129,247,239,79,177,213,10,167,222,125,69,165,179,251,16,151,72,212,129,96,195,160,140,52,21,122,30,166,37,17,113,82,213,76,220,117,226,53,84,53,147,110,78,91,123,192,109,201,151,228,207,25,111,52,203,221,194,60,9,202,246,91,31,152,139,91,145,37,227,18,195,158,55,152,174,247,102,202,25,41,158,93,71,67,79,110,255,70,176,49,105,58,85,13,105,78,243,136,140,240,65,96,217,37,79,79,228,69,243,208,123,23,175,156,230,192,102,183,203,124,100,208,19,67,169,92,50,70,141,15,235,92,41,106,130,42,71,109,77,15,103,199,142,194,212,33,104,250,189,107,57,181,51,161,182,125,118,169,46,111,232,164,158,18,1,69,122,251,155,95,38,36,192,254,126,75,5,236,202,46,171,77,24,162,88,200,44,128,88,178,57,195,75,109,103,220,153,242,160,193,53,209,245,41,86,167,21,222,104,151,175,157,198,4,115,117,67,42,163,69,2,215,126,58,217,173,112,88,126,27,84,0,54,227,170,93,239,12,226,59,185,80,135,175,255,43,225,74,158,213,28,236,213,167,180,218,245,170,145,172,77,156,78,46,96,23,98,72,6,251,63,62,9,215,157,196,202,160,249,255,147,41,147,181,253,152,225,96,100,39,120,71,186,180,42,110,127,60,221,1,125,35,125,90,61,172,63,190,108,34,232,127,43,104,57,219,144,143,157,120,43,197,84,187,94,75,177,31,235,219,219,70,131,14,244,54,176,201,119,53,29,110,30,4,126,100,70,180,70,191,124,170,107,15,109,245,65,172,221,197,115,239,76,8,138,131,206,49,170,81,238,204,110,125,19,247,212,207,191,120,34,225,103,231,21,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a9f4225e-4fcb-41ae-9373-d905f499b7e8"));
		}

		#endregion

	}

	#endregion

}

