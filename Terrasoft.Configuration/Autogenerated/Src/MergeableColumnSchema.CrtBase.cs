namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MergeableColumnSchema

	/// <exclude/>
	public class MergeableColumnSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MergeableColumnSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MergeableColumnSchema(MergeableColumnSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("130e3881-b742-42e2-8cd7-66092d66a439");
			Name = "MergeableColumn";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,78,75,10,2,49,12,93,183,208,59,244,4,94,96,86,50,27,93,232,70,47,144,153,201,148,66,219,148,166,69,6,241,238,182,163,46,4,21,67,18,94,242,94,62,133,109,48,250,180,112,70,223,41,89,214,242,140,41,1,211,156,55,61,121,79,225,35,145,176,182,149,12,224,145,35,140,248,70,134,217,154,146,32,91,10,74,94,149,20,177,12,206,142,122,116,192,172,15,152,12,194,224,176,39,87,124,85,136,38,121,105,56,167,118,235,193,245,16,219,18,189,10,132,193,220,173,128,159,224,214,210,183,217,99,125,237,223,193,129,200,233,61,111,221,5,22,222,217,105,194,159,55,107,84,111,118,7,144,139,141,163,65,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("130e3881-b742-42e2-8cd7-66092d66a439"));
		}

		#endregion

	}

	#endregion

}

