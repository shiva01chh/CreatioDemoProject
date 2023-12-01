namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MissingConsumerInfoServiceUriExceptionSchema

	/// <exclude/>
	public class MissingConsumerInfoServiceUriExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MissingConsumerInfoServiceUriExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MissingConsumerInfoServiceUriExceptionSchema(MissingConsumerInfoServiceUriExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5e6523ca-dcf1-4c7d-a366-78c39999c290");
			Name = "MissingConsumerInfoServiceUriException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,189,14,194,48,12,132,231,70,234,59,88,98,239,3,148,177,98,96,96,10,60,64,8,110,100,169,249,145,221,32,16,226,221,113,232,194,136,165,27,124,186,251,116,201,69,148,226,60,194,25,153,157,228,121,29,166,156,102,10,149,221,74,57,13,54,123,114,75,111,94,189,233,170,80,10,96,159,178,98,220,247,70,157,29,99,208,20,76,139,19,25,225,68,210,34,74,144,26,145,143,105,206,22,249,78,30,47,76,135,135,199,210,152,223,102,169,215,133,60,248,86,252,179,7,35,252,48,186,182,168,83,189,183,37,152,110,219,152,246,170,167,247,1,71,70,14,77,222,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5e6523ca-dcf1-4c7d-a366-78c39999c290"));
		}

		#endregion

	}

	#endregion

}

