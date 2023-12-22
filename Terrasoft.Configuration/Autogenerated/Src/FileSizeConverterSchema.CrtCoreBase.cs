namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FileSizeConverterSchema

	/// <exclude/>
	public class FileSizeConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FileSizeConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FileSizeConverterSchema(FileSizeConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b9844b9b-b3bf-4414-a49f-287d942d6932");
			Name = "FileSizeConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,193,78,195,48,12,61,51,105,255,96,141,203,198,97,1,196,9,186,30,152,132,196,97,18,18,251,1,55,245,70,164,38,169,156,20,105,32,254,29,167,77,11,131,40,82,236,231,247,94,108,59,180,20,90,212,4,123,98,198,224,15,113,189,245,238,96,142,29,99,52,222,193,231,124,54,159,93,92,50,29,83,182,109,48,132,123,120,50,13,189,154,15,18,234,59,113,36,22,138,220,182,171,26,163,33,68,145,106,208,137,251,159,154,29,39,203,29,197,55,95,139,233,75,175,30,138,74,41,40,66,103,45,242,169,28,129,108,1,65,236,192,136,178,130,232,167,172,58,69,10,235,73,172,254,170,139,22,25,45,56,153,120,179,72,162,103,183,171,22,101,161,122,252,135,198,20,59,118,65,10,99,148,74,231,163,213,164,141,197,70,58,216,251,199,244,239,210,184,161,175,100,186,130,77,9,203,204,89,141,40,92,193,205,245,237,93,126,30,242,18,200,213,195,30,250,252,107,88,246,25,216,99,191,207,55,177,216,193,47,180,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b9844b9b-b3bf-4414-a49f-287d942d6932"));
		}

		#endregion

	}

	#endregion

}

