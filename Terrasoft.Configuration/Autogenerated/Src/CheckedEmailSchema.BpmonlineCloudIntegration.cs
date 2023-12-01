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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,49,79,195,48,16,133,231,70,202,127,56,181,11,44,201,78,128,37,84,136,161,168,106,216,16,66,78,114,77,45,98,59,186,187,12,165,226,191,227,56,109,105,43,6,240,118,207,239,249,62,63,171,12,114,167,42,132,23,36,82,236,214,146,228,206,174,117,211,147,18,237,108,146,207,139,133,171,177,229,56,218,197,81,28,77,122,214,182,129,98,203,130,38,89,245,86,180,193,164,64,210,170,213,159,33,147,5,223,140,176,241,3,228,173,98,190,129,124,131,213,7,214,115,163,116,27,238,211,52,133,91,238,141,81,180,189,223,207,43,236,8,25,173,48,200,6,1,7,51,104,191,8,88,148,96,114,136,165,39,185,215,7,37,202,51,11,169,74,222,188,208,245,101,171,43,168,134,189,23,107,39,227,23,142,108,75,114,29,146,104,244,128,203,16,27,239,47,217,130,240,136,30,203,17,48,158,226,37,71,255,41,212,72,181,64,83,34,93,61,251,146,225,14,166,193,63,189,30,24,15,144,44,52,180,25,240,96,7,13,74,54,188,159,193,215,191,65,126,42,250,35,142,230,247,106,108,231,156,169,116,174,133,39,222,55,247,27,213,12,109,61,54,24,230,81,61,23,131,230,207,55,248,78,167,193,97,2,0,0 };
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

