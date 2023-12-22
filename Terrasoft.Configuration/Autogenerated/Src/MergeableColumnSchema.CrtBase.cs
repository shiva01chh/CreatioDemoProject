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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,78,205,10,194,48,12,62,175,208,119,232,19,248,2,59,201,46,122,208,139,190,64,186,101,165,208,54,163,105,25,67,124,119,219,169,160,160,98,72,194,151,124,95,126,50,219,96,212,105,225,132,190,149,34,175,229,25,99,4,166,49,109,58,242,158,194,71,34,98,105,75,17,192,35,79,208,227,27,25,70,107,114,132,100,41,72,113,145,162,153,178,118,182,87,189,3,102,117,192,104,16,180,195,142,92,246,69,209,84,201,83,195,41,214,91,119,174,131,169,46,81,171,160,49,152,218,21,240,3,92,107,250,54,123,44,175,253,59,168,137,156,218,243,214,205,176,240,206,14,3,254,188,89,162,248,171,221,0,183,43,145,243,73,1,0,0 };
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

