namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IColumnProcessorSchema

	/// <exclude/>
	public class IColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IColumnProcessorSchema(IColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("30c9471b-7e5a-4dc5-b5d7-b25c0e8ae3a9");
			Name = "IColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bdeb1980-c322-4103-af7f-58bfe7162080");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,193,10,131,64,12,68,207,10,254,67,192,107,241,3,122,172,80,216,75,241,208,31,216,110,179,18,208,100,73,214,147,248,239,93,45,61,20,231,150,201,155,97,216,207,104,201,7,132,39,170,122,147,152,187,94,56,210,184,168,207,36,220,221,105,66,55,39,209,220,212,107,83,87,173,226,88,124,112,156,81,99,73,94,193,245,50,45,51,15,42,1,205,68,155,186,112,105,121,77,20,128,126,216,137,130,18,124,8,15,168,70,150,145,243,223,255,2,238,230,13,79,205,213,10,219,209,223,34,191,191,83,246,243,240,118,125,0,161,230,36,101,209,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("30c9471b-7e5a-4dc5-b5d7-b25c0e8ae3a9"));
		}

		#endregion

	}

	#endregion

}

