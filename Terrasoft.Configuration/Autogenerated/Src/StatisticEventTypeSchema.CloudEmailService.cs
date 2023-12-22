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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,77,79,132,48,20,69,215,67,194,127,104,198,141,38,6,226,231,66,29,55,74,226,198,141,51,174,140,49,192,188,193,70,250,145,190,214,132,24,255,187,109,25,16,50,132,204,192,174,229,220,251,78,67,225,41,3,148,105,14,100,5,74,165,40,54,58,122,16,124,67,11,163,82,77,5,15,131,159,48,152,25,164,188,32,203,10,53,48,251,158,73,193,129,235,103,177,134,242,54,12,44,112,164,160,176,52,73,184,97,55,100,169,109,22,53,205,147,111,139,173,42,9,30,138,227,152,220,161,97,44,85,213,253,118,221,162,68,91,12,163,6,139,59,156,52,89,105,1,176,221,131,213,51,167,184,211,238,55,18,150,210,146,96,19,138,90,176,219,63,123,123,4,204,21,149,238,192,199,115,112,153,143,54,131,243,147,119,7,249,170,118,60,146,5,57,59,245,199,26,158,252,2,57,149,212,58,30,56,93,53,185,93,131,182,178,103,113,190,159,197,167,48,170,172,38,203,212,241,17,167,39,15,244,204,46,246,52,179,31,81,149,148,127,77,151,107,26,198,252,26,166,167,120,57,166,88,95,158,169,122,245,53,26,81,243,245,195,90,87,99,90,175,28,77,230,6,101,112,160,146,249,79,110,29,186,93,11,114,109,183,126,235,255,25,248,186,254,165,221,210,239,117,159,63,207,36,96,122,55,4,0,0 };
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

