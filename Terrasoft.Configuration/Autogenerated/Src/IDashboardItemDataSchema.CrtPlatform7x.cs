namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDashboardItemDataSchema

	/// <exclude/>
	public class IDashboardItemDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDashboardItemDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDashboardItemDataSchema(IDashboardItemDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6b9c62e2-4fb8-44c6-bf30-c17c6dcdc426");
			Name = "IDashboardItemData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,78,132,48,16,61,239,38,251,15,115,212,11,124,192,26,47,144,24,54,198,245,128,49,241,86,96,138,85,153,193,182,196,172,27,255,221,161,236,18,68,76,236,161,201,244,189,55,175,243,90,82,13,186,86,149,8,57,90,171,28,107,31,37,76,218,212,157,85,222,48,109,214,199,205,122,213,57,67,53,36,108,113,59,86,119,248,225,153,130,98,231,152,162,91,67,239,130,10,30,199,49,92,185,174,105,148,61,92,159,234,140,60,90,221,27,105,182,80,41,247,92,176,178,21,24,143,141,148,94,69,103,97,60,81,182,93,241,102,74,48,163,56,75,207,202,76,132,169,232,132,117,12,174,191,108,195,193,131,67,11,37,19,97,217,143,19,193,200,156,250,172,122,90,50,178,96,86,30,161,70,191,133,175,193,103,183,47,94,4,128,33,39,152,163,57,191,34,193,189,178,18,173,92,219,205,9,206,219,16,159,192,203,200,163,169,228,52,63,180,115,124,113,192,244,103,148,165,106,195,156,203,99,158,28,146,129,244,159,246,185,145,107,126,50,33,176,214,14,253,31,141,229,133,2,245,73,152,251,64,92,206,236,6,125,255,89,46,46,135,159,18,80,217,166,235,27,179,240,225,253,147,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6b9c62e2-4fb8-44c6-bf30-c17c6dcdc426"));
		}

		#endregion

	}

	#endregion

}

