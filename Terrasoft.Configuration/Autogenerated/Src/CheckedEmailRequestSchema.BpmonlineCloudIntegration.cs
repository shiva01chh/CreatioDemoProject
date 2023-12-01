namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailRequestSchema

	/// <exclude/>
	public class CheckedEmailRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailRequestSchema(CheckedEmailRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("942945d7-ac66-48ca-b114-0dbc0d994415");
			Name = "CheckedEmailRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,65,79,27,49,16,133,207,32,241,31,70,233,5,46,187,119,18,56,52,68,136,3,21,74,184,85,61,56,222,183,193,194,107,47,51,222,72,52,226,191,51,246,134,148,166,149,216,131,87,51,126,243,217,239,201,193,116,144,222,88,208,35,152,141,196,54,85,243,24,90,183,25,216,36,23,67,53,95,172,238,99,3,47,103,167,187,179,211,147,65,92,216,208,234,85,18,58,85,122,15,155,101,82,221,34,128,157,157,30,107,150,67,72,174,67,181,210,93,227,221,239,66,85,149,234,190,49,54,90,208,220,27,145,75,154,63,193,62,163,89,116,198,249,37,94,6,72,42,178,186,174,105,38,67,215,25,126,189,222,215,75,244,12,65,72,66,60,74,41,69,178,153,64,200,0,201,245,26,180,213,99,91,135,134,244,156,158,227,214,53,96,18,93,171,15,114,125,132,158,9,96,188,40,141,209,94,77,190,204,165,250,110,4,234,110,235,44,246,215,158,80,157,105,63,111,76,50,58,149,216,216,244,75,27,253,176,246,206,146,205,126,255,103,151,46,233,95,152,206,237,74,14,135,188,30,56,246,224,228,160,161,61,20,228,184,127,28,84,105,220,66,51,138,234,57,255,211,19,200,59,61,40,182,159,98,42,177,85,7,66,125,140,152,109,141,31,112,40,31,21,50,14,127,154,249,35,41,174,239,209,173,193,231,63,244,121,209,21,77,70,249,228,34,135,240,145,194,221,34,12,29,216,172,61,102,146,88,159,204,53,45,198,59,237,104,131,52,205,87,158,210,219,222,59,66,51,218,47,245,216,253,187,89,122,250,189,3,234,38,100,11,212,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("942945d7-ac66-48ca-b114-0dbc0d994415"));
		}

		#endregion

	}

	#endregion

}

