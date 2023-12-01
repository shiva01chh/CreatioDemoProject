namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarSchema

	/// <exclude/>
	public class ICalendarSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarSchema(ICalendarSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77b2d1ec-9baf-4fa5-be75-9d8f0bdfecfb");
			Name = "ICalendar";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,106,131,64,16,198,207,6,242,14,131,15,160,247,214,228,146,66,16,10,133,86,40,244,182,209,217,100,233,186,43,59,107,131,45,125,247,142,214,63,96,147,64,74,100,61,140,243,125,206,111,102,214,136,18,169,18,57,66,134,206,9,178,210,71,27,107,164,218,215,78,120,101,77,180,17,26,77,33,28,45,23,95,203,69,80,147,50,123,120,105,200,99,121,63,139,217,169,53,230,173,141,162,45,26,116,42,103,13,171,226,56,134,132,234,178,20,174,89,247,241,51,86,14,9,141,39,200,251,26,160,140,180,174,252,45,60,216,226,153,47,241,77,133,149,112,162,4,195,244,171,48,11,215,233,64,249,32,154,36,30,5,163,133,16,133,38,11,185,67,185,10,123,218,116,163,173,65,177,211,24,66,220,74,171,122,167,85,206,16,30,157,108,103,50,254,54,201,214,112,7,147,1,88,29,28,15,232,120,110,93,98,42,207,153,118,78,127,90,238,62,108,145,187,245,7,4,85,112,227,74,42,116,209,40,142,231,234,228,67,232,26,199,48,59,231,155,100,219,90,21,144,22,208,17,4,123,244,237,138,130,239,110,7,23,136,172,3,26,200,188,42,17,62,185,207,235,192,78,217,38,85,198,217,55,78,166,188,95,24,130,25,101,64,255,193,45,68,3,86,74,186,142,246,132,107,18,165,143,138,124,187,113,222,230,19,139,110,194,121,68,124,7,190,117,149,22,254,202,209,158,179,158,32,126,101,105,214,43,47,96,183,47,31,126,126,0,18,162,51,154,0,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77b2d1ec-9baf-4fa5-be75-9d8f0bdfecfb"));
		}

		#endregion

	}

	#endregion

}

