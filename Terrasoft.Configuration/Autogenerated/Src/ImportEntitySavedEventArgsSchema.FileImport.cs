namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySavedEventArgsSchema

	/// <exclude/>
	public class ImportEntitySavedEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySavedEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySavedEventArgsSchema(ImportEntitySavedEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d9862337-3e49-447c-a6fe-f4c905fd9341");
			Name = "ImportEntitySavedEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1101e5cd-b945-4f88-8001-faccb4fdb24c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,106,195,48,12,134,207,41,244,29,12,189,231,1,218,83,9,221,200,97,80,150,237,1,188,88,113,205,98,57,88,114,187,16,246,238,115,156,80,178,110,196,7,131,228,79,159,126,163,180,64,157,172,65,188,129,247,146,92,195,121,225,176,49,58,120,201,198,97,254,100,90,40,109,231,60,111,55,195,118,147,5,50,168,69,213,19,131,61,220,235,229,180,135,252,132,108,216,0,69,32,34,59,15,58,170,68,209,74,162,189,152,108,9,233,43,121,5,117,186,2,242,209,107,74,116,23,62,90,83,139,122,132,87,88,17,69,216,184,23,32,146,26,22,138,108,72,154,251,214,179,119,29,248,49,205,94,156,147,123,122,159,247,60,7,163,230,53,85,116,197,137,82,137,65,104,224,131,160,241,250,254,139,191,58,199,85,125,1,43,223,87,225,41,119,76,96,172,244,253,92,61,224,89,246,104,47,46,1,63,87,189,193,32,199,16,183,18,21,124,253,199,237,0,213,244,253,84,79,221,223,205,212,91,158,31,131,193,96,164,11,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d9862337-3e49-447c-a6fe-f4c905fd9341"));
		}

		#endregion

	}

	#endregion

}

