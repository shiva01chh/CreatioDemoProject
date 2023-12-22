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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,203,170,194,48,16,134,215,45,244,29,6,220,74,235,109,117,176,130,104,31,64,244,5,198,58,213,64,146,150,92,68,17,223,221,52,181,82,209,83,179,251,39,31,223,204,48,18,5,233,10,115,130,29,41,133,186,44,76,188,42,101,193,142,86,161,97,165,140,194,91,20,70,97,48,80,116,116,17,50,105,197,31,100,2,25,223,26,52,228,63,147,36,129,185,182,66,160,186,46,158,217,35,160,107,70,199,45,147,116,160,202,238,57,203,129,156,240,205,23,184,134,193,135,210,23,214,84,160,229,166,177,198,47,172,107,13,54,150,44,29,32,133,209,208,207,246,221,180,84,249,137,157,145,3,213,157,255,81,189,160,20,198,125,178,85,41,42,78,198,117,245,123,124,151,181,144,147,77,250,100,217,165,98,170,95,213,34,41,76,123,199,66,153,19,255,49,85,203,164,48,115,249,222,220,154,228,161,57,119,29,125,173,251,30,143,132,98,242,52,2,0,0 };
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

