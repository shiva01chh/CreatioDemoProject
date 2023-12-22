namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BeforeImportEntitiesSaveEventArgsSchema

	/// <exclude/>
	public class BeforeImportEntitiesSaveEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BeforeImportEntitiesSaveEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BeforeImportEntitiesSaveEventArgsSchema(BeforeImportEntitiesSaveEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ccd3636d-c0d8-49cf-8899-16272e80dadf");
			Name = "BeforeImportEntitiesSaveEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,209,106,195,48,12,69,159,27,200,63,8,250,158,15,72,203,96,43,93,9,172,80,150,238,3,60,71,241,4,142,29,36,165,48,202,254,125,113,178,149,108,12,230,7,97,93,238,209,189,193,116,40,189,177,8,103,100,54,18,91,45,118,49,180,228,6,54,74,49,20,143,228,177,234,250,200,154,103,215,60,91,13,66,193,65,253,46,138,221,230,215,62,162,222,163,77,156,20,7,12,200,100,71,207,232,90,51,186,81,133,157,55,34,37,60,96,27,249,235,236,62,40,41,161,212,230,130,251,11,6,189,103,39,19,212,15,175,158,44,216,196,252,143,64,9,85,104,227,17,69,140,91,94,90,165,218,183,6,39,142,61,114,162,75,56,77,1,83,214,119,216,97,160,6,158,99,212,218,190,97,103,94,170,6,174,224,80,55,32,105,124,252,48,63,145,232,118,174,116,54,238,14,110,95,249,11,90,99,104,230,18,227,54,107,75,41,207,38,109,249,62,1,187,216,24,161,158,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ccd3636d-c0d8-49cf-8899-16272e80dadf"));
		}

		#endregion

	}

	#endregion

}

