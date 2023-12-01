namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStateSchema

	/// <exclude/>
	public class EmailStateSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStateSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStateSchema(EmailStateSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f");
			Name = "EmailState";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,75,10,194,48,16,134,215,45,244,14,3,110,165,245,181,18,43,136,246,0,162,23,24,235,84,3,73,90,242,16,69,188,187,105,106,69,81,107,118,255,228,227,155,25,70,162,32,93,97,78,176,37,165,80,151,133,137,151,165,44,216,193,42,52,172,148,81,120,141,194,40,12,122,138,14,46,66,38,173,152,66,38,144,241,141,65,67,254,51,73,18,152,105,43,4,170,203,252,145,61,2,186,102,116,220,50,201,11,84,217,29,103,57,144,19,190,249,2,215,48,248,80,250,194,138,10,180,220,52,214,248,137,189,90,131,181,37,75,123,72,97,208,247,179,125,55,45,84,126,100,39,228,64,117,231,31,170,39,148,194,176,75,182,44,69,197,201,184,174,126,143,239,178,22,114,178,81,151,44,59,87,76,117,171,90,36,133,113,231,88,40,115,226,127,166,106,153,20,38,46,223,154,91,147,220,55,231,174,163,175,185,119,7,105,244,209,10,43,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b3683c63-c39e-be9c-9916-00ffa0f49f4f"));
		}

		#endregion

	}

	#endregion

}

