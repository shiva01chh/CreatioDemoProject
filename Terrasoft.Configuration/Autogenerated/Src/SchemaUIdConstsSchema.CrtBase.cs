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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,206,65,111,194,32,20,7,240,179,77,250,29,136,187,232,129,89,106,169,16,179,3,165,176,236,208,100,153,115,119,214,162,35,105,169,41,109,140,89,246,221,135,186,131,61,185,23,2,225,241,39,239,55,56,99,247,96,115,114,189,110,214,97,16,6,86,53,218,29,84,169,193,187,238,58,229,218,93,255,200,91,187,51,251,161,83,189,105,109,24,124,135,193,228,48,124,214,166,4,174,247,189,18,148,181,114,14,108,202,47,221,168,237,75,229,243,174,119,62,117,78,78,22,11,240,112,91,215,27,128,163,238,226,210,155,141,130,243,243,239,241,160,78,171,170,181,245,9,60,15,166,2,31,71,15,103,85,99,236,214,154,30,60,1,171,143,151,151,217,52,199,121,132,36,207,97,154,19,14,147,44,166,144,10,76,32,231,108,41,165,72,227,101,154,76,231,235,255,248,174,231,61,139,151,20,109,53,212,90,182,117,165,187,17,134,16,201,8,37,24,226,44,203,97,66,87,24,82,156,33,136,17,103,130,163,136,146,21,187,135,201,94,11,63,204,88,13,248,91,113,15,83,40,99,11,109,135,145,2,11,44,41,163,2,50,182,242,138,200,111,84,32,1,17,143,19,190,148,52,195,244,79,241,19,6,126,249,250,5,222,144,51,101,30,2,0,0 };
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

