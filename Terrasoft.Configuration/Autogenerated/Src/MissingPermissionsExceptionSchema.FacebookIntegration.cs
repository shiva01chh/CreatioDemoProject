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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,141,65,10,2,49,12,69,215,45,244,14,1,247,115,128,113,57,184,20,132,241,2,181,102,74,160,77,75,211,130,34,222,221,214,217,184,50,16,72,62,47,121,108,35,74,182,14,225,138,165,88,73,91,157,150,196,27,249,86,108,165,196,211,154,28,217,96,244,203,104,213,132,216,195,250,148,138,241,104,116,79,14,5,125,167,96,9,86,100,134,51,201,64,46,88,226,152,18,203,233,225,48,143,71,95,60,183,91,32,7,110,208,255,96,152,225,231,80,13,183,234,253,222,157,200,247,93,59,214,158,245,250,0,18,150,189,58,200,0,0,0 };
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

