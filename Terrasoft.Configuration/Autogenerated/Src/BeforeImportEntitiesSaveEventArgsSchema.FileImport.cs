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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,209,74,195,64,16,69,159,27,200,63,12,244,61,31,144,138,160,165,150,128,66,49,245,3,214,205,100,29,216,236,134,153,73,65,138,255,238,110,162,165,138,224,62,12,59,151,123,230,222,96,6,148,209,88,132,35,50,27,137,189,86,219,24,122,114,19,27,165,24,170,7,242,216,12,99,100,45,139,115,89,172,38,161,224,160,125,23,197,97,243,107,79,168,247,104,51,39,213,30,3,50,217,228,73,174,53,163,75,42,108,189,17,169,225,30,251,200,95,103,119,65,73,9,165,53,39,220,157,48,232,29,59,153,161,113,122,245,100,193,102,230,127,4,106,104,66,31,159,80,196,184,235,75,171,92,251,210,224,192,113,68,206,116,13,135,57,96,206,250,14,219,79,212,193,115,140,218,218,55,28,204,75,211,193,25,28,234,6,36,143,143,31,230,71,18,189,89,42,29,141,187,133,203,87,254,130,214,24,186,165,68,218,22,237,90,42,139,89,75,239,19,117,97,167,5,149,1,0,0 };
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

