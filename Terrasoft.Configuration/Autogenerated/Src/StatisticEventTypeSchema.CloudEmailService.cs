namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: StatisticEventTypeSchema

	/// <exclude/>
	public class StatisticEventTypeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public StatisticEventTypeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public StatisticEventTypeSchema(StatisticEventTypeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209");
			Name = "StatisticEventType";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,79,79,131,48,24,135,207,35,225,59,52,243,162,137,129,248,247,160,206,139,146,120,241,226,230,201,24,83,216,59,108,164,165,233,219,154,16,227,119,183,45,3,33,35,100,131,91,203,243,251,189,79,67,17,148,3,74,154,1,89,129,82,20,203,141,142,30,74,177,97,185,81,84,179,82,132,193,79,24,204,12,50,145,147,101,133,26,184,125,207,101,41,64,232,231,114,13,197,109,24,88,224,72,65,110,105,146,8,195,111,200,82,219,44,106,150,37,223,22,91,85,18,60,20,199,49,185,67,195,57,85,213,253,118,221,162,68,91,12,163,6,139,59,156,52,105,97,1,176,221,131,213,51,167,184,211,238,55,18,78,89,65,176,9,69,45,216,237,159,189,61,2,102,138,73,119,224,227,57,184,204,71,155,193,249,201,187,131,124,85,59,30,201,130,156,157,250,99,13,79,126,129,140,73,102,29,15,156,174,154,220,174,65,91,217,179,56,223,207,226,179,52,170,168,38,203,212,241,17,167,39,15,244,204,46,246,52,179,31,81,21,76,124,77,151,107,26,198,252,26,166,167,120,57,166,88,95,158,169,122,245,53,26,81,243,245,195,90,87,99,90,175,2,77,234,6,165,112,160,146,249,79,110,29,186,93,11,114,109,183,126,235,255,25,196,186,254,165,221,210,239,185,231,15,83,52,176,148,47,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f9f834a-d6b3-457b-ba8a-e93406998209"));
		}

		#endregion

	}

	#endregion

}

