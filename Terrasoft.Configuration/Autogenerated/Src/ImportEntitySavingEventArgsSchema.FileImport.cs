namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImportEntitySavingEventArgsSchema

	/// <exclude/>
	public class ImportEntitySavingEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImportEntitySavingEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImportEntitySavingEventArgsSchema(ImportEntitySavingEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898");
			Name = "ImportEntitySavingEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("457f3a21-2903-49a8-8e29-be203e6136ba");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,193,10,194,48,12,134,207,27,236,29,10,222,125,0,119,146,161,224,65,16,231,11,212,45,43,133,45,25,77,58,145,225,187,219,117,67,20,65,236,41,249,251,229,255,19,212,29,112,175,43,80,23,112,78,51,53,178,46,8,27,107,188,211,98,9,215,123,219,194,161,235,201,73,150,142,89,154,120,182,104,84,121,103,129,46,207,210,160,172,28,152,64,170,162,213,204,27,53,195,59,20,43,247,82,15,129,222,13,128,178,117,134,35,222,251,107,107,43,85,77,244,47,88,5,43,108,232,8,204,218,192,155,71,50,70,159,87,238,201,81,15,78,44,132,240,83,52,159,255,151,32,111,81,212,133,68,183,103,186,113,65,62,180,211,33,73,98,64,242,88,240,82,60,190,7,131,121,21,54,128,250,223,225,21,96,61,47,22,251,89,253,20,163,246,254,158,217,9,110,255,134,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9ddd5a40-8a06-4e75-ab40-8d237a2f6898"));
		}

		#endregion

	}

	#endregion

}

