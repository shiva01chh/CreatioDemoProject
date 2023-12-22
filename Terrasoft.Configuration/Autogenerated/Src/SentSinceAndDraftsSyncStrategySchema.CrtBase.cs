namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SentSinceAndDraftsSyncStrategySchema

	/// <exclude/>
	public class SentSinceAndDraftsSyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SentSinceAndDraftsSyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SentSinceAndDraftsSyncStrategySchema(SentSinceAndDraftsSyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55");
			Name = "SentSinceAndDraftsSyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50cc600a-f6aa-433b-8a0a-6a453519907c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,84,77,111,218,64,16,61,19,41,255,97,228,94,64,162,184,103,18,144,26,112,165,72,13,74,101,56,85,61,44,246,216,93,213,222,181,102,199,85,44,196,127,239,248,3,98,40,16,14,200,59,251,102,230,205,123,99,27,149,163,43,84,132,176,70,34,229,108,194,147,23,165,179,251,187,221,253,221,160,116,218,164,189,155,133,53,137,78,75,82,172,173,121,184,8,32,188,22,159,4,134,53,107,116,87,1,223,84,196,150,90,132,96,62,17,166,210,7,22,153,114,110,10,33,26,14,181,137,240,171,137,151,164,18,118,97,101,162,144,133,13,166,85,147,225,251,62,60,186,50,207,21,85,243,227,25,17,34,194,100,230,61,247,19,60,127,14,58,47,50,204,165,174,210,108,205,24,98,204,244,95,36,140,33,33,155,247,83,151,146,243,164,28,198,71,22,103,181,38,135,118,254,121,127,66,57,254,113,135,243,237,49,160,148,30,192,22,28,102,24,49,168,44,3,99,249,179,48,67,150,27,113,203,169,20,221,184,171,230,234,74,2,54,12,177,20,120,103,209,235,250,115,137,137,42,51,126,210,38,22,213,135,92,21,104,147,225,137,26,163,49,172,100,21,96,6,222,109,130,222,232,151,148,44,202,109,166,35,136,106,103,62,154,104,10,183,197,147,114,187,198,189,163,225,175,100,11,36,174,166,245,19,139,12,24,183,128,115,127,59,65,21,69,191,1,223,10,18,113,234,124,70,241,181,83,227,127,83,6,197,161,40,88,49,155,116,44,2,50,213,251,184,49,78,136,189,184,180,173,249,163,68,170,160,126,17,6,131,20,185,123,26,16,114,73,6,188,205,106,25,124,15,214,193,18,194,96,181,14,159,87,139,0,118,95,246,222,67,3,219,215,255,251,110,48,52,113,59,219,233,160,242,62,73,231,178,222,122,89,240,215,70,212,27,147,46,8,101,42,215,223,203,15,204,170,119,92,90,40,1,92,17,163,137,20,138,84,14,70,22,96,230,201,2,146,240,50,162,144,80,244,230,27,57,67,116,12,76,30,253,6,125,57,185,150,47,68,102,17,211,121,243,30,207,250,155,178,181,111,97,255,190,79,174,95,181,91,174,219,163,13,55,39,60,225,148,246,24,154,143,77,5,125,66,163,198,151,41,108,101,21,135,231,248,19,96,235,244,101,243,218,104,63,40,145,254,239,31,52,34,145,13,83,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6a52f3c-de2d-4d94-bc45-c093e0898f55"));
		}

		#endregion

	}

	#endregion

}

