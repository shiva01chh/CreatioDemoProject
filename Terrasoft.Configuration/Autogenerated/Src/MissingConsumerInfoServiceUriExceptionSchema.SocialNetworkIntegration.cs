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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,189,14,194,48,12,132,231,70,234,59,88,98,239,3,148,177,98,96,96,10,60,64,48,110,100,169,249,145,221,32,16,226,221,73,232,194,136,165,27,124,186,251,116,209,5,210,236,144,224,76,34,78,211,188,14,83,138,51,251,34,110,229,20,7,155,144,221,210,155,87,111,186,162,28,61,216,167,174,20,246,189,169,206,78,200,215,20,76,139,83,29,225,196,218,34,149,160,37,144,28,227,156,44,201,157,145,46,194,135,7,82,110,204,111,51,151,235,194,8,216,138,127,246,96,132,31,70,215,22,117,85,239,109,9,197,219,54,166,189,213,107,247,1,230,220,34,218,223,0,0,0 };
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

