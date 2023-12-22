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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,84,193,106,219,64,16,61,59,144,127,24,148,67,36,40,171,187,99,27,92,55,80,168,213,134,58,61,149,28,198,210,200,222,34,237,138,221,149,193,132,254,123,71,43,109,136,140,221,148,222,74,117,219,217,247,230,205,60,61,73,97,77,182,193,156,224,145,140,65,171,75,39,86,90,149,114,215,26,116,82,43,145,173,175,175,158,175,175,38,173,149,106,55,66,25,186,187,80,23,247,202,73,39,201,190,9,16,247,7,82,174,195,49,242,198,208,142,37,97,85,161,181,83,200,214,153,46,168,90,75,235,72,145,241,144,52,77,97,102,219,186,70,115,92,12,231,0,128,82,27,184,29,88,183,64,157,196,17,200,11,136,192,77,79,200,51,75,132,149,213,144,27,42,231,209,239,199,20,239,209,146,175,29,125,33,40,71,144,118,253,190,159,185,138,55,249,158,106,252,204,62,195,28,162,97,186,40,121,98,124,211,110,43,153,67,222,173,123,186,45,76,225,130,24,19,159,189,23,47,126,101,228,246,186,96,199,30,124,195,254,242,212,41,95,248,136,170,168,200,6,111,54,120,160,162,119,72,188,112,210,83,210,172,65,131,53,40,94,97,30,89,82,5,47,188,240,35,65,127,18,179,212,67,206,51,40,90,60,238,201,27,29,76,158,94,180,217,207,181,44,29,25,47,176,52,59,219,153,11,82,89,135,138,99,154,107,229,80,170,46,82,110,79,65,208,175,0,5,58,28,205,50,24,172,15,44,39,11,130,131,150,5,124,81,126,237,88,111,127,80,30,86,120,7,231,164,129,18,232,178,63,153,108,249,93,136,192,12,20,74,238,252,229,55,75,134,63,26,197,237,186,215,209,142,143,115,136,227,190,121,210,19,19,49,38,244,77,198,44,177,108,26,30,221,127,130,43,228,8,137,175,84,243,30,113,182,102,144,229,40,62,24,42,100,238,112,91,81,176,111,147,27,217,184,79,116,236,231,250,249,231,65,248,64,21,185,255,49,10,195,226,127,21,134,192,253,183,226,112,195,162,253,127,195,159,251,234,184,232,107,175,159,95,205,26,207,106,38,6,0,0 };
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

