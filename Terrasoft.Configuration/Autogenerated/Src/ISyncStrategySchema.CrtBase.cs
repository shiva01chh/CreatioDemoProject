namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISyncStrategySchema

	/// <exclude/>
	public class ISyncStrategySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISyncStrategySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISyncStrategySchema(ISyncStrategySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b771ff15-a14f-4f39-be65-1b31aa728594");
			Name = "ISyncStrategy";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,82,193,106,195,48,12,61,55,144,127,16,237,101,187,36,151,157,186,174,48,54,54,122,8,116,164,251,0,47,81,82,67,98,103,146,83,22,198,254,125,114,210,134,144,109,199,25,12,182,44,61,189,247,44,163,106,228,70,101,8,7,36,82,108,11,23,37,74,87,97,240,25,6,139,150,181,41,33,237,216,97,125,27,6,18,89,17,150,218,26,216,25,135,84,72,221,26,118,105,103,178,212,145,114,88,118,125,82,28,199,176,225,182,174,21,117,219,243,125,79,246,164,115,100,168,209,29,109,206,80,88,130,18,29,188,183,72,29,56,11,140,138,178,163,111,104,172,3,22,80,204,37,155,89,149,200,209,5,54,158,224,54,237,91,165,51,104,20,57,173,42,208,23,78,115,74,11,175,101,164,158,12,4,214,176,239,203,253,147,223,115,210,125,224,129,80,48,248,204,13,240,163,33,33,228,81,180,120,144,220,239,111,160,82,166,108,133,98,52,130,196,115,148,13,161,107,201,240,24,72,231,112,147,226,105,46,59,242,126,60,163,123,53,222,144,132,203,161,244,197,155,118,117,61,252,201,191,82,23,115,85,13,70,198,228,110,41,211,144,225,163,160,46,183,169,63,66,46,103,56,169,170,197,104,19,247,153,63,53,255,34,246,47,145,79,50,120,246,132,52,147,233,59,30,116,141,48,246,191,8,95,161,201,135,95,149,219,215,48,160,147,80,24,72,76,214,55,234,224,12,61,229,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b771ff15-a14f-4f39-be65-1b31aa728594"));
		}

		#endregion

	}

	#endregion

}

