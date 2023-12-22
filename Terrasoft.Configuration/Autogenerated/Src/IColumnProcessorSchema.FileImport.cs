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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,193,10,131,64,12,68,207,46,248,15,1,175,197,15,232,177,66,97,47,197,67,127,96,107,163,44,184,201,146,196,147,248,239,221,90,10,45,206,45,147,55,195,80,72,168,57,12,8,119,20,9,202,163,181,29,211,24,167,69,130,69,166,246,26,103,244,41,179,88,237,214,218,85,141,224,84,124,240,100,40,99,73,158,193,119,60,47,137,122,225,1,85,89,106,87,184,188,60,230,56,64,252,98,7,10,74,240,198,212,163,104,84,67,178,191,255,9,252,37,40,30,154,171,21,182,189,191,65,122,126,166,188,207,221,251,213,11,44,8,209,8,217,0,0,0 };
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

