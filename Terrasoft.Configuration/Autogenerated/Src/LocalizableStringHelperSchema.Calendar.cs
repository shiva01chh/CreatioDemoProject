namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalizableStringHelperSchema

	/// <exclude/>
	public class LocalizableStringHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalizableStringHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalizableStringHelperSchema(LocalizableStringHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("372a558a-906c-4891-8361-c65204ffc892");
			Name = "LocalizableStringHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,83,223,79,219,48,16,126,14,18,255,195,45,188,180,26,114,222,71,233,75,133,198,36,96,211,6,227,217,77,175,37,194,177,163,59,155,137,85,252,239,187,56,73,215,164,41,248,193,242,253,250,252,221,119,182,213,37,114,165,115,132,123,36,210,236,214,94,45,156,93,23,155,64,218,23,206,158,158,108,79,79,146,192,133,221,244,82,202,210,217,139,209,8,161,248,37,114,70,184,17,0,88,24,205,252,5,110,92,174,77,241,87,47,13,254,242,36,69,215,104,42,164,152,154,101,25,204,56,148,165,166,215,121,107,159,245,23,116,59,116,54,140,37,200,82,29,96,182,135,88,133,165,41,114,96,47,77,229,144,215,148,142,51,74,182,145,213,174,131,91,244,79,110,37,61,252,136,40,77,112,200,185,71,250,240,176,111,169,93,125,54,4,152,85,154,116,9,86,198,114,153,6,70,146,97,88,204,235,73,164,243,177,110,235,53,203,98,213,56,8,231,79,88,234,59,57,71,128,166,240,28,142,64,117,214,187,144,102,40,220,0,253,35,44,66,31,200,242,124,144,55,172,234,210,234,186,254,252,56,222,10,95,209,255,214,38,224,228,161,39,20,244,117,59,239,210,255,43,177,115,141,118,50,133,250,201,39,201,139,38,32,228,96,60,92,182,5,234,170,172,252,235,69,12,23,107,152,124,106,221,223,248,46,24,243,157,98,120,50,142,218,193,38,221,221,252,34,184,233,193,43,100,149,194,231,113,102,226,79,85,108,57,109,56,68,142,134,5,199,226,159,195,7,61,233,43,161,30,29,61,199,223,174,126,34,187,64,185,228,57,210,155,90,144,61,113,132,217,180,197,223,245,111,88,221,187,22,181,13,190,197,189,153,82,43,84,12,188,181,191,7,237,170,249,64,209,110,188,125,167,248,100,253,3,160,21,8,237,132,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("372a558a-906c-4891-8361-c65204ffc892"));
		}

		#endregion

	}

	#endregion

}

