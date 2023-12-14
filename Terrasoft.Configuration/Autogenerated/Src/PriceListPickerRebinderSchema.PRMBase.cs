namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PriceListPickerRebinderSchema

	/// <exclude/>
	public class PriceListPickerRebinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PriceListPickerRebinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PriceListPickerRebinderSchema(PriceListPickerRebinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58d4987a-d23e-4bb9-a16c-5a1bd52bc088");
			Name = "PriceListPickerRebinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5ae20eb0-a56b-4e38-9555-e43d9bbc10d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,77,75,195,64,16,61,183,208,255,48,224,165,130,36,247,182,20,108,81,16,20,67,21,60,111,54,211,116,176,217,13,179,155,96,41,254,119,39,187,137,180,65,115,9,59,239,99,222,60,163,42,116,181,210,8,239,200,172,156,221,251,100,107,205,158,202,134,149,39,107,102,211,243,108,58,105,28,153,242,138,194,152,60,42,237,45,19,186,229,31,140,15,204,133,85,85,214,8,42,248,13,99,41,118,176,61,42,231,22,144,49,105,124,38,231,51,210,159,200,59,204,201,20,200,129,154,166,41,172,92,83,85,138,79,235,254,253,52,18,128,238,124,128,123,93,50,200,210,11,93,221,228,71,210,61,243,159,133,176,128,251,186,126,104,209,248,14,68,131,188,81,14,69,125,14,89,126,115,191,160,63,216,162,75,30,92,35,216,111,176,173,156,77,5,66,107,169,128,87,35,142,111,94,177,159,15,214,210,168,199,47,15,58,254,111,161,235,116,50,201,101,83,114,65,31,224,101,64,67,83,177,227,83,178,195,141,228,93,141,107,184,131,76,132,18,218,29,168,30,97,235,121,52,250,238,15,65,83,196,91,194,59,78,175,135,50,235,190,31,54,97,140,42,20,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58d4987a-d23e-4bb9-a16c-5a1bd52bc088"));
		}

		#endregion

	}

	#endregion

}

