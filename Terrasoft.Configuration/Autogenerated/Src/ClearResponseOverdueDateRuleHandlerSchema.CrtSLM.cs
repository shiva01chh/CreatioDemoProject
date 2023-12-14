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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,194,48,16,60,7,137,127,216,210,75,144,170,208,51,45,61,52,244,117,168,138,128,246,238,38,75,106,201,177,163,181,141,132,42,254,189,182,19,4,4,162,146,75,180,227,153,157,157,181,37,43,81,87,44,67,88,34,17,211,106,101,146,84,201,21,47,44,49,195,149,236,247,126,251,189,200,106,46,11,88,108,180,193,242,174,85,39,83,102,216,9,152,42,33,48,243,29,116,242,130,18,137,103,123,206,161,87,89,42,121,254,132,176,11,79,166,143,157,71,79,210,112,195,81,119,18,158,89,102,20,117,50,14,178,39,41,19,40,115,70,158,234,200,215,132,133,131,33,21,76,235,177,251,33,163,185,91,159,203,136,31,107,164,220,162,219,5,206,173,192,87,38,115,129,20,100,149,253,22,60,131,204,171,46,17,193,104,52,134,183,148,233,227,78,145,191,136,253,12,78,111,200,250,40,110,148,89,176,8,110,59,187,11,140,226,79,141,228,26,201,250,162,192,30,149,67,8,134,81,139,52,105,209,252,22,163,109,109,125,237,182,85,207,215,212,205,176,51,82,21,146,191,149,179,163,182,28,90,101,61,69,129,38,56,69,21,241,181,139,1,186,1,254,177,126,71,243,163,242,243,190,107,197,115,168,119,17,135,103,179,1,12,191,93,116,190,130,184,70,220,27,54,203,77,133,185,123,215,182,148,95,76,88,188,231,210,60,196,131,214,142,7,67,184,154,192,237,174,69,212,232,23,104,14,164,167,170,27,39,169,3,110,59,82,53,216,113,208,128,249,239,15,49,113,222,220,201,3,0,0 };
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

