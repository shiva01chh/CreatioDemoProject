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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,142,65,10,194,48,16,69,215,45,244,14,3,238,61,64,187,146,82,193,133,32,234,5,98,157,134,64,59,41,51,19,69,138,119,183,77,68,116,101,22,129,121,153,247,127,200,12,40,163,105,17,206,200,108,196,119,186,174,61,117,206,6,54,234,60,173,183,174,199,221,48,122,214,34,159,138,60,11,226,200,194,233,33,138,67,85,228,51,89,49,218,121,19,234,222,136,148,176,233,20,57,25,13,169,83,135,114,50,55,108,110,72,186,97,43,209,25,195,165,119,45,180,139,242,215,128,18,118,212,249,61,138,24,251,29,148,77,49,236,243,131,3,251,17,121,241,75,56,196,134,244,254,110,11,142,20,82,15,94,143,254,46,181,15,51,153,192,162,86,32,203,245,124,7,34,93,83,102,156,19,253,133,145,125,159,23,236,90,221,3,75,1,0,0 };
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

