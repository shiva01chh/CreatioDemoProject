namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysCultureServiceSchema

	/// <exclude/>
	public class SysCultureServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysCultureServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysCultureServiceSchema(SysCultureServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff");
			Name = "SysCultureService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,79,227,48,16,61,7,137,255,48,42,151,86,42,201,29,10,18,116,5,218,149,186,84,180,21,135,106,15,110,50,41,22,137,29,60,118,170,104,181,255,125,253,145,166,129,162,226,219,60,191,121,51,243,102,4,43,145,42,150,34,44,81,41,70,50,215,241,84,138,156,111,141,98,154,75,113,126,246,247,252,44,50,196,197,22,22,13,105,44,175,63,197,241,2,85,205,83,156,201,12,139,147,159,241,93,170,121,237,101,79,243,94,112,115,32,28,26,179,176,109,174,44,125,186,253,191,80,184,181,90,48,45,24,209,149,83,154,154,66,27,133,173,152,39,37,73,2,19,50,101,201,84,115,219,198,115,37,107,158,33,193,14,55,151,20,200,144,75,5,59,169,222,96,199,245,43,228,200,156,18,197,123,137,164,167,177,110,11,88,167,180,98,169,254,227,176,59,170,126,163,182,253,85,118,194,13,47,184,110,158,241,221,112,133,37,10,77,195,126,224,198,132,27,248,38,197,177,226,22,200,70,174,72,101,54,5,79,33,117,3,31,207,11,87,112,207,232,48,125,228,86,215,185,52,67,253,42,51,235,211,220,139,120,115,142,220,241,192,51,90,81,65,144,97,206,108,1,72,67,21,48,130,191,27,180,198,9,205,115,142,42,238,20,146,207,18,19,21,52,110,127,124,167,49,73,246,84,151,187,126,170,48,28,94,223,219,104,109,87,255,83,212,242,13,135,97,12,107,222,96,254,180,88,14,198,176,82,124,137,101,85,48,237,44,29,60,162,110,107,182,230,88,202,189,204,154,133,110,10,71,176,74,51,36,98,91,236,208,248,69,177,170,194,108,236,74,69,206,112,36,253,32,85,201,244,135,132,0,197,191,72,138,177,53,137,42,41,8,79,243,252,214,246,107,123,52,60,131,163,254,134,35,240,123,138,106,166,128,186,157,174,180,187,7,110,143,244,6,4,238,122,219,238,126,134,43,123,187,214,39,129,169,115,108,116,237,101,130,157,95,41,197,95,212,246,57,255,194,49,92,160,200,194,177,248,56,160,31,65,139,245,222,127,51,144,33,82,62,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a4865d94-8357-4f78-a417-9cd6dcdf4fff"));
		}

		#endregion

	}

	#endregion

}

