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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,49,14,131,48,12,69,103,34,113,7,75,221,57,0,157,42,212,161,51,92,192,53,38,138,26,28,20,19,212,170,234,221,155,148,133,169,150,254,224,175,103,63,193,153,117,65,98,24,56,70,212,48,173,77,23,100,114,54,69,92,93,144,166,15,228,208,215,230,93,155,42,169,19,11,253,75,87,158,207,181,201,205,41,178,205,20,116,30,85,91,184,201,134,222,141,23,34,86,29,194,131,229,250,36,94,202,163,31,190,164,187,119,4,84,232,127,48,180,112,56,172,138,187,202,249,236,78,150,113,215,150,53,119,199,249,2,160,62,141,214,209,0,0,0 };
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

