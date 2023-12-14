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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,143,193,10,194,48,12,134,207,27,236,29,10,94,20,100,15,224,78,110,94,118,241,82,95,160,182,217,44,116,109,73,90,97,136,239,110,187,161,120,209,92,66,194,159,255,255,98,197,4,228,133,4,118,1,68,65,110,8,117,231,236,160,199,136,34,104,103,171,242,81,149,85,89,68,210,118,100,124,166,0,83,243,153,191,143,16,126,237,235,83,219,44,38,27,132,49,121,178,222,6,192,33,165,30,88,207,65,230,28,30,48,202,16,17,218,168,141,2,92,244,62,94,141,150,76,191,229,127,212,69,194,44,138,187,211,138,29,189,55,115,23,41,184,41,189,162,116,62,160,45,5,204,100,36,111,48,137,115,122,123,207,56,152,100,199,104,105,187,76,255,92,49,193,170,149,52,143,105,151,235,5,42,96,100,5,42,1,0,0 };
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

