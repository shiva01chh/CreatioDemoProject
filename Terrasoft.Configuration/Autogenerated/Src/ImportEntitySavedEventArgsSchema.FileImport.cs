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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,106,195,48,12,134,207,41,244,29,12,189,231,1,218,211,8,221,200,97,80,150,237,1,188,88,113,205,98,57,72,118,183,16,246,238,115,236,80,186,110,196,7,131,228,79,159,126,163,180,192,131,108,65,188,2,145,100,215,249,178,114,216,25,29,72,122,227,176,124,52,61,212,118,112,228,183,155,105,187,41,2,27,212,162,25,217,131,61,92,235,219,105,130,242,136,222,120,3,28,129,136,236,8,116,84,137,170,151,204,123,145,109,9,25,27,121,1,117,188,0,250,7,210,156,232,33,188,247,166,21,237,12,175,176,34,138,176,115,207,192,44,53,220,40,138,41,105,174,91,79,228,6,160,57,205,94,156,146,59,191,47,123,158,130,81,203,154,38,186,226,68,173,196,36,52,248,131,224,249,250,254,139,191,56,231,155,246,12,86,190,173,194,57,119,76,96,172,164,113,169,238,240,162,184,183,87,231,128,31,171,222,96,208,199,16,159,53,42,248,250,143,219,1,170,252,253,84,231,238,239,102,234,205,231,7,11,235,239,153,3,2,0,0 };
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

