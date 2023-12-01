namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PageResponseSourceCodeSchema

	/// <exclude/>
	public class PageResponseSourceCodeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PageResponseSourceCodeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PageResponseSourceCodeSchema(PageResponseSourceCodeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7282cd51-6666-41a7-9651-efa983edf92b");
			Name = "PageResponseSourceCode";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("66e9e705-64b4-4dda-925e-d1e05a389eb6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,107,227,48,16,61,215,224,255,32,124,169,179,77,212,235,130,201,33,155,205,110,11,221,54,52,10,93,40,61,40,210,56,17,232,195,72,227,82,179,228,191,175,228,52,109,214,16,214,23,89,51,111,102,222,123,163,54,40,187,37,171,46,32,152,42,207,218,147,43,101,240,134,195,216,220,105,13,2,149,179,129,254,4,11,94,137,33,228,9,54,49,148,103,150,27,8,13,23,64,24,120,207,131,171,49,150,219,90,109,91,207,83,135,60,251,147,103,23,77,187,209,74,144,128,49,38,136,208,60,4,18,97,8,22,89,215,0,137,144,4,27,224,2,250,126,36,122,224,166,199,77,73,49,91,46,239,110,231,51,118,251,112,127,253,48,103,11,54,89,177,199,197,236,87,81,157,109,240,219,232,99,53,111,154,152,239,153,93,191,90,73,93,3,246,205,232,218,121,195,49,76,92,93,43,1,210,137,214,68,106,52,52,113,178,12,59,0,52,154,246,39,53,92,217,171,88,210,207,219,159,209,182,228,91,120,140,198,68,7,207,137,123,117,74,146,39,175,16,202,27,196,230,3,237,223,127,198,100,211,33,60,191,16,201,145,143,143,82,106,165,225,62,122,254,17,16,159,46,142,250,41,23,199,6,116,38,229,77,164,15,190,44,222,189,158,124,87,49,23,84,146,95,140,163,27,136,92,236,146,212,170,239,156,182,249,101,186,102,63,38,95,47,47,11,114,117,178,109,154,72,174,81,105,133,29,93,123,189,228,184,91,88,225,36,148,71,78,163,88,80,20,163,234,95,22,167,107,158,158,210,173,254,203,246,14,236,22,119,145,104,178,128,30,110,148,185,85,175,188,28,13,39,125,83,150,251,238,96,105,170,24,230,23,86,150,135,216,254,176,186,125,122,193,121,22,191,191,252,183,104,102,34,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7282cd51-6666-41a7-9651-efa983edf92b"));
		}

		#endregion

	}

	#endregion

}

