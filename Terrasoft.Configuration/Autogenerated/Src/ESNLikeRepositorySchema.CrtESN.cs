﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ESNLikeRepositorySchema

	/// <exclude/>
	public class ESNLikeRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ESNLikeRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ESNLikeRepositorySchema(ESNLikeRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eec8a1cc-ca56-42e8-bd6a-b4f46ded958c");
			Name = "ESNLikeRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b66b5ae8-46e0-4931-ad78-c2c1ba5fd6ea");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,89,91,111,219,54,20,126,246,128,253,7,206,123,168,12,4,242,123,234,120,112,28,39,48,150,6,93,211,174,15,195,48,208,18,109,115,149,72,149,164,156,10,69,254,251,14,47,146,40,201,86,226,180,235,82,172,40,154,136,58,231,240,92,190,115,83,25,78,137,204,112,68,208,91,34,4,150,124,173,194,57,103,107,186,201,5,86,148,179,112,113,123,131,62,255,248,195,32,151,148,109,208,109,33,21,73,95,182,158,129,37,73,72,164,233,101,120,69,24,17,52,234,208,92,83,246,177,62,156,243,52,229,204,127,22,164,249,20,46,152,162,138,18,217,58,190,196,145,226,194,158,195,155,159,5,217,192,189,104,201,20,17,107,176,228,20,45,23,146,93,211,15,228,13,201,184,164,64,92,24,202,44,95,37,52,66,180,36,220,67,103,44,133,191,131,241,120,140,38,50,79,83,44,138,105,121,48,23,4,43,130,114,73,196,11,137,18,224,68,107,46,16,120,80,226,13,9,43,190,113,155,113,146,97,129,83,196,192,217,103,67,205,190,140,135,211,119,240,19,209,24,169,45,86,232,142,38,137,22,28,27,137,145,189,72,223,16,78,198,134,121,191,44,119,181,22,247,202,254,250,20,137,130,168,92,48,57,253,29,39,57,65,124,237,168,227,146,188,124,175,25,174,114,184,96,22,199,218,111,129,121,176,246,156,32,243,80,41,52,178,209,217,239,200,11,146,144,111,226,200,216,94,244,21,29,217,43,241,24,71,174,56,79,156,35,190,200,151,111,172,204,146,218,186,83,26,93,181,180,167,56,19,98,210,48,126,69,172,253,138,163,53,77,32,123,236,29,143,244,168,28,78,175,169,84,218,29,165,142,47,158,40,191,244,223,68,18,162,125,187,62,27,250,101,203,171,25,246,151,98,56,158,82,38,21,102,144,237,81,85,163,90,145,88,46,88,158,18,129,87,9,153,88,182,41,186,34,74,123,66,71,70,158,23,14,18,178,17,36,205,218,224,213,47,167,117,212,228,163,194,230,229,128,124,74,18,60,4,220,231,233,219,247,91,174,93,27,59,149,131,46,222,7,247,182,186,19,22,219,2,223,40,246,243,4,75,121,138,246,215,249,182,191,245,243,107,193,119,52,6,23,227,140,26,55,243,140,216,6,7,253,0,197,88,225,21,150,182,10,29,112,128,223,19,111,121,68,113,162,175,30,162,113,121,69,35,80,230,128,178,45,116,66,21,243,200,82,253,113,65,214,56,79,212,57,101,49,180,179,64,21,25,225,235,160,219,134,70,163,63,235,126,21,105,91,187,166,162,125,125,78,247,47,237,246,202,79,220,68,72,129,175,94,11,186,131,90,100,223,103,246,1,226,6,239,145,84,66,119,87,39,205,134,233,54,218,146,20,223,0,198,208,25,26,122,6,191,244,249,161,188,197,156,37,5,210,201,2,151,49,11,2,244,87,222,120,118,137,208,10,102,105,96,199,138,160,37,173,41,108,100,154,244,96,208,186,3,212,236,92,58,112,40,170,252,241,138,168,45,143,15,121,195,90,142,46,33,60,189,229,216,41,176,195,2,17,171,187,245,22,168,0,216,94,248,71,129,193,114,131,22,168,26,92,161,29,43,236,229,65,203,42,143,29,98,21,83,51,98,129,4,70,238,208,5,53,36,128,184,137,141,224,9,226,171,191,129,111,234,20,28,124,70,67,237,202,225,137,179,4,221,159,84,47,108,72,93,2,2,69,101,30,186,55,52,247,246,102,155,204,165,198,225,37,81,209,246,82,240,244,226,60,168,21,58,65,107,156,72,50,66,191,84,70,158,34,150,39,137,31,131,166,151,157,199,186,254,66,103,211,54,124,66,159,229,21,102,160,166,128,49,83,45,93,249,57,47,52,78,131,3,248,29,29,64,223,30,76,112,5,23,146,184,167,108,195,228,163,139,93,158,50,93,81,205,228,242,49,39,162,120,108,185,214,28,191,105,134,225,180,212,254,80,193,233,86,92,107,147,101,31,79,253,10,158,149,170,163,29,21,42,199,9,218,241,122,78,51,28,115,163,181,12,58,162,80,165,83,9,236,234,32,132,52,209,182,120,2,194,165,156,37,119,184,144,183,68,87,124,128,162,18,57,121,217,226,131,139,45,121,96,1,56,234,33,104,2,177,143,210,38,74,124,94,56,170,251,7,2,229,26,222,170,48,240,215,125,17,179,184,30,148,116,177,127,54,17,60,186,177,227,56,246,219,122,120,36,28,46,13,87,47,28,14,213,189,58,54,78,136,142,81,96,11,75,253,206,6,203,82,188,167,106,251,90,107,71,204,157,150,116,96,223,193,34,8,138,83,201,217,91,104,135,225,226,35,168,235,170,212,160,93,164,220,113,165,145,125,30,153,31,255,3,72,28,94,120,250,192,208,59,153,215,208,146,255,5,182,202,6,219,59,70,127,123,216,217,166,233,158,172,142,93,168,61,163,60,144,225,28,75,53,113,221,63,24,133,111,249,12,48,87,4,163,227,50,228,150,40,89,182,183,157,222,97,109,70,232,97,195,108,176,71,228,131,219,17,234,132,128,245,239,152,213,162,23,193,86,69,179,101,107,12,227,172,84,90,191,150,38,165,173,250,143,0,46,216,124,67,238,52,118,231,158,84,135,93,84,155,114,210,55,111,249,10,149,120,5,207,17,28,109,81,96,135,183,138,64,47,28,251,232,7,245,93,33,40,229,105,19,120,228,225,175,4,84,241,15,204,191,14,146,247,254,204,251,224,188,99,198,111,15,14,237,125,165,28,208,31,253,205,199,89,98,223,134,243,45,137,62,204,196,6,50,155,169,69,154,193,116,171,227,3,27,143,37,24,57,165,43,254,30,142,250,14,111,34,174,29,6,99,136,153,218,75,189,154,171,228,96,64,215,40,240,168,127,58,51,211,105,229,121,181,21,252,206,192,124,169,72,58,75,244,90,83,44,62,81,169,22,159,34,146,233,168,7,181,135,143,30,254,27,122,30,61,251,55,97,1,43,100,3,167,141,5,161,62,127,112,69,8,42,227,63,55,171,11,52,152,198,50,80,111,12,239,108,251,169,151,137,106,79,48,191,28,72,36,63,131,26,176,239,88,7,242,103,113,74,217,27,186,217,42,109,193,85,194,87,56,153,101,25,136,86,160,188,132,245,3,195,58,66,154,148,75,182,72,87,68,183,172,107,190,177,31,158,155,94,195,59,18,200,50,163,192,129,70,129,83,183,179,52,214,28,143,203,141,190,158,45,157,242,121,40,95,142,249,180,247,189,164,204,89,111,202,220,112,117,201,115,22,239,75,151,189,222,181,222,9,186,45,233,144,79,255,181,143,116,95,24,0,217,100,185,1,31,117,2,32,71,221,175,0,143,250,98,80,77,17,46,157,59,3,85,208,144,230,56,247,109,125,245,142,215,165,41,199,53,111,56,235,128,66,118,102,158,175,154,173,30,64,140,116,55,224,232,37,223,218,92,255,7,211,254,42,249,5,16,122,224,91,164,195,199,147,51,238,187,136,119,59,249,159,121,152,253,209,102,207,135,98,115,2,127,254,1,228,26,103,52,221,28,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eec8a1cc-ca56-42e8-bd6a-b4f46ded958c"));
		}

		#endregion

	}

	#endregion

}
