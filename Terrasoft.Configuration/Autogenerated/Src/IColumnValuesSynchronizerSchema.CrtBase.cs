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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,80,189,78,196,48,12,158,123,210,189,131,37,22,144,78,125,0,14,177,192,129,58,48,29,98,15,169,91,44,165,78,101,39,72,229,196,187,147,54,28,141,24,24,241,102,251,251,241,103,54,3,234,104,44,194,51,138,24,245,93,168,239,60,119,212,71,49,129,60,215,7,14,20,166,227,196,246,77,60,211,199,50,221,110,78,219,77,21,149,184,135,227,164,1,135,196,114,14,237,188,212,250,17,25,133,236,254,7,83,138,11,102,77,66,77,128,4,185,16,236,19,13,26,14,40,93,186,229,26,154,164,22,7,126,49,46,162,174,222,40,11,97,140,175,142,44,208,25,255,23,188,58,45,148,234,221,83,11,197,234,124,194,101,206,7,234,163,88,220,193,119,219,162,6,226,37,235,110,166,87,205,154,239,230,215,51,178,249,147,25,199,20,245,22,108,217,234,213,190,240,127,32,231,238,87,229,236,245,79,23,124,230,95,35,183,249,221,115,155,102,101,125,1,155,241,99,33,13,2,0,0 };
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

