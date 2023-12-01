namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SubjectEmailHashComposerSchema

	/// <exclude/>
	public class SubjectEmailHashComposerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SubjectEmailHashComposerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SubjectEmailHashComposerSchema(SubjectEmailHashComposerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ab466a0-81cf-410f-864e-38ae3b3a01c4");
			Name = "SubjectEmailHashComposer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5e01e2a5-733f-47cc-a4c2-452cdff090f0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,219,106,227,48,16,125,118,161,255,48,116,95,108,8,206,123,111,208,36,189,4,246,198,38,165,176,165,15,138,60,113,180,200,82,208,72,217,53,165,255,222,177,172,184,233,150,234,109,206,25,157,57,58,35,35,26,164,173,144,8,75,116,78,144,93,251,114,106,205,90,213,193,9,175,172,57,62,122,62,62,202,2,41,83,195,162,37,143,13,243,90,163,236,72,42,111,209,160,83,242,108,232,57,148,113,248,25,94,222,8,233,173,83,72,220,193,61,227,241,24,206,41,52,141,112,237,101,170,167,90,16,129,116,40,60,18,96,35,148,134,141,160,13,23,202,72,29,170,78,118,107,137,212,74,35,72,107,118,232,124,135,177,110,173,140,208,64,97,245,135,141,150,251,1,227,131,9,143,51,92,139,160,253,68,153,78,40,247,237,22,237,58,159,95,119,115,238,120,204,212,54,44,142,174,24,193,119,14,9,46,224,100,209,235,125,104,57,41,158,88,113,27,86,90,73,144,209,246,103,173,112,10,19,65,248,1,231,251,207,49,137,236,139,195,154,163,133,111,232,55,182,162,83,248,25,117,123,50,205,176,252,84,167,42,132,249,181,9,13,58,193,9,156,147,119,252,144,75,184,69,127,23,99,202,239,89,152,151,105,250,101,65,120,87,142,96,48,49,91,254,232,243,45,160,91,118,150,125,85,228,7,189,148,249,5,24,252,11,135,76,94,156,197,238,157,112,251,168,185,235,138,213,119,202,183,247,94,105,42,111,212,191,135,141,242,253,31,163,60,78,41,83,56,233,122,175,95,94,85,213,47,97,106,204,7,255,115,227,209,241,30,243,255,141,119,70,222,153,239,93,103,139,193,68,178,51,74,56,154,106,198,191,136,137,100,32,1,137,159,216,170,29,184,174,72,248,82,53,248,219,154,183,123,123,32,210,47,69,122,128,67,31,156,73,57,69,232,37,173,146,199,244,219,140,53,163,145,224,243,10,252,197,13,136,119,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ab466a0-81cf-410f-864e-38ae3b3a01c4"));
		}

		#endregion

	}

	#endregion

}

