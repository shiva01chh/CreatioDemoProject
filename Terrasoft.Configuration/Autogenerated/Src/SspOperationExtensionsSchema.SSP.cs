namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspOperationExtensionsSchema

	/// <exclude/>
	public class SspOperationExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspOperationExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspOperationExtensionsSchema(SspOperationExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd");
			Name = "SspOperationExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,147,193,110,219,48,12,134,207,46,208,119,224,188,139,3,20,242,125,77,2,172,105,182,203,134,21,240,246,0,138,66,219,66,109,201,16,233,38,89,219,119,159,36,59,70,146,174,195,124,16,44,146,250,249,81,164,140,108,145,58,169,16,126,162,115,146,108,201,98,101,77,169,171,222,73,214,214,136,162,120,184,190,122,190,190,74,122,210,166,130,226,64,140,173,40,80,245,78,243,225,118,114,156,158,111,91,107,254,238,113,248,158,93,220,223,121,151,119,126,116,88,249,196,176,106,36,209,39,40,168,251,209,225,0,179,222,51,26,242,63,20,35,243,60,135,57,245,109,43,221,97,57,238,227,41,40,173,131,157,117,143,33,205,78,115,13,242,73,234,70,110,26,4,123,20,35,240,73,136,58,113,84,202,79,164,186,126,211,104,5,196,62,84,129,138,162,239,145,36,207,145,230,13,206,192,83,163,122,36,208,37,112,141,208,19,58,168,37,129,211,85,205,4,108,161,149,70,86,24,64,162,151,196,36,149,95,106,205,59,233,100,11,198,247,108,145,210,216,129,181,169,180,193,116,121,236,8,96,52,120,18,68,80,14,203,69,122,127,87,156,7,231,203,121,30,181,162,244,121,173,79,86,111,7,234,149,52,223,35,156,47,252,87,64,203,184,214,4,151,106,112,78,50,131,48,44,73,178,177,182,1,37,205,231,109,171,141,38,246,247,134,176,184,8,22,95,145,125,154,245,222,91,25,167,219,205,210,41,119,76,156,206,224,229,37,170,38,255,127,254,52,241,131,117,44,155,81,235,54,42,249,142,100,31,46,248,142,236,9,215,206,238,192,224,14,166,90,247,10,187,168,237,67,253,88,137,47,214,181,146,179,16,243,205,42,217,232,223,97,188,138,232,204,210,243,217,78,111,6,217,228,77,43,196,164,43,86,189,115,104,56,64,122,122,99,121,172,42,2,78,165,165,179,27,248,103,117,99,121,175,97,13,203,235,240,168,208,108,135,119,21,182,222,118,250,253,1,172,200,55,40,5,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("63085386-1dd0-42f1-b47d-9c7bcf45cfbd"));
		}

		#endregion

	}

	#endregion

}

