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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,189,14,194,48,12,132,231,86,202,59,88,98,239,3,148,177,98,96,96,10,60,64,8,110,100,41,127,178,155,10,132,120,119,18,186,116,196,210,13,62,221,125,186,104,2,74,54,22,225,138,204,70,210,188,12,83,138,51,185,194,102,161,20,7,157,44,25,175,250,183,234,187,34,20,29,232,151,44,24,142,170,175,206,129,209,213,20,76,222,136,140,112,33,105,145,74,144,18,144,207,113,78,26,121,37,139,55,166,211,211,98,110,204,95,51,151,187,39,11,182,21,255,236,193,8,59,70,215,22,117,85,159,109,9,198,199,54,166,189,213,219,223,23,28,69,84,99,231,0,0,0 };
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

