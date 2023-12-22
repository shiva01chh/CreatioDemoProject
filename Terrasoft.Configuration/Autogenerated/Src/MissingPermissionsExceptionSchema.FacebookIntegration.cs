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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,61,10,195,48,12,70,103,27,124,7,65,247,28,32,29,67,199,66,33,189,128,234,42,193,224,63,44,27,82,74,239,94,171,89,50,85,32,144,62,158,244,34,6,226,140,150,224,78,165,32,167,165,14,83,138,139,91,91,193,234,82,28,230,100,29,122,163,223,70,171,198,46,174,48,191,184,82,56,27,221,147,83,161,181,83,48,121,100,30,225,234,88,144,27,149,32,83,138,124,217,44,101,121,244,195,115,123,120,103,193,10,253,15,134,17,14,135,74,220,170,247,103,119,82,124,238,90,89,123,118,172,47,125,95,54,90,209,0,0,0 };
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

