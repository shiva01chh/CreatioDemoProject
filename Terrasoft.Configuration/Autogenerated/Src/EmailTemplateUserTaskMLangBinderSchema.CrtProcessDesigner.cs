namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskMLangBinderSchema

	/// <exclude/>
	public class EmailTemplateUserTaskMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskMLangBinderSchema(EmailTemplateUserTaskMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a");
			Name = "EmailTemplateUserTaskMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,223,107,194,48,16,199,159,21,252,31,14,247,226,96,180,239,42,194,20,7,66,101,131,57,246,124,109,207,46,172,73,74,114,145,137,236,127,223,153,214,161,210,188,132,220,247,123,159,251,17,131,154,124,131,5,193,142,156,67,111,247,156,172,172,217,171,42,56,100,101,205,104,120,26,13,7,193,43,83,221,88,28,37,47,88,176,117,138,252,172,199,241,73,185,184,180,182,70,84,209,31,28,85,130,131,85,141,222,79,97,173,81,213,31,158,220,14,253,247,54,67,83,45,149,41,201,69,111,154,166,48,247,65,107,116,199,69,247,142,9,192,164,155,26,153,32,72,42,176,228,130,14,53,171,90,0,1,43,130,226,140,135,60,178,146,11,42,189,98,53,33,175,85,209,249,34,116,215,49,123,186,153,194,115,211,172,15,100,56,83,158,201,144,91,162,39,161,156,98,159,255,67,109,137,191,108,41,99,189,69,122,43,118,149,236,65,118,162,74,130,131,85,37,188,26,33,190,51,58,158,92,208,178,110,166,31,134,162,189,31,225,188,240,193,32,151,74,201,149,253,34,207,162,26,215,216,126,192,49,57,55,59,223,100,221,14,54,76,242,117,214,61,245,143,119,111,91,76,198,189,190,113,91,233,183,155,148,76,217,14,27,223,109,244,54,40,177,235,243,7,54,78,217,53,90,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a"));
		}

		#endregion

	}

	#endregion

}

