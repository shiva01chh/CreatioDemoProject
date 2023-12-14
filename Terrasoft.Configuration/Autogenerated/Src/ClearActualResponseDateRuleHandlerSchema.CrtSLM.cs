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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,220,105,169,212,134,190,14,85,17,208,222,183,201,146,90,114,236,200,15,36,84,241,239,245,35,17,36,37,162,185,68,59,222,217,217,25,155,67,137,170,130,12,201,6,165,4,37,182,58,73,5,223,210,194,72,208,84,240,225,224,103,56,136,140,162,188,32,235,189,210,88,222,116,234,100,1,26,254,128,169,96,12,51,55,65,37,207,200,81,210,236,216,115,170,85,150,130,159,63,145,216,135,39,139,135,222,163,71,174,169,166,168,122,27,158,32,211,66,246,118,156,120,79,82,96,200,115,144,174,213,54,143,37,22,22,38,41,3,165,102,246,135,32,239,51,109,128,173,108,136,214,41,218,40,112,101,24,190,0,207,25,74,207,170,204,23,163,25,201,28,233,31,28,50,157,206,200,107,10,170,61,40,114,215,112,220,192,18,181,52,206,136,93,100,233,21,188,88,163,118,89,39,254,80,40,237,28,30,110,137,152,86,57,33,94,47,234,52,205,59,109,46,194,232,16,148,199,54,170,176,94,93,215,187,46,165,168,80,186,43,57,187,105,71,161,83,134,45,10,212,94,41,170,36,221,89,27,68,213,192,5,233,55,212,223,34,63,175,187,19,52,39,33,139,216,191,153,61,65,255,107,172,211,45,137,3,98,31,176,222,236,43,204,237,163,54,37,255,4,102,240,214,197,185,161,37,222,197,163,144,112,142,249,59,31,77,200,213,156,112,195,88,51,38,170,103,172,81,159,208,219,164,235,192,8,30,15,61,198,106,172,237,213,99,238,251,5,179,137,215,73,201,3,0,0 };
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

