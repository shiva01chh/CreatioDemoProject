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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,82,77,107,227,48,16,61,215,224,255,32,124,169,179,77,212,235,130,201,33,155,205,182,133,126,132,70,161,133,210,131,34,141,19,129,62,140,52,46,53,75,254,251,202,78,211,186,134,176,190,200,154,121,51,243,222,27,213,65,217,45,89,53,1,193,20,105,82,247,174,148,193,59,14,99,115,167,53,8,84,206,6,122,5,22,188,18,67,200,19,108,98,40,77,44,55,16,42,46,128,48,240,158,7,87,98,44,183,165,218,214,158,183,29,210,228,111,154,156,85,245,70,43,65,2,198,152,32,66,243,16,72,132,33,88,100,77,5,36,66,90,216,0,23,208,119,35,209,3,55,29,110,74,178,217,114,121,123,51,159,177,155,135,251,203,135,57,91,176,201,138,61,46,102,119,89,113,178,193,179,209,199,106,94,85,49,223,49,187,124,179,146,186,10,236,187,209,165,243,134,99,152,184,178,84,2,164,19,181,137,212,104,168,226,100,25,118,0,104,52,237,78,106,184,178,23,177,164,155,183,63,161,109,201,183,240,24,141,137,14,158,18,247,230,148,36,79,94,33,228,215,136,213,39,218,127,252,140,201,166,65,120,121,37,146,35,31,31,165,148,74,195,125,244,252,51,32,190,92,28,117,83,206,142,13,232,76,202,235,72,31,124,158,125,120,61,249,173,98,46,168,86,126,54,142,110,32,114,177,107,165,22,93,231,118,155,63,166,107,246,103,242,243,252,60,35,23,189,109,211,150,228,26,149,86,216,208,181,215,75,142,187,133,21,78,66,126,228,52,138,5,89,54,42,190,179,232,175,121,218,167,91,252,151,237,45,216,45,238,34,209,214,2,122,184,81,230,86,157,242,124,52,156,244,75,89,238,155,131,165,109,197,48,191,176,50,63,196,246,135,213,237,219,23,156,38,253,239,31,162,131,169,31,43,3,0,0 };
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

