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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,146,207,106,195,48,12,198,207,41,244,29,68,30,32,185,111,105,47,29,148,192,96,176,5,6,187,185,137,220,153,57,118,176,156,149,108,236,221,39,103,249,3,93,91,232,88,112,14,138,190,47,250,73,178,17,53,82,35,74,132,2,157,19,100,165,79,54,214,72,181,111,157,240,202,154,100,35,52,154,74,56,90,46,62,151,139,168,37,101,246,240,212,145,199,250,246,40,102,167,214,88,6,27,37,91,52,232,84,201,26,86,165,105,10,25,181,117,45,92,183,30,226,71,108,28,18,26,79,80,14,53,64,25,105,93,253,83,120,180,165,71,190,204,119,13,54,194,137,26,12,211,175,226,34,94,231,35,229,157,232,178,116,18,76,22,66,20,154,44,148,14,229,42,30,104,243,141,182,6,197,78,99,12,105,144,54,237,78,171,146,33,60,58,25,102,50,253,54,43,214,112,3,179,1,88,29,29,94,209,241,220,250,196,92,158,51,97,78,191,90,238,63,108,145,187,245,175,8,170,226,198,149,84,232,146,73,156,30,171,179,119,161,91,156,194,226,156,111,150,109,91,85,65,94,65,79,16,237,209,135,21,69,95,253,14,46,16,89,7,52,146,121,85,35,124,112,159,215,129,157,178,205,170,130,179,47,156,204,121,191,48,6,71,148,17,253,5,183,18,29,88,41,233,58,218,19,174,89,148,223,43,242,97,227,188,205,7,22,253,11,231,1,241,13,248,214,53,90,248,43,71,123,206,122,130,248,153,165,197,160,188,128,29,94,62,225,249,6,121,68,244,193,1,4,0,0 };
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

