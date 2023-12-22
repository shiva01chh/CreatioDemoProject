namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailSchema

	/// <exclude/>
	public class CheckedEmailSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailSchema(CheckedEmailSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("29627a54-240f-4b4f-a2e5-afc88eca3ba7");
			Name = "CheckedEmail";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,49,79,195,48,16,133,231,70,234,127,56,181,11,44,201,78,128,37,84,136,161,168,106,216,16,66,78,114,77,45,98,59,186,187,12,165,226,191,227,56,109,73,43,6,240,118,207,239,249,62,63,171,12,114,171,74,132,23,36,82,236,54,18,103,206,110,116,221,145,18,237,108,156,45,242,165,171,176,225,105,180,159,70,211,104,210,177,182,53,228,59,22,52,241,186,179,162,13,198,57,146,86,141,254,12,153,52,248,230,132,181,31,32,107,20,243,13,100,91,44,63,176,90,24,165,155,112,159,36,9,220,114,103,140,162,221,253,97,94,99,75,200,104,133,65,182,8,216,155,65,251,69,192,162,4,227,99,44,25,229,94,31,148,40,207,44,164,74,121,243,66,219,21,141,46,161,236,247,94,172,157,12,95,56,177,173,200,181,72,162,209,3,174,66,108,184,191,100,11,194,35,122,44,71,192,56,198,139,79,254,49,212,64,181,68,83,32,93,61,251,146,225,14,102,193,63,187,238,25,143,144,44,212,183,25,240,96,15,53,74,218,191,159,194,215,191,65,126,42,250,35,142,230,247,114,104,231,156,169,112,174,129,39,62,52,247,27,213,28,109,53,52,24,230,65,61,23,131,54,62,223,251,19,45,156,106,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("29627a54-240f-4b4f-a2e5-afc88eca3ba7"));
		}

		#endregion

	}

	#endregion

}

