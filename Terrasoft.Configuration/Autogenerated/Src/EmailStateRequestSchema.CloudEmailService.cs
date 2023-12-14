namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateRequestSchema

	/// <exclude/>
	public class EmailStateRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateRequestSchema(EmailStateRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa");
			Name = "EmailStateRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,146,193,78,195,48,12,134,207,157,180,119,176,198,5,46,237,157,1,59,140,105,218,1,52,173,187,33,14,89,235,118,17,109,82,18,23,105,76,188,59,78,210,77,219,52,16,2,209,75,99,199,254,245,253,142,149,168,209,54,34,67,88,162,49,194,234,130,226,177,86,133,44,91,35,72,106,213,239,109,251,189,168,181,82,149,144,110,44,97,61,60,137,227,69,171,72,214,24,167,104,164,168,228,187,239,227,42,174,187,48,88,114,0,227,74,88,123,13,147,90,200,42,37,65,184,192,215,22,45,249,162,36,73,224,198,182,117,45,204,230,174,139,23,216,24,180,168,200,130,9,165,160,11,160,53,2,58,13,176,78,4,44,154,55,153,97,188,19,73,14,84,158,238,5,9,182,66,70,100,244,204,137,166,93,85,50,131,204,161,156,35,137,182,158,102,207,60,55,186,65,67,18,25,124,238,123,195,253,41,174,79,76,145,73,181,97,34,254,7,196,89,14,164,33,91,99,246,18,239,251,14,9,3,226,3,214,43,52,151,143,252,16,112,11,3,223,59,203,7,87,14,121,199,60,109,101,62,10,204,172,234,30,36,138,74,164,161,63,216,238,240,241,83,60,158,157,33,200,221,0,187,153,178,79,169,115,40,124,133,162,96,192,254,6,223,107,115,30,143,13,184,204,146,119,100,4,233,174,224,207,54,80,229,255,100,130,149,191,179,48,9,215,95,26,128,110,143,88,38,172,146,143,131,175,227,164,207,185,239,19,188,185,176,181,135,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e71e3e74-ee53-49b0-8b08-eff380e4bbfa"));
		}

		#endregion

	}

	#endregion

}

