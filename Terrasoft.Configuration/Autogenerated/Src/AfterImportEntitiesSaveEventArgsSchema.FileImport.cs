namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AfterImportEntitiesSaveEventArgsSchema

	/// <exclude/>
	public class AfterImportEntitiesSaveEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AfterImportEntitiesSaveEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AfterImportEntitiesSaveEventArgsSchema(AfterImportEntitiesSaveEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("232e8c67-42ba-4203-936e-0c03b535963d");
			Name = "AfterImportEntitiesSaveEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,65,10,194,48,16,69,215,22,122,135,1,247,30,160,93,149,162,224,66,16,245,2,177,157,134,64,59,41,51,19,69,138,119,183,77,68,116,101,22,129,121,153,247,127,200,12,40,163,105,16,46,200,108,196,119,186,169,61,117,206,6,54,234,60,109,118,174,199,253,48,122,214,60,155,242,108,21,196,145,133,243,67,20,135,50,207,102,178,102,180,243,38,212,189,17,41,160,234,20,57,25,91,82,167,14,229,108,110,184,189,33,105,197,86,162,51,134,107,239,26,104,22,229,175,1,5,236,169,243,7,20,49,246,59,104,53,197,176,207,15,142,236,71,228,197,47,224,24,27,210,251,187,45,56,82,72,61,216,158,252,93,106,31,102,50,129,69,45,65,150,235,249,14,68,106,83,102,156,19,253,133,145,45,231,5,145,132,232,28,67,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("232e8c67-42ba-4203-936e-0c03b535963d"));
		}

		#endregion

	}

	#endregion

}

