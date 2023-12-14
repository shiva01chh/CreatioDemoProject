namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLModelListenerSchema

	/// <exclude/>
	public class MLModelListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLModelListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLModelListenerSchema(MLModelListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c04a9621-1ecc-4eff-a2d5-eca6fc6ea020");
			Name = "MLModelListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("73704ec6-562c-4400-8a4a-17477a18625f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,106,219,64,16,61,59,144,127,24,148,67,36,40,171,187,99,27,28,39,80,136,149,134,58,61,149,30,198,210,200,222,34,237,138,221,149,193,132,254,123,71,43,109,64,198,110,75,111,165,186,237,236,123,243,102,158,158,164,176,38,219,96,78,240,74,198,160,213,165,19,43,173,74,185,107,13,58,169,149,200,214,215,87,111,215,87,147,214,74,181,27,161,12,221,93,168,139,71,229,164,147,100,127,11,16,143,7,82,174,195,49,242,198,208,142,37,97,85,161,181,83,200,214,153,46,168,90,75,235,72,145,241,144,52,77,97,102,219,186,70,115,92,12,231,0,128,82,27,184,29,88,183,64,157,196,17,200,11,136,192,77,79,200,51,75,132,149,213,144,27,42,231,209,175,199,20,247,104,201,215,142,190,16,148,35,72,187,126,95,207,92,197,155,124,79,53,62,179,207,48,135,104,152,46,74,190,49,190,105,183,149,204,33,239,214,61,221,22,166,112,65,140,137,111,222,139,119,191,50,114,123,93,176,99,47,190,97,127,121,234,148,47,124,68,85,84,100,131,55,27,60,80,209,59,36,222,57,233,41,105,214,160,193,26,20,175,48,143,44,169,130,23,94,248,145,160,63,137,89,234,33,231,25,20,45,94,247,228,141,14,38,79,47,218,236,231,90,150,142,140,23,88,154,157,237,204,5,169,172,67,197,49,205,181,114,40,85,23,41,183,167,32,232,87,128,2,29,142,102,25,12,214,7,150,147,5,193,65,203,2,62,41,191,118,172,183,223,41,15,43,124,128,115,210,64,9,116,217,159,76,182,252,46,68,96,6,10,37,119,254,242,139,37,195,31,141,226,118,221,235,104,199,199,57,196,113,223,60,233,137,137,24,19,250,38,99,150,88,54,13,143,238,63,193,21,114,132,196,103,170,121,143,56,91,51,200,114,20,95,12,21,50,119,184,173,40,216,183,201,141,108,220,19,29,251,185,126,252,121,16,30,168,34,247,63,70,97,88,252,175,194,16,184,255,86,28,110,88,180,255,111,248,115,95,29,23,125,173,123,126,2,123,29,248,230,30,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c04a9621-1ecc-4eff-a2d5-eca6fc6ea020"));
		}

		#endregion

	}

	#endregion

}

