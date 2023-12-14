namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailIndicatorSchema

	/// <exclude/>
	public class EmailIndicatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailIndicatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailIndicatorSchema(EmailIndicatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051");
			Name = "EmailIndicator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,77,111,211,64,16,134,207,169,212,255,48,114,47,112,113,238,180,84,2,23,69,145,0,85,13,226,130,56,76,214,147,100,213,245,174,181,51,70,42,21,255,157,221,177,99,242,81,137,64,124,177,231,227,157,121,198,179,235,177,33,110,209,16,124,161,24,145,195,74,202,42,248,149,93,119,17,197,6,127,121,241,124,121,49,233,216,250,53,44,158,88,168,185,62,176,83,190,115,100,114,50,151,51,242,20,173,57,202,121,232,188,216,134,202,69,138,162,179,63,181,118,202,74,121,87,145,214,201,128,202,33,243,27,248,208,160,117,115,95,91,131,18,162,102,76,167,83,184,225,174,105,48,62,221,14,246,3,181,145,152,188,48,80,86,128,196,208,45,29,129,221,74,203,173,114,186,35,253,118,135,130,105,64,137,104,228,123,114,180,73,100,13,152,220,252,168,247,228,89,251,143,136,247,49,180,20,197,82,226,188,87,97,31,63,4,84,199,140,18,91,136,192,249,61,82,129,193,54,207,94,142,186,93,188,158,239,19,53,75,138,175,62,167,221,192,91,40,6,69,241,58,243,110,129,89,98,254,189,85,31,131,188,164,201,100,77,114,173,31,60,124,252,58,149,111,73,222,108,82,248,17,126,160,235,232,31,232,70,229,62,159,245,2,239,199,162,231,226,165,101,117,232,122,54,8,43,144,205,193,162,79,132,237,235,84,33,157,198,99,220,119,26,252,170,61,206,5,102,65,57,153,84,61,58,219,104,86,232,193,164,99,138,214,243,48,118,17,30,139,92,191,72,23,53,196,98,167,214,31,233,75,51,43,202,139,135,103,161,144,231,142,234,44,75,158,116,126,199,219,129,245,70,50,64,109,107,240,65,160,65,49,155,255,90,152,86,154,215,31,83,143,253,17,178,231,102,214,217,250,118,184,181,154,243,151,97,174,200,215,253,85,86,187,247,238,59,213,151,159,223,131,126,252,253,26,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051"));
		}

		#endregion

	}

	#endregion

}

