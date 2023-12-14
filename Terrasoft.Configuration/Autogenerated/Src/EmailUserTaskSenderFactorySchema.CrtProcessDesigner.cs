namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskSenderFactorySchema

	/// <exclude/>
	public class EmailUserTaskSenderFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskSenderFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskSenderFactorySchema(EmailUserTaskSenderFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("638e470d-51ca-4d2c-ac7f-a8a2d6682831");
			Name = "EmailUserTaskSenderFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("da7de29a-d2b3-4248-bf8e-b7a592dc81f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,81,203,106,195,48,16,60,43,144,127,88,232,197,185,248,3,18,122,40,233,131,28,82,2,73,63,64,149,55,142,168,45,25,237,138,52,132,252,123,245,176,67,12,105,111,245,193,104,103,118,102,135,93,35,91,164,78,42,132,29,58,39,201,238,185,92,90,135,229,198,89,133,68,161,48,123,93,123,39,89,91,51,157,156,167,19,225,73,155,26,182,39,98,108,23,215,250,86,127,35,25,140,158,145,116,109,208,5,65,144,60,56,172,3,9,203,70,18,205,225,165,149,186,249,32,116,59,73,95,91,52,21,186,87,169,216,186,83,234,238,252,103,163,21,16,7,71,5,42,106,254,148,136,115,146,93,167,172,145,15,182,10,115,54,201,40,147,99,211,213,29,63,120,67,78,112,46,139,244,222,97,219,53,146,113,104,5,223,63,102,16,119,35,4,29,53,171,3,20,69,84,101,201,169,195,217,208,86,142,225,94,36,148,36,132,17,85,62,121,182,243,204,10,135,236,157,1,131,71,136,240,189,176,189,145,16,17,15,39,48,168,226,254,225,241,154,176,28,51,125,255,101,241,107,130,181,52,94,54,119,50,100,226,63,82,84,184,151,190,225,97,38,31,156,61,166,145,239,150,87,97,243,216,162,97,172,94,190,21,118,81,94,204,178,240,18,255,151,254,236,33,74,190,124,170,51,58,6,19,22,191,31,43,39,215,172,0,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("638e470d-51ca-4d2c-ac7f-a8a2d6682831"));
		}

		#endregion

	}

	#endregion

}

