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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,82,203,110,194,48,16,60,7,137,127,216,170,151,32,161,124,0,136,67,75,105,203,129,10,181,244,3,140,179,4,171,137,29,217,155,82,132,248,247,218,206,163,9,80,212,83,115,176,178,143,153,217,29,173,100,25,154,156,113,132,21,106,205,140,218,80,52,85,26,163,165,86,28,141,177,129,220,136,164,208,140,132,146,253,222,161,223,11,10,35,100,2,111,123,67,152,141,155,184,141,111,65,106,162,7,52,34,145,168,45,192,66,110,53,38,182,8,211,148,25,51,130,89,198,68,250,110,80,175,152,249,88,48,174,149,121,198,52,71,253,200,56,41,189,247,152,188,88,167,130,131,33,203,203,129,59,228,31,128,193,193,131,27,197,5,210,86,197,86,115,233,233,202,98,151,122,126,129,213,110,241,41,98,212,240,132,212,214,9,29,60,8,60,98,133,89,158,50,194,26,9,69,245,51,4,151,178,182,72,228,206,19,95,248,9,7,112,240,44,107,165,82,87,186,139,51,33,95,69,178,37,3,147,134,36,122,67,25,151,58,251,28,225,102,2,161,144,52,232,100,163,187,130,212,216,147,153,157,32,190,133,48,188,87,241,190,158,204,245,12,26,194,179,74,53,71,192,153,65,56,173,70,157,29,71,101,103,160,145,10,45,65,226,14,46,122,208,241,170,86,110,132,130,224,196,152,201,137,53,195,86,223,153,45,173,68,213,118,28,95,91,160,186,196,43,43,84,29,191,94,213,255,109,16,227,134,21,41,213,51,210,86,171,157,31,241,69,209,220,206,143,25,74,194,120,246,197,49,119,50,225,160,4,30,221,123,172,78,222,158,70,121,245,62,46,179,221,164,205,185,239,27,227,79,99,82,6,4,0,0 };
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

