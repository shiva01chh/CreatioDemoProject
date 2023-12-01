namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearResponseOverdueDateRuleHandlerSchema

	/// <exclude/>
	public class ClearResponseOverdueDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearResponseOverdueDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearResponseOverdueDateRuleHandlerSchema(ClearResponseOverdueDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd");
			Name = "ClearResponseOverdueDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,194,48,16,60,7,137,127,112,233,37,72,85,232,153,150,30,26,250,58,84,69,64,123,119,147,37,181,228,216,209,218,70,66,21,255,222,141,29,4,4,162,146,75,180,227,153,157,157,181,21,47,193,84,60,3,182,4,68,110,244,202,38,169,86,43,81,56,228,86,104,213,239,253,246,123,145,51,66,21,108,177,49,22,202,187,86,157,76,185,229,39,96,170,165,132,172,238,96,146,23,80,128,34,219,115,14,189,202,82,171,243,39,8,93,120,50,125,236,60,122,82,86,88,1,166,147,240,204,51,171,177,147,113,144,61,73,185,4,149,115,172,169,68,190,70,40,8,102,169,228,198,140,233,7,28,231,180,62,202,8,31,107,192,220,1,237,2,230,78,194,43,87,185,4,244,178,202,125,75,145,177,172,86,93,34,98,163,209,152,189,165,220,28,119,138,234,139,216,207,64,122,139,174,142,66,163,204,188,133,119,219,217,93,96,20,127,26,64,106,164,194,69,49,119,84,14,153,55,140,90,164,73,139,86,111,49,218,6,235,107,218,86,152,175,169,155,97,103,168,43,192,250,86,206,142,218,114,104,149,97,138,2,172,119,138,42,20,107,138,193,76,3,252,99,253,14,246,71,231,231,125,215,90,228,44,236,34,246,207,102,195,192,255,118,209,197,138,197,1,161,55,108,151,155,10,114,122,215,174,84,95,92,58,184,23,202,62,196,131,214,142,7,67,118,53,97,183,187,22,81,163,95,128,61,144,158,170,110,72,18,2,110,59,82,53,216,113,80,143,209,247,7,2,142,22,7,200,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd"));
		}

		#endregion

	}

	#endregion

}

