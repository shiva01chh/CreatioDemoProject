namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StringLczHelperSchema

	/// <exclude/>
	public class StringLczHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StringLczHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StringLczHelperSchema(StringLczHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22");
			Name = "StringLczHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,77,111,219,48,12,61,167,64,255,3,225,237,144,0,134,125,95,211,20,88,54,116,135,118,24,150,117,59,43,10,157,104,149,37,67,31,9,150,160,255,125,148,100,103,115,236,214,7,67,34,169,199,247,248,36,197,106,180,13,227,8,63,208,24,102,117,229,138,165,86,149,216,122,195,156,208,234,250,234,116,125,53,241,86,168,109,175,164,174,181,186,25,205,24,164,56,101,222,25,220,18,0,44,37,179,246,3,172,156,161,202,7,126,252,130,178,65,19,75,202,178,132,185,245,117,205,204,159,69,187,79,105,168,180,129,131,54,207,112,16,110,7,82,115,38,197,17,193,70,20,91,116,135,203,255,78,55,126,45,5,167,18,34,206,129,135,182,195,174,147,83,236,124,102,247,136,110,167,55,196,239,91,60,157,146,151,188,98,224,30,221,37,143,226,92,92,94,86,207,27,102,88,13,138,230,123,155,73,126,252,74,139,108,241,144,206,179,181,196,196,204,66,172,67,71,146,97,207,164,199,121,25,35,227,64,222,162,33,123,20,242,224,77,182,120,162,61,240,115,0,104,187,23,252,109,12,131,86,123,195,241,145,41,182,69,147,136,133,63,232,10,186,100,0,117,76,40,208,235,223,132,61,0,52,232,188,81,118,49,47,187,85,72,245,29,72,51,10,115,163,249,39,185,63,131,194,169,219,9,219,101,219,209,228,240,212,147,6,125,165,121,87,62,66,30,110,163,48,93,77,63,122,249,252,185,102,66,174,26,41,28,245,18,27,230,180,153,205,32,220,225,201,100,207,76,231,224,63,7,90,136,247,217,208,155,226,212,178,123,41,34,241,236,230,117,152,192,2,15,48,0,153,246,133,20,191,232,78,199,7,87,124,111,165,172,136,34,105,201,35,246,100,68,96,62,78,122,150,216,180,131,137,119,135,72,12,74,19,117,184,187,27,73,145,53,75,47,201,63,76,198,220,163,66,195,228,5,179,226,19,86,109,89,14,21,147,182,107,157,172,79,173,99,228,165,125,91,168,54,233,121,197,125,138,246,131,49,22,190,191,57,205,160,214,129,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f3f34d7-0318-4d6e-85df-0dbdd9ff8f22"));
		}

		#endregion

	}

	#endregion

}

