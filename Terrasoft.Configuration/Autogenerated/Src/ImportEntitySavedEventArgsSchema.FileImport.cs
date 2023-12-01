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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,106,195,48,12,134,207,41,244,29,12,189,231,1,218,211,8,221,200,97,80,150,237,1,188,88,113,205,98,57,88,114,183,16,246,238,115,236,80,186,110,196,7,131,228,79,159,126,163,180,64,131,108,65,188,130,247,146,92,199,101,229,176,51,58,120,201,198,97,249,104,122,168,237,224,60,111,55,211,118,83,4,50,168,69,51,18,131,61,92,235,219,105,15,229,17,217,176,1,138,64,68,118,30,116,84,137,170,151,68,123,145,109,9,25,27,121,1,117,188,0,242,131,215,148,232,33,188,247,166,21,237,12,175,176,34,138,176,115,207,64,36,53,220,40,138,41,105,174,91,79,222,13,224,231,52,123,113,74,238,252,190,236,121,10,70,45,107,154,232,138,19,181,18,147,208,192,7,65,243,245,253,23,127,113,142,155,246,12,86,190,173,194,57,119,76,96,172,244,227,82,221,225,69,113,111,175,206,1,63,86,189,193,32,199,16,159,53,42,248,250,143,219,1,170,252,253,84,231,238,239,102,234,197,243,3,47,193,208,233,2,2,0,0 };
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

