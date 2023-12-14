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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,80,189,78,195,64,12,158,83,169,239,96,169,11,72,85,30,128,34,22,40,40,3,83,81,247,235,197,9,150,46,190,200,190,67,10,21,239,222,75,142,146,136,129,17,111,182,191,31,127,102,211,161,246,198,34,188,161,136,81,223,132,242,209,115,67,109,20,19,200,115,185,231,64,97,56,12,108,223,197,51,125,78,211,245,234,188,94,21,81,137,91,56,12,26,176,75,44,231,208,142,75,45,95,144,81,200,238,126,48,75,113,193,172,73,168,9,144,32,27,193,54,209,160,226,128,210,164,91,238,160,74,106,177,227,163,113,17,117,246,70,153,8,125,60,57,178,64,87,252,95,240,226,60,81,138,15,79,53,44,86,215,19,110,114,62,80,31,197,226,22,190,219,26,53,16,79,89,183,35,189,168,230,124,247,191,158,145,205,95,77,223,167,168,15,96,151,173,222,238,22,254,207,228,220,211,172,156,189,254,233,130,175,252,107,228,58,191,123,108,211,108,172,11,200,60,64,103,5,2,0,0 };
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

