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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,49,14,194,48,12,69,231,84,202,29,44,177,247,0,101,66,21,3,115,123,1,227,186,85,68,234,68,113,131,64,136,187,147,208,133,9,75,127,240,215,179,159,224,202,26,145,24,70,78,9,53,204,91,219,7,153,221,146,19,110,46,72,59,4,114,232,109,243,178,141,201,234,100,129,225,169,27,175,71,219,148,230,144,120,41,20,244,30,85,59,184,200,29,189,155,78,68,172,58,134,27,203,249,65,28,235,163,47,30,243,213,59,2,170,244,63,24,58,248,57,52,213,109,74,222,187,147,101,218,181,117,45,93,153,15,244,26,210,160,200,0,0,0 };
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

