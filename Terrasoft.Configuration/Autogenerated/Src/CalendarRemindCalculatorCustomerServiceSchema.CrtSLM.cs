namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorCustomerServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorCustomerServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorCustomerServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorCustomerServiceSchema(CalendarRemindCalculatorCustomerServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187");
			Name = "CalendarRemindCalculatorCustomerService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("50529f8b-8504-4b8d-9a81-5bda32bd1be4");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,106,194,64,16,61,71,240,31,6,189,68,16,63,64,241,20,74,201,161,80,106,123,42,61,172,155,49,93,72,118,195,236,174,34,154,127,239,108,18,107,180,8,105,14,11,111,118,223,188,247,102,226,173,210,57,108,142,214,97,185,26,143,124,3,223,145,72,88,179,115,139,196,16,114,121,60,210,162,68,91,9,137,55,151,122,167,114,79,194,41,163,199,163,83,120,23,77,9,115,134,144,20,194,218,37,36,162,64,157,9,122,195,82,233,140,145,244,133,112,134,18,111,157,41,145,54,72,123,37,177,161,86,126,91,40,9,50,48,135,18,225,177,4,119,100,75,209,213,145,209,214,145,151,124,197,198,94,73,237,133,107,133,163,170,5,67,69,227,15,139,196,237,52,202,16,29,252,13,156,133,142,209,18,182,194,98,124,119,5,141,163,186,85,157,178,86,235,173,195,157,209,23,116,223,38,11,30,155,129,116,22,219,225,88,199,211,150,131,167,147,16,114,174,148,131,11,45,241,95,49,230,240,236,85,6,146,83,164,89,103,60,218,11,106,42,79,218,41,119,132,53,228,232,146,95,28,223,119,104,201,115,208,120,248,252,130,19,76,58,229,148,255,182,52,155,204,97,194,107,48,196,84,70,80,207,86,141,136,218,197,125,141,53,104,95,20,112,62,247,148,23,87,94,120,16,156,46,158,202,202,29,47,70,35,66,231,73,55,212,182,107,221,156,151,50,30,6,47,251,207,10,33,36,230,236,61,147,245,234,193,94,187,90,191,196,149,254,247,3,201,168,64,175,130,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edcd46c2-7ae7-4652-8fc1-4857d18db187"));
		}

		#endregion

	}

	#endregion

}

