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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,193,78,195,48,12,61,51,105,255,96,141,203,198,97,1,196,105,116,61,48,9,137,195,36,36,246,3,105,234,141,72,77,82,217,41,210,64,252,59,78,155,22,13,162,72,177,159,223,123,177,237,181,67,110,181,65,56,32,145,230,112,140,235,93,240,71,123,234,72,71,27,60,124,205,103,243,217,213,53,225,41,101,187,70,51,111,224,217,54,248,102,63,81,168,31,72,17,73,40,114,219,174,106,172,1,142,34,53,96,18,247,63,53,59,78,150,123,140,239,161,22,211,215,94,61,20,149,82,80,112,231,156,166,115,57,2,217,2,88,236,192,138,178,130,24,166,172,58,71,228,245,36,86,127,213,69,171,73,59,240,50,241,118,145,68,47,126,95,45,202,66,245,248,47,141,48,118,228,89,10,99,148,74,151,163,213,104,172,211,141,116,112,8,79,233,223,165,245,67,95,201,116,5,219,18,150,153,179,26,81,184,129,187,219,251,135,252,60,230,37,160,175,135,61,244,249,247,176,236,11,176,199,210,249,1,117,38,15,73,172,1,0,0 };
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

