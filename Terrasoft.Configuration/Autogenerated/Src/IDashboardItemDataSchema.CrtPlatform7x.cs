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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,78,132,48,16,61,239,38,251,15,115,212,11,124,192,26,47,144,24,54,198,245,128,49,241,86,96,138,85,153,193,182,196,172,196,127,119,40,187,100,69,76,236,161,201,244,189,55,175,243,90,82,13,186,86,149,8,57,90,171,28,107,31,37,76,218,212,157,85,222,48,109,214,253,102,189,234,156,161,26,18,182,184,157,170,59,252,240,76,65,177,115,76,209,173,161,119,65,5,143,227,24,174,92,215,52,202,30,174,143,117,70,30,173,30,140,52,91,168,148,123,46,88,217,10,140,199,70,74,175,162,147,48,62,83,182,93,241,102,74,48,147,56,75,79,202,76,132,169,232,132,213,7,215,95,182,225,224,193,161,133,146,137,176,28,198,137,96,98,158,251,172,6,90,50,177,96,86,246,80,163,223,194,215,232,179,219,23,47,2,192,152,19,204,209,156,95,145,224,94,89,137,86,174,237,230,4,231,109,136,79,224,101,228,209,84,114,154,31,218,57,190,56,96,250,51,202,82,181,97,206,229,49,143,14,201,72,250,79,251,220,200,53,63,153,16,88,107,135,254,143,198,242,66,129,250,36,204,125,32,46,103,118,131,126,248,44,23,151,227,79,9,168,108,195,250,6,106,79,140,97,139,2,0,0 };
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

