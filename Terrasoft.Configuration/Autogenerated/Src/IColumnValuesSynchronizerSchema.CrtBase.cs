namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnValuesSynchronizerSchema

	/// <exclude/>
	public class IColumnValuesSynchronizerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnValuesSynchronizerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnValuesSynchronizerSchema(IColumnValuesSynchronizerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("27011a19-7509-4ec0-bb21-cf388cf23492");
			Name = "IColumnValuesSynchronizer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("dd282faf-27c2-4fbe-9d4d-aa5a0b526cd3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,80,189,78,195,64,12,158,83,169,239,112,82,23,144,170,60,0,69,44,80,80,6,166,162,238,215,139,19,44,93,124,145,125,135,20,42,222,189,78,142,146,136,129,17,111,182,191,31,127,38,219,129,244,214,129,121,3,102,43,161,137,229,99,160,6,219,196,54,98,160,114,79,17,227,112,24,200,189,115,32,252,156,166,235,213,121,189,42,146,32,181,230,48,72,132,78,89,222,131,27,151,82,190,0,1,163,219,253,96,150,226,12,89,19,65,20,160,144,13,67,171,52,83,81,4,110,244,150,59,83,169,90,234,232,104,125,2,153,189,129,39,66,159,78,30,157,193,43,254,47,120,113,158,40,197,71,192,218,44,86,215,19,110,114,62,35,33,177,131,173,249,110,107,144,136,52,101,221,142,244,162,154,243,221,255,122,70,54,127,181,125,175,81,31,140,91,182,114,187,91,248,63,163,247,79,179,114,246,250,167,11,190,242,175,129,234,252,238,177,213,153,214,5,183,116,28,146,4,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("27011a19-7509-4ec0-bb21-cf388cf23492"));
		}

		#endregion

	}

	#endregion

}

