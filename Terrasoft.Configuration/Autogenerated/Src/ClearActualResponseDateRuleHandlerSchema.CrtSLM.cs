namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearActualResponseDateRuleHandlerSchema

	/// <exclude/>
	public class ClearActualResponseDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearActualResponseDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearActualResponseDateRuleHandlerSchema(ClearActualResponseDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("49896338-f1b3-42b4-a897-a58e4a82829a");
			Name = "ClearActualResponseDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,220,105,169,212,134,190,14,85,17,208,222,183,201,146,90,114,236,200,15,36,84,241,239,245,35,136,36,37,162,185,68,59,222,217,217,25,155,67,137,170,130,12,201,6,165,4,37,182,58,73,5,223,210,194,72,208,84,240,225,224,103,56,136,140,162,188,32,235,189,210,88,222,116,234,100,1,26,254,128,169,96,12,51,55,65,37,207,200,81,210,236,212,211,212,42,75,193,207,159,72,236,195,147,197,67,239,209,35,215,84,83,84,189,13,79,144,105,33,123,59,26,222,147,20,24,242,28,164,107,181,205,99,137,133,133,73,202,64,169,153,253,33,200,251,76,27,96,43,27,162,117,138,54,10,92,25,134,47,192,115,134,210,179,42,243,197,104,70,50,71,250,7,135,76,167,51,242,154,130,106,15,138,220,53,156,54,176,68,45,141,51,98,23,89,122,5,47,118,84,187,172,19,127,40,148,118,14,15,183,68,76,171,156,16,175,23,117,154,230,157,54,23,97,116,8,202,99,27,85,88,175,174,235,93,151,82,84,40,221,149,156,221,180,163,208,41,195,22,5,106,175,20,85,146,238,172,13,162,106,224,130,244,27,234,111,145,159,215,221,9,154,147,144,69,236,223,204,158,160,255,29,173,211,45,137,3,98,31,176,222,236,43,204,237,163,54,37,255,4,102,240,214,197,185,161,37,222,197,163,144,112,142,249,59,31,77,200,213,156,112,195,216,113,76,84,207,88,163,110,208,219,164,235,192,8,30,15,61,198,106,172,237,213,99,205,239,23,196,171,134,220,209,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("49896338-f1b3-42b4-a897-a58e4a82829a"));
		}

		#endregion

	}

	#endregion

}

