namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ColumnProcessErrorEventArgsSchema

	/// <exclude/>
	public class ColumnProcessErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ColumnProcessErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ColumnProcessErrorEventArgsSchema(ColumnProcessErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a1ce7950-dd79-4139-9857-1c8e2032f3d9");
			Name = "ColumnProcessErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79cdeed7-eef0-4dd8-9765-07d140cf1035");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,65,10,194,48,16,69,215,45,244,14,1,247,30,192,174,164,40,184,16,68,189,64,172,191,33,144,78,202,76,34,72,241,238,166,105,17,221,56,171,153,63,63,239,103,72,247,144,65,183,80,87,48,107,241,93,88,55,158,58,107,34,235,96,61,173,247,214,225,208,15,158,67,85,142,85,89,68,177,100,212,229,41,1,125,93,149,73,89,49,76,114,170,198,105,145,141,106,188,139,61,157,216,183,16,217,49,123,222,61,64,97,203,70,178,125,136,55,103,91,213,78,238,127,102,181,81,7,234,252,49,45,180,193,23,163,24,51,231,147,155,94,15,224,96,145,194,79,25,62,239,151,32,9,60,253,184,129,115,103,116,96,80,186,118,186,164,40,12,66,157,27,89,154,215,66,6,221,103,120,158,103,245,87,204,218,84,111,176,174,128,129,66,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a1ce7950-dd79-4139-9857-1c8e2032f3d9"));
		}

		#endregion

	}

	#endregion

}

