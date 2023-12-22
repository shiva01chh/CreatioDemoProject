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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,77,75,195,64,16,61,167,208,255,48,224,165,130,36,247,182,20,108,81,16,20,67,21,60,111,54,211,116,176,217,13,179,155,96,41,254,119,39,217,68,210,160,185,132,157,247,49,111,158,81,37,186,74,105,132,119,100,86,206,30,124,188,179,230,64,69,205,202,147,53,243,217,101,62,139,106,71,166,184,162,48,198,143,74,123,203,132,110,245,7,227,3,51,97,149,165,53,130,10,126,195,88,136,29,236,78,202,185,37,164,76,26,159,201,249,148,244,39,242,30,51,50,57,114,71,77,146,4,214,174,46,75,197,231,77,255,126,154,8,64,183,62,192,189,46,30,100,201,72,87,213,217,137,116,207,252,103,33,44,225,190,170,30,26,52,190,5,209,32,111,149,67,81,95,186,44,191,185,95,208,31,109,222,38,239,92,3,216,111,176,141,156,77,57,66,99,41,135,87,35,142,111,94,177,95,12,214,210,168,199,47,15,58,252,111,161,237,52,138,50,217,20,143,232,3,188,234,208,174,169,208,241,57,222,227,86,242,174,167,53,220,65,42,66,9,237,142,84,77,176,205,34,24,125,247,135,160,201,195,45,221,59,76,175,135,50,27,127,63,163,61,201,79,28,2,0,0 };
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

