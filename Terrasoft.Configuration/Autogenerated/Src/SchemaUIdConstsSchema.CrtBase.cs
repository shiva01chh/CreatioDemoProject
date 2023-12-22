namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SchemaUIdConstsSchema

	/// <exclude/>
	public class SchemaUIdConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SchemaUIdConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SchemaUIdConstsSchema(SchemaUIdConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5dcd2477-a927-4f24-b4d0-93f8657dbaa4");
			Name = "SchemaUIdConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e98ccaae-0bf0-40d8-a40d-46418c204c90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,206,65,111,194,32,20,7,240,179,77,250,29,136,187,232,129,105,109,169,16,179,3,165,176,236,208,100,153,115,119,214,162,35,105,169,41,52,198,44,251,238,67,221,193,158,186,23,2,225,241,39,239,215,91,109,14,96,123,182,78,53,155,48,8,3,35,27,101,143,178,84,224,93,117,157,180,237,222,61,178,214,236,245,161,239,164,211,173,9,131,239,48,152,28,251,207,90,151,192,58,223,43,65,89,75,107,193,182,252,82,141,220,189,84,62,111,157,245,169,75,114,178,88,128,135,251,186,221,0,28,116,23,215,222,108,16,156,95,126,15,7,117,74,86,173,169,207,224,185,215,21,248,56,121,56,173,26,109,118,70,59,240,4,140,58,93,95,102,211,28,229,203,72,176,28,166,57,102,48,201,86,4,18,142,48,100,140,198,66,240,116,21,167,201,116,190,249,143,239,118,142,89,188,164,104,171,190,86,162,173,43,213,13,48,24,11,138,9,70,16,101,89,14,19,178,70,144,160,44,130,40,98,148,179,104,73,240,154,142,97,178,215,194,15,211,70,1,246,86,140,97,10,169,77,161,76,63,80,32,142,4,161,132,67,74,215,94,177,244,27,225,17,135,17,91,37,44,22,36,67,228,79,241,19,6,126,221,215,47,43,141,91,231,39,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5dcd2477-a927-4f24-b4d0-93f8657dbaa4"));
		}

		#endregion

	}

	#endregion

}

