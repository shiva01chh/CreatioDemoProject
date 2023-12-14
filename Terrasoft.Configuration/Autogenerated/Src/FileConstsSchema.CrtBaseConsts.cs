namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileConstsSchema

	/// <exclude/>
	public class FileConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileConstsSchema(FileConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1");
			Name = "FileConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,95,111,155,48,20,197,159,27,41,223,225,42,125,89,31,220,64,160,105,88,183,74,105,26,170,73,211,20,173,127,246,108,240,37,177,10,6,217,102,21,138,246,221,103,155,146,132,41,235,84,141,23,139,235,115,142,127,246,181,5,45,80,85,52,69,120,64,41,169,42,51,125,254,3,147,121,85,13,7,219,225,224,164,86,92,172,225,190,81,26,139,171,225,192,84,78,37,174,121,41,96,145,83,165,62,66,204,115,92,148,66,105,229,102,171,58,201,121,10,74,83,109,134,212,106,122,146,147,173,147,237,82,98,142,57,51,49,43,231,107,231,198,99,235,0,221,84,8,196,185,21,80,193,32,231,226,89,129,85,244,87,145,72,89,41,242,6,238,106,206,156,254,193,88,31,191,48,248,12,2,95,92,249,195,232,98,18,221,44,38,241,140,120,203,165,71,110,99,223,39,209,165,127,67,60,207,191,157,122,203,40,152,45,166,163,179,171,14,225,171,89,236,47,8,255,34,176,214,163,4,193,187,8,150,66,115,221,252,7,199,62,224,40,77,24,37,233,36,51,52,136,30,97,89,75,147,88,26,54,245,208,208,164,135,52,214,94,209,53,194,79,148,202,116,78,65,153,129,222,32,100,182,87,239,102,179,242,167,215,164,59,201,217,202,68,255,73,136,179,48,77,194,128,146,48,12,124,18,78,163,128,36,140,81,66,253,112,226,207,146,32,189,136,46,15,8,231,140,113,109,242,104,14,149,44,43,148,186,129,71,133,115,86,112,241,157,175,55,90,153,13,72,115,223,53,74,16,102,124,131,81,105,105,239,125,223,190,95,96,101,115,158,104,94,227,55,147,99,160,71,125,229,104,7,53,134,79,170,46,10,42,155,235,174,16,35,178,246,212,208,53,8,84,186,193,130,58,164,243,157,107,124,104,123,155,210,6,218,243,108,251,125,223,198,117,96,221,100,135,116,138,130,181,111,207,253,255,106,223,116,175,232,106,246,251,13,37,186,201,202,29,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("92a37fd3-69e6-42f0-916f-9be6698711d1"));
		}

		#endregion

	}

	#endregion

}

