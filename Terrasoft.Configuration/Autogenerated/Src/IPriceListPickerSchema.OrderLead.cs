namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPriceListPickerSchema

	/// <exclude/>
	public class IPriceListPickerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPriceListPickerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPriceListPickerSchema(IPriceListPickerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("664fa71d-95dd-488e-ad10-f92c9b477801");
			Name = "IPriceListPicker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c797525-d05e-4bd8-84e9-5dcb79ad7c60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,106,195,48,12,134,207,13,228,29,76,79,219,37,126,128,102,129,177,67,9,236,80,88,95,192,117,228,34,22,203,65,150,15,101,236,221,107,167,173,41,155,241,193,250,253,127,210,143,200,120,136,139,177,160,142,192,108,98,112,210,125,4,114,120,78,108,4,3,181,205,79,219,108,82,68,58,171,175,75,20,240,187,182,201,138,214,90,245,49,121,111,248,50,220,235,145,4,216,149,102,46,176,58,48,90,248,196,40,42,194,12,182,52,235,30,160,126,34,151,116,154,209,42,172,240,88,201,3,218,111,224,236,41,25,254,141,92,133,61,136,90,138,127,46,147,110,57,141,181,33,145,116,21,210,127,169,85,93,12,27,175,40,111,224,109,123,71,198,105,59,188,223,158,10,39,32,65,135,192,93,175,87,111,197,123,6,73,76,113,168,73,123,253,144,138,103,159,112,42,201,234,247,203,170,212,33,175,121,135,155,223,182,201,247,249,92,1,72,197,210,127,141,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("664fa71d-95dd-488e-ad10-f92c9b477801"));
		}

		#endregion

	}

	#endregion

}

