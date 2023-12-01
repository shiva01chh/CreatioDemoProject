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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,193,106,195,48,12,134,207,13,228,29,68,79,221,37,126,128,101,129,178,67,9,244,80,216,94,192,115,228,34,26,203,65,182,15,101,236,221,103,167,173,25,171,241,193,250,253,127,210,143,88,59,12,139,54,8,159,40,162,131,183,177,123,247,108,233,156,68,71,242,220,54,223,109,179,73,129,248,12,31,215,16,209,189,182,77,86,148,82,208,135,228,156,150,235,112,175,71,142,40,182,52,179,94,224,36,100,240,72,33,66,192,25,77,105,214,61,64,245,135,92,210,215,76,6,168,194,99,37,79,100,46,40,217,83,50,60,141,92,133,3,70,88,138,127,46,147,110,57,181,49,62,113,236,42,164,254,83,171,186,104,209,14,56,111,224,109,123,71,198,105,59,236,111,79,160,9,57,146,37,148,174,87,171,183,226,189,96,76,194,97,168,73,123,245,144,138,231,144,104,42,201,234,247,110,85,234,144,151,188,195,205,79,219,228,155,207,47,166,212,205,71,132,1,0,0 };
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

