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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,219,106,227,48,16,125,118,161,255,48,116,95,108,8,206,123,111,208,36,189,4,246,198,38,165,176,165,15,138,61,113,180,200,82,208,72,217,53,165,255,222,145,172,184,233,150,234,109,206,25,157,57,58,35,45,90,164,173,168,16,150,104,173,32,179,118,229,212,232,181,108,188,21,78,26,125,124,244,124,124,148,121,146,186,129,69,71,14,91,230,149,194,42,144,84,222,162,70,43,171,179,161,231,80,198,226,103,120,121,35,42,103,172,68,226,14,238,25,143,199,112,78,190,109,133,237,46,83,61,85,130,8,42,139,194,33,1,182,66,42,216,8,218,112,33,117,165,124,29,100,183,134,72,174,20,66,101,244,14,173,11,24,235,54,82,11,5,228,87,127,216,104,185,31,48,62,152,240,56,195,181,240,202,77,164,14,66,185,235,182,104,214,249,252,58,204,185,227,49,83,211,178,56,218,98,4,223,57,36,184,128,147,69,175,247,161,229,164,120,98,197,173,95,41,89,65,21,109,127,214,10,167,48,17,132,31,112,190,255,28,147,200,190,88,108,56,90,248,134,110,99,106,58,133,159,81,183,39,211,12,195,79,181,178,70,152,95,107,223,162,21,156,192,57,57,203,15,185,132,91,116,119,49,166,252,158,133,121,153,186,95,22,248,119,229,8,6,19,179,229,143,62,223,2,194,178,179,236,171,36,55,232,165,204,47,64,227,95,56,100,242,226,44,118,239,132,221,71,205,93,87,172,190,147,174,187,119,82,81,121,35,255,61,108,164,235,255,24,229,113,74,153,194,73,215,123,253,242,170,174,127,9,221,96,62,248,159,107,135,150,247,152,255,111,60,24,121,103,190,119,157,45,6,19,201,206,40,225,168,235,25,255,34,38,146,129,4,36,126,98,234,110,224,66,145,240,165,108,241,183,209,111,247,246,64,164,95,138,244,0,139,206,91,157,114,138,208,75,90,37,143,233,183,25,107,70,35,17,206,43,97,181,84,134,120,3,0,0 };
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

