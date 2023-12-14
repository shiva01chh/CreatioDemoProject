namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailProcessTemplateUserTaskMessageProviderSchema

	/// <exclude/>
	public class EmailProcessTemplateUserTaskMessageProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailProcessTemplateUserTaskMessageProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailProcessTemplateUserTaskMessageProviderSchema(EmailProcessTemplateUserTaskMessageProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b79b40c-b679-49a4-ace9-9049573f8669");
			Name = "EmailProcessTemplateUserTaskMessageProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,145,65,110,194,48,16,69,215,65,226,14,150,186,73,55,57,0,136,5,80,212,21,18,45,244,0,38,153,4,171,137,29,102,108,164,8,113,247,142,157,132,146,66,23,100,21,143,255,159,255,198,163,101,5,84,203,20,196,14,16,37,153,220,38,75,131,144,108,208,164,64,196,7,157,171,194,161,180,202,232,241,232,60,30,69,142,148,46,6,250,27,73,111,124,3,82,133,6,156,62,52,112,192,74,91,101,21,16,11,88,242,130,80,176,91,44,75,73,52,17,171,74,170,178,235,180,131,170,46,165,133,47,2,220,73,250,94,115,77,22,192,183,39,149,1,6,123,237,246,165,74,69,234,221,207,152,197,68,44,36,65,39,14,198,187,246,209,57,68,252,34,26,77,22,93,106,13,50,233,38,36,183,138,142,226,137,252,56,104,255,138,132,235,126,94,125,215,104,34,246,204,24,95,139,194,47,33,186,116,84,160,179,22,108,72,185,6,123,48,153,7,68,99,33,181,144,117,140,253,81,152,19,47,132,33,4,79,227,247,243,14,54,208,44,76,214,196,93,72,132,96,29,234,118,164,30,47,241,138,233,13,195,131,158,97,187,205,54,61,64,37,63,28,96,227,219,111,153,21,112,69,199,107,251,123,25,208,81,204,194,192,201,208,17,2,35,149,139,120,8,227,37,237,43,54,53,136,217,76,196,74,219,215,65,53,153,59,107,250,200,136,19,18,118,207,179,74,233,79,85,28,44,113,96,46,75,130,54,226,114,59,56,139,167,255,191,118,91,29,22,185,230,191,31,188,189,72,207,89,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b79b40c-b679-49a4-ace9-9049573f8669"));
		}

		#endregion

	}

	#endregion

}

