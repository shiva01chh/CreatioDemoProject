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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,206,65,111,194,32,20,7,240,179,77,250,29,136,187,232,129,85,180,180,16,179,3,165,176,236,208,100,153,115,119,214,162,35,105,169,41,109,140,89,246,221,135,186,131,61,185,23,2,225,241,39,239,55,56,99,247,96,115,114,189,110,214,97,16,6,86,53,218,29,84,169,193,187,238,58,229,218,93,255,200,91,187,51,251,161,83,189,105,109,24,124,135,193,228,48,124,214,166,4,174,247,189,18,148,181,114,14,108,202,47,221,168,237,75,229,243,174,119,62,117,78,78,162,8,60,220,214,245,6,224,168,27,93,122,179,81,112,126,254,61,30,212,105,85,181,182,62,129,231,193,84,224,227,232,225,172,106,140,221,90,211,131,39,96,245,241,242,50,155,230,56,95,32,201,115,152,228,132,195,56,91,82,72,5,38,144,115,182,146,82,36,203,85,18,79,231,235,255,248,174,231,61,139,151,20,109,53,212,90,182,117,165,187,17,134,16,201,8,37,24,226,44,203,97,76,83,12,41,206,16,196,136,51,193,209,130,146,148,221,195,100,175,133,31,102,172,6,252,173,184,135,41,148,177,133,182,195,72,129,5,150,148,81,1,25,75,189,98,225,55,42,144,128,136,47,99,190,146,52,195,244,79,241,19,6,126,157,235,23,208,202,217,83,31,2,0,0 };
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

