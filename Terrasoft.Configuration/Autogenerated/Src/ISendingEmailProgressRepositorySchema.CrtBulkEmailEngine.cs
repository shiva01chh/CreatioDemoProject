namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISendingEmailProgressRepositorySchema

	/// <exclude/>
	public class ISendingEmailProgressRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISendingEmailProgressRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISendingEmailProgressRepositorySchema(ISendingEmailProgressRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae");
			Name = "ISendingEmailProgressRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,207,13,228,29,12,189,108,48,154,251,58,118,41,101,228,48,8,105,95,192,115,148,84,16,91,70,182,11,161,244,221,39,39,45,108,48,58,159,44,235,255,63,253,194,78,91,8,94,27,80,71,96,214,129,250,184,217,145,235,113,72,172,35,146,43,139,75,89,172,82,64,55,168,195,20,34,216,109,89,200,75,85,85,234,45,36,107,53,79,239,183,186,5,207,16,192,197,160,226,9,212,1,92,39,182,189,213,56,54,76,131,244,130,72,40,96,36,158,148,33,23,89,155,184,185,211,170,31,56,159,190,70,52,10,93,4,238,115,188,250,49,77,44,151,57,215,106,205,48,72,110,245,9,241,68,93,120,85,205,140,90,154,103,194,78,213,206,48,88,137,217,48,120,205,208,181,96,208,99,206,253,244,145,68,0,121,70,221,189,228,241,202,223,68,71,202,9,118,148,92,124,222,254,77,35,35,153,254,193,133,101,141,7,28,177,3,158,161,171,29,70,212,99,43,255,67,46,192,111,216,221,186,22,220,178,240,92,95,203,226,154,47,114,190,1,137,252,65,87,218,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae"));
		}

		#endregion

	}

	#endregion

}

