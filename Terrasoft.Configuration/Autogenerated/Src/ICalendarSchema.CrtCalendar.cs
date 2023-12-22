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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,106,131,64,16,198,207,6,242,14,131,15,160,247,214,228,146,66,16,10,133,86,40,244,54,209,217,100,233,186,43,187,107,131,45,125,247,142,214,63,197,38,129,148,202,122,24,231,251,156,223,204,172,198,146,92,133,57,65,70,214,162,51,194,71,27,163,133,220,215,22,189,52,58,218,160,34,93,160,117,203,197,199,114,17,212,78,234,61,60,53,206,83,121,59,139,217,169,20,229,173,205,69,91,210,100,101,206,26,86,197,113,12,137,171,203,18,109,179,238,227,71,170,44,57,210,222,65,222,215,0,169,133,177,229,119,225,193,22,207,124,137,111,42,170,208,98,9,154,233,87,97,22,174,211,129,242,14,155,36,30,5,163,197,17,161,114,6,114,75,98,21,246,180,233,70,25,77,184,83,20,66,220,74,171,122,167,100,206,16,158,172,104,103,50,254,54,201,214,112,3,147,1,88,29,28,15,100,121,110,93,98,42,207,153,118,78,191,90,238,62,108,137,187,245,7,2,89,112,227,82,72,178,209,40,142,231,234,228,13,85,77,99,152,157,243,77,178,109,45,11,72,11,232,8,130,61,249,118,69,193,103,183,131,11,68,198,130,27,200,188,44,9,222,185,207,235,192,78,217,38,85,198,217,23,78,166,188,95,24,130,25,101,224,254,130,91,96,3,70,8,119,29,237,9,215,36,74,239,165,243,237,198,121,155,15,44,250,23,206,35,209,43,240,173,171,20,250,43,71,123,206,122,130,248,153,165,89,175,188,128,221,190,124,126,62,95,187,130,132,154,9,4,0,0 };
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

