namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HeaderExcelCellWriterSchema

	/// <exclude/>
	public class HeaderExcelCellWriterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HeaderExcelCellWriterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HeaderExcelCellWriterSchema(HeaderExcelCellWriterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("881c36f8-3731-4978-a3c3-2634f94cdae3");
			Name = "HeaderExcelCellWriter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,80,77,171,194,48,16,60,91,232,127,88,240,222,220,125,234,165,40,30,5,133,119,142,233,90,3,105,182,108,82,159,15,241,191,187,77,85,252,10,201,194,236,206,236,12,241,186,193,208,106,131,176,69,102,29,104,31,139,146,252,222,214,29,235,104,201,23,139,83,75,28,183,180,56,25,116,121,118,206,179,145,220,49,99,45,83,40,157,14,97,2,43,212,21,114,162,148,232,220,47,219,136,156,103,66,84,74,193,52,116,77,163,249,127,126,195,3,27,176,167,131,60,7,127,73,80,220,249,234,73,208,118,59,103,13,152,222,232,187,15,76,96,19,217,250,250,195,127,116,78,25,30,105,215,76,45,114,180,40,145,215,105,239,48,23,211,169,245,7,20,89,69,6,84,239,123,55,166,163,124,140,173,16,30,219,151,196,141,142,31,120,54,127,111,21,67,220,159,91,8,244,213,144,35,225,75,170,175,77,233,61,159,43,140,207,40,73,157,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("881c36f8-3731-4978-a3c3-2634f94cdae3"));
		}

		#endregion

	}

	#endregion

}

