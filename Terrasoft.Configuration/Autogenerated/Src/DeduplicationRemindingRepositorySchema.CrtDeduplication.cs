﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationRemindingRepositorySchema

	/// <exclude/>
	public class DeduplicationRemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationRemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationRemindingRepositorySchema(DeduplicationRemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("83eb30ef-0df2-4d49-92a6-110d73fd6775");
			Name = "DeduplicationRemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,203,110,219,58,16,93,187,64,255,129,85,55,50,96,200,65,129,108,146,52,69,109,55,169,129,166,247,34,118,238,230,162,11,86,26,89,44,36,82,32,41,183,70,144,127,239,240,33,89,82,236,88,109,2,216,166,120,230,112,30,103,134,226,180,0,85,210,24,200,26,164,164,74,164,58,154,11,158,178,77,37,169,102,130,71,11,72,170,50,103,177,93,189,126,245,248,250,213,168,82,140,111,200,106,167,52,20,151,189,53,90,231,57,196,6,172,162,91,224,32,89,252,12,179,134,95,122,255,176,125,114,81,8,126,120,71,194,177,231,209,13,141,181,144,12,20,34,16,51,157,78,201,149,170,138,130,202,221,181,95,47,32,165,85,174,9,43,202,28,10,224,218,134,67,68,138,72,0,18,75,72,223,7,203,78,172,247,80,48,158,224,113,247,80,10,197,240,132,93,48,173,249,174,166,173,3,254,247,236,51,135,15,245,174,4,145,134,39,233,198,227,111,104,93,86,223,17,67,226,156,42,69,78,153,144,11,114,146,22,57,31,109,34,70,111,37,108,76,152,55,12,242,68,93,144,127,37,219,82,13,110,179,116,11,18,99,165,48,49,92,227,225,42,150,172,52,180,107,12,97,165,37,242,126,1,190,209,25,121,79,222,157,159,93,30,182,91,85,223,127,96,201,231,244,152,233,249,217,217,165,247,8,120,226,156,234,122,120,7,58,19,71,93,84,166,92,49,126,25,86,114,11,186,137,250,51,85,89,184,96,86,111,88,141,43,7,153,16,97,61,186,38,73,179,53,38,70,186,163,209,150,74,67,132,94,113,248,73,156,163,179,138,229,9,200,112,108,3,28,165,40,42,26,103,36,116,44,100,75,243,10,48,210,22,91,244,159,121,166,106,210,17,50,70,31,203,18,163,11,45,218,51,61,217,79,9,186,146,166,10,57,60,104,150,51,141,82,197,222,208,119,139,115,235,255,39,30,11,19,76,244,192,25,254,2,179,55,219,105,80,161,161,93,11,231,100,56,30,59,214,167,151,146,179,150,21,71,101,248,10,132,254,169,18,149,140,97,98,171,149,219,170,212,158,123,223,28,32,242,21,187,246,32,242,161,222,192,18,59,170,240,108,210,48,92,248,221,182,87,167,11,108,229,238,54,109,39,49,158,225,144,208,137,136,135,182,97,52,199,250,104,104,118,176,45,175,109,70,92,39,109,5,75,72,15,18,62,40,144,56,216,184,27,77,164,234,44,39,117,246,100,141,111,181,194,164,169,112,7,225,69,223,152,170,56,131,130,126,197,121,90,167,182,57,124,111,244,137,107,166,119,94,123,123,231,186,222,120,237,24,161,22,148,211,13,24,177,118,33,70,33,43,123,224,157,67,132,129,163,238,60,12,60,211,210,175,151,56,123,137,166,114,83,27,35,175,63,193,16,154,237,217,206,68,16,182,130,113,20,127,224,200,60,103,56,95,81,202,250,180,51,185,160,216,119,39,156,9,22,94,13,160,86,64,101,156,125,21,154,165,94,30,107,27,206,23,203,19,180,50,167,92,121,144,116,31,139,219,93,32,209,154,21,96,35,105,22,207,2,155,87,82,154,56,148,243,199,47,107,124,61,42,110,43,212,154,183,212,120,13,45,147,151,153,26,216,222,83,156,163,9,179,162,116,178,120,97,154,249,97,227,191,70,193,199,10,155,74,6,147,174,7,110,247,105,66,26,156,223,58,13,92,217,126,70,92,163,205,185,153,242,42,106,214,14,225,14,62,200,208,185,11,144,201,23,226,0,114,167,218,154,69,104,91,154,209,195,158,221,141,82,151,49,223,109,25,206,77,204,215,179,171,160,73,166,175,207,94,6,253,198,117,251,44,37,225,155,94,123,70,55,160,227,236,70,138,98,49,11,79,85,4,255,3,115,50,186,111,125,122,34,24,99,74,115,5,227,230,114,232,243,175,64,227,27,3,190,40,85,5,119,247,72,216,185,47,246,78,247,167,121,61,115,94,190,113,61,217,129,99,91,103,134,193,29,94,58,41,131,228,31,238,133,81,139,123,160,125,45,130,190,172,6,154,55,248,191,180,119,74,180,230,3,213,58,144,216,89,155,68,252,93,94,90,119,7,18,28,186,82,134,70,120,164,151,6,154,119,198,36,74,228,96,170,250,160,246,122,112,198,90,13,48,52,180,110,243,91,215,250,237,63,144,202,205,126,203,208,190,78,254,128,97,169,238,129,26,123,215,183,71,140,232,182,158,250,135,95,117,236,83,252,48,127,191,1,42,112,85,28,87,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("83eb30ef-0df2-4d49-92a6-110d73fd6775"));
		}

		#endregion

	}

	#endregion

}

