namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISectionStructureBuilderSchema

	/// <exclude/>
	public class ISectionStructureBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISectionStructureBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISectionStructureBuilderSchema(ISectionStructureBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f3b188d-ae35-4cb4-bff8-fb00b0b7fadd");
			Name = "ISectionStructureBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc741efe-5ee7-42c9-8935-9d298f1913b5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,10,194,48,12,134,207,29,236,29,10,94,20,100,15,224,78,78,47,187,120,153,47,80,187,108,6,214,118,36,173,48,196,119,183,221,80,118,209,92,66,194,159,255,255,98,149,1,30,149,6,121,5,34,197,174,243,197,201,217,14,251,64,202,163,179,121,246,204,179,60,19,129,209,246,178,153,216,131,41,191,243,250,136,224,215,190,56,87,229,108,178,33,232,163,167,172,173,7,234,98,234,65,214,13,232,148,211,120,10,218,7,130,42,224,208,2,205,250,49,220,6,212,18,63,242,63,106,17,49,133,120,56,108,229,113,28,135,233,20,216,59,19,95,105,49,29,240,150,61,37,50,214,119,48,234,18,223,222,203,6,134,104,39,121,110,187,68,255,90,48,193,182,11,105,26,227,110,93,111,73,51,44,123,50,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f3b188d-ae35-4cb4-bff8-fb00b0b7fadd"));
		}

		#endregion

	}

	#endregion

}

