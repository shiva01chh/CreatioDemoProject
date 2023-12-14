namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarDaySchema

	/// <exclude/>
	public class ICalendarDaySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarDaySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarDaySchema(ICalendarDaySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5");
			Name = "ICalendarDay";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,177,106,195,48,16,157,19,200,63,104,108,23,123,111,130,151,4,130,161,180,67,29,50,203,214,57,136,200,146,123,58,53,152,210,127,239,201,177,155,16,234,197,198,131,116,247,222,189,167,59,201,202,6,124,43,43,16,5,32,74,239,106,74,182,206,214,250,20,80,146,118,54,217,74,3,86,73,244,171,229,247,106,185,8,94,219,147,248,232,60,65,179,126,216,51,211,24,168,34,205,39,123,176,128,186,98,12,163,218,80,26,93,9,109,9,176,142,106,249,88,118,39,59,241,194,91,227,44,200,210,0,131,163,204,34,77,83,177,241,161,105,36,118,217,24,136,96,87,139,11,192,57,249,3,165,247,40,70,188,215,71,206,139,219,170,175,183,56,1,173,251,133,31,22,63,189,179,255,133,70,119,66,73,130,66,55,48,41,119,77,139,219,113,134,192,12,209,55,103,197,197,225,57,54,84,241,73,91,116,45,32,117,19,218,165,115,70,228,158,89,199,129,52,67,115,164,82,244,220,143,231,75,26,63,161,248,170,61,109,6,70,62,96,51,241,16,240,115,108,28,172,254,12,108,64,129,37,93,107,192,56,230,216,3,234,218,169,222,239,131,86,113,202,5,67,14,185,154,35,187,7,234,85,46,119,93,152,80,235,35,8,20,208,250,108,247,192,217,164,99,38,66,149,227,219,14,177,248,208,154,120,33,158,158,175,47,129,237,240,31,191,95,68,149,208,155,123,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("19a08bf9-19ad-47db-8c56-e2bfbacbcbb5"));
		}

		#endregion

	}

	#endregion

}

