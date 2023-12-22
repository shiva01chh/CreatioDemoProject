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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,65,10,194,48,16,69,215,45,244,14,1,247,61,128,93,73,81,232,66,16,245,2,177,254,134,64,58,41,51,169,32,197,187,155,166,69,116,227,172,102,254,252,188,159,33,221,67,6,221,66,93,193,172,197,119,161,172,61,117,214,140,172,131,245,84,30,172,67,211,15,158,67,145,79,69,158,141,98,201,168,203,83,2,250,170,200,163,178,97,152,232,84,181,211,34,91,85,123,55,246,116,98,223,66,100,207,236,121,255,0,133,29,27,73,246,97,188,57,219,170,118,118,255,51,171,173,106,168,243,199,184,208,6,95,140,108,74,156,79,110,124,61,128,131,69,12,63,37,248,178,95,131,36,240,252,227,26,206,157,209,129,65,241,218,249,146,44,51,8,85,106,100,109,94,43,25,116,95,224,105,94,212,95,49,105,223,245,6,96,48,253,144,74,1,0,0 };
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

