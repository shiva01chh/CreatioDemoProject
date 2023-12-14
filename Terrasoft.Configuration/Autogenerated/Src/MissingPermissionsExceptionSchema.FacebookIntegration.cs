namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MissingPermissionsExceptionSchema

	/// <exclude/>
	public class MissingPermissionsExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MissingPermissionsExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MissingPermissionsExceptionSchema(MissingPermissionsExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("043db2ab-b0d2-4dfd-bff1-3c2b2eba32a5");
			Name = "MissingPermissionsException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("34c57733-6570-402b-8e25-5c50c5be2b38");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,77,10,2,49,12,70,215,45,244,14,1,247,115,128,113,57,184,20,132,241,2,181,102,74,160,127,52,45,40,226,221,109,156,141,43,3,129,228,227,37,47,217,136,92,172,67,184,98,173,150,243,214,166,37,167,141,124,175,182,81,78,211,154,29,217,96,244,203,104,213,153,146,135,245,201,13,227,209,232,145,28,42,250,65,193,18,44,243,12,103,98,65,46,88,163,76,57,241,233,225,176,200,163,47,94,250,45,144,3,39,244,63,24,102,248,57,84,226,86,163,223,187,19,211,125,215,202,58,50,169,15,77,202,84,193,201,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("043db2ab-b0d2-4dfd-bff1-3c2b2eba32a5"));
		}

		#endregion

	}

	#endregion

}

