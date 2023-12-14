namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidAccessTokenExceptionSchema

	/// <exclude/>
	public class InvalidAccessTokenExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidAccessTokenExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidAccessTokenExceptionSchema(InvalidAccessTokenExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f0c6f0e-7021-41f4-a539-8f0ca0bda259");
			Name = "InvalidAccessTokenException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,49,14,194,48,12,69,231,70,234,29,44,177,247,0,101,66,21,3,115,123,1,227,186,145,69,234,84,113,139,64,136,187,147,208,133,9,75,127,240,215,179,159,226,204,182,32,49,12,156,18,90,156,214,166,139,58,137,223,18,174,18,181,233,35,9,134,218,189,106,87,109,38,234,161,127,218,202,243,177,118,185,57,36,246,153,130,46,160,89,11,23,189,99,144,241,68,196,102,67,188,177,158,31,196,75,121,244,197,151,237,26,132,128,10,253,15,134,22,126,14,171,226,174,114,222,187,147,117,220,181,101,205,93,153,15,140,226,167,136,201,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f0c6f0e-7021-41f4-a539-8f0ca0bda259"));
		}

		#endregion

	}

	#endregion

}

