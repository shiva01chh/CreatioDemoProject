namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnchorSchemaSchema

	/// <exclude/>
	public class AnchorSchemaSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnchorSchemaSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnchorSchemaSchema(AnchorSchemaSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d6e901b7-c83c-496b-bfca-a90070dabbd4");
			Name = "AnchorSchema";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("9dcf4d22-4488-4059-8715-c0b6327feea5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,211,215,82,112,86,6,2,5,101,8,80,128,177,117,20,80,249,8,37,200,44,100,46,140,114,206,47,74,85,208,210,231,229,2,2,0,234,128,98,178,95,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d6e901b7-c83c-496b-bfca-a90070dabbd4"));
		}

		#endregion

	}

	#endregion

}

