namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailUserTaskMacrosHelperFactorySchema

	/// <exclude/>
	public class EmailUserTaskMacrosHelperFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailUserTaskMacrosHelperFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailUserTaskMacrosHelperFactorySchema(EmailUserTaskMacrosHelperFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d18446c3-8f82-456b-8ac3-209c16faa243");
			Name = "EmailUserTaskMacrosHelperFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1a6f4c5-4ce0-49cf-afb2-f720b4b96f90");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,203,110,194,48,16,60,7,137,127,216,170,151,32,161,124,0,136,3,165,180,229,64,133,10,253,0,227,44,137,213,196,142,236,77,41,66,252,123,29,231,209,4,40,234,169,57,88,217,199,204,236,142,86,178,20,77,198,56,194,6,181,102,70,237,40,152,41,141,193,74,43,142,198,216,64,238,68,148,107,70,66,201,126,239,216,239,121,185,17,50,130,245,193,16,166,227,38,110,227,91,144,154,232,17,141,136,36,106,11,176,144,123,141,145,45,194,44,97,198,140,96,158,50,145,188,27,212,27,102,62,150,140,107,101,94,48,201,80,63,49,78,74,31,28,38,203,183,137,224,96,200,242,114,224,5,242,15,64,239,232,192,141,226,18,41,86,161,213,92,57,186,178,216,165,94,92,97,181,91,124,138,16,53,60,35,181,117,252,2,238,121,14,177,193,52,75,24,97,141,132,188,250,25,66,145,178,182,72,228,133,39,174,240,19,14,224,232,88,182,74,37,69,105,26,166,66,190,137,40,38,3,147,134,36,88,163,12,75,157,67,134,112,55,1,95,72,26,116,178,193,52,39,53,118,100,102,47,136,199,224,251,15,42,60,212,147,21,61,131,134,240,162,82,205,225,113,102,16,206,171,65,103,199,81,217,233,105,164,92,75,144,184,135,171,30,116,188,170,149,27,33,207,59,51,102,114,102,205,176,213,119,97,75,43,81,181,157,198,183,22,168,46,241,198,10,85,199,175,87,245,127,27,132,184,99,121,66,245,140,20,107,181,119,35,190,42,90,216,249,49,69,73,24,206,191,56,102,133,140,63,40,129,167,226,61,85,39,111,79,163,188,122,23,151,217,110,210,230,218,223,55,67,5,6,176,14,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d18446c3-8f82-456b-8ac3-209c16faa243"));
		}

		#endregion

	}

	#endregion

}

